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

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    /// <summary>
    /// A class representing a collection of <see cref="ApplicationTypeResource" /> and their operations.
    /// Each <see cref="ApplicationTypeResource" /> in the collection will belong to the same instance of <see cref="ManagedClusterResource" />.
    /// To get an <see cref="ApplicationTypeResourceCollection" /> instance call the GetApplicationTypeResources method from an instance of <see cref="ManagedClusterResource" />.
    /// </summary>
    public partial class ApplicationTypeResourceCollection : ArmCollection, IEnumerable<ApplicationTypeResource>, IAsyncEnumerable<ApplicationTypeResource>
    {
        private readonly ClientDiagnostics _applicationTypeResourceApplicationTypesClientDiagnostics;
        private readonly ApplicationTypesRestOperations _applicationTypeResourceApplicationTypesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApplicationTypeResourceCollection"/> class for mocking. </summary>
        protected ApplicationTypeResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApplicationTypeResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApplicationTypeResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _applicationTypeResourceApplicationTypesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceFabricManagedClusters", ApplicationTypeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApplicationTypeResource.ResourceType, out string applicationTypeResourceApplicationTypesApiVersion);
            _applicationTypeResourceApplicationTypesRestClient = new ApplicationTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, applicationTypeResourceApplicationTypesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Service Fabric managed application type name resource with the specified name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}
        /// Operation Id: ApplicationTypes_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="data"> The application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationTypeName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApplicationTypeResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string applicationTypeName, ApplicationTypeResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _applicationTypeResourceApplicationTypesClientDiagnostics.CreateScope("ApplicationTypeResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _applicationTypeResourceApplicationTypesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationTypeName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceFabricManagedClustersArmOperation<ApplicationTypeResource>(Response.FromValue(new ApplicationTypeResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a Service Fabric managed application type name resource with the specified name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}
        /// Operation Id: ApplicationTypes_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="data"> The application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationTypeName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApplicationTypeResource> CreateOrUpdate(WaitUntil waitUntil, string applicationTypeName, ApplicationTypeResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _applicationTypeResourceApplicationTypesClientDiagnostics.CreateScope("ApplicationTypeResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _applicationTypeResourceApplicationTypesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationTypeName, data, cancellationToken);
                var operation = new ServiceFabricManagedClustersArmOperation<ApplicationTypeResource>(Response.FromValue(new ApplicationTypeResource(Client, response), response.GetRawResponse()));
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
        /// Get a Service Fabric application type name resource created or in the process of being created in the Service Fabric managed cluster resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}
        /// Operation Id: ApplicationTypes_Get
        /// </summary>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationTypeName"/> is null. </exception>
        public virtual async Task<Response<ApplicationTypeResource>> GetAsync(string applicationTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));

            using var scope = _applicationTypeResourceApplicationTypesClientDiagnostics.CreateScope("ApplicationTypeResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _applicationTypeResourceApplicationTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationTypeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApplicationTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Service Fabric application type name resource created or in the process of being created in the Service Fabric managed cluster resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}
        /// Operation Id: ApplicationTypes_Get
        /// </summary>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationTypeName"/> is null. </exception>
        public virtual Response<ApplicationTypeResource> Get(string applicationTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));

            using var scope = _applicationTypeResourceApplicationTypesClientDiagnostics.CreateScope("ApplicationTypeResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _applicationTypeResourceApplicationTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationTypeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApplicationTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all application type name resources created or in the process of being created in the Service Fabric managed cluster resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes
        /// Operation Id: ApplicationTypes_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApplicationTypeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApplicationTypeResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ApplicationTypeResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _applicationTypeResourceApplicationTypesClientDiagnostics.CreateScope("ApplicationTypeResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _applicationTypeResourceApplicationTypesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationTypeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApplicationTypeResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _applicationTypeResourceApplicationTypesClientDiagnostics.CreateScope("ApplicationTypeResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _applicationTypeResourceApplicationTypesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationTypeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all application type name resources created or in the process of being created in the Service Fabric managed cluster resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes
        /// Operation Id: ApplicationTypes_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApplicationTypeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApplicationTypeResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ApplicationTypeResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _applicationTypeResourceApplicationTypesClientDiagnostics.CreateScope("ApplicationTypeResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _applicationTypeResourceApplicationTypesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationTypeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApplicationTypeResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _applicationTypeResourceApplicationTypesClientDiagnostics.CreateScope("ApplicationTypeResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _applicationTypeResourceApplicationTypesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationTypeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}
        /// Operation Id: ApplicationTypes_Get
        /// </summary>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationTypeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string applicationTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));

            using var scope = _applicationTypeResourceApplicationTypesClientDiagnostics.CreateScope("ApplicationTypeResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _applicationTypeResourceApplicationTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}
        /// Operation Id: ApplicationTypes_Get
        /// </summary>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationTypeName"/> is null. </exception>
        public virtual Response<bool> Exists(string applicationTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));

            using var scope = _applicationTypeResourceApplicationTypesClientDiagnostics.CreateScope("ApplicationTypeResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _applicationTypeResourceApplicationTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationTypeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApplicationTypeResource> IEnumerable<ApplicationTypeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApplicationTypeResource> IAsyncEnumerable<ApplicationTypeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
