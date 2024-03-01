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

namespace Azure.ResourceManager.Kusto
{
    /// <summary>
    /// A class representing a collection of <see cref="KustoManagedPrivateEndpointResource"/> and their operations.
    /// Each <see cref="KustoManagedPrivateEndpointResource"/> in the collection will belong to the same instance of <see cref="KustoClusterResource"/>.
    /// To get a <see cref="KustoManagedPrivateEndpointCollection"/> instance call the GetKustoManagedPrivateEndpoints method from an instance of <see cref="KustoClusterResource"/>.
    /// </summary>
    public partial class KustoManagedPrivateEndpointCollection : ArmCollection, IEnumerable<KustoManagedPrivateEndpointResource>, IAsyncEnumerable<KustoManagedPrivateEndpointResource>
    {
        private readonly ClientDiagnostics _kustoManagedPrivateEndpointManagedPrivateEndpointsClientDiagnostics;
        private readonly ManagedPrivateEndpointsRestOperations _kustoManagedPrivateEndpointManagedPrivateEndpointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="KustoManagedPrivateEndpointCollection"/> class for mocking. </summary>
        protected KustoManagedPrivateEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KustoManagedPrivateEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal KustoManagedPrivateEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _kustoManagedPrivateEndpointManagedPrivateEndpointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Kusto", KustoManagedPrivateEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(KustoManagedPrivateEndpointResource.ResourceType, out string kustoManagedPrivateEndpointManagedPrivateEndpointsApiVersion);
            _kustoManagedPrivateEndpointManagedPrivateEndpointsRestClient = new ManagedPrivateEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, kustoManagedPrivateEndpointManagedPrivateEndpointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != KustoClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, KustoClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a managed private endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/managedPrivateEndpoints/{managedPrivateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedPrivateEndpoints_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoManagedPrivateEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="managedPrivateEndpointName"> The name of the managed private endpoint. </param>
        /// <param name="data"> The managed private endpoint parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<KustoManagedPrivateEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string managedPrivateEndpointName, KustoManagedPrivateEndpointData data, CancellationToken cancellationToken = default)
        {
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }
            if (managedPrivateEndpointName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedPrivateEndpointName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _kustoManagedPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("KustoManagedPrivateEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _kustoManagedPrivateEndpointManagedPrivateEndpointsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedPrivateEndpointName, data, cancellationToken).ConfigureAwait(false);
                var operation = new KustoArmOperation<KustoManagedPrivateEndpointResource>(new KustoManagedPrivateEndpointOperationSource(Client), _kustoManagedPrivateEndpointManagedPrivateEndpointsClientDiagnostics, Pipeline, _kustoManagedPrivateEndpointManagedPrivateEndpointsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedPrivateEndpointName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a managed private endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/managedPrivateEndpoints/{managedPrivateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedPrivateEndpoints_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoManagedPrivateEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="managedPrivateEndpointName"> The name of the managed private endpoint. </param>
        /// <param name="data"> The managed private endpoint parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<KustoManagedPrivateEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string managedPrivateEndpointName, KustoManagedPrivateEndpointData data, CancellationToken cancellationToken = default)
        {
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }
            if (managedPrivateEndpointName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedPrivateEndpointName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _kustoManagedPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("KustoManagedPrivateEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _kustoManagedPrivateEndpointManagedPrivateEndpointsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedPrivateEndpointName, data, cancellationToken);
                var operation = new KustoArmOperation<KustoManagedPrivateEndpointResource>(new KustoManagedPrivateEndpointOperationSource(Client), _kustoManagedPrivateEndpointManagedPrivateEndpointsClientDiagnostics, Pipeline, _kustoManagedPrivateEndpointManagedPrivateEndpointsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedPrivateEndpointName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a managed private endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/managedPrivateEndpoints/{managedPrivateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedPrivateEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoManagedPrivateEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedPrivateEndpointName"> The name of the managed private endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> is null. </exception>
        public virtual async Task<Response<KustoManagedPrivateEndpointResource>> GetAsync(string managedPrivateEndpointName, CancellationToken cancellationToken = default)
        {
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }
            if (managedPrivateEndpointName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedPrivateEndpointName));
            }

            using var scope = _kustoManagedPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("KustoManagedPrivateEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _kustoManagedPrivateEndpointManagedPrivateEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedPrivateEndpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KustoManagedPrivateEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed private endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/managedPrivateEndpoints/{managedPrivateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedPrivateEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoManagedPrivateEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedPrivateEndpointName"> The name of the managed private endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> is null. </exception>
        public virtual Response<KustoManagedPrivateEndpointResource> Get(string managedPrivateEndpointName, CancellationToken cancellationToken = default)
        {
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }
            if (managedPrivateEndpointName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedPrivateEndpointName));
            }

            using var scope = _kustoManagedPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("KustoManagedPrivateEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _kustoManagedPrivateEndpointManagedPrivateEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedPrivateEndpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KustoManagedPrivateEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the list of managed private endpoints.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/managedPrivateEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedPrivateEndpoints_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoManagedPrivateEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KustoManagedPrivateEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<KustoManagedPrivateEndpointResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kustoManagedPrivateEndpointManagedPrivateEndpointsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new KustoManagedPrivateEndpointResource(Client, KustoManagedPrivateEndpointData.DeserializeKustoManagedPrivateEndpointData(e)), _kustoManagedPrivateEndpointManagedPrivateEndpointsClientDiagnostics, Pipeline, "KustoManagedPrivateEndpointCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Returns the list of managed private endpoints.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/managedPrivateEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedPrivateEndpoints_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoManagedPrivateEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KustoManagedPrivateEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<KustoManagedPrivateEndpointResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kustoManagedPrivateEndpointManagedPrivateEndpointsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new KustoManagedPrivateEndpointResource(Client, KustoManagedPrivateEndpointData.DeserializeKustoManagedPrivateEndpointData(e)), _kustoManagedPrivateEndpointManagedPrivateEndpointsClientDiagnostics, Pipeline, "KustoManagedPrivateEndpointCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/managedPrivateEndpoints/{managedPrivateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedPrivateEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoManagedPrivateEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedPrivateEndpointName"> The name of the managed private endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string managedPrivateEndpointName, CancellationToken cancellationToken = default)
        {
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }
            if (managedPrivateEndpointName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedPrivateEndpointName));
            }

            using var scope = _kustoManagedPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("KustoManagedPrivateEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _kustoManagedPrivateEndpointManagedPrivateEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedPrivateEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/managedPrivateEndpoints/{managedPrivateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedPrivateEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoManagedPrivateEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedPrivateEndpointName"> The name of the managed private endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string managedPrivateEndpointName, CancellationToken cancellationToken = default)
        {
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }
            if (managedPrivateEndpointName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedPrivateEndpointName));
            }

            using var scope = _kustoManagedPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("KustoManagedPrivateEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _kustoManagedPrivateEndpointManagedPrivateEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedPrivateEndpointName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/managedPrivateEndpoints/{managedPrivateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedPrivateEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoManagedPrivateEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedPrivateEndpointName"> The name of the managed private endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> is null. </exception>
        public virtual async Task<NullableResponse<KustoManagedPrivateEndpointResource>> GetIfExistsAsync(string managedPrivateEndpointName, CancellationToken cancellationToken = default)
        {
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }
            if (managedPrivateEndpointName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedPrivateEndpointName));
            }

            using var scope = _kustoManagedPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("KustoManagedPrivateEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _kustoManagedPrivateEndpointManagedPrivateEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedPrivateEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<KustoManagedPrivateEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new KustoManagedPrivateEndpointResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/managedPrivateEndpoints/{managedPrivateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedPrivateEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoManagedPrivateEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedPrivateEndpointName"> The name of the managed private endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> is null. </exception>
        public virtual NullableResponse<KustoManagedPrivateEndpointResource> GetIfExists(string managedPrivateEndpointName, CancellationToken cancellationToken = default)
        {
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }
            if (managedPrivateEndpointName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedPrivateEndpointName));
            }

            using var scope = _kustoManagedPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("KustoManagedPrivateEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _kustoManagedPrivateEndpointManagedPrivateEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedPrivateEndpointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<KustoManagedPrivateEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new KustoManagedPrivateEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<KustoManagedPrivateEndpointResource> IEnumerable<KustoManagedPrivateEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<KustoManagedPrivateEndpointResource> IAsyncEnumerable<KustoManagedPrivateEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
