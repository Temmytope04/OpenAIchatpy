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

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceBusQueueResource" /> and their operations.
    /// Each <see cref="ServiceBusQueueResource" /> in the collection will belong to the same instance of <see cref="ServiceBusNamespaceResource" />.
    /// To get a <see cref="ServiceBusQueueCollection" /> instance call the GetServiceBusQueues method from an instance of <see cref="ServiceBusNamespaceResource" />.
    /// </summary>
    public partial class ServiceBusQueueCollection : ArmCollection, IEnumerable<ServiceBusQueueResource>, IAsyncEnumerable<ServiceBusQueueResource>
    {
        private readonly ClientDiagnostics _serviceBusQueueQueuesClientDiagnostics;
        private readonly QueuesRestOperations _serviceBusQueueQueuesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceBusQueueCollection"/> class for mocking. </summary>
        protected ServiceBusQueueCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusQueueCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceBusQueueCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceBusQueueQueuesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ServiceBusQueueResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceBusQueueResource.ResourceType, out string serviceBusQueueQueuesApiVersion);
            _serviceBusQueueQueuesRestClient = new QueuesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceBusQueueQueuesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceBusNamespaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceBusNamespaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a Service Bus queue. This operation is idempotent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queues_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="data"> Parameters supplied to create or update a queue resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceBusQueueResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string queueName, ServiceBusQueueData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceBusQueueQueuesClientDiagnostics.CreateScope("ServiceBusQueueCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceBusQueueQueuesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, queueName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation<ServiceBusQueueResource>(Response.FromValue(new ServiceBusQueueResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a Service Bus queue. This operation is idempotent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queues_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="data"> Parameters supplied to create or update a queue resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceBusQueueResource> CreateOrUpdate(WaitUntil waitUntil, string queueName, ServiceBusQueueData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceBusQueueQueuesClientDiagnostics.CreateScope("ServiceBusQueueCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceBusQueueQueuesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, queueName, data, cancellationToken);
                var operation = new ServiceBusArmOperation<ServiceBusQueueResource>(Response.FromValue(new ServiceBusQueueResource(Client, response), response.GetRawResponse()));
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
        /// Returns a description for the specified queue.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queues_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public virtual async Task<Response<ServiceBusQueueResource>> GetAsync(string queueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));

            using var scope = _serviceBusQueueQueuesClientDiagnostics.CreateScope("ServiceBusQueueCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceBusQueueQueuesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, queueName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusQueueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a description for the specified queue.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queues_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public virtual Response<ServiceBusQueueResource> Get(string queueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));

            using var scope = _serviceBusQueueQueuesClientDiagnostics.CreateScope("ServiceBusQueueCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceBusQueueQueuesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, queueName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusQueueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the queues within a namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queues_ListByNamespace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceBusQueueResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceBusQueueResource> GetAllAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceBusQueueQueuesRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceBusQueueQueuesRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ServiceBusQueueResource(Client, ServiceBusQueueData.DeserializeServiceBusQueueData(e)), _serviceBusQueueQueuesClientDiagnostics, Pipeline, "ServiceBusQueueCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the queues within a namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queues_ListByNamespace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceBusQueueResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceBusQueueResource> GetAll(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceBusQueueQueuesRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceBusQueueQueuesRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ServiceBusQueueResource(Client, ServiceBusQueueData.DeserializeServiceBusQueueData(e)), _serviceBusQueueQueuesClientDiagnostics, Pipeline, "ServiceBusQueueCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queues_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string queueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));

            using var scope = _serviceBusQueueQueuesClientDiagnostics.CreateScope("ServiceBusQueueCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceBusQueueQueuesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, queueName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queues_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="queueName"> The queue name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public virtual Response<bool> Exists(string queueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));

            using var scope = _serviceBusQueueQueuesClientDiagnostics.CreateScope("ServiceBusQueueCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceBusQueueQueuesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, queueName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceBusQueueResource> IEnumerable<ServiceBusQueueResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceBusQueueResource> IAsyncEnumerable<ServiceBusQueueResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
