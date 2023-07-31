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

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkFabricL3IsolationDomainResource" /> and their operations.
    /// Each <see cref="NetworkFabricL3IsolationDomainResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="NetworkFabricL3IsolationDomainCollection" /> instance call the GetNetworkFabricL3IsolationDomains method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class NetworkFabricL3IsolationDomainCollection : ArmCollection, IEnumerable<NetworkFabricL3IsolationDomainResource>, IAsyncEnumerable<NetworkFabricL3IsolationDomainResource>
    {
        private readonly ClientDiagnostics _networkFabricL3IsolationDomainL3IsolationDomainsClientDiagnostics;
        private readonly L3IsolationDomainsRestOperations _networkFabricL3IsolationDomainL3IsolationDomainsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricL3IsolationDomainCollection"/> class for mocking. </summary>
        protected NetworkFabricL3IsolationDomainCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricL3IsolationDomainCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkFabricL3IsolationDomainCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkFabricL3IsolationDomainL3IsolationDomainsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkFabricL3IsolationDomainResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkFabricL3IsolationDomainResource.ResourceType, out string networkFabricL3IsolationDomainL3IsolationDomainsApiVersion);
            _networkFabricL3IsolationDomainL3IsolationDomainsRestClient = new L3IsolationDomainsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkFabricL3IsolationDomainL3IsolationDomainsApiVersion);
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
        /// Create isolation domain resources for layer 3 connectivity between compute nodes and for communication with external services .This configuration is applied on the devices only after the creation of networks is completed and isolation domain is enabled.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3IsolationDomains_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="l3IsolationDomainName"> Name of the L3 Isolation Domain. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l3IsolationDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l3IsolationDomainName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkFabricL3IsolationDomainResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string l3IsolationDomainName, NetworkFabricL3IsolationDomainData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l3IsolationDomainName, nameof(l3IsolationDomainName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFabricL3IsolationDomainL3IsolationDomainsClientDiagnostics.CreateScope("NetworkFabricL3IsolationDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkFabricL3IsolationDomainL3IsolationDomainsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, l3IsolationDomainName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkFabricArmOperation<NetworkFabricL3IsolationDomainResource>(new NetworkFabricL3IsolationDomainOperationSource(Client), _networkFabricL3IsolationDomainL3IsolationDomainsClientDiagnostics, Pipeline, _networkFabricL3IsolationDomainL3IsolationDomainsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, l3IsolationDomainName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create isolation domain resources for layer 3 connectivity between compute nodes and for communication with external services .This configuration is applied on the devices only after the creation of networks is completed and isolation domain is enabled.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3IsolationDomains_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="l3IsolationDomainName"> Name of the L3 Isolation Domain. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l3IsolationDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l3IsolationDomainName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkFabricL3IsolationDomainResource> CreateOrUpdate(WaitUntil waitUntil, string l3IsolationDomainName, NetworkFabricL3IsolationDomainData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l3IsolationDomainName, nameof(l3IsolationDomainName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFabricL3IsolationDomainL3IsolationDomainsClientDiagnostics.CreateScope("NetworkFabricL3IsolationDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkFabricL3IsolationDomainL3IsolationDomainsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, l3IsolationDomainName, data, cancellationToken);
                var operation = new ManagedNetworkFabricArmOperation<NetworkFabricL3IsolationDomainResource>(new NetworkFabricL3IsolationDomainOperationSource(Client), _networkFabricL3IsolationDomainL3IsolationDomainsClientDiagnostics, Pipeline, _networkFabricL3IsolationDomainL3IsolationDomainsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, l3IsolationDomainName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves details of this L3 Isolation Domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3IsolationDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l3IsolationDomainName"> Name of the L3 Isolation Domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l3IsolationDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l3IsolationDomainName"/> is null. </exception>
        public virtual async Task<Response<NetworkFabricL3IsolationDomainResource>> GetAsync(string l3IsolationDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l3IsolationDomainName, nameof(l3IsolationDomainName));

            using var scope = _networkFabricL3IsolationDomainL3IsolationDomainsClientDiagnostics.CreateScope("NetworkFabricL3IsolationDomainCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkFabricL3IsolationDomainL3IsolationDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, l3IsolationDomainName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricL3IsolationDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves details of this L3 Isolation Domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3IsolationDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l3IsolationDomainName"> Name of the L3 Isolation Domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l3IsolationDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l3IsolationDomainName"/> is null. </exception>
        public virtual Response<NetworkFabricL3IsolationDomainResource> Get(string l3IsolationDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l3IsolationDomainName, nameof(l3IsolationDomainName));

            using var scope = _networkFabricL3IsolationDomainL3IsolationDomainsClientDiagnostics.CreateScope("NetworkFabricL3IsolationDomainCollection.Get");
            scope.Start();
            try
            {
                var response = _networkFabricL3IsolationDomainL3IsolationDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, l3IsolationDomainName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricL3IsolationDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Displays L3IsolationDomains list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3IsolationDomains_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkFabricL3IsolationDomainResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkFabricL3IsolationDomainResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricL3IsolationDomainL3IsolationDomainsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricL3IsolationDomainL3IsolationDomainsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkFabricL3IsolationDomainResource(Client, NetworkFabricL3IsolationDomainData.DeserializeNetworkFabricL3IsolationDomainData(e)), _networkFabricL3IsolationDomainL3IsolationDomainsClientDiagnostics, Pipeline, "NetworkFabricL3IsolationDomainCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Displays L3IsolationDomains list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3IsolationDomains_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkFabricL3IsolationDomainResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkFabricL3IsolationDomainResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricL3IsolationDomainL3IsolationDomainsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricL3IsolationDomainL3IsolationDomainsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkFabricL3IsolationDomainResource(Client, NetworkFabricL3IsolationDomainData.DeserializeNetworkFabricL3IsolationDomainData(e)), _networkFabricL3IsolationDomainL3IsolationDomainsClientDiagnostics, Pipeline, "NetworkFabricL3IsolationDomainCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3IsolationDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l3IsolationDomainName"> Name of the L3 Isolation Domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l3IsolationDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l3IsolationDomainName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string l3IsolationDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l3IsolationDomainName, nameof(l3IsolationDomainName));

            using var scope = _networkFabricL3IsolationDomainL3IsolationDomainsClientDiagnostics.CreateScope("NetworkFabricL3IsolationDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkFabricL3IsolationDomainL3IsolationDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, l3IsolationDomainName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L3IsolationDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l3IsolationDomainName"> Name of the L3 Isolation Domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l3IsolationDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l3IsolationDomainName"/> is null. </exception>
        public virtual Response<bool> Exists(string l3IsolationDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l3IsolationDomainName, nameof(l3IsolationDomainName));

            using var scope = _networkFabricL3IsolationDomainL3IsolationDomainsClientDiagnostics.CreateScope("NetworkFabricL3IsolationDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkFabricL3IsolationDomainL3IsolationDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, l3IsolationDomainName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkFabricL3IsolationDomainResource> IEnumerable<NetworkFabricL3IsolationDomainResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkFabricL3IsolationDomainResource> IAsyncEnumerable<NetworkFabricL3IsolationDomainResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
