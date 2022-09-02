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

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerResource" /> and their operations.
    /// Each <see cref="ContainerResource" /> in the collection will belong to the same instance of <see cref="StorageAccountResource" />.
    /// To get a <see cref="ContainerCollection" /> instance call the GetContainers method from an instance of <see cref="StorageAccountResource" />.
    /// </summary>
    public partial class ContainerCollection : ArmCollection, IEnumerable<ContainerResource>, IAsyncEnumerable<ContainerResource>
    {
        private readonly ClientDiagnostics _containerClientDiagnostics;
        private readonly ContainersRestOperations _containerRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerCollection"/> class for mocking. </summary>
        protected ContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataBoxEdge", ContainerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerResource.ResourceType, out string containerApiVersion);
            _containerRestClient = new ContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StorageAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StorageAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new container or updates an existing container on the device.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccounts/{storageAccountName}/containers/{containerName}
        /// Operation Id: Containers_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="containerName"> The container name. </param>
        /// <param name="data"> The container properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string containerName, ContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerClientDiagnostics.CreateScope("ContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataBoxEdgeArmOperation<ContainerResource>(new ContainerOperationSource(Client), _containerClientDiagnostics, Pipeline, _containerRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a new container or updates an existing container on the device.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccounts/{storageAccountName}/containers/{containerName}
        /// Operation Id: Containers_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="containerName"> The container name. </param>
        /// <param name="data"> The container properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerResource> CreateOrUpdate(WaitUntil waitUntil, string containerName, ContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerClientDiagnostics.CreateScope("ContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, data, cancellationToken);
                var operation = new DataBoxEdgeArmOperation<ContainerResource>(new ContainerOperationSource(Client), _containerClientDiagnostics, Pipeline, _containerRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a container by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccounts/{storageAccountName}/containers/{containerName}
        /// Operation Id: Containers_Get
        /// </summary>
        /// <param name="containerName"> The container Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual async Task<Response<ContainerResource>> GetAsync(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _containerClientDiagnostics.CreateScope("ContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a container by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccounts/{storageAccountName}/containers/{containerName}
        /// Operation Id: Containers_Get
        /// </summary>
        /// <param name="containerName"> The container Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual Response<ContainerResource> Get(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _containerClientDiagnostics.CreateScope("ContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _containerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the containers of a storage Account in a Data Box Edge/Data Box Gateway device.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccounts/{storageAccountName}/containers
        /// Operation Id: Containers_ListByStorageAccount
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ContainerResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _containerClientDiagnostics.CreateScope("ContainerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _containerRestClient.ListByStorageAccountAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ContainerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ContainerResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _containerClientDiagnostics.CreateScope("ContainerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _containerRestClient.ListByStorageAccountNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ContainerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all the containers of a storage Account in a Data Box Edge/Data Box Gateway device.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccounts/{storageAccountName}/containers
        /// Operation Id: Containers_ListByStorageAccount
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ContainerResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _containerClientDiagnostics.CreateScope("ContainerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _containerRestClient.ListByStorageAccount(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ContainerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ContainerResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _containerClientDiagnostics.CreateScope("ContainerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _containerRestClient.ListByStorageAccountNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ContainerResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccounts/{storageAccountName}/containers/{containerName}
        /// Operation Id: Containers_Get
        /// </summary>
        /// <param name="containerName"> The container Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _containerClientDiagnostics.CreateScope("ContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccounts/{storageAccountName}/containers/{containerName}
        /// Operation Id: Containers_Get
        /// </summary>
        /// <param name="containerName"> The container Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual Response<bool> Exists(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _containerClientDiagnostics.CreateScope("ContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerResource> IEnumerable<ContainerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerResource> IAsyncEnumerable<ContainerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
