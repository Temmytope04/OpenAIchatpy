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
    /// A Class representing a SiteSlotTriggeredWebJobHistory along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteSlotTriggeredWebJobHistoryResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteSlotTriggeredWebJobHistoryResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteSlotTriggeredWebJobResource" /> using the GetSiteSlotTriggeredWebJobHistory method.
    /// </summary>
    public partial class SiteSlotTriggeredWebJobHistoryResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotTriggeredWebJobHistoryResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string webJobName, string id)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotTriggeredWebJobHistoryWebAppsRestClient;
        private readonly TriggeredJobHistoryData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotTriggeredWebJobHistoryResource"/> class for mocking. </summary>
        protected SiteSlotTriggeredWebJobHistoryResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotTriggeredWebJobHistoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotTriggeredWebJobHistoryResource(ArmClient client, TriggeredJobHistoryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotTriggeredWebJobHistoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotTriggeredWebJobHistoryResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteSlotTriggeredWebJobHistoryWebAppsApiVersion);
            _siteSlotTriggeredWebJobHistoryWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotTriggeredWebJobHistoryWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/triggeredwebjobs/history";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TriggeredJobHistoryData Data
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

        /// <summary>
        /// Description for Gets a triggered web job&apos;s history by its ID for an app, , or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}
        /// Operation Id: WebApps_GetTriggeredWebJobHistory
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteSlotTriggeredWebJobHistoryResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryResource.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistoryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotTriggeredWebJobHistoryResource(Client, response.Value), response.GetRawResponse());
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
        public virtual Response<SiteSlotTriggeredWebJobHistoryResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryResource.Get");
            scope.Start();
            try
            {
                var response = _siteSlotTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistory(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotTriggeredWebJobHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
