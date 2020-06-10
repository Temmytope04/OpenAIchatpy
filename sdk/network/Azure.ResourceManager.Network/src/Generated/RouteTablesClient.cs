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
    /// <summary> The RouteTables service client. </summary>
    public partial class RouteTablesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal RouteTablesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of RouteTablesClient for mocking. </summary>
        protected RouteTablesClient()
        {
        }
        /// <summary> Initializes a new instance of RouteTablesClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal RouteTablesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new RouteTablesRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the specified route table. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RouteTable>> GetAsync(string resourceGroupName, string routeTableName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteTablesClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, routeTableName, expand, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified route table. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RouteTable> Get(string resourceGroupName, string routeTableName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteTablesClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, routeTableName, expand, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a route table tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="parameters"> Parameters supplied to update route table tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RouteTable>> UpdateTagsAsync(string resourceGroupName, string routeTableName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteTablesClient.UpdateTags");
            scope.Start();
            try
            {
                return await RestClient.UpdateTagsAsync(resourceGroupName, routeTableName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a route table tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="parameters"> Parameters supplied to update route table tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RouteTable> UpdateTags(string resourceGroupName, string routeTableName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteTablesClient.UpdateTags");
            scope.Start();
            try
            {
                return RestClient.UpdateTags(resourceGroupName, routeTableName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all route tables in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<RouteTable> ListAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<RouteTable>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteTablesClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RouteTable>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteTablesClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets all route tables in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<RouteTable> List(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<RouteTable> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteTablesClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RouteTable> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteTablesClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, cancellationToken);
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

        /// <summary> Gets all route tables in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<RouteTable> ListAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RouteTable>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteTablesClient.ListAll");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAllAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RouteTable>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteTablesClient.ListAll");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAllNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets all route tables in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<RouteTable> ListAll(CancellationToken cancellationToken = default)
        {
            Page<RouteTable> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteTablesClient.ListAll");
                scope.Start();
                try
                {
                    var response = RestClient.ListAll(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RouteTable> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteTablesClient.ListAll");
                scope.Start();
                try
                {
                    var response = RestClient.ListAllNextPage(nextLink, cancellationToken);
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

        /// <summary> Deletes the specified route table. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<RouteTablesDeleteOperation> StartDeleteAsync(string resourceGroupName, string routeTableName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteTablesClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, routeTableName, cancellationToken).ConfigureAwait(false);
                return new RouteTablesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, routeTableName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified route table. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual RouteTablesDeleteOperation StartDelete(string resourceGroupName, string routeTableName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteTablesClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, routeTableName, cancellationToken);
                return new RouteTablesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, routeTableName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or updates a route table in a specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="parameters"> Parameters supplied to the create or update route table operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<RouteTablesCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string routeTableName, RouteTable parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteTablesClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, routeTableName, parameters, cancellationToken).ConfigureAwait(false);
                return new RouteTablesCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, routeTableName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or updates a route table in a specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="parameters"> Parameters supplied to the create or update route table operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual RouteTablesCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string routeTableName, RouteTable parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteTablesClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, routeTableName, parameters, cancellationToken);
                return new RouteTablesCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, routeTableName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
