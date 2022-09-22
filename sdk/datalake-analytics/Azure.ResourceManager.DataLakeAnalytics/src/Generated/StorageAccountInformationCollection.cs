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
using Azure.ResourceManager.DataLakeAnalytics.Models;

namespace Azure.ResourceManager.DataLakeAnalytics
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageAccountInformationResource" /> and their operations.
    /// Each <see cref="StorageAccountInformationResource" /> in the collection will belong to the same instance of <see cref="DataLakeAnalyticsAccountResource" />.
    /// To get a <see cref="StorageAccountInformationCollection" /> instance call the GetStorageAccountInformation method from an instance of <see cref="DataLakeAnalyticsAccountResource" />.
    /// </summary>
    public partial class StorageAccountInformationCollection : ArmCollection, IEnumerable<StorageAccountInformationResource>, IAsyncEnumerable<StorageAccountInformationResource>
    {
        private readonly ClientDiagnostics _storageAccountInformationStorageAccountsClientDiagnostics;
        private readonly StorageAccountsRestOperations _storageAccountInformationStorageAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageAccountInformationCollection"/> class for mocking. </summary>
        protected StorageAccountInformationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageAccountInformationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageAccountInformationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageAccountInformationStorageAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataLakeAnalytics", StorageAccountInformationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageAccountInformationResource.ResourceType, out string storageAccountInformationStorageAccountsApiVersion);
            _storageAccountInformationStorageAccountsRestClient = new StorageAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageAccountInformationStorageAccountsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataLakeAnalyticsAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataLakeAnalyticsAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates the specified Data Lake Analytics account to add an Azure Storage account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}
        /// Operation Id: StorageAccounts_Add
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageAccountName"> The name of the Azure Storage account to add. </param>
        /// <param name="content"> The parameters containing the access key and optional suffix for the Azure Storage Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation> CreateOrUpdateAsync(WaitUntil waitUntil, string storageAccountName, StorageAccountInformationCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _storageAccountInformationStorageAccountsClientDiagnostics.CreateScope("StorageAccountInformationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageAccountInformationStorageAccountsRestClient.AddAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, content, cancellationToken).ConfigureAwait(false);
                var operation = new DataLakeAnalyticsArmOperation(response);
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
        /// Updates the specified Data Lake Analytics account to add an Azure Storage account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}
        /// Operation Id: StorageAccounts_Add
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageAccountName"> The name of the Azure Storage account to add. </param>
        /// <param name="content"> The parameters containing the access key and optional suffix for the Azure Storage Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation CreateOrUpdate(WaitUntil waitUntil, string storageAccountName, StorageAccountInformationCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _storageAccountInformationStorageAccountsClientDiagnostics.CreateScope("StorageAccountInformationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageAccountInformationStorageAccountsRestClient.Add(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, content, cancellationToken);
                var operation = new DataLakeAnalyticsArmOperation(response);
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
        /// Gets the specified Azure Storage account linked to the given Data Lake Analytics account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}
        /// Operation Id: StorageAccounts_Get
        /// </summary>
        /// <param name="storageAccountName"> The name of the Azure Storage account for which to retrieve the details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> is null. </exception>
        public virtual async Task<Response<StorageAccountInformationResource>> GetAsync(string storageAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));

            using var scope = _storageAccountInformationStorageAccountsClientDiagnostics.CreateScope("StorageAccountInformationCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageAccountInformationStorageAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageAccountInformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Azure Storage account linked to the given Data Lake Analytics account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}
        /// Operation Id: StorageAccounts_Get
        /// </summary>
        /// <param name="storageAccountName"> The name of the Azure Storage account for which to retrieve the details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> is null. </exception>
        public virtual Response<StorageAccountInformationResource> Get(string storageAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));

            using var scope = _storageAccountInformationStorageAccountsClientDiagnostics.CreateScope("StorageAccountInformationCollection.Get");
            scope.Start();
            try
            {
                var response = _storageAccountInformationStorageAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageAccountInformationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the first page of Azure Storage accounts, if any, linked to the specified Data Lake Analytics account. The response includes a link to the next page, if any.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts
        /// Operation Id: StorageAccounts_ListByAccount
        /// </summary>
        /// <param name="filter"> The OData filter. Optional. </param>
        /// <param name="top"> The number of items to return. Optional. </param>
        /// <param name="skip"> The number of items to skip over before returning elements. Optional. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional. </param>
        /// <param name="orderby"> OrderBy clause. One or more comma-separated expressions with an optional &quot;asc&quot; (the default) or &quot;desc&quot; depending on the order you&apos;d like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional. </param>
        /// <param name="count"> The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageAccountInformationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageAccountInformationResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, string select = null, string orderby = null, bool? count = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<StorageAccountInformationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _storageAccountInformationStorageAccountsClientDiagnostics.CreateScope("StorageAccountInformationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _storageAccountInformationStorageAccountsRestClient.ListByAccountAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, select, orderby, count, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageAccountInformationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<StorageAccountInformationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _storageAccountInformationStorageAccountsClientDiagnostics.CreateScope("StorageAccountInformationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _storageAccountInformationStorageAccountsRestClient.ListByAccountNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, select, orderby, count, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageAccountInformationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets the first page of Azure Storage accounts, if any, linked to the specified Data Lake Analytics account. The response includes a link to the next page, if any.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts
        /// Operation Id: StorageAccounts_ListByAccount
        /// </summary>
        /// <param name="filter"> The OData filter. Optional. </param>
        /// <param name="top"> The number of items to return. Optional. </param>
        /// <param name="skip"> The number of items to skip over before returning elements. Optional. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional. </param>
        /// <param name="orderby"> OrderBy clause. One or more comma-separated expressions with an optional &quot;asc&quot; (the default) or &quot;desc&quot; depending on the order you&apos;d like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional. </param>
        /// <param name="count"> The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageAccountInformationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageAccountInformationResource> GetAll(string filter = null, int? top = null, int? skip = null, string select = null, string orderby = null, bool? count = null, CancellationToken cancellationToken = default)
        {
            Page<StorageAccountInformationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _storageAccountInformationStorageAccountsClientDiagnostics.CreateScope("StorageAccountInformationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _storageAccountInformationStorageAccountsRestClient.ListByAccount(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, select, orderby, count, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageAccountInformationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<StorageAccountInformationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _storageAccountInformationStorageAccountsClientDiagnostics.CreateScope("StorageAccountInformationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _storageAccountInformationStorageAccountsRestClient.ListByAccountNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, select, orderby, count, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageAccountInformationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}
        /// Operation Id: StorageAccounts_Get
        /// </summary>
        /// <param name="storageAccountName"> The name of the Azure Storage account for which to retrieve the details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string storageAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));

            using var scope = _storageAccountInformationStorageAccountsClientDiagnostics.CreateScope("StorageAccountInformationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageAccountInformationStorageAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}
        /// Operation Id: StorageAccounts_Get
        /// </summary>
        /// <param name="storageAccountName"> The name of the Azure Storage account for which to retrieve the details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> is null. </exception>
        public virtual Response<bool> Exists(string storageAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));

            using var scope = _storageAccountInformationStorageAccountsClientDiagnostics.CreateScope("StorageAccountInformationCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageAccountInformationStorageAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageAccountInformationResource> IEnumerable<StorageAccountInformationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageAccountInformationResource> IAsyncEnumerable<StorageAccountInformationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
