// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ContainerService
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _managedClusterClientDiagnostics;
        private ManagedClustersRestOperations _managedClusterRestClient;
        private ClientDiagnostics _snapshotClientDiagnostics;
        private SnapshotsRestOperations _snapshotRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ManagedClusterClientDiagnostics => _managedClusterClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ContainerService", ManagedClusterResource.ResourceType.Namespace, Diagnostics);
        private ManagedClustersRestOperations ManagedClusterRestClient => _managedClusterRestClient ??= new ManagedClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ManagedClusterResource.ResourceType));
        private ClientDiagnostics SnapshotClientDiagnostics => _snapshotClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ContainerService", SnapshotResource.ResourceType.Namespace, Diagnostics);
        private SnapshotsRestOperations SnapshotRestClient => _snapshotRestClient ??= new SnapshotsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(SnapshotResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of OSOptionProfileResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of OSOptionProfileResources and their operations over a OSOptionProfileResource. </returns>
        public virtual OSOptionProfileCollection GetOSOptionProfiles()
        {
            return GetCachedClient(Client => new OSOptionProfileCollection(Client, Id));
        }

        /// <summary>
        /// Gets a list of managed clusters in the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/managedClusters
        /// Operation Id: ManagedClusters_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedClusterResource> GetManagedClustersAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedClusterResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ManagedClusterClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedClusters");
                scope.Start();
                try
                {
                    var response = await ManagedClusterRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedClusterResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedClusterResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ManagedClusterClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedClusters");
                scope.Start();
                try
                {
                    var response = await ManagedClusterRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedClusterResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of managed clusters in the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/managedClusters
        /// Operation Id: ManagedClusters_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedClusterResource> GetManagedClusters(CancellationToken cancellationToken = default)
        {
            Page<ManagedClusterResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ManagedClusterClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedClusters");
                scope.Start();
                try
                {
                    var response = ManagedClusterRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedClusterResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedClusterResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ManagedClusterClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedClusters");
                scope.Start();
                try
                {
                    var response = ManagedClusterRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedClusterResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of snapshots in the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/snapshots
        /// Operation Id: Snapshots_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SnapshotResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SnapshotResource> GetSnapshotsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SnapshotResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = SnapshotClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSnapshots");
                scope.Start();
                try
                {
                    var response = await SnapshotRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SnapshotResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SnapshotResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = SnapshotClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSnapshots");
                scope.Start();
                try
                {
                    var response = await SnapshotRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SnapshotResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of snapshots in the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/snapshots
        /// Operation Id: Snapshots_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SnapshotResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SnapshotResource> GetSnapshots(CancellationToken cancellationToken = default)
        {
            Page<SnapshotResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = SnapshotClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSnapshots");
                scope.Start();
                try
                {
                    var response = SnapshotRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SnapshotResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SnapshotResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = SnapshotClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSnapshots");
                scope.Start();
                try
                {
                    var response = SnapshotRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SnapshotResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
