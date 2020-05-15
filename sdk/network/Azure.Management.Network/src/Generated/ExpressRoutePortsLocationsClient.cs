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
    /// <summary> The ExpressRoutePortsLocations service client. </summary>
    public partial class ExpressRoutePortsLocationsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ExpressRoutePortsLocationsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ExpressRoutePortsLocationsClient for mocking. </summary>
        protected ExpressRoutePortsLocationsClient()
        {
        }
        /// <summary> Initializes a new instance of ExpressRoutePortsLocationsClient. </summary>
        internal ExpressRoutePortsLocationsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ExpressRoutePortsLocationsRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Retrieves a single ExpressRoutePort peering location, including the list of available bandwidths available at said peering location. </summary>
        /// <param name="locationName"> Name of the requested ExpressRoutePort peering location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRoutePortsLocation>> GetAsync(string locationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRoutePortsLocationsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(locationName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves a single ExpressRoutePort peering location, including the list of available bandwidths available at said peering location. </summary>
        /// <param name="locationName"> Name of the requested ExpressRoutePort peering location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRoutePortsLocation> Get(string locationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRoutePortsLocationsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(locationName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves all ExpressRoutePort peering locations. Does not return available bandwidths for each location. Available bandwidths can only be obtained when retrieving a specific peering location. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ExpressRoutePortsLocation> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExpressRoutePortsLocation>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRoutePortsLocationsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExpressRoutePortsLocation>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRoutePortsLocationsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Retrieves all ExpressRoutePort peering locations. Does not return available bandwidths for each location. Available bandwidths can only be obtained when retrieving a specific peering location. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ExpressRoutePortsLocation> List(CancellationToken cancellationToken = default)
        {
            Page<ExpressRoutePortsLocation> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRoutePortsLocationsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExpressRoutePortsLocation> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRoutePortsLocationsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, cancellationToken);
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
