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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of ResourceGroup and their operations over its parent. </summary>
    public partial class ResourceGroupCollection : ArmCollection, IEnumerable<ResourceGroup>, IAsyncEnumerable<ResourceGroup>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ResourceGroupsRestOperations _resourceGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupCollection"/> class for mocking. </summary>
        protected ResourceGroupCollection()
        {
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ResourceGroups_CreateOrUpdate
        /// <summary> Creates or updates a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to create or update. Can include alphanumeric, underscore, parentheses, hyphen, period (except at end), and Unicode characters that match the allowed characters. </param>
        /// <param name="parameters"> Parameters supplied to the create or update a resource group. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ResourceGroupCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string resourceGroupName, ResourceGroupData parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _resourceGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, resourceGroupName, parameters, cancellationToken);
                var operation = new ResourceGroupCreateOrUpdateOperation(this, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ResourceGroups_CreateOrUpdate
        /// <summary> Creates or updates a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to create or update. Can include alphanumeric, underscore, parentheses, hyphen, period (except at end), and Unicode characters that match the allowed characters. </param>
        /// <param name="parameters"> Parameters supplied to the create or update a resource group. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ResourceGroupCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string resourceGroupName, ResourceGroupData parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _resourceGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, resourceGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ResourceGroupCreateOrUpdateOperation(this, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ResourceGroups_Get
        /// <summary> Gets a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to get. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual Response<ResourceGroup> Get(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _resourceGroupsRestClient.Get(Id.SubscriptionId, resourceGroupName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ResourceGroups_Get
        /// <summary> Gets a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to get. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public async virtual Task<Response<ResourceGroup>> GetAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourceGroupsRestClient.GetAsync(Id.SubscriptionId, resourceGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ResourceGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to get. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual Response<ResourceGroup> GetIfExists(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _resourceGroupsRestClient.Get(Id.SubscriptionId, resourceGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ResourceGroup>(null, response.GetRawResponse());
                return Response.FromValue(new ResourceGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to get. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public async virtual Task<Response<ResourceGroup>> GetIfExistsAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _resourceGroupsRestClient.GetAsync(Id.SubscriptionId, resourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ResourceGroup>(null, response.GetRawResponse());
                return Response.FromValue(new ResourceGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to get. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(resourceGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to get. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(resourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ResourceGroups_List
        /// <summary> Gets all the resource groups for a subscription. </summary>
        /// <param name="filter"> The filter to apply on the operation.&lt;br&gt;&lt;br&gt;You can filter by tag names and values. For example, to filter for a tag name and value, use $filter=tagName eq &apos;tag1&apos; and tagValue eq &apos;Value1&apos;. </param>
        /// <param name="top"> The number of results to return. If null is passed, returns all resource groups. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceGroup> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ResourceGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resourceGroupsRestClient.List(Id.SubscriptionId, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resourceGroupsRestClient.ListNextPage(nextLink, Id.SubscriptionId, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourcegroups
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ResourceGroups_List
        /// <summary> Gets all the resource groups for a subscription. </summary>
        /// <param name="filter"> The filter to apply on the operation.&lt;br&gt;&lt;br&gt;You can filter by tag names and values. For example, to filter for a tag name and value, use $filter=tagName eq &apos;tag1&apos; and tagValue eq &apos;Value1&apos;. </param>
        /// <param name="top"> The number of results to return. If null is passed, returns all resource groups. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceGroup> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resourceGroupsRestClient.ListAsync(Id.SubscriptionId, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resourceGroupsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ResourceGroup> IEnumerable<ResourceGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourceGroup> IAsyncEnumerable<ResourceGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ResourceGroup, ResourceGroupData> Construct() { }
    }
}
