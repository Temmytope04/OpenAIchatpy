// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="EventResource" /> and their operations.
    /// Each <see cref="EventResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="EventCollection" /> instance call the GetEvents method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class EventCollection : ArmCollection, IEnumerable<EventResource>, IAsyncEnumerable<EventResource>
    {
        private readonly ClientDiagnostics _eventReplicationEventsClientDiagnostics;
        private readonly ReplicationEventsRestOperations _eventReplicationEventsRestClient;
        private readonly string _resourceName;

        /// <summary> Initializes a new instance of the <see cref="EventCollection"/> class for mocking. </summary>
        protected EventCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        internal EventCollection(ArmClient client, ResourceIdentifier id, string resourceName) : base(client, id)
        {
            _resourceName = resourceName;
            _eventReplicationEventsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", EventResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EventResource.ResourceType, out string eventReplicationEventsApiVersion);
            _eventReplicationEventsRestClient = new ReplicationEventsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventReplicationEventsApiVersion);
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
        /// The operation to get the details of an Azure Site recovery event.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationEvents/{eventName}
        /// Operation Id: ReplicationEvents_Get
        /// </summary>
        /// <param name="eventName"> The name of the Azure Site Recovery event. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventName"/> is null. </exception>
        public virtual async Task<Response<EventResource>> GetAsync(string eventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventName, nameof(eventName));

            using var scope = _eventReplicationEventsClientDiagnostics.CreateScope("EventCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventReplicationEventsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, eventName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the details of an Azure Site recovery event.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationEvents/{eventName}
        /// Operation Id: ReplicationEvents_Get
        /// </summary>
        /// <param name="eventName"> The name of the Azure Site Recovery event. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventName"/> is null. </exception>
        public virtual Response<EventResource> Get(string eventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventName, nameof(eventName));

            using var scope = _eventReplicationEventsClientDiagnostics.CreateScope("EventCollection.Get");
            scope.Start();
            try
            {
                var response = _eventReplicationEventsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, eventName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of Azure Site Recovery events for the vault.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationEvents
        /// Operation Id: ReplicationEvents_List
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<EventResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _eventReplicationEventsClientDiagnostics.CreateScope("EventCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _eventReplicationEventsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EventResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EventResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _eventReplicationEventsClientDiagnostics.CreateScope("EventCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _eventReplicationEventsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EventResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets the list of Azure Site Recovery events for the vault.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationEvents
        /// Operation Id: ReplicationEvents_List
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<EventResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _eventReplicationEventsClientDiagnostics.CreateScope("EventCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _eventReplicationEventsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EventResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EventResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _eventReplicationEventsClientDiagnostics.CreateScope("EventCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _eventReplicationEventsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EventResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationEvents/{eventName}
        /// Operation Id: ReplicationEvents_Get
        /// </summary>
        /// <param name="eventName"> The name of the Azure Site Recovery event. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string eventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventName, nameof(eventName));

            using var scope = _eventReplicationEventsClientDiagnostics.CreateScope("EventCollection.Exists");
            scope.Start();
            try
            {
                var response = await _eventReplicationEventsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, eventName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationEvents/{eventName}
        /// Operation Id: ReplicationEvents_Get
        /// </summary>
        /// <param name="eventName"> The name of the Azure Site Recovery event. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventName"/> is null. </exception>
        public virtual Response<bool> Exists(string eventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventName, nameof(eventName));

            using var scope = _eventReplicationEventsClientDiagnostics.CreateScope("EventCollection.Exists");
            scope.Start();
            try
            {
                var response = _eventReplicationEventsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, eventName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EventResource> IEnumerable<EventResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventResource> IAsyncEnumerable<EventResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
