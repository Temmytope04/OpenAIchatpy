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
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Batch
{
    /// <summary>
    /// A class representing a collection of <see cref="BatchAccountPoolResource"/> and their operations.
    /// Each <see cref="BatchAccountPoolResource"/> in the collection will belong to the same instance of <see cref="BatchAccountResource"/>.
    /// To get a <see cref="BatchAccountPoolCollection"/> instance call the GetBatchAccountPools method from an instance of <see cref="BatchAccountResource"/>.
    /// </summary>
    public partial class BatchAccountPoolCollection : ArmCollection, IEnumerable<BatchAccountPoolResource>, IAsyncEnumerable<BatchAccountPoolResource>
    {
        private readonly ClientDiagnostics _batchAccountPoolPoolClientDiagnostics;
        private readonly PoolRestOperations _batchAccountPoolPoolRestClient;

        /// <summary> Initializes a new instance of the <see cref="BatchAccountPoolCollection"/> class for mocking. </summary>
        protected BatchAccountPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BatchAccountPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BatchAccountPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _batchAccountPoolPoolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Batch", BatchAccountPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BatchAccountPoolResource.ResourceType, out string batchAccountPoolPoolApiVersion);
            _batchAccountPoolPoolRestClient = new PoolRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, batchAccountPoolPoolApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BatchAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BatchAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new pool inside the specified account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="poolName"> The pool name. This must be unique within the account. </param>
        /// <param name="data"> Additional parameters for pool creation. </param>
        /// <param name="ifMatch"> The entity state (ETag) version of the pool to update. A value of "*" can be used to apply the operation only if the pool already exists. If omitted, this operation will always be applied. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new pool to be created, but to prevent updating an existing pool. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BatchAccountPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string poolName, BatchAccountPoolData data, ETag? ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (poolName == null)
            {
                throw new ArgumentNullException(nameof(poolName));
            }
            if (poolName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(poolName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _batchAccountPoolPoolClientDiagnostics.CreateScope("BatchAccountPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _batchAccountPoolPoolRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new BatchArmOperation<BatchAccountPoolResource>(Response.FromValue(new BatchAccountPoolResource(Client, response), response.GetRawResponse()));
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
        /// Creates a new pool inside the specified account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="poolName"> The pool name. This must be unique within the account. </param>
        /// <param name="data"> Additional parameters for pool creation. </param>
        /// <param name="ifMatch"> The entity state (ETag) version of the pool to update. A value of "*" can be used to apply the operation only if the pool already exists. If omitted, this operation will always be applied. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new pool to be created, but to prevent updating an existing pool. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BatchAccountPoolResource> CreateOrUpdate(WaitUntil waitUntil, string poolName, BatchAccountPoolData data, ETag? ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (poolName == null)
            {
                throw new ArgumentNullException(nameof(poolName));
            }
            if (poolName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(poolName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _batchAccountPoolPoolClientDiagnostics.CreateScope("BatchAccountPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _batchAccountPoolPoolRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new BatchArmOperation<BatchAccountPoolResource>(Response.FromValue(new BatchAccountPoolResource(Client, response), response.GetRawResponse()));
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
        /// Gets information about the specified pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> The pool name. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual async Task<Response<BatchAccountPoolResource>> GetAsync(string poolName, CancellationToken cancellationToken = default)
        {
            if (poolName == null)
            {
                throw new ArgumentNullException(nameof(poolName));
            }
            if (poolName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(poolName));
            }

            using var scope = _batchAccountPoolPoolClientDiagnostics.CreateScope("BatchAccountPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _batchAccountPoolPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchAccountPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> The pool name. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual Response<BatchAccountPoolResource> Get(string poolName, CancellationToken cancellationToken = default)
        {
            if (poolName == null)
            {
                throw new ArgumentNullException(nameof(poolName));
            }
            if (poolName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(poolName));
            }

            using var scope = _batchAccountPoolPoolClientDiagnostics.CreateScope("BatchAccountPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _batchAccountPoolPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchAccountPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the pools in the specified account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/pools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_ListByBatchAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="select"> Comma separated list of properties that should be returned. e.g. "properties/provisioningState". Only top level properties under properties/ are valid for selection. </param>
        /// <param name="filter">
        /// OData filter expression. Valid properties for filtering are:
        ///
        ///  name
        ///  properties/allocationState
        ///  properties/allocationStateTransitionTime
        ///  properties/creationTime
        ///  properties/provisioningState
        ///  properties/provisioningStateTransitionTime
        ///  properties/lastModified
        ///  properties/vmSize
        ///  properties/interNodeCommunication
        ///  properties/scaleSettings/autoScale
        ///  properties/scaleSettings/fixedScale
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BatchAccountPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BatchAccountPoolResource> GetAllAsync(int? maxresults = null, string select = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _batchAccountPoolPoolRestClient.CreateListByBatchAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults, select, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _batchAccountPoolPoolRestClient.CreateListByBatchAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults, select, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BatchAccountPoolResource(Client, BatchAccountPoolData.DeserializeBatchAccountPoolData(e)), _batchAccountPoolPoolClientDiagnostics, Pipeline, "BatchAccountPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the pools in the specified account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/pools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_ListByBatchAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="select"> Comma separated list of properties that should be returned. e.g. "properties/provisioningState". Only top level properties under properties/ are valid for selection. </param>
        /// <param name="filter">
        /// OData filter expression. Valid properties for filtering are:
        ///
        ///  name
        ///  properties/allocationState
        ///  properties/allocationStateTransitionTime
        ///  properties/creationTime
        ///  properties/provisioningState
        ///  properties/provisioningStateTransitionTime
        ///  properties/lastModified
        ///  properties/vmSize
        ///  properties/interNodeCommunication
        ///  properties/scaleSettings/autoScale
        ///  properties/scaleSettings/fixedScale
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BatchAccountPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BatchAccountPoolResource> GetAll(int? maxresults = null, string select = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _batchAccountPoolPoolRestClient.CreateListByBatchAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults, select, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _batchAccountPoolPoolRestClient.CreateListByBatchAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults, select, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BatchAccountPoolResource(Client, BatchAccountPoolData.DeserializeBatchAccountPoolData(e)), _batchAccountPoolPoolClientDiagnostics, Pipeline, "BatchAccountPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> The pool name. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string poolName, CancellationToken cancellationToken = default)
        {
            if (poolName == null)
            {
                throw new ArgumentNullException(nameof(poolName));
            }
            if (poolName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(poolName));
            }

            using var scope = _batchAccountPoolPoolClientDiagnostics.CreateScope("BatchAccountPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _batchAccountPoolPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> The pool name. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual Response<bool> Exists(string poolName, CancellationToken cancellationToken = default)
        {
            if (poolName == null)
            {
                throw new ArgumentNullException(nameof(poolName));
            }
            if (poolName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(poolName));
            }

            using var scope = _batchAccountPoolPoolClientDiagnostics.CreateScope("BatchAccountPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _batchAccountPoolPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> The pool name. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual async Task<NullableResponse<BatchAccountPoolResource>> GetIfExistsAsync(string poolName, CancellationToken cancellationToken = default)
        {
            if (poolName == null)
            {
                throw new ArgumentNullException(nameof(poolName));
            }
            if (poolName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(poolName));
            }

            using var scope = _batchAccountPoolPoolClientDiagnostics.CreateScope("BatchAccountPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _batchAccountPoolPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BatchAccountPoolResource>(response.GetRawResponse());
                return Response.FromValue(new BatchAccountPoolResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> The pool name. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual NullableResponse<BatchAccountPoolResource> GetIfExists(string poolName, CancellationToken cancellationToken = default)
        {
            if (poolName == null)
            {
                throw new ArgumentNullException(nameof(poolName));
            }
            if (poolName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(poolName));
            }

            using var scope = _batchAccountPoolPoolClientDiagnostics.CreateScope("BatchAccountPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _batchAccountPoolPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BatchAccountPoolResource>(response.GetRawResponse());
                return Response.FromValue(new BatchAccountPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BatchAccountPoolResource> IEnumerable<BatchAccountPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BatchAccountPoolResource> IAsyncEnumerable<BatchAccountPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
