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
    /// A Class representing a WebSiteConfigConnectionString along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="WebSiteConfigConnectionStringResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetWebSiteConfigConnectionStringResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource" /> using the GetWebSiteConfigConnectionString method.
    /// </summary>
    public partial class WebSiteConfigConnectionStringResource : ApiKeyVaultReferenceResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WebSiteConfigConnectionStringResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string connectionStringKey)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/connectionstrings/{connectionStringKey}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _webSiteConfigConnectionStringWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteConfigConnectionStringWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteConfigConnectionStringResource"/> class for mocking. </summary>
        protected WebSiteConfigConnectionStringResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WebSiteConfigConnectionStringResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WebSiteConfigConnectionStringResource(ArmClient client, ApiKeyVaultReferenceData data) : base(client, data)
        {
            _webSiteConfigConnectionStringWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteConfigConnectionStringWebAppsApiVersion);
            _webSiteConfigConnectionStringWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteConfigConnectionStringWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteConfigConnectionStringResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WebSiteConfigConnectionStringResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteConfigConnectionStringWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteConfigConnectionStringWebAppsApiVersion);
            _webSiteConfigConnectionStringWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteConfigConnectionStringWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/config/connectionstrings";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets the config reference and status of an app
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/connectionstrings/{connectionStringKey}
        /// Operation Id: WebApps_GetSiteConnectionStringKeyVaultReference
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<ApiKeyVaultReferenceResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteConfigConnectionStringWebAppsClientDiagnostics.CreateScope("WebSiteConfigConnectionStringResource.Get");
            scope.Start();
            try
            {
                var response = await _webSiteConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReferenceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Gets the config reference and status of an app
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/connectionstrings/{connectionStringKey}
        /// Operation Id: WebApps_GetSiteConnectionStringKeyVaultReference
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual new async Task<Response<WebSiteConfigConnectionStringResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((WebSiteConfigConnectionStringResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Description for Gets the config reference and status of an app
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/connectionstrings/{connectionStringKey}
        /// Operation Id: WebApps_GetSiteConnectionStringKeyVaultReference
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<ApiKeyVaultReferenceResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteConfigConnectionStringWebAppsClientDiagnostics.CreateScope("WebSiteConfigConnectionStringResource.Get");
            scope.Start();
            try
            {
                var response = _webSiteConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReference(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Gets the config reference and status of an app
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/connectionstrings/{connectionStringKey}
        /// Operation Id: WebApps_GetSiteConnectionStringKeyVaultReference
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual new Response<WebSiteConfigConnectionStringResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((WebSiteConfigConnectionStringResource)result.Value, result.GetRawResponse());
        }
    }
}
