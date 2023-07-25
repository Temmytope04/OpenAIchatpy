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
    /// A class representing a collection of <see cref="SiteProcessResource" /> and their operations.
    /// Each <see cref="SiteProcessResource" /> in the collection will belong to the same instance of <see cref="WebSiteResource" />.
    /// To get a <see cref="SiteProcessCollection" /> instance call the GetSiteProcesses method from an instance of <see cref="WebSiteResource" />.
    /// </summary>
    public partial class SiteProcessCollection : ArmCollection, IEnumerable<SiteProcessResource>, IAsyncEnumerable<SiteProcessResource>
    {
        private readonly ClientDiagnostics _siteProcessWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteProcessWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteProcessCollection"/> class for mocking. </summary>
        protected SiteProcessCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteProcessCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteProcessCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteProcessWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteProcessResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteProcessResource.ResourceType, out string siteProcessWebAppsApiVersion);
            _siteProcessWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteProcessWebAppsApiVersion);
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
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetProcess</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual async Task<Response<SiteProcessResource>> GetAsync(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteProcessWebAppsRestClient.GetProcessAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, processId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteProcessResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetProcess</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual Response<SiteProcessResource> Get(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessCollection.Get");
            scope.Start();
            try
            {
                var response = _siteProcessWebAppsRestClient.GetProcess(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, processId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteProcessResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get list of processes for a web site, or a deployment slot, or for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListProcesses</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteProcessResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteProcessResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteProcessWebAppsRestClient.CreateListProcessesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteProcessWebAppsRestClient.CreateListProcessesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteProcessResource(Client, ProcessInfoData.DeserializeProcessInfoData(e)), _siteProcessWebAppsClientDiagnostics, Pipeline, "SiteProcessCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get list of processes for a web site, or a deployment slot, or for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListProcesses</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteProcessResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteProcessResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteProcessWebAppsRestClient.CreateListProcessesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteProcessWebAppsRestClient.CreateListProcessesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteProcessResource(Client, ProcessInfoData.DeserializeProcessInfoData(e)), _siteProcessWebAppsClientDiagnostics, Pipeline, "SiteProcessCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetProcess</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteProcessWebAppsRestClient.GetProcessAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, processId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetProcess</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual Response<bool> Exists(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteProcessWebAppsRestClient.GetProcess(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, processId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteProcessResource> IEnumerable<SiteProcessResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteProcessResource> IAsyncEnumerable<SiteProcessResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
