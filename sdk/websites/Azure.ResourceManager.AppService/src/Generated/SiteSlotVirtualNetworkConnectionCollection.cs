// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteSlotVirtualNetworkConnectionResource" /> and their operations.
    /// Each <see cref="SiteSlotVirtualNetworkConnectionResource" /> in the collection will belong to the same instance of <see cref="SiteSlotResource" />.
    /// To get a <see cref="SiteSlotVirtualNetworkConnectionCollection" /> instance call the GetSiteSlotVirtualNetworkConnections method from an instance of <see cref="SiteSlotResource" />.
    /// </summary>
    public partial class SiteSlotVirtualNetworkConnectionCollection : ArmCollection, IEnumerable<SiteSlotVirtualNetworkConnectionResource>, IAsyncEnumerable<SiteSlotVirtualNetworkConnectionResource>
    {
        private readonly ClientDiagnostics _siteSlotVirtualNetworkConnectionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotVirtualNetworkConnectionWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotVirtualNetworkConnectionCollection"/> class for mocking. </summary>
        protected SiteSlotVirtualNetworkConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotVirtualNetworkConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotVirtualNetworkConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotVirtualNetworkConnectionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotVirtualNetworkConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSlotVirtualNetworkConnectionResource.ResourceType, out string siteSlotVirtualNetworkConnectionWebAppsApiVersion);
            _siteSlotVirtualNetworkConnectionWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotVirtualNetworkConnectionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Adds a Virtual Network connection to an app or slot (PUT) or updates the connection properties (PATCH).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections/{vnetName}
        /// Operation Id: WebApps_CreateOrUpdateVnetConnectionSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vnetName"> Name of an existing Virtual Network. </param>
        /// <param name="data"> Properties of the Virtual Network connection. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteSlotVirtualNetworkConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vnetName, VnetInfoResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotVirtualNetworkConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSlotVirtualNetworkConnectionWebAppsRestClient.CreateOrUpdateVnetConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vnetName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteSlotVirtualNetworkConnectionResource>(Response.FromValue(new SiteSlotVirtualNetworkConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections/{vnetName}
        /// Operation Id: WebApps_CreateOrUpdateVnetConnectionSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vnetName"> Name of an existing Virtual Network. </param>
        /// <param name="data"> Properties of the Virtual Network connection. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SiteSlotVirtualNetworkConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string vnetName, VnetInfoResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotVirtualNetworkConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSlotVirtualNetworkConnectionWebAppsRestClient.CreateOrUpdateVnetConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vnetName, data, cancellationToken);
                var operation = new AppServiceArmOperation<SiteSlotVirtualNetworkConnectionResource>(Response.FromValue(new SiteSlotVirtualNetworkConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections/{vnetName}
        /// Operation Id: WebApps_GetVnetConnectionSlot
        /// </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual async Task<Response<SiteSlotVirtualNetworkConnectionResource>> GetAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _siteSlotVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotVirtualNetworkConnectionWebAppsRestClient.GetVnetConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vnetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotVirtualNetworkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a virtual network the app (or deployment slot) is connected to by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections/{vnetName}
        /// Operation Id: WebApps_GetVnetConnectionSlot
        /// </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<SiteSlotVirtualNetworkConnectionResource> Get(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _siteSlotVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotVirtualNetworkConnectionWebAppsRestClient.GetVnetConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vnetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotVirtualNetworkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the virtual networks the app (or deployment slot) is connected to.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections
        /// Operation Id: WebApps_ListVnetConnectionsSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotVirtualNetworkConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotVirtualNetworkConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotVirtualNetworkConnectionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotVirtualNetworkConnectionWebAppsRestClient.ListVnetConnectionsSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Select(value => new SiteSlotVirtualNetworkConnectionResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Description for Gets the virtual networks the app (or deployment slot) is connected to.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections
        /// Operation Id: WebApps_ListVnetConnectionsSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotVirtualNetworkConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotVirtualNetworkConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotVirtualNetworkConnectionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotVirtualNetworkConnectionWebAppsRestClient.ListVnetConnectionsSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Select(value => new SiteSlotVirtualNetworkConnectionResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections/{vnetName}
        /// Operation Id: WebApps_GetVnetConnectionSlot
        /// </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _siteSlotVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotVirtualNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteSlotVirtualNetworkConnectionWebAppsRestClient.GetVnetConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vnetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections/{vnetName}
        /// Operation Id: WebApps_GetVnetConnectionSlot
        /// </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<bool> Exists(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _siteSlotVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotVirtualNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteSlotVirtualNetworkConnectionWebAppsRestClient.GetVnetConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vnetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotVirtualNetworkConnectionResource> IEnumerable<SiteSlotVirtualNetworkConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotVirtualNetworkConnectionResource> IAsyncEnumerable<SiteSlotVirtualNetworkConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
