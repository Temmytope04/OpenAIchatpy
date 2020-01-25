﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Messaging.ServiceBus.Authorization;
using Azure.Messaging.ServiceBus.Receiver;
using Azure.Messaging.ServiceBus.Core;
using Azure.Messaging.ServiceBus.Diagnostics;
using Azure.Messaging.ServiceBus.Primitives;
using Microsoft.Azure.Amqp;
using Microsoft.Azure.Amqp.Encoding;
using Microsoft.Azure.Amqp.Framing;
using Microsoft.Azure.Amqp.Sasl;
using Microsoft.Azure.Amqp.Transport;

namespace Azure.Messaging.ServiceBus.Amqp
{
    /// <summary>
    ///   Defines a context for AMQP operations which can be shared amongst the different
    ///   client types within a given scope.
    /// </summary>
    ///
    internal class AmqpConnectionScope : IDisposable
    {
        /// <summary>The name to assign to the SASL handler to specify that CBS tokens are in use.</summary>
        private const string CbsSaslHandlerName = "MSSBCBS";

        /// <summary>The suffix to attach to the resource path when using web sockets for service communication.</summary>
        private const string WebSocketsPathSuffix = "/$servicebus/websocket/";

        /// <summary>The URI scheme to apply when using web sockets for service communication.</summary>
        private const string WebSocketsUriScheme = "wss";

        /// <summary>The string formatting mask to apply to the service endpoint to consume events for a given consumer group and partition.</summary>
        private const string ConsumerPathSuffixMask = "{0}/ConsumerGroups/{1}/Partitions/{2}";

        /// <summary>The string formatting mask to apply to the service endpoint to publish events for a given partition.</summary>
        private const string PartitionProducerPathSuffixMask = "{0}/Partitions/{1}";

        /// <summary>
        ///   The version of AMQP to use within the scope.
        /// </summary>
        ///
        private static Version AmqpVersion { get; } = new Version(1, 0, 0, 0);

        /// <summary>
        ///   The amount of time to allow an AMQP connection to be idle before considering
        ///   it to be timed out.
        /// </summary>
        ///
        private static TimeSpan ConnectionIdleTimeout { get; } = TimeSpan.FromMinutes(1);

        /// <summary>
        ///   The amount of buffer to apply to account for clock skew when
        ///   refreshing authorization.  Authorization will be refreshed earlier
        ///   than the expected expiration by this amount.
        /// </summary>
        ///
        private static TimeSpan AuthorizationRefreshBuffer { get; } = TimeSpan.FromMinutes(5);

        /// <summary>
        ///   The minimum amount of time for authorization to be refreshed; any calculations that
        ///   call for refreshing more frequently will be substituted with this value.
        /// </summary>
        ///
        private static TimeSpan MinimumAuthorizationRefresh { get; } = TimeSpan.FromMinutes(4);

        /// <summary>
        ///   The amount time to allow to refresh authorization of an AMQP link.
        /// </summary>
        ///
        private static TimeSpan AuthorizationRefreshTimeout { get; } = TimeSpan.FromMinutes(3);

        /// <summary>
        ///   The recommended timeout to associate with an AMQP session.  It is recommended that this
        ///   interval be used when creating or opening AMQP links and related constructs.
        /// </summary>
        ///
        public TimeSpan SessionTimeout { get; } = TimeSpan.FromSeconds(30);

        /// <summary>
        ///   Indicates whether this <see cref="AmqpConnectionScope"/> has been disposed.
        /// </summary>
        ///
        /// <value><c>true</c> if disposed; otherwise, <c>false</c>.</value>
        ///
        public bool IsDisposed { get; private set; }

        /// <summary>
        ///   The cancellation token to use with operations initiated by the scope.
        /// </summary>
        ///
        private CancellationTokenSource OperationCancellationSource { get; } = new CancellationTokenSource();

        /// <summary>
        ///   The set of active AMQP links associated with the connection scope.  These are considered children
        ///   of the active connection and should be managed as such.
        /// </summary>
        ///
        private ConcurrentDictionary<AmqpObject, Timer> ActiveLinks { get; } = new ConcurrentDictionary<AmqpObject, Timer>();

        /// <summary>
        ///   The unique identifier of the scope.
        /// </summary>
        ///
        private string Id { get; }

        /// <summary>
        ///   The endpoint for the Service Bus service to which the scope is associated.
        /// </summary>
        ///
        private Uri ServiceEndpoint { get; }

        /// <summary>
        ///   The name of the Service Bus entity to which the scope is associated.
        /// </summary>
        ///
        private string EntityName { get; }

        /// <summary>
        ///   The provider to use for obtaining a token for authorization with the Service Bus service.
        /// </summary>
        ///
        private CbsTokenProvider TokenProvider { get; }

        /// <summary>
        ///   The type of transport to use for communication.
        /// </summary>
        ///
        private ServiceBusTransportType Transport { get; }

        /// <summary>
        ///   The proxy, if any, which should be used for communication.
        /// </summary>
        ///
        private IWebProxy Proxy { get; }

        /// <summary>
        ///   The AMQP connection that is active for the current scope.
        /// </summary>
        ///
        private FaultTolerantAmqpObject<AmqpConnection> ActiveConnection { get; }

        /// <summary>
        ///   Initializes a new instance of the <see cref="AmqpConnectionScope"/> class.
        /// </summary>
        ///
        /// <param name="serviceEndpoint">Endpoint for the Service Bus service to which the scope is associated.</param>
        /// <param name="entityName"> The name of the Service Bus entity to which the scope is associated</param>
        /// <param name="credential">The credential to use for authorization with the Service Bus service.</param>
        /// <param name="transport">The transport to use for communication.</param>
        /// <param name="proxy">The proxy, if any, to use for communication.</param>
        /// <param name="identifier">The identifier to assign this scope; if not provided, one will be generated.</param>
        ///
        public AmqpConnectionScope(Uri serviceEndpoint,
                                   string entityName,
                                   ServiceBusTokenCredential credential,
                                   ServiceBusTransportType transport,
                                   IWebProxy proxy,
                                   string identifier = default)
        {
            Argument.AssertNotNull(serviceEndpoint, nameof(serviceEndpoint));
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));
            Argument.AssertNotNull(credential, nameof(credential));
            ValidateTransport(transport);

            ServiceEndpoint = serviceEndpoint;
            EntityName = entityName;
            Transport = transport;
            Proxy = proxy;
            TokenProvider = new CbsTokenProvider(new ServiceBusTokenCredential(credential, serviceEndpoint.ToString()), OperationCancellationSource.Token);
            Id = identifier ?? $"{ entityName }-{ Guid.NewGuid().ToString("D").Substring(0, 8) }";

            Task<AmqpConnection> connectionFactory(TimeSpan timeout) => CreateAndOpenConnectionAsync(AmqpVersion, ServiceEndpoint, Transport, Proxy, Id, timeout);
            ActiveConnection = new FaultTolerantAmqpObject<AmqpConnection>(connectionFactory, CloseConnection);
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="AmqpConnectionScope"/> class.
        /// </summary>
        ///
        protected AmqpConnectionScope()
        {
        }

        /// <summary>
        ///   Opens an AMQP link for use with management operations.
        /// </summary>
        ///
        /// <param name="timeout">The timeout to apply when creating the link.</param>
        /// <param name="cancellationToken">An optional <see cref="CancellationToken"/> instance to signal the request to cancel the operation.</param>
        ///
        /// <returns>A link for use with management operations.</returns>
        ///
        /// <remarks>
        ///   The authorization for this link does not require periodic
        ///   refreshing.
        /// </remarks>
        ///
        public virtual async Task<RequestResponseAmqpLink> OpenManagementLinkAsync(TimeSpan timeout,
                                                                                   CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

            var stopWatch = Stopwatch.StartNew();
            var connection = await ActiveConnection.GetOrCreateAsync(timeout).ConfigureAwait(false);
            cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

            var link = await CreateManagementLinkAsync(connection, timeout.CalculateRemaining(stopWatch.Elapsed), cancellationToken).ConfigureAwait(false);
            cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

            await OpenAmqpObjectAsync(link, timeout.CalculateRemaining(stopWatch.Elapsed)).ConfigureAwait(false);
            cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

            stopWatch.Stop();
            return link;
        }

        /// <summary>
        ///   Opens an AMQP link for use with consumer operations.
        /// </summary>
        ///
        /// <param name="prefetchCount">Controls the number of events received and queued locally without regard to whether an operation was requested.</param>
        /// <param name="ownerLevel">The relative priority to associate with the link; for a non-exclusive link, this value should be <c>null</c>.</param>
        /// <param name="sessionId"></param>
        /// <param name="timeout">The timeout to apply when creating the link.</param>
        /// <param name="cancellationToken">An optional <see cref="CancellationToken"/> instance to signal the request to cancel the operation.</param>
        ///
        /// <returns>A link for use with consumer operations.</returns>
        ///
        public virtual async Task<ReceivingAmqpLink> OpenConsumerLinkAsync(TimeSpan timeout,
                                                                           uint prefetchCount,
                                                                           long? ownerLevel,
                                                                           string sessionId,
                                                                           CancellationToken cancellationToken)
        {

            cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

            var stopWatch = Stopwatch.StartNew();
            var consumerEndpoint = new Uri(ServiceEndpoint, EntityName);

            var connection = await ActiveConnection.GetOrCreateAsync(timeout).ConfigureAwait(false);
            cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

            var link = await CreateReceivingLinkAsync(
                connection,
                consumerEndpoint,
                timeout.CalculateRemaining(stopWatch.Elapsed),
                prefetchCount,
                ownerLevel,
                sessionId,
                cancellationToken
            ).ConfigureAwait(false);

            cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

            await OpenAmqpObjectAsync(link, timeout.CalculateRemaining(stopWatch.Elapsed)).ConfigureAwait(false);
            cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

            stopWatch.Stop();
            return link;
        }

        /// <summary>
        ///   Opens an AMQP link for use with producer operations.
        /// </summary>
        ///
        /// <param name="timeout">The timeout to apply when creating the link.</param>
        /// <param name="cancellationToken">An optional <see cref="CancellationToken"/> instance to signal the request to cancel the operation.</param>
        ///
        /// <returns>A link for use with producer operations.</returns>
        ///
        public virtual async Task<SendingAmqpLink> OpenProducerLinkAsync(
            TimeSpan timeout,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

            var stopWatch = Stopwatch.StartNew();
            var producerEndpoint = new Uri(ServiceEndpoint, EntityName);

            var connection = await ActiveConnection.GetOrCreateAsync(timeout).ConfigureAwait(false);
            cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

            var link = await CreateSendingLinkAsync(connection, producerEndpoint, timeout.CalculateRemaining(stopWatch.Elapsed), cancellationToken).ConfigureAwait(false);
            cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

            await OpenAmqpObjectAsync(link, timeout.CalculateRemaining(stopWatch.Elapsed)).ConfigureAwait(false);
            cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

            stopWatch.Stop();
            return link;
        }

        /// <summary>
        ///   Performs the task needed to clean up resources used by the <see cref="AmqpConnectionScope" />,
        ///   including ensuring that the client itself has been closed.
        /// </summary>
        ///
        public void Dispose()
        {
            if (IsDisposed)
            {
                return;
            }

            ActiveConnection?.Dispose();
            OperationCancellationSource.Cancel();
            OperationCancellationSource.Dispose();

            IsDisposed = true;
        }

        /// <summary>
        ///   Creates an AMQP connection for a given scope.
        /// </summary>
        ///
        /// <param name="amqpVersion">The version of AMQP to use for the connection.</param>
        /// <param name="serviceEndpoint">The endpoint for the Service Bus service to which the scope is associated.</param>
        /// <param name="transportType">The type of transport to use for communication.</param>
        /// <param name="proxy">The proxy, if any, to use for communication.</param>
        /// <param name="scopeIdentifier">The unique identifier for the associated scope.</param>
        /// <param name="timeout">The timeout to consider when creating the connection.</param>
        ///
        /// <returns>An AMQP connection that may be used for communicating with the Service Bus service.</returns>
        ///
        protected virtual async Task<AmqpConnection> CreateAndOpenConnectionAsync(Version amqpVersion,
                                                                                  Uri serviceEndpoint,
                                                                                  ServiceBusTransportType transportType,
                                                                                  IWebProxy proxy,
                                                                                  string scopeIdentifier,
                                                                                  TimeSpan timeout)
        {
            var hostName = serviceEndpoint.Host;
            AmqpSettings amqpSettings = CreateAmpqSettings(AmqpVersion);
            AmqpConnectionSettings connectionSetings = CreateAmqpConnectionSettings(hostName, scopeIdentifier);

            TransportSettings transportSettings = transportType.IsWebSocketTransport()
                ? CreateTransportSettingsForWebSockets(hostName, proxy)
                : CreateTransportSettingsforTcp(hostName, serviceEndpoint.Port);

            // Create and open the connection, respecting the timeout constraint
            // that was received.

            var stopWatch = Stopwatch.StartNew();

            var initiator = new AmqpTransportInitiator(amqpSettings, transportSettings);
            TransportBase transport = await initiator.ConnectTaskAsync(timeout).ConfigureAwait(false);

            var connection = new AmqpConnection(transport, amqpSettings, connectionSetings);
            await OpenAmqpObjectAsync(connection, timeout.CalculateRemaining(stopWatch.Elapsed)).ConfigureAwait(false);

            stopWatch.Stop();

            // Create the CBS link that will be used for authorization.  The act of creating the link will associate
            // it with the connection.

            new AmqpCbsLink(connection);

            // When the connection is closed, close each of the links associated with it.

            EventHandler closeHandler = null;

            closeHandler = (snd, args) =>
            {
                foreach (var link in ActiveLinks.Keys)
                {
                    link.SafeClose();
                }

                connection.Closed -= closeHandler;
            };

            connection.Closed += closeHandler;
            return connection;
        }

        /// <summary>
        ///   Creates an AMQP link for use with management operations.
        /// </summary>
        ///
        /// <param name="connection">The active and opened AMQP connection to use for this link.</param>
        /// <param name="timeout">The timeout to apply when creating the link.</param>
        /// <param name="cancellationToken">An optional <see cref="CancellationToken"/> instance to signal the request to cancel the operation.</param>
        ///
        /// <returns>A link for use with management operations.</returns>
        ///
        protected virtual async Task<RequestResponseAmqpLink> CreateManagementLinkAsync(AmqpConnection connection,
                                                                                        TimeSpan timeout,
                                                                                        CancellationToken cancellationToken)
        {
            Argument.AssertNotDisposed(IsDisposed, nameof(AmqpConnectionScope));
            cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

            var session = default(AmqpSession);
            var stopWatch = Stopwatch.StartNew();

            try
            {
                // Create and open the AMQP session associated with the link.

                var sessionSettings = new AmqpSessionSettings { Properties = new Fields() };
                session = connection.CreateSession(sessionSettings);

                await OpenAmqpObjectAsync(session, timeout).ConfigureAwait(false);
                cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

                // Create and open the link.

                var linkSettings = new AmqpLinkSettings();
                linkSettings.AddProperty(AmqpProperty.Timeout, (uint)timeout.CalculateRemaining(stopWatch.Elapsed).TotalMilliseconds);
                linkSettings.AddProperty(AmqpClientConstants.EntityTypeName, AmqpClientConstants.EntityTypeManagement);
                var entityPath = EntityName + '/' + AmqpClientConstants.ManagementAddress;
                string[] claims = { ClaimConstants.Manage, ClaimConstants.Listen };
                var endpointUri = new Uri(ServiceEndpoint, entityPath);

                var authExpirationUtc = await RequestAuthorizationUsingCbsAsync(connection, TokenProvider, ServiceEndpoint, endpointUri.AbsoluteUri, endpointUri.AbsoluteUri, claims, timeout.CalculateRemaining(stopWatch.Elapsed)).ConfigureAwait(false);

                var link = new RequestResponseAmqpLink(/*AmqpManagement.LinkType*/"entity-mgmt", session, entityPath, linkSettings.Properties);
                linkSettings.LinkName = $"{connection.Settings.ContainerId};{connection.Identifier}:{session.Identifier}:{link.Identifier}:111";
                stopWatch.Stop();

                // Track the link before returning it, so that it can be managed with the scope.
                var refreshTimer = default(Timer);

                var refreshHandler = CreateAuthorizationRefreshHandler
                (
                    connection,
                    link,
                    TokenProvider,
                    ServiceEndpoint,
                    ServiceEndpoint.AbsoluteUri,
                    ServiceEndpoint.AbsoluteUri,
                    claims,
                    AuthorizationRefreshTimeout,
                    () => (ActiveLinks.ContainsKey(link) ? refreshTimer : null)
                );

                refreshTimer = new Timer(refreshHandler, null, CalculateLinkAuthorizationRefreshInterval(authExpirationUtc), Timeout.InfiniteTimeSpan);

                // Track the link before returning it, so that it can be managed with the scope.

                BeginTrackingLinkAsActive(link, refreshTimer);
                return link;
            }
            catch
            {
                // Aborting the session will perform any necessary cleanup of
                // the associated link as well.

                session?.Abort();
                throw;
            }
        }

        /// <summary>
        ///   Creates an AMQP link for use with receiving operations.
        /// </summary>
        ///
        /// <param name="connection">The active and opened AMQP connection to use for this link.</param>
        /// <param name="endpoint">The fully qualified endpoint to open the link for.</param>
        /// <param name="prefetchCount">Controls the number of events received and queued locally without regard to whether an operation was requested.</param>
        /// <param name="ownerLevel">The relative priority to associate with the link; for a non-exclusive link, this value should be <c>null</c>.</param>
        /// <param name="sessionId"></param>
        /// <param name="timeout">The timeout to apply when creating the link.</param>
        /// <param name="cancellationToken">An optional <see cref="CancellationToken"/> instance to signal the request to cancel the operation.</param>
        ///
        /// <returns>A link for use for operations related to receiving events.</returns>
        ///
        protected virtual async Task<ReceivingAmqpLink> CreateReceivingLinkAsync(AmqpConnection connection,
                                                                                 Uri endpoint,
                                                                                 TimeSpan timeout,
                                                                                 uint prefetchCount,
                                                                                 long? ownerLevel,
                                                                                 string sessionId,
                                                                                 CancellationToken cancellationToken)
        {
            Argument.AssertNotDisposed(IsDisposed, nameof(AmqpConnectionScope));
            cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

            var session = default(AmqpSession);
            var stopWatch = Stopwatch.StartNew();

            try
            {
                // Perform the initial authorization for the link.

                var authClaims = new[] { ServiceBusClaim.Listen };
                var authExpirationUtc = await RequestAuthorizationUsingCbsAsync(connection, TokenProvider, endpoint, endpoint.AbsoluteUri, endpoint.AbsoluteUri, authClaims, timeout.CalculateRemaining(stopWatch.Elapsed)).ConfigureAwait(false);
                cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

                // Create and open the AMQP session associated with the link.

                var sessionSettings = new AmqpSessionSettings { Properties = new Fields() };
                session = connection.CreateSession(sessionSettings);

                await OpenAmqpObjectAsync(session, timeout).ConfigureAwait(false);
                cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

                // Create and open the link.
                var filters = new FilterSet();
                if (sessionId != null)
                {
                    filters.Add(AmqpClientConstants.SessionFilterName, sessionId);
                }


                //if (this.isSessionReceiver)
                //{
                //    filterMap = new FilterSet { { AmqpClientConstants.SessionFilterName, this.SessionIdInternal } };
                //}


                var linkSettings = new AmqpLinkSettings
                {
                    Role = true,
                    TotalLinkCredit = prefetchCount,
                    AutoSendFlow = prefetchCount > 0,
                    SettleType = SettleMode.SettleOnSend,
                    Source = new Source { Address = endpoint.AbsolutePath, FilterSet = filters },
                    Target = new Target { Address = Guid.NewGuid().ToString() }
                };

                //linkSettings.AddProperty(AmqpProperty.EntityType, "0,1,2,3");//(int)AmqpProperty.Entity.ConsumerGroup);

                if (ownerLevel.HasValue)
                {
                    linkSettings.AddProperty(AmqpProperty.OwnerLevel, ownerLevel.Value);
                }

                var link = new ReceivingAmqpLink(linkSettings);
                linkSettings.LinkName = $"{connection.Settings.ContainerId};{connection.Identifier}:{session.Identifier}:{link.Identifier}:{linkSettings.Source.ToString()}:test";

                //linkSettings.LinkName = $"{ Id };{ connection.Identifier }:{ session.Identifier }:{ link.Identifier }";
                link.AttachTo(session);

                stopWatch.Stop();

                // Configure refresh for authorization of the link.

                var refreshTimer = default(Timer);

                var refreshHandler = CreateAuthorizationRefreshHandler
                (
                    connection,
                    link,
                    TokenProvider,
                    endpoint,
                    endpoint.AbsoluteUri,
                    endpoint.AbsoluteUri,
                    authClaims,
                    AuthorizationRefreshTimeout,
                    () => (ActiveLinks.ContainsKey(link) ? refreshTimer : null)
                );

                refreshTimer = new Timer(refreshHandler, null, CalculateLinkAuthorizationRefreshInterval(authExpirationUtc), Timeout.InfiniteTimeSpan);

                // Track the link before returning it, so that it can be managed with the scope.

                BeginTrackingLinkAsActive(link, refreshTimer);
                return link;
            }
            catch
            {
                // Aborting the session will perform any necessary cleanup of
                // the associated link as well.

                session?.Abort();
                throw;
            }
        }

        /// <summary>
        ///   Creates an AMQP link for use with publishing operations.
        /// </summary>
        ///
        /// <param name="connection">The active and opened AMQP connection to use for this link.</param>
        /// <param name="endpoint">The fully qualified endpoint to open the link for.</param>
        /// <param name="timeout">The timeout to apply when creating the link.</param>
        /// <param name="cancellationToken">An optional <see cref="CancellationToken"/> instance to signal the request to cancel the operation.</param>
        ///
        /// <returns>A link for use for operations related to receiving events.</returns>
        ///
        protected virtual async Task<SendingAmqpLink> CreateSendingLinkAsync(AmqpConnection connection,
                                                                             Uri endpoint,
                                                                             TimeSpan timeout,
                                                                             CancellationToken cancellationToken)
        {
            Argument.AssertNotDisposed(IsDisposed, nameof(AmqpConnectionScope));
            cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

            var session = default(AmqpSession);
            var stopWatch = Stopwatch.StartNew();

            try
            {
                // Perform the initial authorization for the link.

                var authClaims = new[] { ServiceBusClaim.Send };
                var authExpirationUtc = await RequestAuthorizationUsingCbsAsync(connection, TokenProvider, endpoint, endpoint.AbsoluteUri, endpoint.AbsoluteUri, authClaims, timeout.CalculateRemaining(stopWatch.Elapsed)).ConfigureAwait(false);
                cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

                // Create and open the AMQP session associated with the link.

                var sessionSettings = new AmqpSessionSettings { Properties = new Fields() };
                session = connection.CreateSession(sessionSettings);

                await OpenAmqpObjectAsync(session, timeout).ConfigureAwait(false);
                cancellationToken.ThrowIfCancellationRequested<TaskCanceledException>();

                // Create and open the link.

                var linkSettings = new AmqpLinkSettings
                {
                    Role = false,
                    InitialDeliveryCount = 0,
                    Source = new Source { Address = Guid.NewGuid().ToString() },
                    Target = new Target { Address = endpoint.AbsolutePath }
                };

                linkSettings.AddProperty(AmqpProperty.Timeout, (uint)timeout.CalculateRemaining(stopWatch.Elapsed).TotalMilliseconds);
                //linkSettings.AddProperty(AmqpProperty.EntityType, "0,1"); // MessagingEntityType

                var link = new SendingAmqpLink(linkSettings);
                linkSettings.LinkName = $"{ Id };{ connection.Identifier }:{ session.Identifier }:{ link.Identifier }";
                link.AttachTo(session);

                stopWatch.Stop();

                // Configure refresh for authorization of the link.

                var refreshTimer = default(Timer);

                var refreshHandler = CreateAuthorizationRefreshHandler
                (
                    connection,
                    link,
                    TokenProvider,
                    endpoint,
                    endpoint.AbsoluteUri,
                    endpoint.AbsoluteUri,
                    authClaims,
                    AuthorizationRefreshTimeout,
                    () => refreshTimer
                );

                refreshTimer = new Timer(refreshHandler, null, CalculateLinkAuthorizationRefreshInterval(authExpirationUtc), Timeout.InfiniteTimeSpan);

                // Track the link before returning it, so that it can be managed with the scope.

                BeginTrackingLinkAsActive(link, refreshTimer);
                return link;
            }
            catch
            {
                // Aborting the session will perform any necessary cleanup of
                // the associated link as well.

                session?.Abort();
                throw;
            }
        }

        /// <summary>
        ///   Performs the actions needed to configure and begin tracking the specified AMQP
        ///   link as an active link bound to this scope.
        /// </summary>
        ///
        /// <param name="link">The link to begin tracking.</param>
        /// <param name="authorizationRefreshTimer">The timer used to manage refreshing authorization, if the link requires it.</param>
        ///
        /// <remarks>
        ///   This method does operate on the specified <paramref name="link"/> in order to configure it
        ///   for active tracking; no assumptions are made about the open/connected state of the link nor are
        ///   its communication properties modified.
        /// </remarks>
        ///
        protected virtual void BeginTrackingLinkAsActive(AmqpObject link,
                                                         Timer authorizationRefreshTimer = null)
        {
            // Register the link as active and having authorization automatically refreshed, so that it can be
            // managed with the scope.

            if (!ActiveLinks.TryAdd(link, authorizationRefreshTimer))
            {
                throw new ServiceBusException(true, EntityName, Resources1.CouldNotCreateLink);
            }

            // When the link is closed, stop refreshing authorization and remove it from the
            // set of associated links.

            var closeHandler = default(EventHandler);

            closeHandler = (snd, args) =>
            {
                ActiveLinks.TryRemove(link, out var timer);

                timer?.Change(Timeout.InfiniteTimeSpan, Timeout.InfiniteTimeSpan);
                timer?.Dispose();

                link.Closed -= closeHandler;
            };

            link.Closed += closeHandler;
        }

        /// <summary>
        ///   Performs the tasks needed to close a connection.
        /// </summary>
        ///
        /// <param name="connection">The connection to close.</param>
        ///
        protected virtual void CloseConnection(AmqpConnection connection) => connection.SafeClose();

        /// <summary>
        ///   Calculates the interval after which authorization for an AMQP link should be
        ///   refreshed.
        /// </summary>
        ///
        /// <param name="expirationTimeUtc">The date/time, in UTC, that the current authorization is expected to expire.</param>
        ///
        /// <returns>The interval after which authorization should be refreshed.</returns>
        ///
        protected virtual TimeSpan CalculateLinkAuthorizationRefreshInterval(DateTime expirationTimeUtc)
        {
            var refreshDueInterval = (expirationTimeUtc.Subtract(DateTime.UtcNow)).Add(AuthorizationRefreshBuffer);
            return (refreshDueInterval < MinimumAuthorizationRefresh) ? MinimumAuthorizationRefresh : refreshDueInterval;
        }

        /// <summary>
        ///   Creates the timer event handler to support refreshing AMQP link authorization
        ///   on a recurring basis.
        /// </summary>
        ///
        /// <param name="connection">The AMQP connection to which the link being refreshed is bound to.</param>
        /// <param name="amqpLink">The AMQO link to refresh authorization for.</param>
        /// <param name="tokenProvider">The <see cref="CbsTokenProvider" /> to use for obtaining access tokens.</param>
        /// <param name="endpoint">The Service Bus service endpoint that the AMQP link is communicating with.</param>
        /// <param name="audience">The audience associated with the authorization.  This is likely the <paramref name="endpoint"/> absolute URI.</param>
        /// <param name="resource">The resource associated with the authorization.  This is likely the <paramref name="endpoint"/> absolute URI.</param>
        /// <param name="requiredClaims">The set of claims required to support the operations of the AMQP link.</param>
        /// <param name="refreshTimeout">The timeout to apply when requesting authorization refresh.</param>
        /// <param name="refreshTimerFactory">A function to allow retrieving the <see cref="Timer" /> associated with the link authorization.</param>
        ///
        /// <returns>A <see cref="TimerCallback"/> delegate to perform the refresh when a timer is due.</returns>
        ///
        protected virtual TimerCallback CreateAuthorizationRefreshHandler(AmqpConnection connection,
                                                                          AmqpObject amqpLink,
                                                                          CbsTokenProvider tokenProvider,
                                                                          Uri endpoint,
                                                                          string audience,
                                                                          string resource,
                                                                          string[] requiredClaims,
                                                                          TimeSpan refreshTimeout,
                                                                          Func<Timer> refreshTimerFactory)
        {
            return async _ =>
            {
                ServiceBusEventSource.Log.AmqpLinkAuthorizationRefreshStart(EntityName, endpoint.AbsoluteUri);
                var refreshTimer = refreshTimerFactory();

                try
                {
                    if (refreshTimer == null)
                    {
                        return;
                    }

                    var authExpirationUtc = await RequestAuthorizationUsingCbsAsync(connection, tokenProvider, endpoint, audience, resource, requiredClaims, refreshTimeout).ConfigureAwait(false);

                    // Reset the timer for the next refresh.

                    if (authExpirationUtc >= DateTimeOffset.UtcNow)
                    {
                        refreshTimer.Change(CalculateLinkAuthorizationRefreshInterval(authExpirationUtc), Timeout.InfiniteTimeSpan);
                    }
                }
                catch (ObjectDisposedException)
                {
                    // This can occur if the connection is closed or the scope disposed after the factory
                    // is called but before the timer is updated.  The callback may also fire while the timer is
                    // in the act of disposing.  Do not consider it an error.
                }
                catch (Exception ex)
                {
                    ServiceBusEventSource.Log.AmqpLinkAuthorizationRefreshError(EntityName, endpoint.AbsoluteUri, ex.Message);

                    // Attempt to unset the timer; there's a decent chance that it has been disposed at this point or
                    // that the connection has been closed.  Ignore potential exceptions, as they won't impact operation.
                    // At worse, another timer tick will occur and the operation will be retried.

                    try { refreshTimer.Change(Timeout.Infinite, Timeout.Infinite); } catch {}
                }
                finally
                {
                    ServiceBusEventSource.Log.AmqpLinkAuthorizationRefreshComplete(EntityName, endpoint.AbsoluteUri);
                }
            };
        }

        /// <summary>
        ///   Performs the actions needed to open a generic AMQP object, such
        ///   as a session or link for use.
        /// </summary>
        ///
        /// <param name="target">The target AMQP object to open.</param>
        /// <param name="timeout">The timeout to apply when opening the link.</param>
        ///
        protected virtual Task OpenAmqpObjectAsync(AmqpObject target,
                                                   TimeSpan timeout) => target.OpenAsync(timeout);

        /// <summary>
        ///   Requests authorization for a connection or link using a connection via the CBS mechanism.
        /// </summary>
        ///
        /// <param name="connection">The AMQP connection for which the authorization is associated.</param>
        /// <param name="tokenProvider">The <see cref="CbsTokenProvider" /> to use for obtaining access tokens.</param>
        /// <param name="endpoint">The Service Bus service endpoint that the authorization is requested for.</param>
        /// <param name="audience">The audience associated with the authorization.  This is likely the <paramref name="endpoint"/> absolute URI.</param>
        /// <param name="resource">The resource associated with the authorization.  This is likely the <paramref name="endpoint"/> absolute URI.</param>
        /// <param name="requiredClaims">The set of claims required to support the operations of the AMQP link.</param>
        /// <param name="timeout">The timeout to apply when requesting authorization.</param>
        ///
        /// <returns>The date/time, in UTC, when the authorization expires.</returns>
        ///
        /// <remarks>
        ///   It is assumed that there is a valid <see cref="AmqpCbsLink" /> already associated
        ///   with the connection; this will be used as the transport for the authorization
        ///   credentials.
        /// </remarks>
        ///
        protected virtual Task<DateTime> RequestAuthorizationUsingCbsAsync(AmqpConnection connection,
                                                                           CbsTokenProvider tokenProvider,
                                                                           Uri endpoint,
                                                                           string audience,
                                                                           string resource,
                                                                           string[] requiredClaims,
                                                                           TimeSpan timeout)
        {
            var authLink = connection.Extensions.Find<AmqpCbsLink>();
            return authLink.SendTokenAsync(TokenProvider, endpoint, audience, resource, requiredClaims, timeout);
        }

        /// <summary>
        ///   Creates the settings to use for AMQP communication.
        /// </summary>
        ///
        /// <param name="amqpVersion">The version of AMQP to be used.</param>
        ///
        /// <returns>The settings for AMQP to use for communication with the Service Bus service.</returns>
        ///
        private static AmqpSettings CreateAmpqSettings(Version amqpVersion)
        {
            var saslProvider = new SaslTransportProvider();
            saslProvider.Versions.Add(new AmqpVersion(amqpVersion));
            saslProvider.AddHandler(new SaslAnonymousHandler(CbsSaslHandlerName));

            var amqpProvider = new AmqpTransportProvider();
            amqpProvider.Versions.Add(new AmqpVersion(amqpVersion));

            var settings = new AmqpSettings();
            settings.TransportProviders.Add(saslProvider);
            settings.TransportProviders.Add(amqpProvider);

            return settings;
        }

        /// <summary>
        ///  Creates the transport settings for use with TCP.
        /// </summary>
        ///
        /// <param name="hostName">The host name of the Service Bus service endpoint.</param>
        /// <param name="port">The port to use for connecting to the endpoint.</param>
        ///
        /// <returns>The settings to use for transport.</returns>
        ///
        private static TransportSettings CreateTransportSettingsforTcp(string hostName,
                                                                       int port)
        {
            var tcpSettings = new TcpTransportSettings
            {
                Host = hostName,
                Port = port < 0 ? AmqpConstants.DefaultSecurePort : port,
                ReceiveBufferSize = AmqpConstants.TransportBufferSize,
                SendBufferSize = AmqpConstants.TransportBufferSize
            };

            return new TlsTransportSettings(tcpSettings)
            {
                TargetHost = hostName,
            };
        }

        /// <summary>
        ///  Creates the transport settings for use with web sockets.
        /// </summary>
        ///
        /// <param name="hostName">The host name of the Service Bus service endpoint.</param>
        /// <param name="proxy">The proxy to use for connecting to the endpoint.</param>
        ///
        /// <returns>The settings to use for transport.</returns>
        ///
        private static TransportSettings CreateTransportSettingsForWebSockets(string hostName,
                                                                              IWebProxy proxy)
        {
            var uriBuilder = new UriBuilder(hostName)
            {
                Path = WebSocketsPathSuffix,
                Scheme = WebSocketsUriScheme,
                Port = -1
            };

            return new WebSocketTransportSettings
            {
                Uri = uriBuilder.Uri,
                Proxy = proxy ?? (default)
            };
        }

        /// <summary>
        ///   Creates the AMQP connection settings to use when communicating with the Service Bus service.
        /// </summary>
        ///
        /// <param name="hostName">The host name of the Service Bus service endpoint.</param>
        /// <param name="identifier">unique identifier of the current Service Bus scope.</param>
        ///
        /// <returns>The settings to apply to the connection.</returns>
        ///
        private static AmqpConnectionSettings CreateAmqpConnectionSettings(string hostName,
                                                                           string identifier)
        {
            var connectionSettings = new AmqpConnectionSettings
            {
                IdleTimeOut = (uint)ConnectionIdleTimeout.TotalMilliseconds,
                MaxFrameSize = AmqpConstants.DefaultMaxFrameSize,
                ContainerId = identifier,
                HostName = hostName
            };

            foreach (KeyValuePair<string, string> property in ClientLibraryInformation.Current.EnumerateProperties())
            {
                connectionSettings.AddProperty(property.Key, property.Value);
            }

            return connectionSettings;
        }

        /// <summary>
        ///   Validates the transport associated with the scope, throwing an argument exception
        ///   if it is unknown in this context.
        /// </summary>
        ///
        /// <param name="transport">The transport to validate.</param>
        ///
        private static void ValidateTransport(ServiceBusTransportType transport)
        {
            if ((transport != ServiceBusTransportType.AmqpTcp) && (transport != ServiceBusTransportType.AmqpWebSockets))
            {
                throw new ArgumentException(nameof(transport), string.Format(CultureInfo.CurrentCulture, Resources1.UnknownConnectionType, transport));
            }
        }
    }
}
