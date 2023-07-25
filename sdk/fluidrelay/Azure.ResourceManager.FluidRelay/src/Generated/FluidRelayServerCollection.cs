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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.FluidRelay
{
    /// <summary>
    /// A class representing a collection of <see cref="FluidRelayServerResource" /> and their operations.
    /// Each <see cref="FluidRelayServerResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="FluidRelayServerCollection" /> instance call the GetFluidRelayServers method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class FluidRelayServerCollection : ArmCollection, IEnumerable<FluidRelayServerResource>, IAsyncEnumerable<FluidRelayServerResource>
    {
        private readonly ClientDiagnostics _fluidRelayServerClientDiagnostics;
        private readonly FluidRelayServersRestOperations _fluidRelayServerRestClient;

        /// <summary> Initializes a new instance of the <see cref="FluidRelayServerCollection"/> class for mocking. </summary>
        protected FluidRelayServerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FluidRelayServerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FluidRelayServerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _fluidRelayServerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.FluidRelay", FluidRelayServerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FluidRelayServerResource.ResourceType, out string fluidRelayServerApiVersion);
            _fluidRelayServerRestClient = new FluidRelayServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, fluidRelayServerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or Update a Fluid Relay server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers/{fluidRelayServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayServers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fluidRelayServerName"> The Fluid Relay server resource name. </param>
        /// <param name="data"> The details of the Fluid Relay server resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluidRelayServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluidRelayServerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FluidRelayServerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string fluidRelayServerName, FluidRelayServerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluidRelayServerName, nameof(fluidRelayServerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _fluidRelayServerClientDiagnostics.CreateScope("FluidRelayServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _fluidRelayServerRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, fluidRelayServerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new FluidRelayArmOperation<FluidRelayServerResource>(Response.FromValue(new FluidRelayServerResource(Client, response), response.GetRawResponse()));
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
        /// Create or Update a Fluid Relay server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers/{fluidRelayServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayServers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fluidRelayServerName"> The Fluid Relay server resource name. </param>
        /// <param name="data"> The details of the Fluid Relay server resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluidRelayServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluidRelayServerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FluidRelayServerResource> CreateOrUpdate(WaitUntil waitUntil, string fluidRelayServerName, FluidRelayServerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluidRelayServerName, nameof(fluidRelayServerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _fluidRelayServerClientDiagnostics.CreateScope("FluidRelayServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _fluidRelayServerRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, fluidRelayServerName, data, cancellationToken);
                var operation = new FluidRelayArmOperation<FluidRelayServerResource>(Response.FromValue(new FluidRelayServerResource(Client, response), response.GetRawResponse()));
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
        /// Get a Fluid Relay server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers/{fluidRelayServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayServers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fluidRelayServerName"> The Fluid Relay server resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluidRelayServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluidRelayServerName"/> is null. </exception>
        public virtual async Task<Response<FluidRelayServerResource>> GetAsync(string fluidRelayServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluidRelayServerName, nameof(fluidRelayServerName));

            using var scope = _fluidRelayServerClientDiagnostics.CreateScope("FluidRelayServerCollection.Get");
            scope.Start();
            try
            {
                var response = await _fluidRelayServerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, fluidRelayServerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FluidRelayServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Fluid Relay server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers/{fluidRelayServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayServers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fluidRelayServerName"> The Fluid Relay server resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluidRelayServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluidRelayServerName"/> is null. </exception>
        public virtual Response<FluidRelayServerResource> Get(string fluidRelayServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluidRelayServerName, nameof(fluidRelayServerName));

            using var scope = _fluidRelayServerClientDiagnostics.CreateScope("FluidRelayServerCollection.Get");
            scope.Start();
            try
            {
                var response = _fluidRelayServerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, fluidRelayServerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FluidRelayServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all Fluid Relay servers in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayServers_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FluidRelayServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FluidRelayServerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _fluidRelayServerRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _fluidRelayServerRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FluidRelayServerResource(Client, FluidRelayServerData.DeserializeFluidRelayServerData(e)), _fluidRelayServerClientDiagnostics, Pipeline, "FluidRelayServerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all Fluid Relay servers in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayServers_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FluidRelayServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FluidRelayServerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _fluidRelayServerRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _fluidRelayServerRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FluidRelayServerResource(Client, FluidRelayServerData.DeserializeFluidRelayServerData(e)), _fluidRelayServerClientDiagnostics, Pipeline, "FluidRelayServerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers/{fluidRelayServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayServers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fluidRelayServerName"> The Fluid Relay server resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluidRelayServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluidRelayServerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fluidRelayServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluidRelayServerName, nameof(fluidRelayServerName));

            using var scope = _fluidRelayServerClientDiagnostics.CreateScope("FluidRelayServerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _fluidRelayServerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, fluidRelayServerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.FluidRelay/fluidRelayServers/{fluidRelayServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayServers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fluidRelayServerName"> The Fluid Relay server resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fluidRelayServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fluidRelayServerName"/> is null. </exception>
        public virtual Response<bool> Exists(string fluidRelayServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fluidRelayServerName, nameof(fluidRelayServerName));

            using var scope = _fluidRelayServerClientDiagnostics.CreateScope("FluidRelayServerCollection.Exists");
            scope.Start();
            try
            {
                var response = _fluidRelayServerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, fluidRelayServerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FluidRelayServerResource> IEnumerable<FluidRelayServerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FluidRelayServerResource> IAsyncEnumerable<FluidRelayServerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
