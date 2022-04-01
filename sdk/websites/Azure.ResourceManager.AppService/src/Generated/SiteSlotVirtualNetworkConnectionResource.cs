// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
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
    /// A Class representing a SiteSlotVirtualNetworkConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteSlotVirtualNetworkConnectionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteSlotVirtualNetworkConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteSlotResource" /> using the GetSiteSlotVirtualNetworkConnection method.
    /// </summary>
    public partial class SiteSlotVirtualNetworkConnectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotVirtualNetworkConnectionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string vnetName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections/{vnetName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotVirtualNetworkConnectionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotVirtualNetworkConnectionWebAppsRestClient;
        private readonly VnetInfoResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotVirtualNetworkConnectionResource"/> class for mocking. </summary>
        protected SiteSlotVirtualNetworkConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotVirtualNetworkConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotVirtualNetworkConnectionResource(ArmClient client, VnetInfoResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotVirtualNetworkConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotVirtualNetworkConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotVirtualNetworkConnectionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteSlotVirtualNetworkConnectionWebAppsApiVersion);
            _siteSlotVirtualNetworkConnectionWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotVirtualNetworkConnectionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/virtualNetworkConnections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VnetInfoResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SiteSlotVirtualNetworkConnectionGatewayResources in the SiteSlotVirtualNetworkConnection. </summary>
        /// <returns> An object representing collection of SiteSlotVirtualNetworkConnectionGatewayResources and their operations over a SiteSlotVirtualNetworkConnectionGatewayResource. </returns>
        public virtual SiteSlotVirtualNetworkConnectionGatewayCollection GetSiteSlotVirtualNetworkConnectionGateways()
        {
            return GetCachedClient(Client => new SiteSlotVirtualNetworkConnectionGatewayCollection(Client, Id));
        }

        /// <summary>
        /// Description for Gets an app&apos;s Virtual Network gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// Operation Id: WebApps_GetVnetConnectionGatewaySlot
        /// </summary>
        /// <param name="gatewayName"> Name of the gateway. Currently, the only supported string is &quot;primary&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual async Task<Response<SiteSlotVirtualNetworkConnectionGatewayResource>> GetSiteSlotVirtualNetworkConnectionGatewayAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            return await GetSiteSlotVirtualNetworkConnectionGateways().GetAsync(gatewayName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Gets an app&apos;s Virtual Network gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// Operation Id: WebApps_GetVnetConnectionGatewaySlot
        /// </summary>
        /// <param name="gatewayName"> Name of the gateway. Currently, the only supported string is &quot;primary&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<SiteSlotVirtualNetworkConnectionGatewayResource> GetSiteSlotVirtualNetworkConnectionGateway(string gatewayName, CancellationToken cancellationToken = default)
        {
            return GetSiteSlotVirtualNetworkConnectionGateways().Get(gatewayName, cancellationToken);
        }

        /// <summary>
        /// Description for Gets a virtual network the app (or deployment slot) is connected to by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections/{vnetName}
        /// Operation Id: WebApps_GetVnetConnectionSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteSlotVirtualNetworkConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotVirtualNetworkConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotVirtualNetworkConnectionWebAppsRestClient.GetVnetConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotVirtualNetworkConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotVirtualNetworkConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _siteSlotVirtualNetworkConnectionWebAppsRestClient.GetVnetConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Deletes a connection from an app (or deployment slot to a named virtual network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections/{vnetName}
        /// Operation Id: WebApps_DeleteVnetConnectionSlot
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotVirtualNetworkConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = await _siteSlotVirtualNetworkConnectionWebAppsRestClient.DeleteVnetConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Deletes a connection from an app (or deployment slot to a named virtual network.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections/{vnetName}
        /// Operation Id: WebApps_DeleteVnetConnectionSlot
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotVirtualNetworkConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = _siteSlotVirtualNetworkConnectionWebAppsRestClient.DeleteVnetConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
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
        /// Operation Id: WebApps_UpdateVnetConnectionSlot
        /// </summary>
        /// <param name="data"> Properties of the Virtual Network connection. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<SiteSlotVirtualNetworkConnectionResource>> UpdateAsync(VnetInfoResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotVirtualNetworkConnectionResource.Update");
            scope.Start();
            try
            {
                var response = await _siteSlotVirtualNetworkConnectionWebAppsRestClient.UpdateVnetConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotVirtualNetworkConnectionResource(Client, response.Value), response.GetRawResponse());
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
        /// Operation Id: WebApps_UpdateVnetConnectionSlot
        /// </summary>
        /// <param name="data"> Properties of the Virtual Network connection. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<SiteSlotVirtualNetworkConnectionResource> Update(VnetInfoResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotVirtualNetworkConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotVirtualNetworkConnectionResource.Update");
            scope.Start();
            try
            {
                var response = _siteSlotVirtualNetworkConnectionWebAppsRestClient.UpdateVnetConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                return Response.FromValue(new SiteSlotVirtualNetworkConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
