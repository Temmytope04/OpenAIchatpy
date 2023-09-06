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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteProcessModuleResource" /> and their operations.
    /// Each <see cref="SiteProcessModuleResource" /> in the collection will belong to the same instance of <see cref="SiteProcessResource" />.
    /// To get a <see cref="SiteProcessModuleCollection" /> instance call the GetSiteProcessModules method from an instance of <see cref="SiteProcessResource" />.
    /// </summary>
    public partial class SiteProcessModuleCollection : ArmCollection, IEnumerable<SiteProcessModuleResource>, IAsyncEnumerable<SiteProcessModuleResource>
    {
        private readonly ClientDiagnostics _siteProcessModuleWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteProcessModuleWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteProcessModuleCollection"/> class for mocking. </summary>
        protected SiteProcessModuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteProcessModuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteProcessModuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteProcessModuleWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteProcessModuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteProcessModuleResource.ResourceType, out string siteProcessModuleWebAppsApiVersion);
            _siteProcessModuleWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteProcessModuleWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteProcessResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteProcessResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/modules/{baseAddress}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetProcessModule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        public virtual async Task<Response<SiteProcessModuleResource>> GetAsync(string baseAddress, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(baseAddress, nameof(baseAddress));

            using var scope = _siteProcessModuleWebAppsClientDiagnostics.CreateScope("SiteProcessModuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteProcessModuleWebAppsRestClient.GetProcessModuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, baseAddress, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteProcessModuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/modules/{baseAddress}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetProcessModule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        public virtual Response<SiteProcessModuleResource> Get(string baseAddress, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(baseAddress, nameof(baseAddress));

            using var scope = _siteProcessModuleWebAppsClientDiagnostics.CreateScope("SiteProcessModuleCollection.Get");
            scope.Start();
            try
            {
                var response = _siteProcessModuleWebAppsRestClient.GetProcessModule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, baseAddress, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteProcessModuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List module information for a process by its ID for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/modules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListProcessModules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteProcessModuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteProcessModuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteProcessModuleWebAppsRestClient.CreateListProcessModulesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteProcessModuleWebAppsRestClient.CreateListProcessModulesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SiteProcessModuleResource(Client, ProcessModuleInfoData.DeserializeProcessModuleInfoData(e)), _siteProcessModuleWebAppsClientDiagnostics, Pipeline, "SiteProcessModuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for List module information for a process by its ID for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/modules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListProcessModules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteProcessModuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteProcessModuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteProcessModuleWebAppsRestClient.CreateListProcessModulesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteProcessModuleWebAppsRestClient.CreateListProcessModulesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SiteProcessModuleResource(Client, ProcessModuleInfoData.DeserializeProcessModuleInfoData(e)), _siteProcessModuleWebAppsClientDiagnostics, Pipeline, "SiteProcessModuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/modules/{baseAddress}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetProcessModule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string baseAddress, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(baseAddress, nameof(baseAddress));

            using var scope = _siteProcessModuleWebAppsClientDiagnostics.CreateScope("SiteProcessModuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteProcessModuleWebAppsRestClient.GetProcessModuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, baseAddress, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/modules/{baseAddress}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetProcessModule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        public virtual Response<bool> Exists(string baseAddress, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(baseAddress, nameof(baseAddress));

            using var scope = _siteProcessModuleWebAppsClientDiagnostics.CreateScope("SiteProcessModuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteProcessModuleWebAppsRestClient.GetProcessModule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, baseAddress, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteProcessModuleResource> IEnumerable<SiteProcessModuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteProcessModuleResource> IAsyncEnumerable<SiteProcessModuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
