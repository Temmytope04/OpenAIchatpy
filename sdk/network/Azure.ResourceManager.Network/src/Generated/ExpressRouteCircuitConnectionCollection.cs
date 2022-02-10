// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of ExpressRouteCircuitConnection and their operations over its parent. </summary>
    public partial class ExpressRouteCircuitConnectionCollection : ArmCollection, IEnumerable<ExpressRouteCircuitConnection>, IAsyncEnumerable<ExpressRouteCircuitConnection>
    {
        private readonly ClientDiagnostics _expressRouteCircuitConnectionClientDiagnostics;
        private readonly ExpressRouteCircuitConnectionsRestOperations _expressRouteCircuitConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitConnectionCollection"/> class for mocking. </summary>
        protected ExpressRouteCircuitConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRouteCircuitConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteCircuitConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRouteCircuitConnection.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ExpressRouteCircuitConnection.ResourceType, out string expressRouteCircuitConnectionApiVersion);
            _expressRouteCircuitConnectionRestClient = new ExpressRouteCircuitConnectionsRestOperations(_expressRouteCircuitConnectionClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, expressRouteCircuitConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ExpressRouteCircuitPeering.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ExpressRouteCircuitPeering.ResourceType), nameof(id));
        }

        /// <summary> Creates or updates a Express Route Circuit Connection in the specified express route circuits. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="expressRouteCircuitConnectionParameters"> Parameters supplied to the create or update express route circuit connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="expressRouteCircuitConnectionParameters"/> is null. </exception>
        public async virtual Task<ArmOperation<ExpressRouteCircuitConnection>> CreateOrUpdateAsync(bool waitForCompletion, string connectionName, ExpressRouteCircuitConnectionData expressRouteCircuitConnectionParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            if (expressRouteCircuitConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(expressRouteCircuitConnectionParameters));
            }

            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, expressRouteCircuitConnectionParameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ExpressRouteCircuitConnection>(new ExpressRouteCircuitConnectionOperationSource(Client), _expressRouteCircuitConnectionClientDiagnostics, Pipeline, _expressRouteCircuitConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, expressRouteCircuitConnectionParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a Express Route Circuit Connection in the specified express route circuits. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="expressRouteCircuitConnectionParameters"> Parameters supplied to the create or update express route circuit connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="expressRouteCircuitConnectionParameters"/> is null. </exception>
        public virtual ArmOperation<ExpressRouteCircuitConnection> CreateOrUpdate(bool waitForCompletion, string connectionName, ExpressRouteCircuitConnectionData expressRouteCircuitConnectionParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            if (expressRouteCircuitConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(expressRouteCircuitConnectionParameters));
            }

            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, expressRouteCircuitConnectionParameters, cancellationToken);
                var operation = new NetworkArmOperation<ExpressRouteCircuitConnection>(new ExpressRouteCircuitConnectionOperationSource(Client), _expressRouteCircuitConnectionClientDiagnostics, Pipeline, _expressRouteCircuitConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, expressRouteCircuitConnectionParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Express Route Circuit Connection from the specified express route circuit. </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public async virtual Task<Response<ExpressRouteCircuitConnection>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _expressRouteCircuitConnectionClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ExpressRouteCircuitConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Express Route Circuit Connection from the specified express route circuit. </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<ExpressRouteCircuitConnection> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken);
                if (response.Value == null)
                    throw _expressRouteCircuitConnectionClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all global reach connections associated with a private peering in an express route circuit. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteCircuitConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteCircuitConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExpressRouteCircuitConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteCircuitConnectionRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuitConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExpressRouteCircuitConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteCircuitConnectionRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuitConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all global reach connections associated with a private peering in an express route circuit. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteCircuitConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteCircuitConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ExpressRouteCircuitConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteCircuitConnectionRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuitConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExpressRouteCircuitConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteCircuitConnectionRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuitConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(connectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public async virtual Task<Response<ExpressRouteCircuitConnection>> GetIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ExpressRouteCircuitConnection>(null, response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<ExpressRouteCircuitConnection> GetIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ExpressRouteCircuitConnection>(null, response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRouteCircuitConnection> IEnumerable<ExpressRouteCircuitConnection>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteCircuitConnection> IAsyncEnumerable<ExpressRouteCircuitConnection>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
