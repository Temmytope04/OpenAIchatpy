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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A class representing a collection of <see cref="DataFactoryResource" /> and their operations.
    /// Each <see cref="DataFactoryResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DataFactoryCollection" /> instance call the GetDataFactories method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DataFactoryCollection : ArmCollection, IEnumerable<DataFactoryResource>, IAsyncEnumerable<DataFactoryResource>
    {
        private readonly ClientDiagnostics _dataFactoryFactoriesClientDiagnostics;
        private readonly FactoriesRestOperations _dataFactoryFactoriesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataFactoryCollection"/> class for mocking. </summary>
        protected DataFactoryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataFactoryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataFactoryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataFactoryFactoriesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataFactory", DataFactoryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataFactoryResource.ResourceType, out string dataFactoryFactoriesApiVersion);
            _dataFactoryFactoriesRestClient = new FactoriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataFactoryFactoriesApiVersion);
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
        /// Creates or updates a factory.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="data"> Factory resource definition. </param>
        /// <param name="ifMatch"> ETag of the factory entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="factoryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="factoryName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataFactoryResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string factoryName, DataFactoryData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryFactoriesClientDiagnostics.CreateScope("DataFactoryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataFactoryFactoriesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, factoryName, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DataFactoryArmOperation<DataFactoryResource>(Response.FromValue(new DataFactoryResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a factory.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="data"> Factory resource definition. </param>
        /// <param name="ifMatch"> ETag of the factory entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="factoryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="factoryName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataFactoryResource> CreateOrUpdate(WaitUntil waitUntil, string factoryName, DataFactoryData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryFactoriesClientDiagnostics.CreateScope("DataFactoryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataFactoryFactoriesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, factoryName, data, ifMatch, cancellationToken);
                var operation = new DataFactoryArmOperation<DataFactoryResource>(Response.FromValue(new DataFactoryResource(Client, response), response.GetRawResponse()));
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
        /// Gets a factory.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="ifNoneMatch"> ETag of the factory entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="factoryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="factoryName"/> is null. </exception>
        public virtual async Task<Response<DataFactoryResource>> GetAsync(string factoryName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));

            using var scope = _dataFactoryFactoriesClientDiagnostics.CreateScope("DataFactoryCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataFactoryFactoriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, factoryName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a factory.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="ifNoneMatch"> ETag of the factory entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="factoryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="factoryName"/> is null. </exception>
        public virtual Response<DataFactoryResource> Get(string factoryName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));

            using var scope = _dataFactoryFactoriesClientDiagnostics.CreateScope("DataFactoryCollection.Get");
            scope.Start();
            try
            {
                var response = _dataFactoryFactoriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, factoryName, ifNoneMatch, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists factories.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataFactoryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataFactoryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataFactoryFactoriesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataFactoryFactoriesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataFactoryResource(Client, DataFactoryData.DeserializeDataFactoryData(e)), _dataFactoryFactoriesClientDiagnostics, Pipeline, "DataFactoryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists factories.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataFactoryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataFactoryResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataFactoryFactoriesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataFactoryFactoriesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataFactoryResource(Client, DataFactoryData.DeserializeDataFactoryData(e)), _dataFactoryFactoriesClientDiagnostics, Pipeline, "DataFactoryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="ifNoneMatch"> ETag of the factory entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="factoryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="factoryName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string factoryName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));

            using var scope = _dataFactoryFactoriesClientDiagnostics.CreateScope("DataFactoryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataFactoryFactoriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, factoryName, ifNoneMatch, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="ifNoneMatch"> ETag of the factory entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="factoryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="factoryName"/> is null. </exception>
        public virtual Response<bool> Exists(string factoryName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));

            using var scope = _dataFactoryFactoriesClientDiagnostics.CreateScope("DataFactoryCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataFactoryFactoriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, factoryName, ifNoneMatch, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="ifNoneMatch"> ETag of the factory entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="factoryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="factoryName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataFactoryResource>> GetIfExistsAsync(string factoryName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));

            using var scope = _dataFactoryFactoriesClientDiagnostics.CreateScope("DataFactoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataFactoryFactoriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, factoryName, ifNoneMatch, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataFactoryResource>(response.GetRawResponse());
                return Response.FromValue(new DataFactoryResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="factoryName"> The factory name. </param>
        /// <param name="ifNoneMatch"> ETag of the factory entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="factoryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="factoryName"/> is null. </exception>
        public virtual NullableResponse<DataFactoryResource> GetIfExists(string factoryName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(factoryName, nameof(factoryName));

            using var scope = _dataFactoryFactoriesClientDiagnostics.CreateScope("DataFactoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataFactoryFactoriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, factoryName, ifNoneMatch, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataFactoryResource>(response.GetRawResponse());
                return Response.FromValue(new DataFactoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataFactoryResource> IEnumerable<DataFactoryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataFactoryResource> IAsyncEnumerable<DataFactoryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
