// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.HybridContainerService;

namespace Azure.ResourceManager.HybridContainerService.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableHybridContainerServiceSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _provisionedClusterClientDiagnostics;
        private ProvisionedClustersRestOperations _provisionedClusterRestClient;
        private ClientDiagnostics _storageSpacestorageSpacesClientDiagnostics;
        private StorageSpacesRestOperations _storageSpacestorageSpacesRestClient;
        private ClientDiagnostics _hybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics;
        private VirtualNetworksRestOperations _hybridContainerServiceVirtualNetworkvirtualNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableHybridContainerServiceSubscriptionResource"/> class for mocking. </summary>
        protected MockableHybridContainerServiceSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableHybridContainerServiceSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableHybridContainerServiceSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ProvisionedClusterClientDiagnostics => _provisionedClusterClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HybridContainerService", ProvisionedClusterResource.ResourceType.Namespace, Diagnostics);
        private ProvisionedClustersRestOperations ProvisionedClusterRestClient => _provisionedClusterRestClient ??= new ProvisionedClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ProvisionedClusterResource.ResourceType));
        private ClientDiagnostics StorageSpacestorageSpacesClientDiagnostics => _storageSpacestorageSpacesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HybridContainerService", StorageSpaceResource.ResourceType.Namespace, Diagnostics);
        private StorageSpacesRestOperations StorageSpacestorageSpacesRestClient => _storageSpacestorageSpacesRestClient ??= new StorageSpacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(StorageSpaceResource.ResourceType));
        private ClientDiagnostics HybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics => _hybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HybridContainerService", HybridContainerServiceVirtualNetworkResource.ResourceType.Namespace, Diagnostics);
        private VirtualNetworksRestOperations HybridContainerServiceVirtualNetworkvirtualNetworksRestClient => _hybridContainerServiceVirtualNetworkvirtualNetworksRestClient ??= new VirtualNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(HybridContainerServiceVirtualNetworkResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets the Hybrid AKS provisioned cluster in a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridContainerService/provisionedClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProvisionedClusters_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProvisionedClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProvisionedClusterResource> GetProvisionedClustersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ProvisionedClusterRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ProvisionedClusterRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ProvisionedClusterResource(Client, ProvisionedClusterData.DeserializeProvisionedClusterData(e)), ProvisionedClusterClientDiagnostics, Pipeline, "MockableHybridContainerServiceSubscriptionResource.GetProvisionedClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the Hybrid AKS provisioned cluster in a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridContainerService/provisionedClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProvisionedClusters_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProvisionedClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProvisionedClusterResource> GetProvisionedClusters(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ProvisionedClusterRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ProvisionedClusterRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ProvisionedClusterResource(Client, ProvisionedClusterData.DeserializeProvisionedClusterData(e)), ProvisionedClusterClientDiagnostics, Pipeline, "MockableHybridContainerServiceSubscriptionResource.GetProvisionedClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List the Hybrid AKS storage object by subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridContainerService/storageSpaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>storageSpaces_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageSpaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageSpaceResource> GetStorageSpacesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => StorageSpacestorageSpacesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => StorageSpacestorageSpacesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new StorageSpaceResource(Client, StorageSpaceData.DeserializeStorageSpaceData(e)), StorageSpacestorageSpacesClientDiagnostics, Pipeline, "MockableHybridContainerServiceSubscriptionResource.GetStorageSpaces", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List the Hybrid AKS storage object by subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridContainerService/storageSpaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>storageSpaces_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageSpaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageSpaceResource> GetStorageSpaces(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => StorageSpacestorageSpacesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => StorageSpacestorageSpacesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new StorageSpaceResource(Client, StorageSpaceData.DeserializeStorageSpaceData(e)), StorageSpacestorageSpacesClientDiagnostics, Pipeline, "MockableHybridContainerServiceSubscriptionResource.GetStorageSpaces", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Hybrid AKS virtual networks by subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridContainerService/virtualNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>virtualNetworks_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridContainerServiceVirtualNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridContainerServiceVirtualNetworkResource> GetHybridContainerServiceVirtualNetworksAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HybridContainerServiceVirtualNetworkvirtualNetworksRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HybridContainerServiceVirtualNetworkvirtualNetworksRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new HybridContainerServiceVirtualNetworkResource(Client, HybridContainerServiceVirtualNetworkData.DeserializeHybridContainerServiceVirtualNetworkData(e)), HybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics, Pipeline, "MockableHybridContainerServiceSubscriptionResource.GetHybridContainerServiceVirtualNetworks", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Hybrid AKS virtual networks by subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridContainerService/virtualNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>virtualNetworks_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridContainerServiceVirtualNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridContainerServiceVirtualNetworkResource> GetHybridContainerServiceVirtualNetworks(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HybridContainerServiceVirtualNetworkvirtualNetworksRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HybridContainerServiceVirtualNetworkvirtualNetworksRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new HybridContainerServiceVirtualNetworkResource(Client, HybridContainerServiceVirtualNetworkData.DeserializeHybridContainerServiceVirtualNetworkData(e)), HybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics, Pipeline, "MockableHybridContainerServiceSubscriptionResource.GetHybridContainerServiceVirtualNetworks", "value", "nextLink", cancellationToken);
        }
    }
}
