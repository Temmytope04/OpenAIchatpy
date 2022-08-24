// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _netAppResourceClientDiagnostics;
        private NetAppResourceRestOperations _netAppResourceRestClient;
        private ClientDiagnostics _netAppAccountAccountsClientDiagnostics;
        private AccountsRestOperations _netAppAccountAccountsRestClient;

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

        private ClientDiagnostics NetAppResourceClientDiagnostics => _netAppResourceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.NetApp", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private NetAppResourceRestOperations NetAppResourceRestClient => _netAppResourceRestClient ??= new NetAppResourceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics NetAppAccountAccountsClientDiagnostics => _netAppAccountAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.NetApp", NetAppAccountResource.ResourceType.Namespace, Diagnostics);
        private AccountsRestOperations NetAppAccountAccountsRestClient => _netAppAccountAccountsRestClient ??= new AccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(NetAppAccountResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of SubscriptionQuotaItemResources in the SubscriptionResource. </summary>
        /// <param name="location"> The location. </param>
        /// <returns> An object representing collection of SubscriptionQuotaItemResources and their operations over a SubscriptionQuotaItemResource. </returns>
        public virtual SubscriptionQuotaItemCollection GetSubscriptionQuotaItems(AzureLocation location)
        {
            return new SubscriptionQuotaItemCollection(Client, Id, location);
        }

        /// <summary>
        /// Check if a resource name is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkNameAvailability
        /// Operation Id: NetAppResource_CheckNameAvailability
        /// </summary>
        /// <param name="location"> The location. </param>
        /// <param name="content"> Name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CheckAvailabilityResponse>> CheckNameAvailabilityNetAppResourceAsync(AzureLocation location, ResourceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = NetAppResourceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNameAvailabilityNetAppResource");
            scope.Start();
            try
            {
                var response = await NetAppResourceRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if a resource name is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkNameAvailability
        /// Operation Id: NetAppResource_CheckNameAvailability
        /// </summary>
        /// <param name="location"> The location. </param>
        /// <param name="content"> Name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckAvailabilityResponse> CheckNameAvailabilityNetAppResource(AzureLocation location, ResourceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = NetAppResourceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNameAvailabilityNetAppResource");
            scope.Start();
            try
            {
                var response = NetAppResourceRestClient.CheckNameAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if a file path is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkFilePathAvailability
        /// Operation Id: NetAppResource_CheckFilePathAvailability
        /// </summary>
        /// <param name="location"> The location. </param>
        /// <param name="content"> File path availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CheckAvailabilityResponse>> CheckFilePathAvailabilityNetAppResourceAsync(AzureLocation location, FilePathAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = NetAppResourceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckFilePathAvailabilityNetAppResource");
            scope.Start();
            try
            {
                var response = await NetAppResourceRestClient.CheckFilePathAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if a file path is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkFilePathAvailability
        /// Operation Id: NetAppResource_CheckFilePathAvailability
        /// </summary>
        /// <param name="location"> The location. </param>
        /// <param name="content"> File path availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckAvailabilityResponse> CheckFilePathAvailabilityNetAppResource(AzureLocation location, FilePathAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = NetAppResourceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckFilePathAvailabilityNetAppResource");
            scope.Start();
            try
            {
                var response = NetAppResourceRestClient.CheckFilePathAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if a quota is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkQuotaAvailability
        /// Operation Id: NetAppResource_CheckQuotaAvailability
        /// </summary>
        /// <param name="location"> The location. </param>
        /// <param name="content"> Quota availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CheckAvailabilityResponse>> CheckQuotaAvailabilityNetAppResourceAsync(AzureLocation location, QuotaAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = NetAppResourceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckQuotaAvailabilityNetAppResource");
            scope.Start();
            try
            {
                var response = await NetAppResourceRestClient.CheckQuotaAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if a quota is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkQuotaAvailability
        /// Operation Id: NetAppResource_CheckQuotaAvailability
        /// </summary>
        /// <param name="location"> The location. </param>
        /// <param name="content"> Quota availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckAvailabilityResponse> CheckQuotaAvailabilityNetAppResource(AzureLocation location, QuotaAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = NetAppResourceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckQuotaAvailabilityNetAppResource");
            scope.Start();
            try
            {
                var response = NetAppResourceRestClient.CheckQuotaAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List and describe all NetApp accounts in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/netAppAccounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetAppAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetAppAccountResource> GetNetAppAccountsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetAppAccountResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = NetAppAccountAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetNetAppAccounts");
                scope.Start();
                try
                {
                    var response = await NetAppAccountAccountsRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetAppAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NetAppAccountResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = NetAppAccountAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetNetAppAccounts");
                scope.Start();
                try
                {
                    var response = await NetAppAccountAccountsRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetAppAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List and describe all NetApp accounts in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/netAppAccounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetAppAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetAppAccountResource> GetNetAppAccounts(CancellationToken cancellationToken = default)
        {
            Page<NetAppAccountResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = NetAppAccountAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetNetAppAccounts");
                scope.Start();
                try
                {
                    var response = NetAppAccountAccountsRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetAppAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NetAppAccountResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = NetAppAccountAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetNetAppAccounts");
                scope.Start();
                try
                {
                    var response = NetAppAccountAccountsRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetAppAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
