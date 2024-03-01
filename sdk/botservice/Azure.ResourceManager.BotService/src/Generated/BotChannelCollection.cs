// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.BotService.Models;

namespace Azure.ResourceManager.BotService
{
    /// <summary>
    /// A class representing a collection of <see cref="BotChannelResource"/> and their operations.
    /// Each <see cref="BotChannelResource"/> in the collection will belong to the same instance of <see cref="BotResource"/>.
    /// To get a <see cref="BotChannelCollection"/> instance call the GetBotChannels method from an instance of <see cref="BotResource"/>.
    /// </summary>
    public partial class BotChannelCollection : ArmCollection, IEnumerable<BotChannelResource>, IAsyncEnumerable<BotChannelResource>
    {
        private readonly ClientDiagnostics _botChannelChannelsClientDiagnostics;
        private readonly ChannelsRestOperations _botChannelChannelsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BotChannelCollection"/> class for mocking. </summary>
        protected BotChannelCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BotChannelCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BotChannelCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _botChannelChannelsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.BotService", BotChannelResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BotChannelResource.ResourceType, out string botChannelChannelsApiVersion);
            _botChannelChannelsRestClient = new ChannelsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, botChannelChannelsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a Channel registration for a Bot Service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/channels/{channelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Channels_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotChannelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="channelName"> The name of the Channel resource. </param>
        /// <param name="data"> The parameters to provide for the created bot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BotChannelResource>> CreateOrUpdateAsync(WaitUntil waitUntil, BotChannelName channelName, BotChannelData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _botChannelChannelsClientDiagnostics.CreateScope("BotChannelCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _botChannelChannelsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, channelName, data, cancellationToken).ConfigureAwait(false);
                var operation = new BotServiceArmOperation<BotChannelResource>(Response.FromValue(new BotChannelResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a Channel registration for a Bot Service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/channels/{channelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Channels_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotChannelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="channelName"> The name of the Channel resource. </param>
        /// <param name="data"> The parameters to provide for the created bot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BotChannelResource> CreateOrUpdate(WaitUntil waitUntil, BotChannelName channelName, BotChannelData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _botChannelChannelsClientDiagnostics.CreateScope("BotChannelCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _botChannelChannelsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, channelName, data, cancellationToken);
                var operation = new BotServiceArmOperation<BotChannelResource>(Response.FromValue(new BotChannelResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a BotService Channel registration specified by the parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/channels/{channelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Channels_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotChannelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="channelName"> The name of the Channel resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BotChannelResource>> GetAsync(BotChannelName channelName, CancellationToken cancellationToken = default)
        {
            using var scope = _botChannelChannelsClientDiagnostics.CreateScope("BotChannelCollection.Get");
            scope.Start();
            try
            {
                var response = await _botChannelChannelsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, channelName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BotChannelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a BotService Channel registration specified by the parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/channels/{channelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Channels_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotChannelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="channelName"> The name of the Channel resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BotChannelResource> Get(BotChannelName channelName, CancellationToken cancellationToken = default)
        {
            using var scope = _botChannelChannelsClientDiagnostics.CreateScope("BotChannelCollection.Get");
            scope.Start();
            try
            {
                var response = _botChannelChannelsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, channelName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BotChannelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns all the Channel registrations of a particular BotService resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/channels</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Channels_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotChannelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BotChannelResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BotChannelResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _botChannelChannelsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _botChannelChannelsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BotChannelResource(Client, BotChannelData.DeserializeBotChannelData(e)), _botChannelChannelsClientDiagnostics, Pipeline, "BotChannelCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns all the Channel registrations of a particular BotService resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/channels</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Channels_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotChannelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BotChannelResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BotChannelResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _botChannelChannelsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _botChannelChannelsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BotChannelResource(Client, BotChannelData.DeserializeBotChannelData(e)), _botChannelChannelsClientDiagnostics, Pipeline, "BotChannelCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/channels/{channelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Channels_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotChannelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="channelName"> The name of the Channel resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(BotChannelName channelName, CancellationToken cancellationToken = default)
        {
            using var scope = _botChannelChannelsClientDiagnostics.CreateScope("BotChannelCollection.Exists");
            scope.Start();
            try
            {
                var response = await _botChannelChannelsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, channelName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/channels/{channelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Channels_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotChannelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="channelName"> The name of the Channel resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(BotChannelName channelName, CancellationToken cancellationToken = default)
        {
            using var scope = _botChannelChannelsClientDiagnostics.CreateScope("BotChannelCollection.Exists");
            scope.Start();
            try
            {
                var response = _botChannelChannelsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, channelName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/channels/{channelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Channels_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotChannelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="channelName"> The name of the Channel resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<BotChannelResource>> GetIfExistsAsync(BotChannelName channelName, CancellationToken cancellationToken = default)
        {
            using var scope = _botChannelChannelsClientDiagnostics.CreateScope("BotChannelCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _botChannelChannelsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, channelName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BotChannelResource>(response.GetRawResponse());
                return Response.FromValue(new BotChannelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/channels/{channelName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Channels_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotChannelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="channelName"> The name of the Channel resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<BotChannelResource> GetIfExists(BotChannelName channelName, CancellationToken cancellationToken = default)
        {
            using var scope = _botChannelChannelsClientDiagnostics.CreateScope("BotChannelCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _botChannelChannelsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, channelName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BotChannelResource>(response.GetRawResponse());
                return Response.FromValue(new BotChannelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BotChannelResource> IEnumerable<BotChannelResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BotChannelResource> IAsyncEnumerable<BotChannelResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
