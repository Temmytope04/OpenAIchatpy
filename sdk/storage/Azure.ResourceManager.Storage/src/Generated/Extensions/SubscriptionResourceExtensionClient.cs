// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _skusClientDiagnostics;
        private SkusRestOperations _skusRestClient;
        private ClientDiagnostics _storageAccountClientDiagnostics;
        private StorageAccountsRestOperations _storageAccountRestClient;
        private ClientDiagnostics _deletedAccountClientDiagnostics;
        private DeletedAccountsRestOperations _deletedAccountRestClient;
        private ClientDiagnostics _usagesClientDiagnostics;
        private UsagesRestOperations _usagesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics SkusClientDiagnostics => _skusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Storage", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private SkusRestOperations SkusRestClient => _skusRestClient ??= new SkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics StorageAccountClientDiagnostics => _storageAccountClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Storage", StorageAccountResource.ResourceType.Namespace, Diagnostics);
        private StorageAccountsRestOperations StorageAccountRestClient => _storageAccountRestClient ??= new StorageAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(StorageAccountResource.ResourceType));
        private ClientDiagnostics DeletedAccountClientDiagnostics => _deletedAccountClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Storage", DeletedAccountResource.ResourceType.Namespace, Diagnostics);
        private DeletedAccountsRestOperations DeletedAccountRestClient => _deletedAccountRestClient ??= new DeletedAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DeletedAccountResource.ResourceType));
        private ClientDiagnostics UsagesClientDiagnostics => _usagesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Storage", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private UsagesRestOperations UsagesRestClient => _usagesRestClient ??= new UsagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DeletedAccountResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of DeletedAccountResources and their operations over a DeletedAccountResource. </returns>
        public virtual DeletedAccountCollection GetDeletedAccounts()
        {
            return GetCachedClient(Client => new DeletedAccountCollection(Client, Id));
        }

        /// <summary>
        /// Lists the available SKUs supported by Microsoft.Storage for given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageSkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageSkuInformation> GetSkusAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, StorageSkuInformation.DeserializeStorageSkuInformation, SkusClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetSkus", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the available SKUs supported by Microsoft.Storage for given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageSkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageSkuInformation> GetSkus(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, StorageSkuInformation.DeserializeStorageSkuInformation, SkusClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetSkus", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks that the storage account name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StorageAccountNameAvailabilityResult>> CheckStorageAccountNameAvailabilityAsync(StorageAccountNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = StorageAccountClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckStorageAccountNameAvailability");
            scope.Start();
            try
            {
                var response = await StorageAccountRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks that the storage account name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StorageAccountNameAvailabilityResult> CheckStorageAccountNameAvailability(StorageAccountNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = StorageAccountClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckStorageAccountNameAvailability");
            scope.Start();
            try
            {
                var response = StorageAccountRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the storage accounts available under the subscription. Note that storage keys are not returned; use the ListKeys operation for this.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageAccountResource> GetStorageAccountsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => StorageAccountRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => StorageAccountRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new StorageAccountResource(Client, StorageAccountData.DeserializeStorageAccountData(e)), StorageAccountClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetStorageAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the storage accounts available under the subscription. Note that storage keys are not returned; use the ListKeys operation for this.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageAccountResource> GetStorageAccounts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => StorageAccountRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => StorageAccountRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new StorageAccountResource(Client, StorageAccountData.DeserializeStorageAccountData(e)), StorageAccountClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetStorageAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists deleted accounts under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/deletedAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeletedAccountResource> GetDeletedAccountsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DeletedAccountRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DeletedAccountRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DeletedAccountResource(Client, DeletedAccountData.DeserializeDeletedAccountData(e)), DeletedAccountClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDeletedAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists deleted accounts under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/deletedAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeletedAccountResource> GetDeletedAccounts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DeletedAccountRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DeletedAccountRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DeletedAccountResource(Client, DeletedAccountData.DeserializeDeletedAccountData(e)), DeletedAccountClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDeletedAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the current usage count and the limit for the resources of the location under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_ListByLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageUsage> GetUsagesByLocationAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsagesRestClient.CreateListByLocationRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, StorageUsage.DeserializeStorageUsage, UsagesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetUsagesByLocation", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets the current usage count and the limit for the resources of the location under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_ListByLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageUsage> GetUsagesByLocation(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsagesRestClient.CreateListByLocationRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, StorageUsage.DeserializeStorageUsage, UsagesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetUsagesByLocation", "value", null, cancellationToken);
        }
    }
}
