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
using Azure.ResourceManager.Media.Models;

namespace Azure.ResourceManager.Media
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _mediaServicesAccountMediaservicesClientDiagnostics;
        private MediaservicesRestOperations _mediaServicesAccountMediaservicesRestClient;
        private ClientDiagnostics _locationsClientDiagnostics;
        private LocationsRestOperations _locationsRestClient;
        private ClientDiagnostics _mediaServicesOperationStatusesClientDiagnostics;
        private MediaServicesOperationStatusesRestOperations _mediaServicesOperationStatusesRestClient;

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

        private ClientDiagnostics MediaServicesAccountMediaservicesClientDiagnostics => _mediaServicesAccountMediaservicesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Media", MediaServicesAccountResource.ResourceType.Namespace, Diagnostics);
        private MediaservicesRestOperations MediaServicesAccountMediaservicesRestClient => _mediaServicesAccountMediaservicesRestClient ??= new MediaservicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(MediaServicesAccountResource.ResourceType));
        private ClientDiagnostics LocationsClientDiagnostics => _locationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Media", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationsRestOperations LocationsRestClient => _locationsRestClient ??= new LocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics MediaServicesOperationStatusesClientDiagnostics => _mediaServicesOperationStatusesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Media", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private MediaServicesOperationStatusesRestOperations MediaServicesOperationStatusesRestClient => _mediaServicesOperationStatusesRestClient ??= new MediaServicesOperationStatusesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of MediaServicesOperationResultResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of MediaServicesOperationResultResources and their operations over a MediaServicesOperationResultResource. </returns>
        public virtual MediaServicesOperationResultCollection GetMediaServicesOperationResults()
        {
            return GetCachedClient(Client => new MediaServicesOperationResultCollection(Client, Id));
        }

        /// <summary>
        /// List Media Services accounts in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Media/mediaservices
        /// Operation Id: Mediaservices_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MediaServicesAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MediaServicesAccountResource> GetMediaServicesAccountsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MediaServicesAccountResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = MediaServicesAccountMediaservicesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetMediaServicesAccounts");
                scope.Start();
                try
                {
                    var response = await MediaServicesAccountMediaservicesRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MediaServicesAccountResource(Client, value)), response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MediaServicesAccountResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = MediaServicesAccountMediaservicesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetMediaServicesAccounts");
                scope.Start();
                try
                {
                    var response = await MediaServicesAccountMediaservicesRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MediaServicesAccountResource(Client, value)), response.Value.OdataNextLink, response.GetRawResponse());
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
        /// List Media Services accounts in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Media/mediaservices
        /// Operation Id: Mediaservices_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MediaServicesAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MediaServicesAccountResource> GetMediaServicesAccounts(CancellationToken cancellationToken = default)
        {
            Page<MediaServicesAccountResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = MediaServicesAccountMediaservicesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetMediaServicesAccounts");
                scope.Start();
                try
                {
                    var response = MediaServicesAccountMediaservicesRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MediaServicesAccountResource(Client, value)), response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MediaServicesAccountResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = MediaServicesAccountMediaservicesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetMediaServicesAccounts");
                scope.Start();
                try
                {
                    var response = MediaServicesAccountMediaservicesRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MediaServicesAccountResource(Client, value)), response.Value.OdataNextLink, response.GetRawResponse());
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
        /// Checks whether the Media Service resource name is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Media/locations/{locationName}/checkNameAvailability
        /// Operation Id: Locations_CheckNameAvailability
        /// </summary>
        /// <param name="locationName"> Location name. </param>
        /// <param name="content"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MediaNameAvailabilityResult>> CheckMediaNameAvailabilityAsync(AzureLocation locationName, MediaNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckMediaNameAvailability");
            scope.Start();
            try
            {
                var response = await LocationsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, locationName, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks whether the Media Service resource name is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Media/locations/{locationName}/checkNameAvailability
        /// Operation Id: Locations_CheckNameAvailability
        /// </summary>
        /// <param name="locationName"> Location name. </param>
        /// <param name="content"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MediaNameAvailabilityResult> CheckMediaNameAvailability(AzureLocation locationName, MediaNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckMediaNameAvailability");
            scope.Start();
            try
            {
                var response = LocationsRestClient.CheckNameAvailability(Id.SubscriptionId, locationName, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get media service operation status.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Media/locations/{locationName}/mediaServicesOperationStatuses/{operationId}
        /// Operation Id: MediaServicesOperationStatuses_Get
        /// </summary>
        /// <param name="locationName"> Location name. </param>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MediaServicesOperationStatus>> GetMediaServicesOperationStatusAsync(AzureLocation locationName, string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = MediaServicesOperationStatusesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetMediaServicesOperationStatus");
            scope.Start();
            try
            {
                var response = await MediaServicesOperationStatusesRestClient.GetAsync(Id.SubscriptionId, locationName, operationId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get media service operation status.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Media/locations/{locationName}/mediaServicesOperationStatuses/{operationId}
        /// Operation Id: MediaServicesOperationStatuses_Get
        /// </summary>
        /// <param name="locationName"> Location name. </param>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MediaServicesOperationStatus> GetMediaServicesOperationStatus(AzureLocation locationName, string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = MediaServicesOperationStatusesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetMediaServicesOperationStatus");
            scope.Start();
            try
            {
                var response = MediaServicesOperationStatusesRestClient.Get(Id.SubscriptionId, locationName, operationId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
