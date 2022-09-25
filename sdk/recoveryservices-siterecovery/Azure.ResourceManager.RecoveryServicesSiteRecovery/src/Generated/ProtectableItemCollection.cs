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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="ProtectableItemResource" /> and their operations.
    /// Each <see cref="ProtectableItemResource" /> in the collection will belong to the same instance of <see cref="ProtectionContainerResource" />.
    /// To get a <see cref="ProtectableItemCollection" /> instance call the GetProtectableItems method from an instance of <see cref="ProtectionContainerResource" />.
    /// </summary>
    public partial class ProtectableItemCollection : ArmCollection, IEnumerable<ProtectableItemResource>, IAsyncEnumerable<ProtectableItemResource>
    {
        private readonly ClientDiagnostics _protectableItemReplicationProtectableItemsClientDiagnostics;
        private readonly ReplicationProtectableItemsRestOperations _protectableItemReplicationProtectableItemsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ProtectableItemCollection"/> class for mocking. </summary>
        protected ProtectableItemCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ProtectableItemCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ProtectableItemCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _protectableItemReplicationProtectableItemsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", ProtectableItemResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ProtectableItemResource.ResourceType, out string protectableItemReplicationProtectableItemsApiVersion);
            _protectableItemReplicationProtectableItemsRestClient = new ReplicationProtectableItemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, protectableItemReplicationProtectableItemsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ProtectionContainerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ProtectionContainerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to get the details of a protectable item.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectableItems/{protectableItemName}
        /// Operation Id: ReplicationProtectableItems_Get
        /// </summary>
        /// <param name="protectableItemName"> Protectable item name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectableItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectableItemName"/> is null. </exception>
        public virtual async Task<Response<ProtectableItemResource>> GetAsync(string protectableItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectableItemName, nameof(protectableItemName));

            using var scope = _protectableItemReplicationProtectableItemsClientDiagnostics.CreateScope("ProtectableItemCollection.Get");
            scope.Start();
            try
            {
                var response = await _protectableItemReplicationProtectableItemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, protectableItemName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProtectableItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the details of a protectable item.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectableItems/{protectableItemName}
        /// Operation Id: ReplicationProtectableItems_Get
        /// </summary>
        /// <param name="protectableItemName"> Protectable item name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectableItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectableItemName"/> is null. </exception>
        public virtual Response<ProtectableItemResource> Get(string protectableItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectableItemName, nameof(protectableItemName));

            using var scope = _protectableItemReplicationProtectableItemsClientDiagnostics.CreateScope("ProtectableItemCollection.Get");
            scope.Start();
            try
            {
                var response = _protectableItemReplicationProtectableItemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, protectableItemName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProtectableItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the protectable items in a protection container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectableItems
        /// Operation Id: ReplicationProtectableItems_ListByReplicationProtectionContainers
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="take"> take OData query parameter. </param>
        /// <param name="skipToken"> skipToken OData query parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProtectableItemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProtectableItemResource> GetAllAsync(string filter = null, string take = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ProtectableItemResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _protectableItemReplicationProtectableItemsClientDiagnostics.CreateScope("ProtectableItemCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _protectableItemReplicationProtectableItemsRestClient.ListByReplicationProtectionContainersAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, take, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ProtectableItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ProtectableItemResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _protectableItemReplicationProtectableItemsClientDiagnostics.CreateScope("ProtectableItemCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _protectableItemReplicationProtectableItemsRestClient.ListByReplicationProtectionContainersNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, take, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ProtectableItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists the protectable items in a protection container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectableItems
        /// Operation Id: ReplicationProtectableItems_ListByReplicationProtectionContainers
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="take"> take OData query parameter. </param>
        /// <param name="skipToken"> skipToken OData query parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProtectableItemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProtectableItemResource> GetAll(string filter = null, string take = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<ProtectableItemResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _protectableItemReplicationProtectableItemsClientDiagnostics.CreateScope("ProtectableItemCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _protectableItemReplicationProtectableItemsRestClient.ListByReplicationProtectionContainers(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, take, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ProtectableItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ProtectableItemResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _protectableItemReplicationProtectableItemsClientDiagnostics.CreateScope("ProtectableItemCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _protectableItemReplicationProtectableItemsRestClient.ListByReplicationProtectionContainersNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, take, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ProtectableItemResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectableItems/{protectableItemName}
        /// Operation Id: ReplicationProtectableItems_Get
        /// </summary>
        /// <param name="protectableItemName"> Protectable item name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectableItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectableItemName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string protectableItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectableItemName, nameof(protectableItemName));

            using var scope = _protectableItemReplicationProtectableItemsClientDiagnostics.CreateScope("ProtectableItemCollection.Exists");
            scope.Start();
            try
            {
                var response = await _protectableItemReplicationProtectableItemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, protectableItemName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationProtectableItems/{protectableItemName}
        /// Operation Id: ReplicationProtectableItems_Get
        /// </summary>
        /// <param name="protectableItemName"> Protectable item name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectableItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectableItemName"/> is null. </exception>
        public virtual Response<bool> Exists(string protectableItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectableItemName, nameof(protectableItemName));

            using var scope = _protectableItemReplicationProtectableItemsClientDiagnostics.CreateScope("ProtectableItemCollection.Exists");
            scope.Start();
            try
            {
                var response = _protectableItemReplicationProtectableItemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, protectableItemName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ProtectableItemResource> IEnumerable<ProtectableItemResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ProtectableItemResource> IAsyncEnumerable<ProtectableItemResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
