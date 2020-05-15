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
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The PrivateDnsZoneGroups service client. </summary>
    public partial class PrivateDnsZoneGroupsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PrivateDnsZoneGroupsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of PrivateDnsZoneGroupsClient for mocking. </summary>
        protected PrivateDnsZoneGroupsClient()
        {
        }
        /// <summary> Initializes a new instance of PrivateDnsZoneGroupsClient. </summary>
        internal PrivateDnsZoneGroupsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new PrivateDnsZoneGroupsRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the private dns zone group resource by specified private dns zone group name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="privateDnsZoneGroupName"> The name of the private dns zone group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateDnsZoneGroup>> GetAsync(string resourceGroupName, string privateEndpointName, string privateDnsZoneGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateDnsZoneGroupsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, privateEndpointName, privateDnsZoneGroupName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the private dns zone group resource by specified private dns zone group name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="privateDnsZoneGroupName"> The name of the private dns zone group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateDnsZoneGroup> Get(string resourceGroupName, string privateEndpointName, string privateDnsZoneGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateDnsZoneGroupsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, privateEndpointName, privateDnsZoneGroupName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all private dns zone groups in a private endpoint. </summary>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<PrivateDnsZoneGroup> ListAsync(string privateEndpointName, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (privateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointName));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<PrivateDnsZoneGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateDnsZoneGroupsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(privateEndpointName, resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PrivateDnsZoneGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateDnsZoneGroupsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, privateEndpointName, resourceGroupName, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets all private dns zone groups in a private endpoint. </summary>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<PrivateDnsZoneGroup> List(string privateEndpointName, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (privateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointName));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<PrivateDnsZoneGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateDnsZoneGroupsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(privateEndpointName, resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PrivateDnsZoneGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateDnsZoneGroupsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, privateEndpointName, resourceGroupName, cancellationToken);
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

        /// <summary> Deletes the specified private dns zone group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="privateDnsZoneGroupName"> The name of the private dns zone group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<PrivateDnsZoneGroupsDeleteOperation> StartDeleteAsync(string resourceGroupName, string privateEndpointName, string privateDnsZoneGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointName));
            }
            if (privateDnsZoneGroupName == null)
            {
                throw new ArgumentNullException(nameof(privateDnsZoneGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateDnsZoneGroupsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, privateEndpointName, privateDnsZoneGroupName, cancellationToken).ConfigureAwait(false);
                return new PrivateDnsZoneGroupsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, privateEndpointName, privateDnsZoneGroupName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified private dns zone group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="privateDnsZoneGroupName"> The name of the private dns zone group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PrivateDnsZoneGroupsDeleteOperation StartDelete(string resourceGroupName, string privateEndpointName, string privateDnsZoneGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointName));
            }
            if (privateDnsZoneGroupName == null)
            {
                throw new ArgumentNullException(nameof(privateDnsZoneGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateDnsZoneGroupsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, privateEndpointName, privateDnsZoneGroupName, cancellationToken);
                return new PrivateDnsZoneGroupsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, privateEndpointName, privateDnsZoneGroupName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a private dns zone group in the specified private endpoint. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="privateDnsZoneGroupName"> The name of the private dns zone group. </param>
        /// <param name="parameters"> Parameters supplied to the create or update private dns zone group operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<PrivateDnsZoneGroupsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string privateEndpointName, string privateDnsZoneGroupName, PrivateDnsZoneGroup parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointName));
            }
            if (privateDnsZoneGroupName == null)
            {
                throw new ArgumentNullException(nameof(privateDnsZoneGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateDnsZoneGroupsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, privateEndpointName, privateDnsZoneGroupName, parameters, cancellationToken).ConfigureAwait(false);
                return new PrivateDnsZoneGroupsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, privateEndpointName, privateDnsZoneGroupName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a private dns zone group in the specified private endpoint. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="privateDnsZoneGroupName"> The name of the private dns zone group. </param>
        /// <param name="parameters"> Parameters supplied to the create or update private dns zone group operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PrivateDnsZoneGroupsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string privateEndpointName, string privateDnsZoneGroupName, PrivateDnsZoneGroup parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (privateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointName));
            }
            if (privateDnsZoneGroupName == null)
            {
                throw new ArgumentNullException(nameof(privateDnsZoneGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateDnsZoneGroupsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, privateEndpointName, privateDnsZoneGroupName, parameters, cancellationToken);
                return new PrivateDnsZoneGroupsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, privateEndpointName, privateDnsZoneGroupName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
