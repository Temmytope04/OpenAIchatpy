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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ServiceFabric
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceFabricApplicationResource" /> and their operations.
    /// Each <see cref="ServiceFabricApplicationResource" /> in the collection will belong to the same instance of <see cref="ServiceFabricClusterResource" />.
    /// To get a <see cref="ServiceFabricApplicationCollection" /> instance call the GetServiceFabricApplications method from an instance of <see cref="ServiceFabricClusterResource" />.
    /// </summary>
    public partial class ServiceFabricApplicationCollection : ArmCollection, IEnumerable<ServiceFabricApplicationResource>, IAsyncEnumerable<ServiceFabricApplicationResource>
    {
        private readonly ClientDiagnostics _serviceFabricApplicationApplicationsClientDiagnostics;
        private readonly ApplicationsRestOperations _serviceFabricApplicationApplicationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceFabricApplicationCollection"/> class for mocking. </summary>
        protected ServiceFabricApplicationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceFabricApplicationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceFabricApplicationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceFabricApplicationApplicationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceFabric", ServiceFabricApplicationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceFabricApplicationResource.ResourceType, out string serviceFabricApplicationApplicationsApiVersion);
            _serviceFabricApplicationApplicationsRestClient = new ApplicationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceFabricApplicationApplicationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceFabricClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceFabricClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Service Fabric application resource with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationName"> The name of the application resource. </param>
        /// <param name="data"> The application resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceFabricApplicationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string applicationName, ServiceFabricApplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceFabricApplicationApplicationsClientDiagnostics.CreateScope("ServiceFabricApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceFabricApplicationApplicationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceFabricArmOperation<ServiceFabricApplicationResource>(new ServiceFabricApplicationOperationSource(Client), _serviceFabricApplicationApplicationsClientDiagnostics, Pipeline, _serviceFabricApplicationApplicationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a Service Fabric application resource with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationName"> The name of the application resource. </param>
        /// <param name="data"> The application resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceFabricApplicationResource> CreateOrUpdate(WaitUntil waitUntil, string applicationName, ServiceFabricApplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceFabricApplicationApplicationsClientDiagnostics.CreateScope("ServiceFabricApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceFabricApplicationApplicationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, data, cancellationToken);
                var operation = new ServiceFabricArmOperation<ServiceFabricApplicationResource>(new ServiceFabricApplicationOperationSource(Client), _serviceFabricApplicationApplicationsClientDiagnostics, Pipeline, _serviceFabricApplicationApplicationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a Service Fabric application resource created or in the process of being created in the Service Fabric cluster resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The name of the application resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual async Task<Response<ServiceFabricApplicationResource>> GetAsync(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _serviceFabricApplicationApplicationsClientDiagnostics.CreateScope("ServiceFabricApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceFabricApplicationApplicationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceFabricApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Service Fabric application resource created or in the process of being created in the Service Fabric cluster resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The name of the application resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual Response<ServiceFabricApplicationResource> Get(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _serviceFabricApplicationApplicationsClientDiagnostics.CreateScope("ServiceFabricApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceFabricApplicationApplicationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceFabricApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all application resources created or in the process of being created in the Service Fabric cluster resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceFabricApplicationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceFabricApplicationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceFabricApplicationApplicationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new ServiceFabricApplicationResource(Client, ServiceFabricApplicationData.DeserializeServiceFabricApplicationData(e)), _serviceFabricApplicationApplicationsClientDiagnostics, Pipeline, "ServiceFabricApplicationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets all application resources created or in the process of being created in the Service Fabric cluster resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceFabricApplicationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceFabricApplicationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceFabricApplicationApplicationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new ServiceFabricApplicationResource(Client, ServiceFabricApplicationData.DeserializeServiceFabricApplicationData(e)), _serviceFabricApplicationApplicationsClientDiagnostics, Pipeline, "ServiceFabricApplicationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The name of the application resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _serviceFabricApplicationApplicationsClientDiagnostics.CreateScope("ServiceFabricApplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceFabricApplicationApplicationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The name of the application resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual Response<bool> Exists(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _serviceFabricApplicationApplicationsClientDiagnostics.CreateScope("ServiceFabricApplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceFabricApplicationApplicationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceFabricApplicationResource> IEnumerable<ServiceFabricApplicationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceFabricApplicationResource> IAsyncEnumerable<ServiceFabricApplicationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
