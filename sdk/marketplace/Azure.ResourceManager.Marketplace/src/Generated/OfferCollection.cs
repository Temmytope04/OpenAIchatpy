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

namespace Azure.ResourceManager.Marketplace
{
    /// <summary>
    /// A class representing a collection of <see cref="OfferResource" /> and their operations.
    /// Each <see cref="OfferResource" /> in the collection will belong to the same instance of <see cref="CollectionResource" />.
    /// To get an <see cref="OfferCollection" /> instance call the GetOffers method from an instance of <see cref="CollectionResource" />.
    /// </summary>
    public partial class OfferCollection : ArmCollection, IEnumerable<OfferResource>, IAsyncEnumerable<OfferResource>
    {
        private readonly ClientDiagnostics _offerPrivateStoreCollectionOfferClientDiagnostics;
        private readonly PrivateStoreCollectionOfferRestOperations _offerPrivateStoreCollectionOfferRestClient;

        /// <summary> Initializes a new instance of the <see cref="OfferCollection"/> class for mocking. </summary>
        protected OfferCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OfferCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal OfferCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _offerPrivateStoreCollectionOfferClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Marketplace", OfferResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(OfferResource.ResourceType, out string offerPrivateStoreCollectionOfferApiVersion);
            _offerPrivateStoreCollectionOfferRestClient = new PrivateStoreCollectionOfferRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, offerPrivateStoreCollectionOfferApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CollectionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CollectionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Update or add an offer to a specific collection of the private store.
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}
        /// Operation Id: PrivateStoreCollectionOffer_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="data"> The Offer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<OfferResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string offerId, OfferData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _offerPrivateStoreCollectionOfferClientDiagnostics.CreateScope("OfferCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _offerPrivateStoreCollectionOfferRestClient.CreateOrUpdateAsync(Id.Parent.Name, Id.Name, offerId, data, cancellationToken).ConfigureAwait(false);
                var operation = new MarketplaceArmOperation<OfferResource>(Response.FromValue(new OfferResource(Client, response), response.GetRawResponse()));
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
        /// Update or add an offer to a specific collection of the private store.
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}
        /// Operation Id: PrivateStoreCollectionOffer_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="data"> The Offer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<OfferResource> CreateOrUpdate(WaitUntil waitUntil, string offerId, OfferData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _offerPrivateStoreCollectionOfferClientDiagnostics.CreateScope("OfferCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _offerPrivateStoreCollectionOfferRestClient.CreateOrUpdate(Id.Parent.Name, Id.Name, offerId, data, cancellationToken);
                var operation = new MarketplaceArmOperation<OfferResource>(Response.FromValue(new OfferResource(Client, response), response.GetRawResponse()));
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
        /// Gets information about a specific offer.
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}
        /// Operation Id: PrivateStoreCollectionOffer_Get
        /// </summary>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        public virtual async Task<Response<OfferResource>> GetAsync(string offerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));

            using var scope = _offerPrivateStoreCollectionOfferClientDiagnostics.CreateScope("OfferCollection.Get");
            scope.Start();
            try
            {
                var response = await _offerPrivateStoreCollectionOfferRestClient.GetAsync(Id.Parent.Name, Id.Name, offerId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OfferResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a specific offer.
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}
        /// Operation Id: PrivateStoreCollectionOffer_Get
        /// </summary>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        public virtual Response<OfferResource> Get(string offerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));

            using var scope = _offerPrivateStoreCollectionOfferClientDiagnostics.CreateScope("OfferCollection.Get");
            scope.Start();
            try
            {
                var response = _offerPrivateStoreCollectionOfferRestClient.Get(Id.Parent.Name, Id.Name, offerId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OfferResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of all private offers in the given private store and collection
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers
        /// Operation Id: PrivateStoreCollectionOffer_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OfferResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OfferResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<OfferResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _offerPrivateStoreCollectionOfferClientDiagnostics.CreateScope("OfferCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _offerPrivateStoreCollectionOfferRestClient.ListAsync(Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OfferResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OfferResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _offerPrivateStoreCollectionOfferClientDiagnostics.CreateScope("OfferCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _offerPrivateStoreCollectionOfferRestClient.ListNextPageAsync(nextLink, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OfferResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Get a list of all private offers in the given private store and collection
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers
        /// Operation Id: PrivateStoreCollectionOffer_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OfferResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OfferResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<OfferResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _offerPrivateStoreCollectionOfferClientDiagnostics.CreateScope("OfferCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _offerPrivateStoreCollectionOfferRestClient.List(Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OfferResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OfferResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _offerPrivateStoreCollectionOfferClientDiagnostics.CreateScope("OfferCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _offerPrivateStoreCollectionOfferRestClient.ListNextPage(nextLink, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OfferResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}
        /// Operation Id: PrivateStoreCollectionOffer_Get
        /// </summary>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string offerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));

            using var scope = _offerPrivateStoreCollectionOfferClientDiagnostics.CreateScope("OfferCollection.Exists");
            scope.Start();
            try
            {
                var response = await _offerPrivateStoreCollectionOfferRestClient.GetAsync(Id.Parent.Name, Id.Name, offerId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}
        /// Operation Id: PrivateStoreCollectionOffer_Get
        /// </summary>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        public virtual Response<bool> Exists(string offerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));

            using var scope = _offerPrivateStoreCollectionOfferClientDiagnostics.CreateScope("OfferCollection.Exists");
            scope.Start();
            try
            {
                var response = _offerPrivateStoreCollectionOfferRestClient.Get(Id.Parent.Name, Id.Name, offerId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OfferResource> IEnumerable<OfferResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OfferResource> IAsyncEnumerable<OfferResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
