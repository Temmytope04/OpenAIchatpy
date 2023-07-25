// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.EdgeOrder.Models;

namespace Azure.ResourceManager.EdgeOrder
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _edgeOrderAddressClientDiagnostics;
        private EdgeOrderManagementRestOperations _edgeOrderAddressRestClient;
        private ClientDiagnostics _defaultClientDiagnostics;
        private EdgeOrderManagementRestOperations _defaultRestClient;
        private ClientDiagnostics _edgeOrderItemClientDiagnostics;
        private EdgeOrderManagementRestOperations _edgeOrderItemRestClient;

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

        private ClientDiagnostics EdgeOrderAddressClientDiagnostics => _edgeOrderAddressClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.EdgeOrder", EdgeOrderAddressResource.ResourceType.Namespace, Diagnostics);
        private EdgeOrderManagementRestOperations EdgeOrderAddressRestClient => _edgeOrderAddressRestClient ??= new EdgeOrderManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(EdgeOrderAddressResource.ResourceType));
        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.EdgeOrder", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private EdgeOrderManagementRestOperations DefaultRestClient => _defaultRestClient ??= new EdgeOrderManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics EdgeOrderItemClientDiagnostics => _edgeOrderItemClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.EdgeOrder", EdgeOrderItemResource.ResourceType.Namespace, Diagnostics);
        private EdgeOrderManagementRestOperations EdgeOrderItemRestClient => _edgeOrderItemRestClient ??= new EdgeOrderManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(EdgeOrderItemResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all the addresses available under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/addresses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListAddressesAtSubscriptionLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> $filter is supported to filter based on shipping address properties. Filter supports only equals operation. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of addresses, which provides the next page in the list of addresses. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EdgeOrderAddressResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EdgeOrderAddressResource> GetEdgeOrderAddressesAsync(string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => EdgeOrderAddressRestClient.CreateListAddressesAtSubscriptionLevelRequest(Id.SubscriptionId, filter, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => EdgeOrderAddressRestClient.CreateListAddressesAtSubscriptionLevelNextPageRequest(nextLink, Id.SubscriptionId, filter, skipToken);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EdgeOrderAddressResource(Client, EdgeOrderAddressData.DeserializeEdgeOrderAddressData(e)), EdgeOrderAddressClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetEdgeOrderAddresses", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the addresses available under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/addresses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListAddressesAtSubscriptionLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> $filter is supported to filter based on shipping address properties. Filter supports only equals operation. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of addresses, which provides the next page in the list of addresses. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EdgeOrderAddressResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EdgeOrderAddressResource> GetEdgeOrderAddresses(string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => EdgeOrderAddressRestClient.CreateListAddressesAtSubscriptionLevelRequest(Id.SubscriptionId, filter, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => EdgeOrderAddressRestClient.CreateListAddressesAtSubscriptionLevelNextPageRequest(nextLink, Id.SubscriptionId, filter, skipToken);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EdgeOrderAddressResource(Client, EdgeOrderAddressData.DeserializeEdgeOrderAddressData(e)), EdgeOrderAddressClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetEdgeOrderAddresses", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// This method provides the list of product families for the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listProductFamilies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListProductFamilies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Filters for showing the product families. </param>
        /// <param name="expand"> $expand is supported on configurations parameter for product, which provides details on the configurations for the product. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families, which provides the next page in the list of product families. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProductFamily" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProductFamily> GetProductFamiliesAsync(ProductFamiliesContent content, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DefaultRestClient.CreateListProductFamiliesRequest(Id.SubscriptionId, content, expand, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DefaultRestClient.CreateListProductFamiliesNextPageRequest(nextLink, Id.SubscriptionId, content, expand, skipToken);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ProductFamily.DeserializeProductFamily, DefaultClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetProductFamilies", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// This method provides the list of product families for the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listProductFamilies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListProductFamilies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Filters for showing the product families. </param>
        /// <param name="expand"> $expand is supported on configurations parameter for product, which provides details on the configurations for the product. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families, which provides the next page in the list of product families. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProductFamily" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProductFamily> GetProductFamilies(ProductFamiliesContent content, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DefaultRestClient.CreateListProductFamiliesRequest(Id.SubscriptionId, content, expand, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DefaultRestClient.CreateListProductFamiliesNextPageRequest(nextLink, Id.SubscriptionId, content, expand, skipToken);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ProductFamily.DeserializeProductFamily, DefaultClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetProductFamilies", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// This method provides the list of configurations for the given product family, product line and product under subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListConfigurations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Filters for showing the configurations. </param>
        /// <param name="skipToken"> $skipToken is supported on list of configurations, which provides the next page in the list of configurations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProductConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProductConfiguration> GetConfigurationsAsync(ConfigurationsContent content, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DefaultRestClient.CreateListConfigurationsRequest(Id.SubscriptionId, content, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DefaultRestClient.CreateListConfigurationsNextPageRequest(nextLink, Id.SubscriptionId, content, skipToken);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ProductConfiguration.DeserializeProductConfiguration, DefaultClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetConfigurations", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// This method provides the list of configurations for the given product family, product line and product under subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListConfigurations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Filters for showing the configurations. </param>
        /// <param name="skipToken"> $skipToken is supported on list of configurations, which provides the next page in the list of configurations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProductConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProductConfiguration> GetConfigurations(ConfigurationsContent content, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DefaultRestClient.CreateListConfigurationsRequest(Id.SubscriptionId, content, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DefaultRestClient.CreateListConfigurationsNextPageRequest(nextLink, Id.SubscriptionId, content, skipToken);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ProductConfiguration.DeserializeProductConfiguration, DefaultClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetConfigurations", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// This method provides the list of product families metadata for the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/productFamiliesMetadata</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListProductFamiliesMetadata</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> $skipToken is supported on list of product families metadata, which provides the next page in the list of product families metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProductFamiliesMetadata" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProductFamiliesMetadata> GetProductFamiliesMetadataAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DefaultRestClient.CreateListProductFamiliesMetadataRequest(Id.SubscriptionId, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DefaultRestClient.CreateListProductFamiliesMetadataNextPageRequest(nextLink, Id.SubscriptionId, skipToken);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ProductFamiliesMetadata.DeserializeProductFamiliesMetadata, DefaultClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetProductFamiliesMetadata", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// This method provides the list of product families metadata for the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/productFamiliesMetadata</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListProductFamiliesMetadata</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> $skipToken is supported on list of product families metadata, which provides the next page in the list of product families metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProductFamiliesMetadata" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProductFamiliesMetadata> GetProductFamiliesMetadata(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DefaultRestClient.CreateListProductFamiliesMetadataRequest(Id.SubscriptionId, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DefaultRestClient.CreateListProductFamiliesMetadataNextPageRequest(nextLink, Id.SubscriptionId, skipToken);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ProductFamiliesMetadata.DeserializeProductFamiliesMetadata, DefaultClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetProductFamiliesMetadata", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists order at subscription level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListOrderAtSubscriptionLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EdgeOrderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EdgeOrderResource> GetEdgeOrdersAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DefaultRestClient.CreateListOrderAtSubscriptionLevelRequest(Id.SubscriptionId, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DefaultRestClient.CreateListOrderAtSubscriptionLevelNextPageRequest(nextLink, Id.SubscriptionId, skipToken);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EdgeOrderResource(Client, EdgeOrderData.DeserializeEdgeOrderData(e)), DefaultClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetEdgeOrders", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists order at subscription level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListOrderAtSubscriptionLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EdgeOrderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EdgeOrderResource> GetEdgeOrders(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DefaultRestClient.CreateListOrderAtSubscriptionLevelRequest(Id.SubscriptionId, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DefaultRestClient.CreateListOrderAtSubscriptionLevelNextPageRequest(nextLink, Id.SubscriptionId, skipToken);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EdgeOrderResource(Client, EdgeOrderData.DeserializeEdgeOrderData(e)), DefaultClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetEdgeOrders", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists order item at subscription level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orderItems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListOrderItemsAtSubscriptionLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> $filter is supported to filter based on order id. Filter supports only equals operation. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order items, which provides the next page in the list of order items. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EdgeOrderItemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EdgeOrderItemResource> GetEdgeOrderItemsAsync(string filter = null, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => EdgeOrderItemRestClient.CreateListOrderItemsAtSubscriptionLevelRequest(Id.SubscriptionId, filter, expand, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => EdgeOrderItemRestClient.CreateListOrderItemsAtSubscriptionLevelNextPageRequest(nextLink, Id.SubscriptionId, filter, expand, skipToken);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EdgeOrderItemResource(Client, EdgeOrderItemData.DeserializeEdgeOrderItemData(e)), EdgeOrderItemClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetEdgeOrderItems", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists order item at subscription level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orderItems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListOrderItemsAtSubscriptionLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> $filter is supported to filter based on order id. Filter supports only equals operation. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order items, which provides the next page in the list of order items. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EdgeOrderItemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EdgeOrderItemResource> GetEdgeOrderItems(string filter = null, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => EdgeOrderItemRestClient.CreateListOrderItemsAtSubscriptionLevelRequest(Id.SubscriptionId, filter, expand, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => EdgeOrderItemRestClient.CreateListOrderItemsAtSubscriptionLevelNextPageRequest(nextLink, Id.SubscriptionId, filter, expand, skipToken);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EdgeOrderItemResource(Client, EdgeOrderItemData.DeserializeEdgeOrderItemData(e)), EdgeOrderItemClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetEdgeOrderItems", "value", "nextLink", cancellationToken);
        }
    }
}
