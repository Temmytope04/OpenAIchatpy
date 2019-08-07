// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Storage.Admin
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for StorageAccountsOperations.
    /// </summary>
    public static partial class StorageAccountsOperationsExtensions
    {
            /// <summary>
            /// Returns a list of storage accounts.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='filter'>
            /// Filter string
            /// </param>
            /// <param name='summary'>
            /// Switch for whether summary or detailed information is returned.
            /// </param>
            public static IPage<StorageAccount> List(this IStorageAccountsOperations operations, string resourceGroupName, string filter = default(string), bool? summary = default(bool?))
            {
                return operations.ListAsync(resourceGroupName, filter, summary).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of storage accounts.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='filter'>
            /// Filter string
            /// </param>
            /// <param name='summary'>
            /// Switch for whether summary or detailed information is returned.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StorageAccount>> ListAsync(this IStorageAccountsOperations operations, string resourceGroupName, string filter = default(string), bool? summary = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, filter, summary, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the requested storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='accountId'>
            /// Internal storage account ID, which is not visible to tenant.
            /// </param>
            public static StorageAccount Get(this IStorageAccountsOperations operations, string resourceGroupName, string accountId)
            {
                return operations.GetAsync(resourceGroupName, accountId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the requested storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='accountId'>
            /// Internal storage account ID, which is not visible to tenant.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageAccount> GetAsync(this IStorageAccountsOperations operations, string resourceGroupName, string accountId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Undelete a deleted storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='accountId'>
            /// Internal storage account ID, which is not visible to tenant.
            /// </param>
            /// <param name='newaccountname'>
            /// New storage account name when doing undelete storage account operation.
            /// </param>
            public static UndeleteStorageAccount Undelete(this IStorageAccountsOperations operations, string resourceGroupName, string accountId, string newaccountname = default(string))
            {
                return operations.UndeleteAsync(resourceGroupName, accountId, newaccountname).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Undelete a deleted storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='accountId'>
            /// Internal storage account ID, which is not visible to tenant.
            /// </param>
            /// <param name='newaccountname'>
            /// New storage account name when doing undelete storage account operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UndeleteStorageAccount> UndeleteAsync(this IStorageAccountsOperations operations, string resourceGroupName, string accountId, string newaccountname = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UndeleteWithHttpMessagesAsync(resourceGroupName, accountId, newaccountname, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Start garbage collection on deleted storage objects.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            public static void OnDemandGC(this IStorageAccountsOperations operations, string resourceGroupName)
            {
                operations.OnDemandGCAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Start garbage collection on deleted storage objects.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task OnDemandGCAsync(this IStorageAccountsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.OnDemandGCWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Undelete a deleted storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='accountId'>
            /// Internal storage account ID, which is not visible to tenant.
            /// </param>
            /// <param name='newaccountname'>
            /// New storage account name when doing undelete storage account operation.
            /// </param>
            public static UndeleteStorageAccount BeginUndelete(this IStorageAccountsOperations operations, string resourceGroupName, string accountId, string newaccountname = default(string))
            {
                return operations.BeginUndeleteAsync(resourceGroupName, accountId, newaccountname).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Undelete a deleted storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='accountId'>
            /// Internal storage account ID, which is not visible to tenant.
            /// </param>
            /// <param name='newaccountname'>
            /// New storage account name when doing undelete storage account operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UndeleteStorageAccount> BeginUndeleteAsync(this IStorageAccountsOperations operations, string resourceGroupName, string accountId, string newaccountname = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUndeleteWithHttpMessagesAsync(resourceGroupName, accountId, newaccountname, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Start garbage collection on deleted storage objects.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            public static void BeginOnDemandGC(this IStorageAccountsOperations operations, string resourceGroupName)
            {
                operations.BeginOnDemandGCAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Start garbage collection on deleted storage objects.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginOnDemandGCAsync(this IStorageAccountsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginOnDemandGCWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a list of storage accounts.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<StorageAccount> ListNext(this IStorageAccountsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of storage accounts.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StorageAccount>> ListNextAsync(this IStorageAccountsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
