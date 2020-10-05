// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> The ResourceLinks service client. </summary>
    public partial class ResourceLinksOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ResourceLinksRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of ResourceLinksOperations for mocking. </summary>
        protected ResourceLinksOperations()
        {
        }
        /// <summary> Initializes a new instance of ResourceLinksOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ResourceLinksOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ResourceLinksRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Deletes a resource link with the specified ID. </summary>
        /// <param name="linkId"> The fully qualified ID of the resource link. Use the format, /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string linkId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLinksOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(linkId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a resource link with the specified ID. </summary>
        /// <param name="linkId"> The fully qualified ID of the resource link. Use the format, /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string linkId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLinksOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(linkId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a resource link between the specified resources. </summary>
        /// <param name="linkId"> The fully qualified ID of the resource link. Use the format, /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="parameters"> Parameters for creating or updating a resource link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceLink>> CreateOrUpdateAsync(string linkId, ResourceLink parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLinksOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateAsync(linkId, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a resource link between the specified resources. </summary>
        /// <param name="linkId"> The fully qualified ID of the resource link. Use the format, /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="parameters"> Parameters for creating or updating a resource link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceLink> CreateOrUpdate(string linkId, ResourceLink parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLinksOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdate(linkId, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a resource link with the specified ID. </summary>
        /// <param name="linkId"> The fully qualified Id of the resource link. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceLink>> GetAsync(string linkId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLinksOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(linkId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a resource link with the specified ID. </summary>
        /// <param name="linkId"> The fully qualified Id of the resource link. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceLink> Get(string linkId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLinksOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(linkId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the linked resources for the subscription. </summary>
        /// <param name="filter"> The filter to apply on the list resource links operation. The supported filter for list resource links is targetId. For example, $filter=targetId eq {value}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ResourceLink> ListAtSubscriptionAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceLinksOperations.ListAtSubscription");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAtSubscriptionAsync(filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceLink>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceLinksOperations.ListAtSubscription");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAtSubscriptionNextPageAsync(nextLink, filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the linked resources for the subscription. </summary>
        /// <param name="filter"> The filter to apply on the list resource links operation. The supported filter for list resource links is targetId. For example, $filter=targetId eq {value}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ResourceLink> ListAtSubscription(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<ResourceLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceLinksOperations.ListAtSubscription");
                scope.Start();
                try
                {
                    var response = RestClient.ListAtSubscription(filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceLink> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceLinksOperations.ListAtSubscription");
                scope.Start();
                try
                {
                    var response = RestClient.ListAtSubscriptionNextPage(nextLink, filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of resource links at and below the specified source scope. </summary>
        /// <param name="scope"> The fully qualified ID of the scope for getting the resource links. For example, to list resource links at and under a resource group, set the scope to /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public virtual AsyncPageable<ResourceLink> ListAtSourceScopeAsync(string scope, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            async Task<Page<ResourceLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope0 = _clientDiagnostics.CreateScope("ResourceLinksOperations.ListAtSourceScope");
                scope0.Start();
                try
                {
                    var response = await RestClient.ListAtSourceScopeAsync(scope, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceLink>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope0 = _clientDiagnostics.CreateScope("ResourceLinksOperations.ListAtSourceScope");
                scope0.Start();
                try
                {
                    var response = await RestClient.ListAtSourceScopeNextPageAsync(nextLink, scope, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of resource links at and below the specified source scope. </summary>
        /// <param name="scope"> The fully qualified ID of the scope for getting the resource links. For example, to list resource links at and under a resource group, set the scope to /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public virtual Pageable<ResourceLink> ListAtSourceScope(string scope, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            Page<ResourceLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope0 = _clientDiagnostics.CreateScope("ResourceLinksOperations.ListAtSourceScope");
                scope0.Start();
                try
                {
                    var response = RestClient.ListAtSourceScope(scope, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            Page<ResourceLink> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope0 = _clientDiagnostics.CreateScope("ResourceLinksOperations.ListAtSourceScope");
                scope0.Start();
                try
                {
                    var response = RestClient.ListAtSourceScopeNextPage(nextLink, scope, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
