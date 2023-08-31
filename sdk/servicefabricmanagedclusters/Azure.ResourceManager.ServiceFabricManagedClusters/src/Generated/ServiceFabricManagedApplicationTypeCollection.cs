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

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceFabricManagedApplicationTypeResource" /> and their operations.
    /// Each <see cref="ServiceFabricManagedApplicationTypeResource" /> in the collection will belong to the same instance of <see cref="ServiceFabricManagedClusterResource" />.
    /// To get a <see cref="ServiceFabricManagedApplicationTypeCollection" /> instance call the GetServiceFabricManagedApplicationTypes method from an instance of <see cref="ServiceFabricManagedClusterResource" />.
    /// </summary>
    public partial class ServiceFabricManagedApplicationTypeCollection : ArmCollection, IEnumerable<ServiceFabricManagedApplicationTypeResource>, IAsyncEnumerable<ServiceFabricManagedApplicationTypeResource>
    {
        private readonly ClientDiagnostics _serviceFabricManagedApplicationTypeApplicationTypesClientDiagnostics;
        private readonly ApplicationTypesRestOperations _serviceFabricManagedApplicationTypeApplicationTypesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceFabricManagedApplicationTypeCollection"/> class for mocking. </summary>
        protected ServiceFabricManagedApplicationTypeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceFabricManagedApplicationTypeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceFabricManagedApplicationTypeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceFabricManagedApplicationTypeApplicationTypesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceFabricManagedClusters", ServiceFabricManagedApplicationTypeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceFabricManagedApplicationTypeResource.ResourceType, out string serviceFabricManagedApplicationTypeApplicationTypesApiVersion);
            _serviceFabricManagedApplicationTypeApplicationTypesRestClient = new ApplicationTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceFabricManagedApplicationTypeApplicationTypesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceFabricManagedClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceFabricManagedClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Service Fabric managed application type name resource with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="data"> The application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationTypeName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceFabricManagedApplicationTypeResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string applicationTypeName, ServiceFabricManagedApplicationTypeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceFabricManagedApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricManagedApplicationTypeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceFabricManagedApplicationTypeApplicationTypesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationTypeName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceFabricManagedClustersArmOperation<ServiceFabricManagedApplicationTypeResource>(Response.FromValue(new ServiceFabricManagedApplicationTypeResource(Client, response), response.GetRawResponse()));
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="data"> The application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationTypeName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceFabricManagedApplicationTypeResource> CreateOrUpdate(WaitUntil waitUntil, string applicationTypeName, ServiceFabricManagedApplicationTypeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceFabricManagedApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricManagedApplicationTypeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceFabricManagedApplicationTypeApplicationTypesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationTypeName, data, cancellationToken);
                var operation = new ServiceFabricManagedClustersArmOperation<ServiceFabricManagedApplicationTypeResource>(Response.FromValue(new ServiceFabricManagedApplicationTypeResource(Client, response), response.GetRawResponse()));
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationTypeName"/> is null. </exception>
        public virtual async Task<Response<ServiceFabricManagedApplicationTypeResource>> GetAsync(string applicationTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));

            using var scope = _serviceFabricManagedApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricManagedApplicationTypeCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceFabricManagedApplicationTypeApplicationTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationTypeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceFabricManagedApplicationTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Service Fabric application type name resource created or in the process of being created in the Service Fabric managed cluster resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationTypeName"/> is null. </exception>
        public virtual Response<ServiceFabricManagedApplicationTypeResource> Get(string applicationTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));

            using var scope = _serviceFabricManagedApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricManagedApplicationTypeCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceFabricManagedApplicationTypeApplicationTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationTypeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceFabricManagedApplicationTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all application type name resources created or in the process of being created in the Service Fabric managed cluster resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceFabricManagedApplicationTypeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceFabricManagedApplicationTypeResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceFabricManagedApplicationTypeApplicationTypesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceFabricManagedApplicationTypeApplicationTypesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ServiceFabricManagedApplicationTypeResource(Client, ServiceFabricManagedApplicationTypeData.DeserializeServiceFabricManagedApplicationTypeData(e)), _serviceFabricManagedApplicationTypeApplicationTypesClientDiagnostics, Pipeline, "ServiceFabricManagedApplicationTypeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all application type name resources created or in the process of being created in the Service Fabric managed cluster resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceFabricManagedApplicationTypeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceFabricManagedApplicationTypeResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceFabricManagedApplicationTypeApplicationTypesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceFabricManagedApplicationTypeApplicationTypesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ServiceFabricManagedApplicationTypeResource(Client, ServiceFabricManagedApplicationTypeData.DeserializeServiceFabricManagedApplicationTypeData(e)), _serviceFabricManagedApplicationTypeApplicationTypesClientDiagnostics, Pipeline, "ServiceFabricManagedApplicationTypeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationTypeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string applicationTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));

            using var scope = _serviceFabricManagedApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricManagedApplicationTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceFabricManagedApplicationTypeApplicationTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationTypeName"/> is null. </exception>
        public virtual Response<bool> Exists(string applicationTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));

            using var scope = _serviceFabricManagedApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricManagedApplicationTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceFabricManagedApplicationTypeApplicationTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationTypeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceFabricManagedApplicationTypeResource> IEnumerable<ServiceFabricManagedApplicationTypeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceFabricManagedApplicationTypeResource> IAsyncEnumerable<ServiceFabricManagedApplicationTypeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
