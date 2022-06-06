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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="GalleryResource" /> and their operations.
    /// Each <see cref="GalleryResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="GalleryCollection" /> instance call the GetGalleries method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class GalleryCollection : ArmCollection, IEnumerable<GalleryResource>, IAsyncEnumerable<GalleryResource>
    {
        private readonly ClientDiagnostics _galleryClientDiagnostics;
        private readonly GalleriesRestOperations _galleryRestClient;

        /// <summary> Initializes a new instance of the <see cref="GalleryCollection"/> class for mocking. </summary>
        protected GalleryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GalleryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GalleryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _galleryClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", GalleryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GalleryResource.ResourceType, out string galleryApiVersion);
            _galleryRestClient = new GalleriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, galleryApiVersion);
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
        /// Create or update a Shared Image Gallery.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}
        /// Operation Id: Galleries_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery. The allowed characters are alphabets and numbers with dots and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="data"> Parameters supplied to the create or update Shared Image Gallery operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GalleryResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string galleryName, GalleryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryName, nameof(galleryName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _galleryClientDiagnostics.CreateScope("GalleryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _galleryRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, galleryName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<GalleryResource>(new GalleryOperationSource(Client), _galleryClientDiagnostics, Pipeline, _galleryRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, galleryName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a Shared Image Gallery.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}
        /// Operation Id: Galleries_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery. The allowed characters are alphabets and numbers with dots and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="data"> Parameters supplied to the create or update Shared Image Gallery operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GalleryResource> CreateOrUpdate(WaitUntil waitUntil, string galleryName, GalleryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryName, nameof(galleryName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _galleryClientDiagnostics.CreateScope("GalleryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _galleryRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, galleryName, data, cancellationToken);
                var operation = new ComputeArmOperation<GalleryResource>(new GalleryOperationSource(Client), _galleryClientDiagnostics, Pipeline, _galleryRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, galleryName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Retrieves information about a Shared Image Gallery.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}
        /// Operation Id: Galleries_Get
        /// </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. </param>
        /// <param name="select"> The select expression to apply on the operation. </param>
        /// <param name="expand"> The expand query option to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryName"/> is null. </exception>
        public virtual async Task<Response<GalleryResource>> GetAsync(string galleryName, SelectPermissions? select = null, GalleryExpandParams? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryName, nameof(galleryName));

            using var scope = _galleryClientDiagnostics.CreateScope("GalleryCollection.Get");
            scope.Start();
            try
            {
                var response = await _galleryRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, galleryName, select, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about a Shared Image Gallery.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}
        /// Operation Id: Galleries_Get
        /// </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. </param>
        /// <param name="select"> The select expression to apply on the operation. </param>
        /// <param name="expand"> The expand query option to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryName"/> is null. </exception>
        public virtual Response<GalleryResource> Get(string galleryName, SelectPermissions? select = null, GalleryExpandParams? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryName, nameof(galleryName));

            using var scope = _galleryClientDiagnostics.CreateScope("GalleryCollection.Get");
            scope.Start();
            try
            {
                var response = _galleryRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, galleryName, select, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List galleries under a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries
        /// Operation Id: Galleries_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GalleryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GalleryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GalleryResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _galleryClientDiagnostics.CreateScope("GalleryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _galleryRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<GalleryResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _galleryClientDiagnostics.CreateScope("GalleryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _galleryRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List galleries under a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries
        /// Operation Id: Galleries_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GalleryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GalleryResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GalleryResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _galleryClientDiagnostics.CreateScope("GalleryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _galleryRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<GalleryResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _galleryClientDiagnostics.CreateScope("GalleryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _galleryRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}
        /// Operation Id: Galleries_Get
        /// </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. </param>
        /// <param name="select"> The select expression to apply on the operation. </param>
        /// <param name="expand"> The expand query option to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string galleryName, SelectPermissions? select = null, GalleryExpandParams? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryName, nameof(galleryName));

            using var scope = _galleryClientDiagnostics.CreateScope("GalleryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _galleryRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, galleryName, select, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}
        /// Operation Id: Galleries_Get
        /// </summary>
        /// <param name="galleryName"> The name of the Shared Image Gallery. </param>
        /// <param name="select"> The select expression to apply on the operation. </param>
        /// <param name="expand"> The expand query option to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryName"/> is null. </exception>
        public virtual Response<bool> Exists(string galleryName, SelectPermissions? select = null, GalleryExpandParams? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryName, nameof(galleryName));

            using var scope = _galleryClientDiagnostics.CreateScope("GalleryCollection.Exists");
            scope.Start();
            try
            {
                var response = _galleryRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, galleryName, select, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GalleryResource> IEnumerable<GalleryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GalleryResource> IAsyncEnumerable<GalleryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
