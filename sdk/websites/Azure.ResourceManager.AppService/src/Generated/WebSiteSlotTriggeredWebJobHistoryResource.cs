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
    /// A Class representing a WebSiteSlotTriggeredWebJobHistory along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="WebSiteSlotTriggeredWebJobHistoryResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetWebSiteSlotTriggeredWebJobHistoryResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteSlotTriggeredWebJobResource" /> using the GetWebSiteSlotTriggeredWebJobHistory method.
    /// </summary>
    public partial class WebSiteSlotTriggeredWebJobHistoryResource : TriggeredJobHistoryResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WebSiteSlotTriggeredWebJobHistoryResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string webJobName, string id)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotTriggeredWebJobHistoryResource"/> class for mocking. </summary>
        protected WebSiteSlotTriggeredWebJobHistoryResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WebSiteSlotTriggeredWebJobHistoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WebSiteSlotTriggeredWebJobHistoryResource(ArmClient client, TriggeredJobHistoryData data) : base(client, data)
        {
            _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteSlotTriggeredWebJobHistoryWebAppsApiVersion);
            _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteSlotTriggeredWebJobHistoryWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotTriggeredWebJobHistoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WebSiteSlotTriggeredWebJobHistoryResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteSlotTriggeredWebJobHistoryWebAppsApiVersion);
            _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteSlotTriggeredWebJobHistoryWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/triggeredwebjobs/history";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets a triggered web job&apos;s history by its ID for an app, , or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}
        /// Operation Id: WebApps_GetTriggeredWebJobHistory
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<TriggeredJobHistoryResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobHistoryResource.Get");
            scope.Start();
            try
            {
                var response = await _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistoryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a triggered web job&apos;s history by its ID for an app, , or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}
        /// Operation Id: WebApps_GetTriggeredWebJobHistory
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual new async Task<Response<WebSiteSlotTriggeredWebJobHistoryResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((WebSiteSlotTriggeredWebJobHistoryResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Description for Gets a triggered web job&apos;s history by its ID for an app, , or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}
        /// Operation Id: WebApps_GetTriggeredWebJobHistory
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<TriggeredJobHistoryResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobHistoryResource.Get");
            scope.Start();
            try
            {
                var response = _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistory(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a triggered web job&apos;s history by its ID for an app, , or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}
        /// Operation Id: WebApps_GetTriggeredWebJobHistory
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual new Response<WebSiteSlotTriggeredWebJobHistoryResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((WebSiteSlotTriggeredWebJobHistoryResource)result.Value, result.GetRawResponse());
        }
    }
}
