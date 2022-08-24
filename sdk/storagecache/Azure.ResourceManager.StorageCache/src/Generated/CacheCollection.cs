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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.StorageCache
{
    /// <summary>
    /// A class representing a collection of <see cref="CacheResource" /> and their operations.
    /// Each <see cref="CacheResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="CacheCollection" /> instance call the GetCaches method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class CacheCollection : ArmCollection, IEnumerable<CacheResource>, IAsyncEnumerable<CacheResource>
    {
        private readonly ClientDiagnostics _cacheClientDiagnostics;
        private readonly CachesRestOperations _cacheRestClient;

        /// <summary> Initializes a new instance of the <see cref="CacheCollection"/> class for mocking. </summary>
        protected CacheCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CacheCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CacheCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cacheClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageCache", CacheResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CacheResource.ResourceType, out string cacheApiVersion);
            _cacheRestClient = new CachesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cacheApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Cache.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}
        /// Operation Id: Caches_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cacheName"> Name of Cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="data"> Object containing the user-selectable properties of the new Cache. If read-only properties are included, they must match the existing values of those properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CacheResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string cacheName, CacheData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheName, nameof(cacheName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cacheClientDiagnostics.CreateScope("CacheCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cacheRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, cacheName, data, cancellationToken).ConfigureAwait(false);
                var operation = new StorageCacheArmOperation<CacheResource>(new CacheOperationSource(Client), _cacheClientDiagnostics, Pipeline, _cacheRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, cacheName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a Cache.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}
        /// Operation Id: Caches_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cacheName"> Name of Cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="data"> Object containing the user-selectable properties of the new Cache. If read-only properties are included, they must match the existing values of those properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CacheResource> CreateOrUpdate(WaitUntil waitUntil, string cacheName, CacheData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheName, nameof(cacheName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cacheClientDiagnostics.CreateScope("CacheCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cacheRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, cacheName, data, cancellationToken);
                var operation = new StorageCacheArmOperation<CacheResource>(new CacheOperationSource(Client), _cacheClientDiagnostics, Pipeline, _cacheRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, cacheName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Returns a Cache.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}
        /// Operation Id: Caches_Get
        /// </summary>
        /// <param name="cacheName"> Name of Cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> is null. </exception>
        public virtual async Task<Response<CacheResource>> GetAsync(string cacheName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheName, nameof(cacheName));

            using var scope = _cacheClientDiagnostics.CreateScope("CacheCollection.Get");
            scope.Start();
            try
            {
                var response = await _cacheRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cacheName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CacheResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a Cache.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}
        /// Operation Id: Caches_Get
        /// </summary>
        /// <param name="cacheName"> Name of Cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> is null. </exception>
        public virtual Response<CacheResource> Get(string cacheName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheName, nameof(cacheName));

            using var scope = _cacheClientDiagnostics.CreateScope("CacheCollection.Get");
            scope.Start();
            try
            {
                var response = _cacheRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cacheName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CacheResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns all Caches the user has access to under a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches
        /// Operation Id: Caches_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CacheResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CacheResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CacheResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cacheClientDiagnostics.CreateScope("CacheCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cacheRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CacheResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CacheResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _cacheClientDiagnostics.CreateScope("CacheCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cacheRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CacheResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Returns all Caches the user has access to under a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches
        /// Operation Id: Caches_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CacheResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CacheResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CacheResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cacheClientDiagnostics.CreateScope("CacheCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cacheRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CacheResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CacheResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _cacheClientDiagnostics.CreateScope("CacheCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cacheRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CacheResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}
        /// Operation Id: Caches_Get
        /// </summary>
        /// <param name="cacheName"> Name of Cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string cacheName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheName, nameof(cacheName));

            using var scope = _cacheClientDiagnostics.CreateScope("CacheCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cacheRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cacheName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}
        /// Operation Id: Caches_Get
        /// </summary>
        /// <param name="cacheName"> Name of Cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> is null. </exception>
        public virtual Response<bool> Exists(string cacheName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheName, nameof(cacheName));

            using var scope = _cacheClientDiagnostics.CreateScope("CacheCollection.Exists");
            scope.Start();
            try
            {
                var response = _cacheRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cacheName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CacheResource> IEnumerable<CacheResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CacheResource> IAsyncEnumerable<CacheResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
