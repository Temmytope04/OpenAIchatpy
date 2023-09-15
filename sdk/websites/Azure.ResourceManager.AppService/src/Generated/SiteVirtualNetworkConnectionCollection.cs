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
    /// A class representing a collection of <see cref="SiteVirtualNetworkConnectionResource" /> and their operations.
    /// Each <see cref="SiteVirtualNetworkConnectionResource" /> in the collection will belong to the same instance of <see cref="WebSiteResource" />.
    /// To get a <see cref="SiteVirtualNetworkConnectionCollection" /> instance call the GetSiteVirtualNetworkConnections method from an instance of <see cref="WebSiteResource" />.
    /// </summary>
    public partial class SiteVirtualNetworkConnectionCollection : ArmCollection, IEnumerable<SiteVirtualNetworkConnectionResource>, IAsyncEnumerable<SiteVirtualNetworkConnectionResource>
    {
        private readonly ClientDiagnostics _siteVirtualNetworkConnectionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteVirtualNetworkConnectionWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteVirtualNetworkConnectionCollection"/> class for mocking. </summary>
        protected SiteVirtualNetworkConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteVirtualNetworkConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteVirtualNetworkConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteVirtualNetworkConnectionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteVirtualNetworkConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteVirtualNetworkConnectionResource.ResourceType, out string siteVirtualNetworkConnectionWebAppsApiVersion);
            _siteVirtualNetworkConnectionWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteVirtualNetworkConnectionWebAppsApiVersion);
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
        /// Description for Adds a Virtual Network connection to an app or slot (PUT) or updates the connection properties (PATCH).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateOrUpdateVnetConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vnetName"> Name of an existing Virtual Network. </param>
        /// <param name="data"> Properties of the Virtual Network connection. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteVirtualNetworkConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vnetName, AppServiceVirtualNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteVirtualNetworkConnectionWebAppsRestClient.CreateOrUpdateVnetConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteVirtualNetworkConnectionResource>(Response.FromValue(new SiteVirtualNetworkConnectionResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Adds a Virtual Network connection to an app or slot (PUT) or updates the connection properties (PATCH).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateOrUpdateVnetConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vnetName"> Name of an existing Virtual Network. </param>
        /// <param name="data"> Properties of the Virtual Network connection. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SiteVirtualNetworkConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string vnetName, AppServiceVirtualNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteVirtualNetworkConnectionWebAppsRestClient.CreateOrUpdateVnetConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, data, cancellationToken);
                var operation = new AppServiceArmOperation<SiteVirtualNetworkConnectionResource>(Response.FromValue(new SiteVirtualNetworkConnectionResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a virtual network the app (or deployment slot) is connected to by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetVnetConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual async Task<Response<SiteVirtualNetworkConnectionResource>> GetAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _siteVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteVirtualNetworkConnectionWebAppsRestClient.GetVnetConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteVirtualNetworkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a virtual network the app (or deployment slot) is connected to by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetVnetConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<SiteVirtualNetworkConnectionResource> Get(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _siteVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _siteVirtualNetworkConnectionWebAppsRestClient.GetVnetConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteVirtualNetworkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the virtual networks the app (or deployment slot) is connected to.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListVnetConnections</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteVirtualNetworkConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteVirtualNetworkConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteVirtualNetworkConnectionWebAppsRestClient.CreateListVnetConnectionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new SiteVirtualNetworkConnectionResource(Client, AppServiceVirtualNetworkData.DeserializeAppServiceVirtualNetworkData(e)), _siteVirtualNetworkConnectionWebAppsClientDiagnostics, Pipeline, "SiteVirtualNetworkConnectionCollection.GetAll", "", null, cancellationToken);
        }

        /// <summary>
        /// Description for Gets the virtual networks the app (or deployment slot) is connected to.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListVnetConnections</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteVirtualNetworkConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteVirtualNetworkConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteVirtualNetworkConnectionWebAppsRestClient.CreateListVnetConnectionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new SiteVirtualNetworkConnectionResource(Client, AppServiceVirtualNetworkData.DeserializeAppServiceVirtualNetworkData(e)), _siteVirtualNetworkConnectionWebAppsClientDiagnostics, Pipeline, "SiteVirtualNetworkConnectionCollection.GetAll", "", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetVnetConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _siteVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteVirtualNetworkConnectionWebAppsRestClient.GetVnetConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetVnetConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<bool> Exists(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _siteVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteVirtualNetworkConnectionWebAppsRestClient.GetVnetConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteVirtualNetworkConnectionResource> IEnumerable<SiteVirtualNetworkConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteVirtualNetworkConnectionResource> IAsyncEnumerable<SiteVirtualNetworkConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
