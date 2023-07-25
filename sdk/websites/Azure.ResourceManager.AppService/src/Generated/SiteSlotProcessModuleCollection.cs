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
    /// A class representing a collection of <see cref="SiteSlotProcessModuleResource" /> and their operations.
    /// Each <see cref="SiteSlotProcessModuleResource" /> in the collection will belong to the same instance of <see cref="SiteSlotProcessResource" />.
    /// To get a <see cref="SiteSlotProcessModuleCollection" /> instance call the GetSiteSlotProcessModules method from an instance of <see cref="SiteSlotProcessResource" />.
    /// </summary>
    public partial class SiteSlotProcessModuleCollection : ArmCollection, IEnumerable<SiteSlotProcessModuleResource>, IAsyncEnumerable<SiteSlotProcessModuleResource>
    {
        private readonly ClientDiagnostics _siteSlotProcessModuleWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotProcessModuleWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotProcessModuleCollection"/> class for mocking. </summary>
        protected SiteSlotProcessModuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotProcessModuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotProcessModuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotProcessModuleWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotProcessModuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSlotProcessModuleResource.ResourceType, out string siteSlotProcessModuleWebAppsApiVersion);
            _siteSlotProcessModuleWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotProcessModuleWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlotProcessResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlotProcessResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/processes/{processId}/modules/{baseAddress}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetProcessModuleSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        public virtual async Task<Response<SiteSlotProcessModuleResource>> GetAsync(string baseAddress, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(baseAddress, nameof(baseAddress));

            using var scope = _siteSlotProcessModuleWebAppsClientDiagnostics.CreateScope("SiteSlotProcessModuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotProcessModuleWebAppsRestClient.GetProcessModuleSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, baseAddress, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotProcessModuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/processes/{processId}/modules/{baseAddress}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetProcessModuleSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        public virtual Response<SiteSlotProcessModuleResource> Get(string baseAddress, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(baseAddress, nameof(baseAddress));

            using var scope = _siteSlotProcessModuleWebAppsClientDiagnostics.CreateScope("SiteSlotProcessModuleCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotProcessModuleWebAppsRestClient.GetProcessModuleSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, baseAddress, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotProcessModuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/processes/{processId}/modules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListProcessModulesSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotProcessModuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotProcessModuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteSlotProcessModuleWebAppsRestClient.CreateListProcessModulesSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteSlotProcessModuleWebAppsRestClient.CreateListProcessModulesSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteSlotProcessModuleResource(Client, ProcessModuleInfoData.DeserializeProcessModuleInfoData(e)), _siteSlotProcessModuleWebAppsClientDiagnostics, Pipeline, "SiteSlotProcessModuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for List module information for a process by its ID for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/processes/{processId}/modules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListProcessModulesSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotProcessModuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotProcessModuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteSlotProcessModuleWebAppsRestClient.CreateListProcessModulesSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteSlotProcessModuleWebAppsRestClient.CreateListProcessModulesSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteSlotProcessModuleResource(Client, ProcessModuleInfoData.DeserializeProcessModuleInfoData(e)), _siteSlotProcessModuleWebAppsClientDiagnostics, Pipeline, "SiteSlotProcessModuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/processes/{processId}/modules/{baseAddress}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetProcessModuleSlot</description>
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

            using var scope = _siteSlotProcessModuleWebAppsClientDiagnostics.CreateScope("SiteSlotProcessModuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteSlotProcessModuleWebAppsRestClient.GetProcessModuleSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, baseAddress, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/processes/{processId}/modules/{baseAddress}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetProcessModuleSlot</description>
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

            using var scope = _siteSlotProcessModuleWebAppsClientDiagnostics.CreateScope("SiteSlotProcessModuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteSlotProcessModuleWebAppsRestClient.GetProcessModuleSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, baseAddress, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotProcessModuleResource> IEnumerable<SiteSlotProcessModuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotProcessModuleResource> IAsyncEnumerable<SiteSlotProcessModuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
