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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="WebSiteTriggeredwebJobResource" /> and their operations.
    /// Each <see cref="WebSiteTriggeredwebJobResource" /> in the collection will belong to the same instance of <see cref="WebSiteResource" />.
    /// To get a <see cref="WebSiteTriggeredwebJobCollection" /> instance call the GetWebSiteTriggeredwebJobs method from an instance of <see cref="WebSiteResource" />.
    /// </summary>
    public partial class WebSiteTriggeredwebJobCollection : ArmCollection, IEnumerable<WebSiteTriggeredwebJobResource>, IAsyncEnumerable<WebSiteTriggeredwebJobResource>
    {
        private readonly ClientDiagnostics _webSiteTriggeredwebJobWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteTriggeredwebJobWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteTriggeredwebJobCollection"/> class for mocking. </summary>
        protected WebSiteTriggeredwebJobCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteTriggeredwebJobCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebSiteTriggeredwebJobCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteTriggeredwebJobWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", WebSiteTriggeredwebJobResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebSiteTriggeredwebJobResource.ResourceType, out string webSiteTriggeredwebJobWebAppsApiVersion);
            _webSiteTriggeredwebJobWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteTriggeredwebJobWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets a triggered web job by its ID for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJob</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual async Task<Response<WebSiteTriggeredwebJobResource>> GetAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteTriggeredwebJobWebAppsClientDiagnostics.CreateScope("WebSiteTriggeredwebJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _webSiteTriggeredwebJobWebAppsRestClient.GetTriggeredWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webJobName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteTriggeredwebJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a triggered web job by its ID for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJob</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<WebSiteTriggeredwebJobResource> Get(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteTriggeredwebJobWebAppsClientDiagnostics.CreateScope("WebSiteTriggeredwebJobCollection.Get");
            scope.Start();
            try
            {
                var response = _webSiteTriggeredwebJobWebAppsRestClient.GetTriggeredWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webJobName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteTriggeredwebJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List triggered web jobs for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListTriggeredWebJobs</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebSiteTriggeredwebJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebSiteTriggeredwebJobResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteTriggeredwebJobWebAppsRestClient.CreateListTriggeredWebJobsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteTriggeredwebJobWebAppsRestClient.CreateListTriggeredWebJobsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new WebSiteTriggeredwebJobResource(Client, TriggeredWebJobData.DeserializeTriggeredWebJobData(e)), _webSiteTriggeredwebJobWebAppsClientDiagnostics, Pipeline, "WebSiteTriggeredwebJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for List triggered web jobs for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListTriggeredWebJobs</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebSiteTriggeredwebJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebSiteTriggeredwebJobResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteTriggeredwebJobWebAppsRestClient.CreateListTriggeredWebJobsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteTriggeredwebJobWebAppsRestClient.CreateListTriggeredWebJobsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new WebSiteTriggeredwebJobResource(Client, TriggeredWebJobData.DeserializeTriggeredWebJobData(e)), _webSiteTriggeredwebJobWebAppsClientDiagnostics, Pipeline, "WebSiteTriggeredwebJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJob</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteTriggeredwebJobWebAppsClientDiagnostics.CreateScope("WebSiteTriggeredwebJobCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webSiteTriggeredwebJobWebAppsRestClient.GetTriggeredWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webJobName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJob</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<bool> Exists(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteTriggeredwebJobWebAppsClientDiagnostics.CreateScope("WebSiteTriggeredwebJobCollection.Exists");
            scope.Start();
            try
            {
                var response = _webSiteTriggeredwebJobWebAppsRestClient.GetTriggeredWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webJobName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebSiteTriggeredwebJobResource> IEnumerable<WebSiteTriggeredwebJobResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebSiteTriggeredwebJobResource> IAsyncEnumerable<WebSiteTriggeredwebJobResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
