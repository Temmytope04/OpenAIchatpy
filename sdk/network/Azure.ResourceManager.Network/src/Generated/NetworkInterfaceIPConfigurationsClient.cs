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
    /// <summary> The NetworkInterfaceIPConfigurations service client. </summary>
    public partial class NetworkInterfaceIPConfigurationsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal NetworkInterfaceIPConfigurationsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of NetworkInterfaceIPConfigurationsClient for mocking. </summary>
        protected NetworkInterfaceIPConfigurationsClient()
        {
        }
        /// <summary> Initializes a new instance of NetworkInterfaceIPConfigurationsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal NetworkInterfaceIPConfigurationsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new NetworkInterfaceIPConfigurationsRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the specified network interface ip configuration. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="ipConfigurationName"> The name of the ip configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkInterfaceIPConfiguration>> GetAsync(string resourceGroupName, string networkInterfaceName, string ipConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, networkInterfaceName, ipConfigurationName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified network interface ip configuration. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="ipConfigurationName"> The name of the ip configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkInterfaceIPConfiguration> Get(string resourceGroupName, string networkInterfaceName, string ipConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, networkInterfaceName, ipConfigurationName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all ip configurations in a network interface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<NetworkInterfaceIPConfiguration> ListAsync(string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }

            async Task<Page<NetworkInterfaceIPConfiguration>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, networkInterfaceName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NetworkInterfaceIPConfiguration>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, networkInterfaceName, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Get all ip configurations in a network interface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<NetworkInterfaceIPConfiguration> List(string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }

            Page<NetworkInterfaceIPConfiguration> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, networkInterfaceName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NetworkInterfaceIPConfiguration> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, networkInterfaceName, cancellationToken);
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
