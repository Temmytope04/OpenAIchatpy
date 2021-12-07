// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of ContinuousWebJob and their operations over its parent. </summary>
    public partial class SiteContinuousWebJobCollection : ArmCollection, IEnumerable<SiteContinuousWebJob>, IAsyncEnumerable<SiteContinuousWebJob>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteContinuousWebJobCollection"/> class for mocking. </summary>
        protected SiteContinuousWebJobCollection()
        {
        }

        /// <summary> Initializes a new instance of SiteContinuousWebJobCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteContinuousWebJobCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => WebSite.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetContinuousWebJob
        /// <summary> Description for Gets a continuous web job by its ID for an app, or a deployment slot. </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<SiteContinuousWebJob> Get(string webJobName, CancellationToken cancellationToken = default)
        {
            if (webJobName == null)
            {
                throw new ArgumentNullException(nameof(webJobName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteContinuousWebJobCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetContinuousWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webJobName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteContinuousWebJob(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetContinuousWebJob
        /// <summary> Description for Gets a continuous web job by its ID for an app, or a deployment slot. </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public async virtual Task<Response<SiteContinuousWebJob>> GetAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            if (webJobName == null)
            {
                throw new ArgumentNullException(nameof(webJobName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteContinuousWebJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetContinuousWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webJobName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteContinuousWebJob(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<SiteContinuousWebJob> GetIfExists(string webJobName, CancellationToken cancellationToken = default)
        {
            if (webJobName == null)
            {
                throw new ArgumentNullException(nameof(webJobName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteContinuousWebJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetContinuousWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webJobName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SiteContinuousWebJob>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteContinuousWebJob(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public async virtual Task<Response<SiteContinuousWebJob>> GetIfExistsAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            if (webJobName == null)
            {
                throw new ArgumentNullException(nameof(webJobName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteContinuousWebJobCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetContinuousWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webJobName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SiteContinuousWebJob>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteContinuousWebJob(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string webJobName, CancellationToken cancellationToken = default)
        {
            if (webJobName == null)
            {
                throw new ArgumentNullException(nameof(webJobName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteContinuousWebJobCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(webJobName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            if (webJobName == null)
            {
                throw new ArgumentNullException(nameof(webJobName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteContinuousWebJobCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(webJobName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListContinuousWebJobs
        /// <summary> Description for List continuous web jobs for an app, or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteContinuousWebJob" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteContinuousWebJob> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteContinuousWebJob> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteContinuousWebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListContinuousWebJobs(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteContinuousWebJob(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteContinuousWebJob> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteContinuousWebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListContinuousWebJobsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteContinuousWebJob(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListContinuousWebJobs
        /// <summary> Description for List continuous web jobs for an app, or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteContinuousWebJob" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteContinuousWebJob> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteContinuousWebJob>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteContinuousWebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListContinuousWebJobsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteContinuousWebJob(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteContinuousWebJob>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteContinuousWebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListContinuousWebJobsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteContinuousWebJob(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteContinuousWebJob> IEnumerable<SiteContinuousWebJob>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteContinuousWebJob> IAsyncEnumerable<SiteContinuousWebJob>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, SiteContinuousWebJob, ContinuousWebJobData> Construct() { }
    }
}
