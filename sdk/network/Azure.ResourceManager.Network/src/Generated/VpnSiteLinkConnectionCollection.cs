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
    /// A class representing a collection of <see cref="VpnSiteLinkConnectionResource"/> and their operations.
    /// Each <see cref="VpnSiteLinkConnectionResource"/> in the collection will belong to the same instance of <see cref="VpnConnectionResource"/>.
    /// To get a <see cref="VpnSiteLinkConnectionCollection"/> instance call the GetVpnSiteLinkConnections method from an instance of <see cref="VpnConnectionResource"/>.
    /// </summary>
    public partial class VpnSiteLinkConnectionCollection : ArmCollection, IEnumerable<VpnSiteLinkConnectionResource>, IAsyncEnumerable<VpnSiteLinkConnectionResource>
    {
        private readonly ClientDiagnostics _vpnSiteLinkConnectionClientDiagnostics;
        private readonly VpnSiteLinkConnectionsRestOperations _vpnSiteLinkConnectionRestClient;
        private readonly ClientDiagnostics _vpnSiteLinkConnectionVpnLinkConnectionsClientDiagnostics;
        private readonly VpnLinkConnectionsRestOperations _vpnSiteLinkConnectionVpnLinkConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VpnSiteLinkConnectionCollection"/> class for mocking. </summary>
        protected VpnSiteLinkConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VpnSiteLinkConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VpnSiteLinkConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vpnSiteLinkConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VpnSiteLinkConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VpnSiteLinkConnectionResource.ResourceType, out string vpnSiteLinkConnectionApiVersion);
            _vpnSiteLinkConnectionRestClient = new VpnSiteLinkConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vpnSiteLinkConnectionApiVersion);
            _vpnSiteLinkConnectionVpnLinkConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VpnSiteLinkConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VpnSiteLinkConnectionResource.ResourceType, out string vpnSiteLinkConnectionVpnLinkConnectionsApiVersion);
            _vpnSiteLinkConnectionVpnLinkConnectionsRestClient = new VpnLinkConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vpnSiteLinkConnectionVpnLinkConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VpnConnectionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VpnConnectionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieves the details of a vpn site link connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}/vpnLinkConnections/{linkConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnSiteLinkConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnSiteLinkConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkConnectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkConnectionName"/> is null. </exception>
        public virtual async Task<Response<VpnSiteLinkConnectionResource>> GetAsync(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkConnectionName, nameof(linkConnectionName));

            using var scope = _vpnSiteLinkConnectionClientDiagnostics.CreateScope("VpnSiteLinkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _vpnSiteLinkConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnSiteLinkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a vpn site link connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}/vpnLinkConnections/{linkConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnSiteLinkConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnSiteLinkConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkConnectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkConnectionName"/> is null. </exception>
        public virtual Response<VpnSiteLinkConnectionResource> Get(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkConnectionName, nameof(linkConnectionName));

            using var scope = _vpnSiteLinkConnectionClientDiagnostics.CreateScope("VpnSiteLinkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _vpnSiteLinkConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnSiteLinkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves all vpn site link connections for a particular virtual wan vpn gateway vpn connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}/vpnLinkConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnLinkConnections_ListByVpnConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnSiteLinkConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VpnSiteLinkConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VpnSiteLinkConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _vpnSiteLinkConnectionVpnLinkConnectionsRestClient.CreateListByVpnConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _vpnSiteLinkConnectionVpnLinkConnectionsRestClient.CreateListByVpnConnectionNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VpnSiteLinkConnectionResource(Client, VpnSiteLinkConnectionData.DeserializeVpnSiteLinkConnectionData(e)), _vpnSiteLinkConnectionVpnLinkConnectionsClientDiagnostics, Pipeline, "VpnSiteLinkConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieves all vpn site link connections for a particular virtual wan vpn gateway vpn connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}/vpnLinkConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnLinkConnections_ListByVpnConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnSiteLinkConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VpnSiteLinkConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VpnSiteLinkConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _vpnSiteLinkConnectionVpnLinkConnectionsRestClient.CreateListByVpnConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _vpnSiteLinkConnectionVpnLinkConnectionsRestClient.CreateListByVpnConnectionNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VpnSiteLinkConnectionResource(Client, VpnSiteLinkConnectionData.DeserializeVpnSiteLinkConnectionData(e)), _vpnSiteLinkConnectionVpnLinkConnectionsClientDiagnostics, Pipeline, "VpnSiteLinkConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}/vpnLinkConnections/{linkConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnSiteLinkConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnSiteLinkConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkConnectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkConnectionName, nameof(linkConnectionName));

            using var scope = _vpnSiteLinkConnectionClientDiagnostics.CreateScope("VpnSiteLinkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _vpnSiteLinkConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}/vpnLinkConnections/{linkConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnSiteLinkConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnSiteLinkConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkConnectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkConnectionName, nameof(linkConnectionName));

            using var scope = _vpnSiteLinkConnectionClientDiagnostics.CreateScope("VpnSiteLinkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _vpnSiteLinkConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkConnectionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}/vpnLinkConnections/{linkConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnSiteLinkConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnSiteLinkConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkConnectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkConnectionName"/> is null. </exception>
        public virtual async Task<NullableResponse<VpnSiteLinkConnectionResource>> GetIfExistsAsync(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkConnectionName, nameof(linkConnectionName));

            using var scope = _vpnSiteLinkConnectionClientDiagnostics.CreateScope("VpnSiteLinkConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _vpnSiteLinkConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VpnSiteLinkConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new VpnSiteLinkConnectionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/vpnConnections/{connectionName}/vpnLinkConnections/{linkConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VpnSiteLinkConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VpnSiteLinkConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkConnectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkConnectionName"/> is null. </exception>
        public virtual NullableResponse<VpnSiteLinkConnectionResource> GetIfExists(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkConnectionName, nameof(linkConnectionName));

            using var scope = _vpnSiteLinkConnectionClientDiagnostics.CreateScope("VpnSiteLinkConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _vpnSiteLinkConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkConnectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VpnSiteLinkConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new VpnSiteLinkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VpnSiteLinkConnectionResource> IEnumerable<VpnSiteLinkConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VpnSiteLinkConnectionResource> IAsyncEnumerable<VpnSiteLinkConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
