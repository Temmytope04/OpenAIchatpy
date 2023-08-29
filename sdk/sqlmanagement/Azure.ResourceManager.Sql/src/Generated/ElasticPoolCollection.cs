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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ElasticPoolResource" /> and their operations.
    /// Each <see cref="ElasticPoolResource" /> in the collection will belong to the same instance of <see cref="SqlServerResource" />.
    /// To get an <see cref="ElasticPoolCollection" /> instance call the GetElasticPools method from an instance of <see cref="SqlServerResource" />.
    /// </summary>
    public partial class ElasticPoolCollection : ArmCollection, IEnumerable<ElasticPoolResource>, IAsyncEnumerable<ElasticPoolResource>
    {
        private readonly ClientDiagnostics _elasticPoolClientDiagnostics;
        private readonly ElasticPoolsRestOperations _elasticPoolRestClient;

        /// <summary> Initializes a new instance of the <see cref="ElasticPoolCollection"/> class for mocking. </summary>
        protected ElasticPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ElasticPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ElasticPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _elasticPoolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ElasticPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ElasticPoolResource.ResourceType, out string elasticPoolApiVersion);
            _elasticPoolRestClient = new ElasticPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, elasticPoolApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an elastic pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticPools_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="data"> The elastic pool parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ElasticPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string elasticPoolName, ElasticPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _elasticPoolRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ElasticPoolResource>(new ElasticPoolOperationSource(Client), _elasticPoolClientDiagnostics, Pipeline, _elasticPoolRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an elastic pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticPools_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="data"> The elastic pool parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ElasticPoolResource> CreateOrUpdate(WaitUntil waitUntil, string elasticPoolName, ElasticPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _elasticPoolRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, data, cancellationToken);
                var operation = new SqlArmOperation<ElasticPoolResource>(new ElasticPoolOperationSource(Client), _elasticPoolClientDiagnostics, Pipeline, _elasticPoolRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets an elastic pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public virtual async Task<Response<ElasticPoolResource>> GetAsync(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _elasticPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ElasticPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an elastic pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public virtual Response<ElasticPoolResource> Get(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _elasticPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ElasticPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all elastic pools in a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticPools_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ElasticPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ElasticPoolResource> GetAllAsync(long? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _elasticPoolRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _elasticPoolRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ElasticPoolResource(Client, ElasticPoolData.DeserializeElasticPoolData(e)), _elasticPoolClientDiagnostics, Pipeline, "ElasticPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all elastic pools in a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticPools_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ElasticPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ElasticPoolResource> GetAll(long? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _elasticPoolRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _elasticPoolRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ElasticPoolResource(Client, ElasticPoolData.DeserializeElasticPoolData(e)), _elasticPoolClientDiagnostics, Pipeline, "ElasticPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _elasticPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _elasticPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ElasticPoolResource> IEnumerable<ElasticPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ElasticPoolResource> IAsyncEnumerable<ElasticPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
