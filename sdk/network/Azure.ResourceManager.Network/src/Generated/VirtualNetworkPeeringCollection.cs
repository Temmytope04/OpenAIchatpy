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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualNetworkPeeringResource"/> and their operations.
    /// Each <see cref="VirtualNetworkPeeringResource"/> in the collection will belong to the same instance of <see cref="VirtualNetworkResource"/>.
    /// To get a <see cref="VirtualNetworkPeeringCollection"/> instance call the GetVirtualNetworkPeerings method from an instance of <see cref="VirtualNetworkResource"/>.
    /// </summary>
    public partial class VirtualNetworkPeeringCollection : ArmCollection, IEnumerable<VirtualNetworkPeeringResource>, IAsyncEnumerable<VirtualNetworkPeeringResource>
    {
        private readonly ClientDiagnostics _virtualNetworkPeeringClientDiagnostics;
        private readonly VirtualNetworkPeeringsRestOperations _virtualNetworkPeeringRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkPeeringCollection"/> class for mocking. </summary>
        protected VirtualNetworkPeeringCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkPeeringCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualNetworkPeeringCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualNetworkPeeringClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VirtualNetworkPeeringResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualNetworkPeeringResource.ResourceType, out string virtualNetworkPeeringApiVersion);
            _virtualNetworkPeeringRestClient = new VirtualNetworkPeeringsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualNetworkPeeringApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualNetworkResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualNetworkResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a peering in the specified virtual network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/virtualNetworkPeerings/{virtualNetworkPeeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkPeerings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkPeeringName"> The name of the peering. </param>
        /// <param name="data"> Parameters supplied to the create or update virtual network peering operation. </param>
        /// <param name="syncRemoteAddressSpace"> Parameter indicates the intention to sync the peering with the current address space on the remote vNet after it's updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkPeeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkPeeringName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualNetworkPeeringResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualNetworkPeeringName, VirtualNetworkPeeringData data, SyncRemoteAddressSpace? syncRemoteAddressSpace = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkPeeringName, nameof(virtualNetworkPeeringName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualNetworkPeeringClientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualNetworkPeeringRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, data, syncRemoteAddressSpace, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VirtualNetworkPeeringResource>(new VirtualNetworkPeeringOperationSource(Client), _virtualNetworkPeeringClientDiagnostics, Pipeline, _virtualNetworkPeeringRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, data, syncRemoteAddressSpace).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a peering in the specified virtual network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/virtualNetworkPeerings/{virtualNetworkPeeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkPeerings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkPeeringName"> The name of the peering. </param>
        /// <param name="data"> Parameters supplied to the create or update virtual network peering operation. </param>
        /// <param name="syncRemoteAddressSpace"> Parameter indicates the intention to sync the peering with the current address space on the remote vNet after it's updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkPeeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkPeeringName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualNetworkPeeringResource> CreateOrUpdate(WaitUntil waitUntil, string virtualNetworkPeeringName, VirtualNetworkPeeringData data, SyncRemoteAddressSpace? syncRemoteAddressSpace = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkPeeringName, nameof(virtualNetworkPeeringName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualNetworkPeeringClientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualNetworkPeeringRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, data, syncRemoteAddressSpace, cancellationToken);
                var operation = new NetworkArmOperation<VirtualNetworkPeeringResource>(new VirtualNetworkPeeringOperationSource(Client), _virtualNetworkPeeringClientDiagnostics, Pipeline, _virtualNetworkPeeringRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, data, syncRemoteAddressSpace).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified virtual network peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/virtualNetworkPeerings/{virtualNetworkPeeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkPeeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkPeeringName"/> is null. </exception>
        public virtual async Task<Response<VirtualNetworkPeeringResource>> GetAsync(string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkPeeringName, nameof(virtualNetworkPeeringName));

            using var scope = _virtualNetworkPeeringClientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworkPeeringRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkPeeringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified virtual network peering.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/virtualNetworkPeerings/{virtualNetworkPeeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkPeeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkPeeringName"/> is null. </exception>
        public virtual Response<VirtualNetworkPeeringResource> Get(string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkPeeringName, nameof(virtualNetworkPeeringName));

            using var scope = _virtualNetworkPeeringClientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworkPeeringRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkPeeringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all virtual network peerings in a virtual network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/virtualNetworkPeerings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkPeerings_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkPeeringResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkPeeringResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualNetworkPeeringRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualNetworkPeeringRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VirtualNetworkPeeringResource(Client, VirtualNetworkPeeringData.DeserializeVirtualNetworkPeeringData(e)), _virtualNetworkPeeringClientDiagnostics, Pipeline, "VirtualNetworkPeeringCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all virtual network peerings in a virtual network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/virtualNetworkPeerings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkPeerings_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkPeeringResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkPeeringResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualNetworkPeeringRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualNetworkPeeringRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VirtualNetworkPeeringResource(Client, VirtualNetworkPeeringData.DeserializeVirtualNetworkPeeringData(e)), _virtualNetworkPeeringClientDiagnostics, Pipeline, "VirtualNetworkPeeringCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/virtualNetworkPeerings/{virtualNetworkPeeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkPeeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkPeeringName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkPeeringName, nameof(virtualNetworkPeeringName));

            using var scope = _virtualNetworkPeeringClientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualNetworkPeeringRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/virtualNetworkPeerings/{virtualNetworkPeeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkPeeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkPeeringName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkPeeringName, nameof(virtualNetworkPeeringName));

            using var scope = _virtualNetworkPeeringClientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualNetworkPeeringRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/virtualNetworkPeerings/{virtualNetworkPeeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkPeeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkPeeringName"/> is null. </exception>
        public virtual async Task<NullableResponse<VirtualNetworkPeeringResource>> GetIfExistsAsync(string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkPeeringName, nameof(virtualNetworkPeeringName));

            using var scope = _virtualNetworkPeeringClientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualNetworkPeeringRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VirtualNetworkPeeringResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkPeeringResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/virtualNetworkPeerings/{virtualNetworkPeeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkPeeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkPeeringName"/> is null. </exception>
        public virtual NullableResponse<VirtualNetworkPeeringResource> GetIfExists(string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkPeeringName, nameof(virtualNetworkPeeringName));

            using var scope = _virtualNetworkPeeringClientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualNetworkPeeringRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VirtualNetworkPeeringResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkPeeringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualNetworkPeeringResource> IEnumerable<VirtualNetworkPeeringResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualNetworkPeeringResource> IAsyncEnumerable<VirtualNetworkPeeringResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
