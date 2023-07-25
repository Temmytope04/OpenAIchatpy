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

namespace Azure.ResourceManager.Kusto
{
    /// <summary>
    /// A class representing a collection of <see cref="KustoDataConnectionResource" /> and their operations.
    /// Each <see cref="KustoDataConnectionResource" /> in the collection will belong to the same instance of <see cref="KustoDatabaseResource" />.
    /// To get a <see cref="KustoDataConnectionCollection" /> instance call the GetKustoDataConnections method from an instance of <see cref="KustoDatabaseResource" />.
    /// </summary>
    public partial class KustoDataConnectionCollection : ArmCollection, IEnumerable<KustoDataConnectionResource>, IAsyncEnumerable<KustoDataConnectionResource>
    {
        private readonly ClientDiagnostics _kustoDataConnectionDataConnectionsClientDiagnostics;
        private readonly DataConnectionsRestOperations _kustoDataConnectionDataConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="KustoDataConnectionCollection"/> class for mocking. </summary>
        protected KustoDataConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KustoDataConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal KustoDataConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _kustoDataConnectionDataConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Kusto", KustoDataConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(KustoDataConnectionResource.ResourceType, out string kustoDataConnectionDataConnectionsApiVersion);
            _kustoDataConnectionDataConnectionsRestClient = new DataConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, kustoDataConnectionDataConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != KustoDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, KustoDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a data connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/dataConnections/{dataConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataConnections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataConnectionName"> The name of the data connection. </param>
        /// <param name="data"> The data connection parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<KustoDataConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dataConnectionName, KustoDataConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataConnectionName, nameof(dataConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kustoDataConnectionDataConnectionsClientDiagnostics.CreateScope("KustoDataConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _kustoDataConnectionDataConnectionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataConnectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new KustoArmOperation<KustoDataConnectionResource>(new KustoDataConnectionOperationSource(Client), _kustoDataConnectionDataConnectionsClientDiagnostics, Pipeline, _kustoDataConnectionDataConnectionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataConnectionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a data connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/dataConnections/{dataConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataConnections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataConnectionName"> The name of the data connection. </param>
        /// <param name="data"> The data connection parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<KustoDataConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string dataConnectionName, KustoDataConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataConnectionName, nameof(dataConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kustoDataConnectionDataConnectionsClientDiagnostics.CreateScope("KustoDataConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _kustoDataConnectionDataConnectionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataConnectionName, data, cancellationToken);
                var operation = new KustoArmOperation<KustoDataConnectionResource>(new KustoDataConnectionOperationSource(Client), _kustoDataConnectionDataConnectionsClientDiagnostics, Pipeline, _kustoDataConnectionDataConnectionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataConnectionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Returns a data connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/dataConnections/{dataConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataConnectionName"> The name of the data connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataConnectionName"/> is null. </exception>
        public virtual async Task<Response<KustoDataConnectionResource>> GetAsync(string dataConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataConnectionName, nameof(dataConnectionName));

            using var scope = _kustoDataConnectionDataConnectionsClientDiagnostics.CreateScope("KustoDataConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _kustoDataConnectionDataConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KustoDataConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a data connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/dataConnections/{dataConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataConnectionName"> The name of the data connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataConnectionName"/> is null. </exception>
        public virtual Response<KustoDataConnectionResource> Get(string dataConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataConnectionName, nameof(dataConnectionName));

            using var scope = _kustoDataConnectionDataConnectionsClientDiagnostics.CreateScope("KustoDataConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _kustoDataConnectionDataConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KustoDataConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the list of data connections of the given Kusto database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/dataConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataConnections_ListByDatabase</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KustoDataConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<KustoDataConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kustoDataConnectionDataConnectionsRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new KustoDataConnectionResource(Client, KustoDataConnectionData.DeserializeKustoDataConnectionData(e)), _kustoDataConnectionDataConnectionsClientDiagnostics, Pipeline, "KustoDataConnectionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Returns the list of data connections of the given Kusto database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/dataConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataConnections_ListByDatabase</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KustoDataConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<KustoDataConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kustoDataConnectionDataConnectionsRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new KustoDataConnectionResource(Client, KustoDataConnectionData.DeserializeKustoDataConnectionData(e)), _kustoDataConnectionDataConnectionsClientDiagnostics, Pipeline, "KustoDataConnectionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/dataConnections/{dataConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataConnectionName"> The name of the data connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dataConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataConnectionName, nameof(dataConnectionName));

            using var scope = _kustoDataConnectionDataConnectionsClientDiagnostics.CreateScope("KustoDataConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _kustoDataConnectionDataConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/dataConnections/{dataConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataConnectionName"> The name of the data connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataConnectionName, nameof(dataConnectionName));

            using var scope = _kustoDataConnectionDataConnectionsClientDiagnostics.CreateScope("KustoDataConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _kustoDataConnectionDataConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<KustoDataConnectionResource> IEnumerable<KustoDataConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<KustoDataConnectionResource> IAsyncEnumerable<KustoDataConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
