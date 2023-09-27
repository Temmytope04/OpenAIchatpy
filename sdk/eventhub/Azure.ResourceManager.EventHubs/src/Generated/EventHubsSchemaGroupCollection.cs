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

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A class representing a collection of <see cref="EventHubsSchemaGroupResource" /> and their operations.
    /// Each <see cref="EventHubsSchemaGroupResource" /> in the collection will belong to the same instance of <see cref="EventHubsNamespaceResource" />.
    /// To get an <see cref="EventHubsSchemaGroupCollection" /> instance call the GetEventHubsSchemaGroups method from an instance of <see cref="EventHubsNamespaceResource" />.
    /// </summary>
    public partial class EventHubsSchemaGroupCollection : ArmCollection, IEnumerable<EventHubsSchemaGroupResource>, IAsyncEnumerable<EventHubsSchemaGroupResource>
    {
        private readonly ClientDiagnostics _eventHubsSchemaGroupSchemaRegistryClientDiagnostics;
        private readonly SchemaRegistryRestOperations _eventHubsSchemaGroupSchemaRegistryRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventHubsSchemaGroupCollection"/> class for mocking. </summary>
        protected EventHubsSchemaGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubsSchemaGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EventHubsSchemaGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventHubsSchemaGroupSchemaRegistryClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHubsSchemaGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EventHubsSchemaGroupResource.ResourceType, out string eventHubsSchemaGroupSchemaRegistryApiVersion);
            _eventHubsSchemaGroupSchemaRegistryRestClient = new SchemaRegistryRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventHubsSchemaGroupSchemaRegistryApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventHubsNamespaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventHubsNamespaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/schemagroups/{schemaGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="schemaGroupName"> The Schema Group name. </param>
        /// <param name="data"> Parameters supplied to create an Event Hub resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EventHubsSchemaGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string schemaGroupName, EventHubsSchemaGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaGroupName, nameof(schemaGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventHubsSchemaGroupSchemaRegistryClientDiagnostics.CreateScope("EventHubsSchemaGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _eventHubsSchemaGroupSchemaRegistryRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventHubsArmOperation<EventHubsSchemaGroupResource>(Response.FromValue(new EventHubsSchemaGroupResource(Client, response), response.GetRawResponse()));
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/schemagroups/{schemaGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="schemaGroupName"> The Schema Group name. </param>
        /// <param name="data"> Parameters supplied to create an Event Hub resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EventHubsSchemaGroupResource> CreateOrUpdate(WaitUntil waitUntil, string schemaGroupName, EventHubsSchemaGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaGroupName, nameof(schemaGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventHubsSchemaGroupSchemaRegistryClientDiagnostics.CreateScope("EventHubsSchemaGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _eventHubsSchemaGroupSchemaRegistryRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaGroupName, data, cancellationToken);
                var operation = new EventHubsArmOperation<EventHubsSchemaGroupResource>(Response.FromValue(new EventHubsSchemaGroupResource(Client, response), response.GetRawResponse()));
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/schemagroups/{schemaGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaGroupName"> The Schema Group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaGroupName"/> is null. </exception>
        public virtual async Task<Response<EventHubsSchemaGroupResource>> GetAsync(string schemaGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaGroupName, nameof(schemaGroupName));

            using var scope = _eventHubsSchemaGroupSchemaRegistryClientDiagnostics.CreateScope("EventHubsSchemaGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventHubsSchemaGroupSchemaRegistryRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubsSchemaGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/schemagroups/{schemaGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaGroupName"> The Schema Group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaGroupName"/> is null. </exception>
        public virtual Response<EventHubsSchemaGroupResource> Get(string schemaGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaGroupName, nameof(schemaGroupName));

            using var scope = _eventHubsSchemaGroupSchemaRegistryClientDiagnostics.CreateScope("EventHubsSchemaGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _eventHubsSchemaGroupSchemaRegistryRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubsSchemaGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the Schema Groups in a Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/schemagroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_ListByNamespace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubsSchemaGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventHubsSchemaGroupResource> GetAllAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubsSchemaGroupSchemaRegistryRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubsSchemaGroupSchemaRegistryRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EventHubsSchemaGroupResource(Client, EventHubsSchemaGroupData.DeserializeEventHubsSchemaGroupData(e)), _eventHubsSchemaGroupSchemaRegistryClientDiagnostics, Pipeline, "EventHubsSchemaGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the Schema Groups in a Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/schemagroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_ListByNamespace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubsSchemaGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventHubsSchemaGroupResource> GetAll(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubsSchemaGroupSchemaRegistryRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubsSchemaGroupSchemaRegistryRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EventHubsSchemaGroupResource(Client, EventHubsSchemaGroupData.DeserializeEventHubsSchemaGroupData(e)), _eventHubsSchemaGroupSchemaRegistryClientDiagnostics, Pipeline, "EventHubsSchemaGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/schemagroups/{schemaGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaGroupName"> The Schema Group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string schemaGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaGroupName, nameof(schemaGroupName));

            using var scope = _eventHubsSchemaGroupSchemaRegistryClientDiagnostics.CreateScope("EventHubsSchemaGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _eventHubsSchemaGroupSchemaRegistryRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/schemagroups/{schemaGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaGroupName"> The Schema Group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string schemaGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaGroupName, nameof(schemaGroupName));

            using var scope = _eventHubsSchemaGroupSchemaRegistryClientDiagnostics.CreateScope("EventHubsSchemaGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _eventHubsSchemaGroupSchemaRegistryRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaGroupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/schemagroups/{schemaGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaGroupName"> The Schema Group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<EventHubsSchemaGroupResource>> GetIfExistsAsync(string schemaGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaGroupName, nameof(schemaGroupName));

            using var scope = _eventHubsSchemaGroupSchemaRegistryClientDiagnostics.CreateScope("EventHubsSchemaGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _eventHubsSchemaGroupSchemaRegistryRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<EventHubsSchemaGroupResource>(response.GetRawResponse());
                return Response.FromValue(new EventHubsSchemaGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/schemagroups/{schemaGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaGroupName"> The Schema Group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaGroupName"/> is null. </exception>
        public virtual NullableResponse<EventHubsSchemaGroupResource> GetIfExists(string schemaGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaGroupName, nameof(schemaGroupName));

            using var scope = _eventHubsSchemaGroupSchemaRegistryClientDiagnostics.CreateScope("EventHubsSchemaGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _eventHubsSchemaGroupSchemaRegistryRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<EventHubsSchemaGroupResource>(response.GetRawResponse());
                return Response.FromValue(new EventHubsSchemaGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EventHubsSchemaGroupResource> IEnumerable<EventHubsSchemaGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventHubsSchemaGroupResource> IAsyncEnumerable<EventHubsSchemaGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
