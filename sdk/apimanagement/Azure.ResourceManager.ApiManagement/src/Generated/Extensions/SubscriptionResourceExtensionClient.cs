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
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _apiManagementDeletedServiceDeletedServicesClientDiagnostics;
        private DeletedServicesRestOperations _apiManagementDeletedServiceDeletedServicesRestClient;
        private ClientDiagnostics _apiManagementServiceClientDiagnostics;
        private ApiManagementServiceRestOperations _apiManagementServiceRestClient;
        private ClientDiagnostics _apiManagementSkusClientDiagnostics;
        private ApiManagementSkusRestOperations _apiManagementSkusRestClient;

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

        private ClientDiagnostics ApiManagementDeletedServiceDeletedServicesClientDiagnostics => _apiManagementDeletedServiceDeletedServicesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementDeletedServiceResource.ResourceType.Namespace, Diagnostics);
        private DeletedServicesRestOperations ApiManagementDeletedServiceDeletedServicesRestClient => _apiManagementDeletedServiceDeletedServicesRestClient ??= new DeletedServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ApiManagementDeletedServiceResource.ResourceType));
        private ClientDiagnostics ApiManagementServiceClientDiagnostics => _apiManagementServiceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementServiceResource.ResourceType.Namespace, Diagnostics);
        private ApiManagementServiceRestOperations ApiManagementServiceRestClient => _apiManagementServiceRestClient ??= new ApiManagementServiceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ApiManagementServiceResource.ResourceType));
        private ClientDiagnostics ApiManagementSkusClientDiagnostics => _apiManagementSkusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ApiManagementSkusRestOperations ApiManagementSkusRestClient => _apiManagementSkusRestClient ??= new ApiManagementSkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ApiManagementDeletedServiceResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of ApiManagementDeletedServiceResources and their operations over a ApiManagementDeletedServiceResource. </returns>
        public virtual ApiManagementDeletedServiceCollection GetApiManagementDeletedServices()
        {
            return GetCachedClient(Client => new ApiManagementDeletedServiceCollection(Client, Id));
        }

        /// <summary>
        /// Lists all soft-deleted services available for undelete for the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/deletedservices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedServices_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementDeletedServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementDeletedServiceResource> GetApiManagementDeletedServicesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ApiManagementDeletedServiceDeletedServicesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ApiManagementDeletedServiceDeletedServicesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ApiManagementDeletedServiceResource(Client, ApiManagementDeletedServiceData.DeserializeApiManagementDeletedServiceData(e)), ApiManagementDeletedServiceDeletedServicesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetApiManagementDeletedServices", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all soft-deleted services available for undelete for the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/deletedservices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedServices_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementDeletedServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementDeletedServiceResource> GetApiManagementDeletedServices(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ApiManagementDeletedServiceDeletedServicesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ApiManagementDeletedServiceDeletedServicesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ApiManagementDeletedServiceResource(Client, ApiManagementDeletedServiceData.DeserializeApiManagementDeletedServiceData(e)), ApiManagementDeletedServiceDeletedServicesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetApiManagementDeletedServices", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all API Management services within an Azure subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/service</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiManagementService_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementServiceResource> GetApiManagementServicesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ApiManagementServiceRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ApiManagementServiceRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ApiManagementServiceResource(Client, ApiManagementServiceData.DeserializeApiManagementServiceData(e)), ApiManagementServiceClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetApiManagementServices", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all API Management services within an Azure subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/service</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiManagementService_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementServiceResource> GetApiManagementServices(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ApiManagementServiceRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ApiManagementServiceRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ApiManagementServiceResource(Client, ApiManagementServiceData.DeserializeApiManagementServiceData(e)), ApiManagementServiceClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetApiManagementServices", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks availability and correctness of a name for an API Management service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiManagementService_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Parameters supplied to the CheckNameAvailability operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiManagementServiceNameAvailabilityResult>> CheckApiManagementServiceNameAvailabilityAsync(ApiManagementServiceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ApiManagementServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckApiManagementServiceNameAvailability");
            scope.Start();
            try
            {
                var response = await ApiManagementServiceRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks availability and correctness of a name for an API Management service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiManagementService_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Parameters supplied to the CheckNameAvailability operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiManagementServiceNameAvailabilityResult> CheckApiManagementServiceNameAvailability(ApiManagementServiceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ApiManagementServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckApiManagementServiceNameAvailability");
            scope.Start();
            try
            {
                var response = ApiManagementServiceRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the custom domain ownership identifier for an API Management service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/getDomainOwnershipIdentifier</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiManagementService_GetDomainOwnershipIdentifier</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiManagementServiceGetDomainOwnershipIdentifierResult>> GetApiManagementServiceDomainOwnershipIdentifierAsync(CancellationToken cancellationToken = default)
        {
            using var scope = ApiManagementServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetApiManagementServiceDomainOwnershipIdentifier");
            scope.Start();
            try
            {
                var response = await ApiManagementServiceRestClient.GetDomainOwnershipIdentifierAsync(Id.SubscriptionId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the custom domain ownership identifier for an API Management service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/getDomainOwnershipIdentifier</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiManagementService_GetDomainOwnershipIdentifier</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiManagementServiceGetDomainOwnershipIdentifierResult> GetApiManagementServiceDomainOwnershipIdentifier(CancellationToken cancellationToken = default)
        {
            using var scope = ApiManagementServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetApiManagementServiceDomainOwnershipIdentifier");
            scope.Start();
            try
            {
                var response = ApiManagementServiceRestClient.GetDomainOwnershipIdentifier(Id.SubscriptionId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of Microsoft.ApiManagement SKUs available for your Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiManagementSkus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementSku" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementSku> GetApiManagementSkusAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ApiManagementSkusRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ApiManagementSkusRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ApiManagementSku.DeserializeApiManagementSku, ApiManagementSkusClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetApiManagementSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of Microsoft.ApiManagement SKUs available for your Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiManagementSkus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementSku" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementSku> GetApiManagementSkus(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ApiManagementSkusRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ApiManagementSkusRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ApiManagementSku.DeserializeApiManagementSku, ApiManagementSkusClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetApiManagementSkus", "value", "nextLink", cancellationToken);
        }
    }
}
