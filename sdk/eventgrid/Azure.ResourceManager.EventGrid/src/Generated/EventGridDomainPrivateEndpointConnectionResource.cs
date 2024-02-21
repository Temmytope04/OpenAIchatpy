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
    /// A Class representing an EventGridDomainPrivateEndpointConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="EventGridDomainPrivateEndpointConnectionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetEventGridDomainPrivateEndpointConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="EventGridDomainResource"/> using the GetEventGridDomainPrivateEndpointConnection method.
    /// </summary>
    public partial class EventGridDomainPrivateEndpointConnectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="EventGridDomainPrivateEndpointConnectionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="parentName"> The parentName. </param>
        /// <param name="privateEndpointConnectionName"> The privateEndpointConnectionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string parentName, string privateEndpointConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{parentName}/privateEndpointConnections/{privateEndpointConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics;
        private readonly PrivateEndpointConnectionsRestOperations _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsRestClient;
        private readonly EventGridPrivateEndpointConnectionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EventGrid/domains/privateEndpointConnections";

        /// <summary> Initializes a new instance of the <see cref="EventGridDomainPrivateEndpointConnectionResource"/> class for mocking. </summary>
        protected EventGridDomainPrivateEndpointConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventGridDomainPrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal EventGridDomainPrivateEndpointConnectionResource(ArmClient client, EventGridPrivateEndpointConnectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="EventGridDomainPrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal EventGridDomainPrivateEndpointConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
            _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsRestClient = new PrivateEndpointConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual EventGridPrivateEndpointConnectionData Data
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
        /// Get a specific private endpoint connection under a topic, domain, or partner namespace or namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventGridDomainPrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EventGridDomainPrivateEndpointConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("EventGridDomainPrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, "domains", Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventGridDomainPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a specific private endpoint connection under a topic, domain, or partner namespace or namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventGridDomainPrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EventGridDomainPrivateEndpointConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("EventGridDomainPrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, "domains", Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventGridDomainPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a specific private endpoint connection under a topic, domain, or partner namespace or namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventGridDomainPrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("EventGridDomainPrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = await _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, "domains", Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation(_eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, "domains", Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete a specific private endpoint connection under a topic, domain, or partner namespace or namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventGridDomainPrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("EventGridDomainPrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, "domains", Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new EventGridArmOperation(_eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, "domains", Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Update a specific private endpoint connection under a topic, domain or partner namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventGridDomainPrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The private endpoint connection object to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EventGridDomainPrivateEndpointConnectionResource>> UpdateAsync(WaitUntil waitUntil, EventGridPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("EventGridDomainPrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = await _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, "domains", Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<EventGridDomainPrivateEndpointConnectionResource>(new EventGridDomainPrivateEndpointConnectionOperationSource(Client), _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, "domains", Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Update a specific private endpoint connection under a topic, domain or partner namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventGridDomainPrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The private endpoint connection object to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EventGridDomainPrivateEndpointConnectionResource> Update(WaitUntil waitUntil, EventGridPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("EventGridDomainPrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, "domains", Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new EventGridArmOperation<EventGridDomainPrivateEndpointConnectionResource>(new EventGridDomainPrivateEndpointConnectionOperationSource(Client), _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, _eventGridDomainPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, "domains", Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
    }
}
