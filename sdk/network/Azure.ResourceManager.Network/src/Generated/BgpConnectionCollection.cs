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
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="BgpConnectionResource"/> and their operations.
    /// Each <see cref="BgpConnectionResource"/> in the collection will belong to the same instance of <see cref="VirtualHubResource"/>.
    /// To get a <see cref="BgpConnectionCollection"/> instance call the GetBgpConnections method from an instance of <see cref="VirtualHubResource"/>.
    /// </summary>
    public partial class BgpConnectionCollection : ArmCollection, IEnumerable<BgpConnectionResource>, IAsyncEnumerable<BgpConnectionResource>
    {
        private readonly ClientDiagnostics _bgpConnectionVirtualHubBgpConnectionClientDiagnostics;
        private readonly VirtualHubBgpConnectionRestOperations _bgpConnectionVirtualHubBgpConnectionRestClient;
        private readonly ClientDiagnostics _bgpConnectionVirtualHubBgpConnectionsClientDiagnostics;
        private readonly VirtualHubBgpConnectionsRestOperations _bgpConnectionVirtualHubBgpConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BgpConnectionCollection"/> class for mocking. </summary>
        protected BgpConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BgpConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BgpConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _bgpConnectionVirtualHubBgpConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", BgpConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BgpConnectionResource.ResourceType, out string bgpConnectionVirtualHubBgpConnectionApiVersion);
            _bgpConnectionVirtualHubBgpConnectionRestClient = new VirtualHubBgpConnectionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, bgpConnectionVirtualHubBgpConnectionApiVersion);
            _bgpConnectionVirtualHubBgpConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", BgpConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BgpConnectionResource.ResourceType, out string bgpConnectionVirtualHubBgpConnectionsApiVersion);
            _bgpConnectionVirtualHubBgpConnectionsRestClient = new VirtualHubBgpConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, bgpConnectionVirtualHubBgpConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualHubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualHubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a VirtualHubBgpConnection resource if it doesn't exist else updates the existing VirtualHubBgpConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubBgpConnection_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BgpConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="data"> Parameters of Bgp connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BgpConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string connectionName, BgpConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _bgpConnectionVirtualHubBgpConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<BgpConnectionResource>(new BgpConnectionOperationSource(Client), _bgpConnectionVirtualHubBgpConnectionClientDiagnostics, Pipeline, _bgpConnectionVirtualHubBgpConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a VirtualHubBgpConnection resource if it doesn't exist else updates the existing VirtualHubBgpConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubBgpConnection_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BgpConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="data"> Parameters of Bgp connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BgpConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string connectionName, BgpConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _bgpConnectionVirtualHubBgpConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, data, cancellationToken);
                var operation = new NetworkArmOperation<BgpConnectionResource>(new BgpConnectionOperationSource(Client), _bgpConnectionVirtualHubBgpConnectionClientDiagnostics, Pipeline, _bgpConnectionVirtualHubBgpConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the details of a Virtual Hub Bgp Connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubBgpConnection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BgpConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<BgpConnectionResource>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _bgpConnectionVirtualHubBgpConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BgpConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a Virtual Hub Bgp Connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubBgpConnection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BgpConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<BgpConnectionResource> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _bgpConnectionVirtualHubBgpConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BgpConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of all VirtualHubBgpConnections.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubBgpConnections_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BgpConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BgpConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BgpConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _bgpConnectionVirtualHubBgpConnectionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _bgpConnectionVirtualHubBgpConnectionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BgpConnectionResource(Client, BgpConnectionData.DeserializeBgpConnectionData(e)), _bgpConnectionVirtualHubBgpConnectionsClientDiagnostics, Pipeline, "BgpConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of all VirtualHubBgpConnections.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubBgpConnections_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BgpConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BgpConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BgpConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _bgpConnectionVirtualHubBgpConnectionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _bgpConnectionVirtualHubBgpConnectionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BgpConnectionResource(Client, BgpConnectionData.DeserializeBgpConnectionData(e)), _bgpConnectionVirtualHubBgpConnectionsClientDiagnostics, Pipeline, "BgpConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubBgpConnection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BgpConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _bgpConnectionVirtualHubBgpConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubBgpConnection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BgpConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _bgpConnectionVirtualHubBgpConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubBgpConnection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BgpConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<NullableResponse<BgpConnectionResource>> GetIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _bgpConnectionVirtualHubBgpConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BgpConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new BgpConnectionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualHubBgpConnection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BgpConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual NullableResponse<BgpConnectionResource> GetIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _bgpConnectionVirtualHubBgpConnectionClientDiagnostics.CreateScope("BgpConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _bgpConnectionVirtualHubBgpConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BgpConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new BgpConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BgpConnectionResource> IEnumerable<BgpConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BgpConnectionResource> IAsyncEnumerable<BgpConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
