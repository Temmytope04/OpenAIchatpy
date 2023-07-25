// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.LoadTesting
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _loadTestingResourceLoadTestsClientDiagnostics;
        private LoadTestsRestOperations _loadTestingResourceLoadTestsRestClient;

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

        private ClientDiagnostics LoadTestingResourceLoadTestsClientDiagnostics => _loadTestingResourceLoadTestsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.LoadTesting", LoadTestingResource.ResourceType.Namespace, Diagnostics);
        private LoadTestsRestOperations LoadTestingResourceLoadTestsRestClient => _loadTestingResourceLoadTestsRestClient ??= new LoadTestsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(LoadTestingResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of LoadTestingQuotaResources in the SubscriptionResource. </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <returns> An object representing collection of LoadTestingQuotaResources and their operations over a LoadTestingQuotaResource. </returns>
        public virtual LoadTestingQuotaCollection GetAllLoadTestingQuota(AzureLocation location)
        {
            return new LoadTestingQuotaCollection(Client, Id, location);
        }

        /// <summary>
        /// Lists loadtests resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/loadTests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadTests_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LoadTestingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LoadTestingResource> GetLoadTestingResourcesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LoadTestingResourceLoadTestsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LoadTestingResourceLoadTestsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LoadTestingResource(Client, LoadTestingResourceData.DeserializeLoadTestingResourceData(e)), LoadTestingResourceLoadTestsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetLoadTestingResources", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists loadtests resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/loadTests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadTests_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LoadTestingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LoadTestingResource> GetLoadTestingResources(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LoadTestingResourceLoadTestsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LoadTestingResourceLoadTestsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LoadTestingResource(Client, LoadTestingResourceData.DeserializeLoadTestingResourceData(e)), LoadTestingResourceLoadTestsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetLoadTestingResources", "value", "nextLink", cancellationToken);
        }
    }
}
