// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="ViewResourceFormatResource" /> and their operations.
    /// Each <see cref="ViewResourceFormatResource" /> in the collection will belong to the same instance of <see cref="HubResource" />.
    /// To get a <see cref="ViewResourceFormatCollection" /> instance call the GetViewResourceFormats method from an instance of <see cref="HubResource" />.
    /// </summary>
    public partial class ViewResourceFormatCollection : ArmCollection
    {
        private readonly ClientDiagnostics _viewResourceFormatViewsClientDiagnostics;
        private readonly ViewsRestOperations _viewResourceFormatViewsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ViewResourceFormatCollection"/> class for mocking. </summary>
        protected ViewResourceFormatCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ViewResourceFormatCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ViewResourceFormatCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _viewResourceFormatViewsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CustomerInsights", ViewResourceFormatResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ViewResourceFormatResource.ResourceType, out string viewResourceFormatViewsApiVersion);
            _viewResourceFormatViewsRestClient = new ViewsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, viewResourceFormatViewsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a view or updates an existing view in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="viewName"> The name of the view. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate View operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ViewResourceFormatResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string viewName, ViewResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _viewResourceFormatViewsClientDiagnostics.CreateScope("ViewResourceFormatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _viewResourceFormatViewsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, viewName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CustomerInsightsArmOperation<ViewResourceFormatResource>(Response.FromValue(new ViewResourceFormatResource(Client, response), response.GetRawResponse()));
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
        /// Creates a view or updates an existing view in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="viewName"> The name of the view. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate View operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ViewResourceFormatResource> CreateOrUpdate(WaitUntil waitUntil, string viewName, ViewResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _viewResourceFormatViewsClientDiagnostics.CreateScope("ViewResourceFormatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _viewResourceFormatViewsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, viewName, data, cancellationToken);
                var operation = new CustomerInsightsArmOperation<ViewResourceFormatResource>(Response.FromValue(new ViewResourceFormatResource(Client, response), response.GetRawResponse()));
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
        /// Gets a view in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> The name of the view. </param>
        /// <param name="userId"> The user ID. Use * to retrieve hub level view. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> or <paramref name="userId"/> is null. </exception>
        public virtual async Task<Response<ViewResourceFormatResource>> GetAsync(string viewName, string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(userId, nameof(userId));

            using var scope = _viewResourceFormatViewsClientDiagnostics.CreateScope("ViewResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = await _viewResourceFormatViewsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, viewName, userId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ViewResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a view in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> The name of the view. </param>
        /// <param name="userId"> The user ID. Use * to retrieve hub level view. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> or <paramref name="userId"/> is null. </exception>
        public virtual Response<ViewResourceFormatResource> Get(string viewName, string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(userId, nameof(userId));

            using var scope = _viewResourceFormatViewsClientDiagnostics.CreateScope("ViewResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = _viewResourceFormatViewsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, viewName, userId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ViewResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all available views for given user in the specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/views</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_ListByHub</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userId"> The user ID. Use * to retrieve hub level views. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        /// <returns> An async collection of <see cref="ViewResourceFormatResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ViewResourceFormatResource> GetAllAsync(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(userId, nameof(userId));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _viewResourceFormatViewsRestClient.CreateListByHubRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _viewResourceFormatViewsRestClient.CreateListByHubNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ViewResourceFormatResource(Client, ViewResourceFormatData.DeserializeViewResourceFormatData(e)), _viewResourceFormatViewsClientDiagnostics, Pipeline, "ViewResourceFormatCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all available views for given user in the specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/views</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_ListByHub</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userId"> The user ID. Use * to retrieve hub level views. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        /// <returns> A collection of <see cref="ViewResourceFormatResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ViewResourceFormatResource> GetAll(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(userId, nameof(userId));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _viewResourceFormatViewsRestClient.CreateListByHubRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _viewResourceFormatViewsRestClient.CreateListByHubNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, userId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ViewResourceFormatResource(Client, ViewResourceFormatData.DeserializeViewResourceFormatData(e)), _viewResourceFormatViewsClientDiagnostics, Pipeline, "ViewResourceFormatCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> The name of the view. </param>
        /// <param name="userId"> The user ID. Use * to retrieve hub level view. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> or <paramref name="userId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string viewName, string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(userId, nameof(userId));

            using var scope = _viewResourceFormatViewsClientDiagnostics.CreateScope("ViewResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = await _viewResourceFormatViewsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, viewName, userId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> The name of the view. </param>
        /// <param name="userId"> The user ID. Use * to retrieve hub level view. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> or <paramref name="userId"/> is null. </exception>
        public virtual Response<bool> Exists(string viewName, string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(userId, nameof(userId));

            using var scope = _viewResourceFormatViewsClientDiagnostics.CreateScope("ViewResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = _viewResourceFormatViewsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, viewName, userId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> The name of the view. </param>
        /// <param name="userId"> The user ID. Use * to retrieve hub level view. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> or <paramref name="userId"/> is null. </exception>
        public virtual async Task<NullableResponse<ViewResourceFormatResource>> GetIfExistsAsync(string viewName, string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(userId, nameof(userId));

            using var scope = _viewResourceFormatViewsClientDiagnostics.CreateScope("ViewResourceFormatCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _viewResourceFormatViewsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, viewName, userId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ViewResourceFormatResource>(response.GetRawResponse());
                return Response.FromValue(new ViewResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> The name of the view. </param>
        /// <param name="userId"> The user ID. Use * to retrieve hub level view. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> or <paramref name="userId"/> is null. </exception>
        public virtual NullableResponse<ViewResourceFormatResource> GetIfExists(string viewName, string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(userId, nameof(userId));

            using var scope = _viewResourceFormatViewsClientDiagnostics.CreateScope("ViewResourceFormatCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _viewResourceFormatViewsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, viewName, userId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ViewResourceFormatResource>(response.GetRawResponse());
                return Response.FromValue(new ViewResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
