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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HybridNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkFunctionResource" /> and their operations.
    /// Each <see cref="NetworkFunctionResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="NetworkFunctionCollection" /> instance call the GetNetworkFunctions method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class NetworkFunctionCollection : ArmCollection, IEnumerable<NetworkFunctionResource>, IAsyncEnumerable<NetworkFunctionResource>
    {
        private readonly ClientDiagnostics _networkFunctionClientDiagnostics;
        private readonly NetworkFunctionsRestOperations _networkFunctionRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkFunctionCollection"/> class for mocking. </summary>
        protected NetworkFunctionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFunctionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkFunctionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkFunctionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridNetwork", NetworkFunctionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkFunctionResource.ResourceType, out string networkFunctionApiVersion);
            _networkFunctionRestClient = new NetworkFunctionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkFunctionApiVersion);
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
        /// Creates or updates a network function resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/networkFunctions/{networkFunctionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkFunctionName"> Resource name for the network function resource. </param>
        /// <param name="data"> Parameters supplied in the body to the create or update network function operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkFunctionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkFunctionName, NetworkFunctionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionName, nameof(networkFunctionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFunctionClientDiagnostics.CreateScope("NetworkFunctionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkFunctionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, networkFunctionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridNetworkArmOperation<NetworkFunctionResource>(new NetworkFunctionOperationSource(Client), _networkFunctionClientDiagnostics, Pipeline, _networkFunctionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkFunctionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a network function resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/networkFunctions/{networkFunctionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkFunctionName"> Resource name for the network function resource. </param>
        /// <param name="data"> Parameters supplied in the body to the create or update network function operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkFunctionResource> CreateOrUpdate(WaitUntil waitUntil, string networkFunctionName, NetworkFunctionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionName, nameof(networkFunctionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFunctionClientDiagnostics.CreateScope("NetworkFunctionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkFunctionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, networkFunctionName, data, cancellationToken);
                var operation = new HybridNetworkArmOperation<NetworkFunctionResource>(new NetworkFunctionOperationSource(Client), _networkFunctionClientDiagnostics, Pipeline, _networkFunctionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkFunctionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified network function resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/networkFunctions/{networkFunctionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionName"> The name of the network function resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionName"/> is null. </exception>
        public virtual async Task<Response<NetworkFunctionResource>> GetAsync(string networkFunctionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionName, nameof(networkFunctionName));

            using var scope = _networkFunctionClientDiagnostics.CreateScope("NetworkFunctionCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkFunctionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkFunctionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified network function resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/networkFunctions/{networkFunctionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionName"> The name of the network function resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionName"/> is null. </exception>
        public virtual Response<NetworkFunctionResource> Get(string networkFunctionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionName, nameof(networkFunctionName));

            using var scope = _networkFunctionClientDiagnostics.CreateScope("NetworkFunctionCollection.Get");
            scope.Start();
            try
            {
                var response = _networkFunctionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkFunctionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the network function resources in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/networkFunctions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctions_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkFunctionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkFunctionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFunctionRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFunctionRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new NetworkFunctionResource(Client, NetworkFunctionData.DeserializeNetworkFunctionData(e)), _networkFunctionClientDiagnostics, Pipeline, "NetworkFunctionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the network function resources in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/networkFunctions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctions_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkFunctionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkFunctionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFunctionRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFunctionRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new NetworkFunctionResource(Client, NetworkFunctionData.DeserializeNetworkFunctionData(e)), _networkFunctionClientDiagnostics, Pipeline, "NetworkFunctionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/networkFunctions/{networkFunctionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionName"> The name of the network function resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkFunctionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionName, nameof(networkFunctionName));

            using var scope = _networkFunctionClientDiagnostics.CreateScope("NetworkFunctionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkFunctionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkFunctionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/networkFunctions/{networkFunctionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionName"> The name of the network function resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkFunctionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionName, nameof(networkFunctionName));

            using var scope = _networkFunctionClientDiagnostics.CreateScope("NetworkFunctionCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkFunctionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkFunctionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/networkFunctions/{networkFunctionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionName"> The name of the network function resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkFunctionResource>> GetIfExistsAsync(string networkFunctionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionName, nameof(networkFunctionName));

            using var scope = _networkFunctionClientDiagnostics.CreateScope("NetworkFunctionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkFunctionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkFunctionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkFunctionResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkFunctionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/networkFunctions/{networkFunctionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionName"> The name of the network function resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionName"/> is null. </exception>
        public virtual NullableResponse<NetworkFunctionResource> GetIfExists(string networkFunctionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionName, nameof(networkFunctionName));

            using var scope = _networkFunctionClientDiagnostics.CreateScope("NetworkFunctionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkFunctionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkFunctionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkFunctionResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkFunctionResource> IEnumerable<NetworkFunctionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkFunctionResource> IAsyncEnumerable<NetworkFunctionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
