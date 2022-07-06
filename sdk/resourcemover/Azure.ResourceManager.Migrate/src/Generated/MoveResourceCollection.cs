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

namespace Azure.ResourceManager.Migrate
{
    /// <summary>
    /// A class representing a collection of <see cref="MoveResource" /> and their operations.
    /// Each <see cref="MoveResource" /> in the collection will belong to the same instance of <see cref="MoveCollectionResource" />.
    /// To get a <see cref="MoveResourceCollection" /> instance call the GetMoveResources method from an instance of <see cref="MoveCollectionResource" />.
    /// </summary>
    public partial class MoveResourceCollection : ArmCollection, IEnumerable<MoveResource>, IAsyncEnumerable<MoveResource>
    {
        private readonly ClientDiagnostics _moveResourceClientDiagnostics;
        private readonly MoveResourcesRestOperations _moveResourceRestClient;

        /// <summary> Initializes a new instance of the <see cref="MoveResourceCollection"/> class for mocking. </summary>
        protected MoveResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MoveResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MoveResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _moveResourceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Migrate", MoveResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MoveResource.ResourceType, out string moveResourceApiVersion);
            _moveResourceRestClient = new MoveResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, moveResourceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MoveCollectionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MoveCollectionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a Move Resource in the move collection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}/moveResources/{moveResourceName}
        /// Operation Id: MoveResources_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="moveResourceName"> The Move Resource Name. </param>
        /// <param name="data"> The MoveResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moveResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moveResourceName"/> is null. </exception>
        public virtual async Task<ArmOperation<MoveResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string moveResourceName, MoveResourceData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moveResourceName, nameof(moveResourceName));

            using var scope = _moveResourceClientDiagnostics.CreateScope("MoveResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _moveResourceRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moveResourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MigrateArmOperation<MoveResource>(new MoveResourceOperationSource(Client), _moveResourceClientDiagnostics, Pipeline, _moveResourceRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moveResourceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a Move Resource in the move collection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}/moveResources/{moveResourceName}
        /// Operation Id: MoveResources_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="moveResourceName"> The Move Resource Name. </param>
        /// <param name="data"> The MoveResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moveResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moveResourceName"/> is null. </exception>
        public virtual ArmOperation<MoveResource> CreateOrUpdate(WaitUntil waitUntil, string moveResourceName, MoveResourceData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moveResourceName, nameof(moveResourceName));

            using var scope = _moveResourceClientDiagnostics.CreateScope("MoveResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _moveResourceRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moveResourceName, data, cancellationToken);
                var operation = new MigrateArmOperation<MoveResource>(new MoveResourceOperationSource(Client), _moveResourceClientDiagnostics, Pipeline, _moveResourceRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moveResourceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the Move Resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}/moveResources/{moveResourceName}
        /// Operation Id: MoveResources_Get
        /// </summary>
        /// <param name="moveResourceName"> The Move Resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moveResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moveResourceName"/> is null. </exception>
        public virtual async Task<Response<MoveResource>> GetAsync(string moveResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moveResourceName, nameof(moveResourceName));

            using var scope = _moveResourceClientDiagnostics.CreateScope("MoveResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _moveResourceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moveResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MoveResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Move Resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}/moveResources/{moveResourceName}
        /// Operation Id: MoveResources_Get
        /// </summary>
        /// <param name="moveResourceName"> The Move Resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moveResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moveResourceName"/> is null. </exception>
        public virtual Response<MoveResource> Get(string moveResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moveResourceName, nameof(moveResourceName));

            using var scope = _moveResourceClientDiagnostics.CreateScope("MoveResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _moveResourceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moveResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MoveResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Move Resources in the move collection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}/moveResources
        /// Operation Id: MoveResources_List
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For example, you can use $filter=Properties/ProvisioningState eq &apos;Succeeded&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MoveResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MoveResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<MoveResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _moveResourceClientDiagnostics.CreateScope("MoveResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _moveResourceRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MoveResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MoveResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _moveResourceClientDiagnostics.CreateScope("MoveResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _moveResourceRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MoveResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists the Move Resources in the move collection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}/moveResources
        /// Operation Id: MoveResources_List
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For example, you can use $filter=Properties/ProvisioningState eq &apos;Succeeded&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MoveResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MoveResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<MoveResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _moveResourceClientDiagnostics.CreateScope("MoveResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _moveResourceRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MoveResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MoveResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _moveResourceClientDiagnostics.CreateScope("MoveResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _moveResourceRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MoveResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}/moveResources/{moveResourceName}
        /// Operation Id: MoveResources_Get
        /// </summary>
        /// <param name="moveResourceName"> The Move Resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moveResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moveResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string moveResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moveResourceName, nameof(moveResourceName));

            using var scope = _moveResourceClientDiagnostics.CreateScope("MoveResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _moveResourceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moveResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}/moveResources/{moveResourceName}
        /// Operation Id: MoveResources_Get
        /// </summary>
        /// <param name="moveResourceName"> The Move Resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moveResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moveResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string moveResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moveResourceName, nameof(moveResourceName));

            using var scope = _moveResourceClientDiagnostics.CreateScope("MoveResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _moveResourceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moveResourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MoveResource> IEnumerable<MoveResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MoveResource> IAsyncEnumerable<MoveResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
