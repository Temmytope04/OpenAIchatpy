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

namespace Azure.ResourceManager.Marketplace
{
    /// <summary>
    /// A class representing a collection of <see cref="PrivateStoreOfferResource"/> and their operations.
    /// Each <see cref="PrivateStoreOfferResource"/> in the collection will belong to the same instance of <see cref="PrivateStoreCollectionInfoResource"/>.
    /// To get a <see cref="PrivateStoreOfferCollection"/> instance call the GetPrivateStoreOffers method from an instance of <see cref="PrivateStoreCollectionInfoResource"/>.
    /// </summary>
    public partial class PrivateStoreOfferCollection : ArmCollection, IEnumerable<PrivateStoreOfferResource>, IAsyncEnumerable<PrivateStoreOfferResource>
    {
        private readonly ClientDiagnostics _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics;
        private readonly PrivateStoreCollectionOfferRestOperations _privateStoreOfferPrivateStoreCollectionOfferRestClient;

        /// <summary> Initializes a new instance of the <see cref="PrivateStoreOfferCollection"/> class for mocking. </summary>
        protected PrivateStoreOfferCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateStoreOfferCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PrivateStoreOfferCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Marketplace", PrivateStoreOfferResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PrivateStoreOfferResource.ResourceType, out string privateStoreOfferPrivateStoreCollectionOfferApiVersion);
            _privateStoreOfferPrivateStoreCollectionOfferRestClient = new PrivateStoreCollectionOfferRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, privateStoreOfferPrivateStoreCollectionOfferApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PrivateStoreCollectionInfoResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PrivateStoreCollectionInfoResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Update or add an offer to a specific collection of the private store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="data"> The <see cref="PrivateStoreOfferData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PrivateStoreOfferResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string offerId, PrivateStoreOfferData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics.CreateScope("PrivateStoreOfferCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _privateStoreOfferPrivateStoreCollectionOfferRestClient.CreateOrUpdateAsync(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), offerId, data, cancellationToken).ConfigureAwait(false);
                var operation = new MarketplaceArmOperation<PrivateStoreOfferResource>(Response.FromValue(new PrivateStoreOfferResource(Client, response), response.GetRawResponse()));
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="data"> The <see cref="PrivateStoreOfferData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PrivateStoreOfferResource> CreateOrUpdate(WaitUntil waitUntil, string offerId, PrivateStoreOfferData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics.CreateScope("PrivateStoreOfferCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _privateStoreOfferPrivateStoreCollectionOfferRestClient.CreateOrUpdate(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), offerId, data, cancellationToken);
                var operation = new MarketplaceArmOperation<PrivateStoreOfferResource>(Response.FromValue(new PrivateStoreOfferResource(Client, response), response.GetRawResponse()));
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        public virtual async Task<Response<PrivateStoreOfferResource>> GetAsync(string offerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));

            using var scope = _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics.CreateScope("PrivateStoreOfferCollection.Get");
            scope.Start();
            try
            {
                var response = await _privateStoreOfferPrivateStoreCollectionOfferRestClient.GetAsync(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), offerId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateStoreOfferResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a specific offer.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        public virtual Response<PrivateStoreOfferResource> Get(string offerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));

            using var scope = _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics.CreateScope("PrivateStoreOfferCollection.Get");
            scope.Start();
            try
            {
                var response = _privateStoreOfferPrivateStoreCollectionOfferRestClient.Get(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), offerId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateStoreOfferResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of all private offers in the given private store and collection
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateStoreOfferResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateStoreOfferResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _privateStoreOfferPrivateStoreCollectionOfferRestClient.CreateListRequest(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _privateStoreOfferPrivateStoreCollectionOfferRestClient.CreateListNextPageRequest(nextLink, Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PrivateStoreOfferResource(Client, PrivateStoreOfferData.DeserializePrivateStoreOfferData(e)), _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics, Pipeline, "PrivateStoreOfferCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of all private offers in the given private store and collection
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateStoreOfferResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateStoreOfferResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _privateStoreOfferPrivateStoreCollectionOfferRestClient.CreateListRequest(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _privateStoreOfferPrivateStoreCollectionOfferRestClient.CreateListNextPageRequest(nextLink, Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PrivateStoreOfferResource(Client, PrivateStoreOfferData.DeserializePrivateStoreOfferData(e)), _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics, Pipeline, "PrivateStoreOfferCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string offerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));

            using var scope = _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics.CreateScope("PrivateStoreOfferCollection.Exists");
            scope.Start();
            try
            {
                var response = await _privateStoreOfferPrivateStoreCollectionOfferRestClient.GetAsync(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), offerId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        public virtual Response<bool> Exists(string offerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));

            using var scope = _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics.CreateScope("PrivateStoreOfferCollection.Exists");
            scope.Start();
            try
            {
                var response = _privateStoreOfferPrivateStoreCollectionOfferRestClient.Get(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), offerId, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        public virtual async Task<NullableResponse<PrivateStoreOfferResource>> GetIfExistsAsync(string offerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));

            using var scope = _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics.CreateScope("PrivateStoreOfferCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _privateStoreOfferPrivateStoreCollectionOfferRestClient.GetAsync(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), offerId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PrivateStoreOfferResource>(response.GetRawResponse());
                return Response.FromValue(new PrivateStoreOfferResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        public virtual NullableResponse<PrivateStoreOfferResource> GetIfExists(string offerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));

            using var scope = _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics.CreateScope("PrivateStoreOfferCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _privateStoreOfferPrivateStoreCollectionOfferRestClient.Get(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), offerId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PrivateStoreOfferResource>(response.GetRawResponse());
                return Response.FromValue(new PrivateStoreOfferResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PrivateStoreOfferResource> IEnumerable<PrivateStoreOfferResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PrivateStoreOfferResource> IAsyncEnumerable<PrivateStoreOfferResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
