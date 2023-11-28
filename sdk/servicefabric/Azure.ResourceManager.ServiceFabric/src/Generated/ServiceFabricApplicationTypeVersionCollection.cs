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

namespace Azure.ResourceManager.ServiceFabric
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceFabricApplicationTypeVersionResource"/> and their operations.
    /// Each <see cref="ServiceFabricApplicationTypeVersionResource"/> in the collection will belong to the same instance of <see cref="ServiceFabricApplicationTypeResource"/>.
    /// To get a <see cref="ServiceFabricApplicationTypeVersionCollection"/> instance call the GetServiceFabricApplicationTypeVersions method from an instance of <see cref="ServiceFabricApplicationTypeResource"/>.
    /// </summary>
    public partial class ServiceFabricApplicationTypeVersionCollection : ArmCollection, IEnumerable<ServiceFabricApplicationTypeVersionResource>, IAsyncEnumerable<ServiceFabricApplicationTypeVersionResource>
    {
        private readonly ClientDiagnostics _serviceFabricApplicationTypeVersionApplicationTypeVersionsClientDiagnostics;
        private readonly ApplicationTypeVersionsRestOperations _serviceFabricApplicationTypeVersionApplicationTypeVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceFabricApplicationTypeVersionCollection"/> class for mocking. </summary>
        protected ServiceFabricApplicationTypeVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceFabricApplicationTypeVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceFabricApplicationTypeVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceFabricApplicationTypeVersionApplicationTypeVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceFabric", ServiceFabricApplicationTypeVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceFabricApplicationTypeVersionResource.ResourceType, out string serviceFabricApplicationTypeVersionApplicationTypeVersionsApiVersion);
            _serviceFabricApplicationTypeVersionApplicationTypeVersionsRestClient = new ApplicationTypeVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceFabricApplicationTypeVersionApplicationTypeVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceFabricApplicationTypeResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceFabricApplicationTypeResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Service Fabric application type version resource with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="version"> The application type version. </param>
        /// <param name="data"> The application type version resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceFabricApplicationTypeVersionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string version, ServiceFabricApplicationTypeVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceFabricApplicationTypeVersionApplicationTypeVersionsClientDiagnostics.CreateScope("ServiceFabricApplicationTypeVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceFabricApplicationTypeVersionApplicationTypeVersionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceFabricArmOperation<ServiceFabricApplicationTypeVersionResource>(new ServiceFabricApplicationTypeVersionOperationSource(Client), _serviceFabricApplicationTypeVersionApplicationTypeVersionsClientDiagnostics, Pipeline, _serviceFabricApplicationTypeVersionApplicationTypeVersionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a Service Fabric application type version resource with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="version"> The application type version. </param>
        /// <param name="data"> The application type version resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceFabricApplicationTypeVersionResource> CreateOrUpdate(WaitUntil waitUntil, string version, ServiceFabricApplicationTypeVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceFabricApplicationTypeVersionApplicationTypeVersionsClientDiagnostics.CreateScope("ServiceFabricApplicationTypeVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceFabricApplicationTypeVersionApplicationTypeVersionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data, cancellationToken);
                var operation = new ServiceFabricArmOperation<ServiceFabricApplicationTypeVersionResource>(new ServiceFabricApplicationTypeVersionOperationSource(Client), _serviceFabricApplicationTypeVersionApplicationTypeVersionsClientDiagnostics, Pipeline, _serviceFabricApplicationTypeVersionApplicationTypeVersionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a Service Fabric application type version resource created or in the process of being created in the Service Fabric application type name resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> The application type version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<ServiceFabricApplicationTypeVersionResource>> GetAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _serviceFabricApplicationTypeVersionApplicationTypeVersionsClientDiagnostics.CreateScope("ServiceFabricApplicationTypeVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceFabricApplicationTypeVersionApplicationTypeVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceFabricApplicationTypeVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Service Fabric application type version resource created or in the process of being created in the Service Fabric application type name resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> The application type version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<ServiceFabricApplicationTypeVersionResource> Get(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _serviceFabricApplicationTypeVersionApplicationTypeVersionsClientDiagnostics.CreateScope("ServiceFabricApplicationTypeVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceFabricApplicationTypeVersionApplicationTypeVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceFabricApplicationTypeVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all application type version resources created or in the process of being created in the Service Fabric application type name resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceFabricApplicationTypeVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceFabricApplicationTypeVersionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceFabricApplicationTypeVersionApplicationTypeVersionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new ServiceFabricApplicationTypeVersionResource(Client, ServiceFabricApplicationTypeVersionData.DeserializeServiceFabricApplicationTypeVersionData(e)), _serviceFabricApplicationTypeVersionApplicationTypeVersionsClientDiagnostics, Pipeline, "ServiceFabricApplicationTypeVersionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets all application type version resources created or in the process of being created in the Service Fabric application type name resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceFabricApplicationTypeVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceFabricApplicationTypeVersionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceFabricApplicationTypeVersionApplicationTypeVersionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new ServiceFabricApplicationTypeVersionResource(Client, ServiceFabricApplicationTypeVersionData.DeserializeServiceFabricApplicationTypeVersionData(e)), _serviceFabricApplicationTypeVersionApplicationTypeVersionsClientDiagnostics, Pipeline, "ServiceFabricApplicationTypeVersionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> The application type version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _serviceFabricApplicationTypeVersionApplicationTypeVersionsClientDiagnostics.CreateScope("ServiceFabricApplicationTypeVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceFabricApplicationTypeVersionApplicationTypeVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> The application type version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<bool> Exists(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _serviceFabricApplicationTypeVersionApplicationTypeVersionsClientDiagnostics.CreateScope("ServiceFabricApplicationTypeVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceFabricApplicationTypeVersionApplicationTypeVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> The application type version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<NullableResponse<ServiceFabricApplicationTypeVersionResource>> GetIfExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _serviceFabricApplicationTypeVersionApplicationTypeVersionsClientDiagnostics.CreateScope("ServiceFabricApplicationTypeVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceFabricApplicationTypeVersionApplicationTypeVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceFabricApplicationTypeVersionResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceFabricApplicationTypeVersionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> The application type version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual NullableResponse<ServiceFabricApplicationTypeVersionResource> GetIfExists(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _serviceFabricApplicationTypeVersionApplicationTypeVersionsClientDiagnostics.CreateScope("ServiceFabricApplicationTypeVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceFabricApplicationTypeVersionApplicationTypeVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceFabricApplicationTypeVersionResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceFabricApplicationTypeVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceFabricApplicationTypeVersionResource> IEnumerable<ServiceFabricApplicationTypeVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceFabricApplicationTypeVersionResource> IAsyncEnumerable<ServiceFabricApplicationTypeVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
