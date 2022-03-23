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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class representing collection of VMwareCluster and their operations over its parent. </summary>
    public partial class VMwareClusterCollection : ArmCollection, IEnumerable<VMwareClusterResource>, IAsyncEnumerable<VMwareClusterResource>
    {
        private readonly ClientDiagnostics _vMwareClusterClustersClientDiagnostics;
        private readonly ClustersRestOperations _vMwareClusterClustersRestClient;

        /// <summary> Initializes a new instance of the <see cref="VMwareClusterCollection"/> class for mocking. </summary>
        protected VMwareClusterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VMwareClusterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VMwareClusterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vMwareClusterClustersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", VMwareClusterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VMwareClusterResource.ResourceType, out string vMwareClusterClustersApiVersion);
            _vMwareClusterClustersRestClient = new ClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vMwareClusterClustersApiVersion);
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
        /// Create Or Update cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters/{clusterName}
        /// Operation Id: Clusters_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual async Task<ArmOperation<VMwareClusterResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string clusterName, VMwareClusterData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _vMwareClusterClustersClientDiagnostics.CreateScope("VMwareClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vMwareClusterClustersRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, body, cancellationToken).ConfigureAwait(false);
                var operation = new ConnectedVMwarevSphereArmOperation<VMwareClusterResource>(new VMwareClusterOperationSource(Client), _vMwareClusterClustersClientDiagnostics, Pipeline, _vMwareClusterClustersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, clusterName, body).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create Or Update cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters/{clusterName}
        /// Operation Id: Clusters_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual ArmOperation<VMwareClusterResource> CreateOrUpdate(WaitUntil waitUntil, string clusterName, VMwareClusterData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _vMwareClusterClustersClientDiagnostics.CreateScope("VMwareClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vMwareClusterClustersRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, clusterName, body, cancellationToken);
                var operation = new ConnectedVMwarevSphereArmOperation<VMwareClusterResource>(new VMwareClusterOperationSource(Client), _vMwareClusterClustersClientDiagnostics, Pipeline, _vMwareClusterClustersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, clusterName, body).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements cluster GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual async Task<Response<VMwareClusterResource>> GetAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _vMwareClusterClustersClientDiagnostics.CreateScope("VMwareClusterCollection.Get");
            scope.Start();
            try
            {
                var response = await _vMwareClusterClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VMwareClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements cluster GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual Response<VMwareClusterResource> Get(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _vMwareClusterClustersClientDiagnostics.CreateScope("VMwareClusterCollection.Get");
            scope.Start();
            try
            {
                var response = _vMwareClusterClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VMwareClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of clusters in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters
        /// Operation Id: Clusters_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VMwareClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VMwareClusterResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VMwareClusterResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vMwareClusterClustersClientDiagnostics.CreateScope("VMwareClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vMwareClusterClustersRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VMwareClusterResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VMwareClusterResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vMwareClusterClustersClientDiagnostics.CreateScope("VMwareClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vMwareClusterClustersRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VMwareClusterResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List of clusters in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters
        /// Operation Id: Clusters_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VMwareClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VMwareClusterResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VMwareClusterResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vMwareClusterClustersClientDiagnostics.CreateScope("VMwareClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vMwareClusterClustersRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VMwareClusterResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VMwareClusterResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vMwareClusterClustersClientDiagnostics.CreateScope("VMwareClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vMwareClusterClustersRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VMwareClusterResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _vMwareClusterClustersClientDiagnostics.CreateScope("VMwareClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(clusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual Response<bool> Exists(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _vMwareClusterClustersClientDiagnostics.CreateScope("VMwareClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(clusterName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual async Task<Response<VMwareClusterResource>> GetIfExistsAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _vMwareClusterClustersClientDiagnostics.CreateScope("VMwareClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _vMwareClusterClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VMwareClusterResource>(null, response.GetRawResponse());
                return Response.FromValue(new VMwareClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual Response<VMwareClusterResource> GetIfExists(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _vMwareClusterClustersClientDiagnostics.CreateScope("VMwareClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _vMwareClusterClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VMwareClusterResource>(null, response.GetRawResponse());
                return Response.FromValue(new VMwareClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VMwareClusterResource> IEnumerable<VMwareClusterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VMwareClusterResource> IAsyncEnumerable<VMwareClusterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
