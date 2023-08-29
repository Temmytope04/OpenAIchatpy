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
    /// A class representing a collection of <see cref="WebSiteSlotPublicCertificateResource" /> and their operations.
    /// Each <see cref="WebSiteSlotPublicCertificateResource" /> in the collection will belong to the same instance of <see cref="WebSiteSlotResource" />.
    /// To get a <see cref="WebSiteSlotPublicCertificateCollection" /> instance call the GetWebSiteSlotPublicCertificates method from an instance of <see cref="WebSiteSlotResource" />.
    /// </summary>
    public partial class WebSiteSlotPublicCertificateCollection : ArmCollection, IEnumerable<WebSiteSlotPublicCertificateResource>, IAsyncEnumerable<WebSiteSlotPublicCertificateResource>
    {
        private readonly ClientDiagnostics _webSiteSlotPublicCertificateWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteSlotPublicCertificateWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotPublicCertificateCollection"/> class for mocking. </summary>
        protected WebSiteSlotPublicCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotPublicCertificateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebSiteSlotPublicCertificateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteSlotPublicCertificateWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", WebSiteSlotPublicCertificateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebSiteSlotPublicCertificateResource.ResourceType, out string webSiteSlotPublicCertificateWebAppsApiVersion);
            _webSiteSlotPublicCertificateWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteSlotPublicCertificateWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteSlotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteSlotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Creates a hostname binding for an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/publicCertificates/{publicCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateOrUpdatePublicCertificateSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="data"> Public certificate details. This is the JSON representation of a PublicCertificate object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WebSiteSlotPublicCertificateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string publicCertificateName, PublicCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteSlotPublicCertificateWebAppsClientDiagnostics.CreateScope("WebSiteSlotPublicCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webSiteSlotPublicCertificateWebAppsRestClient.CreateOrUpdatePublicCertificateSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, publicCertificateName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<WebSiteSlotPublicCertificateResource>(Response.FromValue(new WebSiteSlotPublicCertificateResource(Client, response), response.GetRawResponse()));
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
        /// Description for Creates a hostname binding for an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/publicCertificates/{publicCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateOrUpdatePublicCertificateSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="data"> Public certificate details. This is the JSON representation of a PublicCertificate object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WebSiteSlotPublicCertificateResource> CreateOrUpdate(WaitUntil waitUntil, string publicCertificateName, PublicCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteSlotPublicCertificateWebAppsClientDiagnostics.CreateScope("WebSiteSlotPublicCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webSiteSlotPublicCertificateWebAppsRestClient.CreateOrUpdatePublicCertificateSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, publicCertificateName, data, cancellationToken);
                var operation = new AppServiceArmOperation<WebSiteSlotPublicCertificateResource>(Response.FromValue(new WebSiteSlotPublicCertificateResource(Client, response), response.GetRawResponse()));
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
        /// Description for Get the named public certificate for an app (or deployment slot, if specified).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/publicCertificates/{publicCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetPublicCertificateSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public virtual async Task<Response<WebSiteSlotPublicCertificateResource>> GetAsync(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _webSiteSlotPublicCertificateWebAppsClientDiagnostics.CreateScope("WebSiteSlotPublicCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _webSiteSlotPublicCertificateWebAppsRestClient.GetPublicCertificateSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, publicCertificateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotPublicCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the named public certificate for an app (or deployment slot, if specified).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/publicCertificates/{publicCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetPublicCertificateSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public virtual Response<WebSiteSlotPublicCertificateResource> Get(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _webSiteSlotPublicCertificateWebAppsClientDiagnostics.CreateScope("WebSiteSlotPublicCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _webSiteSlotPublicCertificateWebAppsRestClient.GetPublicCertificateSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, publicCertificateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotPublicCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get public certificates for an app or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/publicCertificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListPublicCertificatesSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebSiteSlotPublicCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebSiteSlotPublicCertificateResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteSlotPublicCertificateWebAppsRestClient.CreateListPublicCertificatesSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteSlotPublicCertificateWebAppsRestClient.CreateListPublicCertificatesSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new WebSiteSlotPublicCertificateResource(Client, PublicCertificateData.DeserializePublicCertificateData(e)), _webSiteSlotPublicCertificateWebAppsClientDiagnostics, Pipeline, "WebSiteSlotPublicCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get public certificates for an app or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/publicCertificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListPublicCertificatesSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebSiteSlotPublicCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebSiteSlotPublicCertificateResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteSlotPublicCertificateWebAppsRestClient.CreateListPublicCertificatesSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteSlotPublicCertificateWebAppsRestClient.CreateListPublicCertificatesSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new WebSiteSlotPublicCertificateResource(Client, PublicCertificateData.DeserializePublicCertificateData(e)), _webSiteSlotPublicCertificateWebAppsClientDiagnostics, Pipeline, "WebSiteSlotPublicCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/publicCertificates/{publicCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetPublicCertificateSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _webSiteSlotPublicCertificateWebAppsClientDiagnostics.CreateScope("WebSiteSlotPublicCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webSiteSlotPublicCertificateWebAppsRestClient.GetPublicCertificateSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, publicCertificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/publicCertificates/{publicCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetPublicCertificateSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public virtual Response<bool> Exists(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _webSiteSlotPublicCertificateWebAppsClientDiagnostics.CreateScope("WebSiteSlotPublicCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = _webSiteSlotPublicCertificateWebAppsRestClient.GetPublicCertificateSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, publicCertificateName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebSiteSlotPublicCertificateResource> IEnumerable<WebSiteSlotPublicCertificateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebSiteSlotPublicCertificateResource> IAsyncEnumerable<WebSiteSlotPublicCertificateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
