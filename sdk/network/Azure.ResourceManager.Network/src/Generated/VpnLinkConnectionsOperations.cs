// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> The VpnLinkConnections service client. </summary>
    public partial class VpnLinkConnectionsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal VpnLinkConnectionsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of VpnLinkConnectionsOperations for mocking. </summary>
        protected VpnLinkConnectionsOperations()
        {
        }
        /// <summary> Initializes a new instance of VpnLinkConnectionsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal VpnLinkConnectionsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new VpnLinkConnectionsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Retrieves all vpn site link connections for a particular virtual wan vpn gateway vpn connection. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<VpnSiteLinkConnection> ListByVpnConnectionAsync(string resourceGroupName, string gatewayName, string connectionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            async Task<Page<VpnSiteLinkConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnLinkConnectionsOperations.ListByVpnConnection");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByVpnConnectionAsync(resourceGroupName, gatewayName, connectionName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VpnSiteLinkConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnLinkConnectionsOperations.ListByVpnConnection");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByVpnConnectionNextPageAsync(nextLink, resourceGroupName, gatewayName, connectionName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves all vpn site link connections for a particular virtual wan vpn gateway vpn connection. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<VpnSiteLinkConnection> ListByVpnConnection(string resourceGroupName, string gatewayName, string connectionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            Page<VpnSiteLinkConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnLinkConnectionsOperations.ListByVpnConnection");
                scope.Start();
                try
                {
                    var response = RestClient.ListByVpnConnection(resourceGroupName, gatewayName, connectionName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VpnSiteLinkConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnLinkConnectionsOperations.ListByVpnConnection");
                scope.Start();
                try
                {
                    var response = RestClient.ListByVpnConnectionNextPage(nextLink, resourceGroupName, gatewayName, connectionName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
