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

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkFabricExternalNetworkResource" /> and their operations.
    /// Each <see cref="NetworkFabricExternalNetworkResource" /> in the collection will belong to the same instance of <see cref="NetworkFabricL3IsolationDomainResource" />.
    /// To get a <see cref="NetworkFabricExternalNetworkCollection" /> instance call the GetNetworkFabricExternalNetworks method from an instance of <see cref="NetworkFabricL3IsolationDomainResource" />.
    /// </summary>
    public partial class NetworkFabricExternalNetworkCollection : ArmCollection, IEnumerable<NetworkFabricExternalNetworkResource>, IAsyncEnumerable<NetworkFabricExternalNetworkResource>
    {
        private readonly ClientDiagnostics _networkFabricExternalNetworkExternalNetworksClientDiagnostics;
        private readonly ExternalNetworksRestOperations _networkFabricExternalNetworkExternalNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricExternalNetworkCollection"/> class for mocking. </summary>
        protected NetworkFabricExternalNetworkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricExternalNetworkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkFabricExternalNetworkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkFabricExternalNetworkExternalNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkFabricExternalNetworkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkFabricExternalNetworkResource.ResourceType, out string networkFabricExternalNetworkExternalNetworksApiVersion);
            _networkFabricExternalNetworkExternalNetworksRestClient = new ExternalNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkFabricExternalNetworkExternalNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkFabricL3IsolationDomainResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkFabricL3IsolationDomainResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates ExternalNetwork PUT method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}/externalNetworks/{externalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExternalNetworks_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="externalNetworkName"> Name of the External Network. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="externalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="externalNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkFabricExternalNetworkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string externalNetworkName, NetworkFabricExternalNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(externalNetworkName, nameof(externalNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFabricExternalNetworkExternalNetworksClientDiagnostics.CreateScope("NetworkFabricExternalNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkFabricExternalNetworkExternalNetworksRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, externalNetworkName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkFabricArmOperation<NetworkFabricExternalNetworkResource>(new NetworkFabricExternalNetworkOperationSource(Client), _networkFabricExternalNetworkExternalNetworksClientDiagnostics, Pipeline, _networkFabricExternalNetworkExternalNetworksRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, externalNetworkName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates ExternalNetwork PUT method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}/externalNetworks/{externalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExternalNetworks_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="externalNetworkName"> Name of the External Network. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="externalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="externalNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkFabricExternalNetworkResource> CreateOrUpdate(WaitUntil waitUntil, string externalNetworkName, NetworkFabricExternalNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(externalNetworkName, nameof(externalNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFabricExternalNetworkExternalNetworksClientDiagnostics.CreateScope("NetworkFabricExternalNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkFabricExternalNetworkExternalNetworksRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, externalNetworkName, data, cancellationToken);
                var operation = new ManagedNetworkFabricArmOperation<NetworkFabricExternalNetworkResource>(new NetworkFabricExternalNetworkOperationSource(Client), _networkFabricExternalNetworkExternalNetworksClientDiagnostics, Pipeline, _networkFabricExternalNetworkExternalNetworksRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, externalNetworkName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements ExternalNetworks GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}/externalNetworks/{externalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExternalNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="externalNetworkName"> Name of the External Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="externalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="externalNetworkName"/> is null. </exception>
        public virtual async Task<Response<NetworkFabricExternalNetworkResource>> GetAsync(string externalNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(externalNetworkName, nameof(externalNetworkName));

            using var scope = _networkFabricExternalNetworkExternalNetworksClientDiagnostics.CreateScope("NetworkFabricExternalNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkFabricExternalNetworkExternalNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, externalNetworkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricExternalNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements ExternalNetworks GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}/externalNetworks/{externalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExternalNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="externalNetworkName"> Name of the External Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="externalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="externalNetworkName"/> is null. </exception>
        public virtual Response<NetworkFabricExternalNetworkResource> Get(string externalNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(externalNetworkName, nameof(externalNetworkName));

            using var scope = _networkFabricExternalNetworkExternalNetworksClientDiagnostics.CreateScope("NetworkFabricExternalNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = _networkFabricExternalNetworkExternalNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, externalNetworkName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricExternalNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements External Networks list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}/externalNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExternalNetworks_ListByL3IsolationDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkFabricExternalNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkFabricExternalNetworkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricExternalNetworkExternalNetworksRestClient.CreateListByL3IsolationDomainRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricExternalNetworkExternalNetworksRestClient.CreateListByL3IsolationDomainNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new NetworkFabricExternalNetworkResource(Client, NetworkFabricExternalNetworkData.DeserializeNetworkFabricExternalNetworkData(e)), _networkFabricExternalNetworkExternalNetworksClientDiagnostics, Pipeline, "NetworkFabricExternalNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Implements External Networks list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}/externalNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExternalNetworks_ListByL3IsolationDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkFabricExternalNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkFabricExternalNetworkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricExternalNetworkExternalNetworksRestClient.CreateListByL3IsolationDomainRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricExternalNetworkExternalNetworksRestClient.CreateListByL3IsolationDomainNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new NetworkFabricExternalNetworkResource(Client, NetworkFabricExternalNetworkData.DeserializeNetworkFabricExternalNetworkData(e)), _networkFabricExternalNetworkExternalNetworksClientDiagnostics, Pipeline, "NetworkFabricExternalNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}/externalNetworks/{externalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExternalNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="externalNetworkName"> Name of the External Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="externalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="externalNetworkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string externalNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(externalNetworkName, nameof(externalNetworkName));

            using var scope = _networkFabricExternalNetworkExternalNetworksClientDiagnostics.CreateScope("NetworkFabricExternalNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkFabricExternalNetworkExternalNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, externalNetworkName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}/externalNetworks/{externalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExternalNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="externalNetworkName"> Name of the External Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="externalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="externalNetworkName"/> is null. </exception>
        public virtual Response<bool> Exists(string externalNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(externalNetworkName, nameof(externalNetworkName));

            using var scope = _networkFabricExternalNetworkExternalNetworksClientDiagnostics.CreateScope("NetworkFabricExternalNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkFabricExternalNetworkExternalNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, externalNetworkName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}/externalNetworks/{externalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExternalNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="externalNetworkName"> Name of the External Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="externalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="externalNetworkName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkFabricExternalNetworkResource>> GetIfExistsAsync(string externalNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(externalNetworkName, nameof(externalNetworkName));

            using var scope = _networkFabricExternalNetworkExternalNetworksClientDiagnostics.CreateScope("NetworkFabricExternalNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkFabricExternalNetworkExternalNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, externalNetworkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkFabricExternalNetworkResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricExternalNetworkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}/externalNetworks/{externalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExternalNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="externalNetworkName"> Name of the External Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="externalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="externalNetworkName"/> is null. </exception>
        public virtual NullableResponse<NetworkFabricExternalNetworkResource> GetIfExists(string externalNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(externalNetworkName, nameof(externalNetworkName));

            using var scope = _networkFabricExternalNetworkExternalNetworksClientDiagnostics.CreateScope("NetworkFabricExternalNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkFabricExternalNetworkExternalNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, externalNetworkName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkFabricExternalNetworkResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricExternalNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkFabricExternalNetworkResource> IEnumerable<NetworkFabricExternalNetworkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkFabricExternalNetworkResource> IAsyncEnumerable<NetworkFabricExternalNetworkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
