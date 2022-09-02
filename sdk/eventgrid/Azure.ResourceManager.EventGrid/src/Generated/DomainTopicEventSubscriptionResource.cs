// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.EventGrid.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A Class representing a DomainTopicEventSubscription along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DomainTopicEventSubscriptionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDomainTopicEventSubscriptionResource method.
    /// Otherwise you can get one from its parent resource <see cref="DomainTopicResource" /> using the GetDomainTopicEventSubscription method.
    /// </summary>
    public partial class DomainTopicEventSubscriptionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DomainTopicEventSubscriptionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string domainName, string topicName, string eventSubscriptionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _domainTopicEventSubscriptionClientDiagnostics;
        private readonly DomainTopicEventSubscriptionsRestOperations _domainTopicEventSubscriptionRestClient;
        private readonly EventSubscriptionData _data;

        /// <summary> Initializes a new instance of the <see cref="DomainTopicEventSubscriptionResource"/> class for mocking. </summary>
        protected DomainTopicEventSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DomainTopicEventSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DomainTopicEventSubscriptionResource(ArmClient client, EventSubscriptionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DomainTopicEventSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DomainTopicEventSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _domainTopicEventSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string domainTopicEventSubscriptionApiVersion);
            _domainTopicEventSubscriptionRestClient = new DomainTopicEventSubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, domainTopicEventSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EventGrid/domains/topics/eventSubscriptions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual EventSubscriptionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get properties of a nested event subscription for a domain topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: DomainTopicEventSubscriptions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DomainTopicEventSubscriptionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _domainTopicEventSubscriptionClientDiagnostics.CreateScope("DomainTopicEventSubscriptionResource.Get");
            scope.Start();
            try
            {
                var response = await _domainTopicEventSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DomainTopicEventSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a nested event subscription for a domain topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: DomainTopicEventSubscriptions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DomainTopicEventSubscriptionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _domainTopicEventSubscriptionClientDiagnostics.CreateScope("DomainTopicEventSubscriptionResource.Get");
            scope.Start();
            try
            {
                var response = _domainTopicEventSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DomainTopicEventSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a nested existing event subscription for a domain topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: DomainTopicEventSubscriptions_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _domainTopicEventSubscriptionClientDiagnostics.CreateScope("DomainTopicEventSubscriptionResource.Delete");
            scope.Start();
            try
            {
                var response = await _domainTopicEventSubscriptionRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation(_domainTopicEventSubscriptionClientDiagnostics, Pipeline, _domainTopicEventSubscriptionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a nested existing event subscription for a domain topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: DomainTopicEventSubscriptions_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _domainTopicEventSubscriptionClientDiagnostics.CreateScope("DomainTopicEventSubscriptionResource.Delete");
            scope.Start();
            try
            {
                var response = _domainTopicEventSubscriptionRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new EventGridArmOperation(_domainTopicEventSubscriptionClientDiagnostics, Pipeline, _domainTopicEventSubscriptionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update an existing event subscription for a domain topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: DomainTopicEventSubscriptions_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="eventSubscriptionUpdateParameters"> Updated event subscription information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionUpdateParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<DomainTopicEventSubscriptionResource>> UpdateAsync(WaitUntil waitUntil, EventSubscriptionUpdateParameters eventSubscriptionUpdateParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(eventSubscriptionUpdateParameters, nameof(eventSubscriptionUpdateParameters));

            using var scope = _domainTopicEventSubscriptionClientDiagnostics.CreateScope("DomainTopicEventSubscriptionResource.Update");
            scope.Start();
            try
            {
                var response = await _domainTopicEventSubscriptionRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, eventSubscriptionUpdateParameters, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<DomainTopicEventSubscriptionResource>(new DomainTopicEventSubscriptionOperationSource(Client), _domainTopicEventSubscriptionClientDiagnostics, Pipeline, _domainTopicEventSubscriptionRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, eventSubscriptionUpdateParameters).Request, response, OperationFinalStateVia.Location);
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
        /// Update an existing event subscription for a domain topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}
        /// Operation Id: DomainTopicEventSubscriptions_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="eventSubscriptionUpdateParameters"> Updated event subscription information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionUpdateParameters"/> is null. </exception>
        public virtual ArmOperation<DomainTopicEventSubscriptionResource> Update(WaitUntil waitUntil, EventSubscriptionUpdateParameters eventSubscriptionUpdateParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(eventSubscriptionUpdateParameters, nameof(eventSubscriptionUpdateParameters));

            using var scope = _domainTopicEventSubscriptionClientDiagnostics.CreateScope("DomainTopicEventSubscriptionResource.Update");
            scope.Start();
            try
            {
                var response = _domainTopicEventSubscriptionRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, eventSubscriptionUpdateParameters, cancellationToken);
                var operation = new EventGridArmOperation<DomainTopicEventSubscriptionResource>(new DomainTopicEventSubscriptionOperationSource(Client), _domainTopicEventSubscriptionClientDiagnostics, Pipeline, _domainTopicEventSubscriptionRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, eventSubscriptionUpdateParameters).Request, response, OperationFinalStateVia.Location);
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
        /// Get the full endpoint URL for a nested event subscription for domain topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}/getFullUrl
        /// Operation Id: DomainTopicEventSubscriptions_GetFullUrl
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EventSubscriptionFullUri>> GetFullUrlAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _domainTopicEventSubscriptionClientDiagnostics.CreateScope("DomainTopicEventSubscriptionResource.GetFullUrl");
            scope.Start();
            try
            {
                var response = await _domainTopicEventSubscriptionRestClient.GetFullUrlAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the full endpoint URL for a nested event subscription for domain topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}/getFullUrl
        /// Operation Id: DomainTopicEventSubscriptions_GetFullUrl
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EventSubscriptionFullUri> GetFullUrl(CancellationToken cancellationToken = default)
        {
            using var scope = _domainTopicEventSubscriptionClientDiagnostics.CreateScope("DomainTopicEventSubscriptionResource.GetFullUrl");
            scope.Start();
            try
            {
                var response = _domainTopicEventSubscriptionRestClient.GetFullUrl(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all delivery attributes for an event subscription for domain topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}/getDeliveryAttributes
        /// Operation Id: DomainTopicEventSubscriptions_GetDeliveryAttributes
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeliveryAttributeMapping" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeliveryAttributeMapping> GetDeliveryAttributesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeliveryAttributeMapping>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _domainTopicEventSubscriptionClientDiagnostics.CreateScope("DomainTopicEventSubscriptionResource.GetDeliveryAttributes");
                scope.Start();
                try
                {
                    var response = await _domainTopicEventSubscriptionRestClient.GetDeliveryAttributesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get all delivery attributes for an event subscription for domain topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/topics/{topicName}/eventSubscriptions/{eventSubscriptionName}/getDeliveryAttributes
        /// Operation Id: DomainTopicEventSubscriptions_GetDeliveryAttributes
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeliveryAttributeMapping" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeliveryAttributeMapping> GetDeliveryAttributes(CancellationToken cancellationToken = default)
        {
            Page<DeliveryAttributeMapping> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _domainTopicEventSubscriptionClientDiagnostics.CreateScope("DomainTopicEventSubscriptionResource.GetDeliveryAttributes");
                scope.Start();
                try
                {
                    var response = _domainTopicEventSubscriptionRestClient.GetDeliveryAttributes(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
