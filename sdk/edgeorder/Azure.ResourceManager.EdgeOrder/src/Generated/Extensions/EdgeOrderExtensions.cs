// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.EdgeOrder.Mocking;
using Azure.ResourceManager.EdgeOrder.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EdgeOrder
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.EdgeOrder. </summary>
    public static partial class EdgeOrderExtensions
    {
        private static EdgeOrderArmClientMockingExtension GetEdgeOrderArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new EdgeOrderArmClientMockingExtension(client);
            });
        }

        private static EdgeOrderResourceGroupMockingExtension GetEdgeOrderResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new EdgeOrderResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static EdgeOrderSubscriptionMockingExtension GetEdgeOrderSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new EdgeOrderSubscriptionMockingExtension(client, resource.Id);
            });
        }

        /// <summary>
        /// Gets an object representing an <see cref="EdgeOrderAddressResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EdgeOrderAddressResource.CreateResourceIdentifier" /> to create an <see cref="EdgeOrderAddressResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EdgeOrderAddressResource" /> object. </returns>
        public static EdgeOrderAddressResource GetEdgeOrderAddressResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetEdgeOrderArmClientMockingExtension(client).GetEdgeOrderAddressResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EdgeOrderResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EdgeOrderResource.CreateResourceIdentifier" /> to create an <see cref="EdgeOrderResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EdgeOrderResource" /> object. </returns>
        public static EdgeOrderResource GetEdgeOrderResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetEdgeOrderArmClientMockingExtension(client).GetEdgeOrderResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EdgeOrderItemResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EdgeOrderItemResource.CreateResourceIdentifier" /> to create an <see cref="EdgeOrderItemResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EdgeOrderItemResource" /> object. </returns>
        public static EdgeOrderItemResource GetEdgeOrderItemResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetEdgeOrderArmClientMockingExtension(client).GetEdgeOrderItemResource(id);
        }

        /// <summary> Gets a collection of EdgeOrderAddressResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of EdgeOrderAddressResources and their operations over a EdgeOrderAddressResource. </returns>
        public static EdgeOrderAddressCollection GetEdgeOrderAddresses(this ResourceGroupResource resourceGroupResource)
        {
            return GetEdgeOrderResourceGroupMockingExtension(resourceGroupResource).GetEdgeOrderAddresses();
        }

        /// <summary>
        /// Gets information about the specified address.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/addresses/{addressName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetAddressByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="addressName"> The name of the address Resource within the specified resource group. address names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addressName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addressName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<EdgeOrderAddressResource>> GetEdgeOrderAddressAsync(this ResourceGroupResource resourceGroupResource, string addressName, CancellationToken cancellationToken = default)
        {
            return await GetEdgeOrderResourceGroupMockingExtension(resourceGroupResource).GetEdgeOrderAddressAsync(addressName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified address.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/addresses/{addressName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetAddressByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="addressName"> The name of the address Resource within the specified resource group. address names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addressName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addressName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<EdgeOrderAddressResource> GetEdgeOrderAddress(this ResourceGroupResource resourceGroupResource, string addressName, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderResourceGroupMockingExtension(resourceGroupResource).GetEdgeOrderAddress(addressName, cancellationToken);
        }

        /// <summary> Gets a collection of EdgeOrderResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of EdgeOrderResources and their operations over a EdgeOrderResource. </returns>
        public static EdgeOrderCollection GetEdgeOrders(this ResourceGroupResource resourceGroupResource)
        {
            return GetEdgeOrderResourceGroupMockingExtension(resourceGroupResource).GetEdgeOrders();
        }

        /// <summary>
        /// Gets an order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetOrderByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<EdgeOrderResource>> GetEdgeOrderAsync(this ResourceGroupResource resourceGroupResource, AzureLocation location, string orderName, CancellationToken cancellationToken = default)
        {
            return await GetEdgeOrderResourceGroupMockingExtension(resourceGroupResource).GetEdgeOrderAsync(location, orderName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetOrderByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<EdgeOrderResource> GetEdgeOrder(this ResourceGroupResource resourceGroupResource, AzureLocation location, string orderName, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderResourceGroupMockingExtension(resourceGroupResource).GetEdgeOrder(location, orderName, cancellationToken);
        }

        /// <summary> Gets a collection of EdgeOrderItemResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of EdgeOrderItemResources and their operations over a EdgeOrderItemResource. </returns>
        public static EdgeOrderItemCollection GetEdgeOrderItems(this ResourceGroupResource resourceGroupResource)
        {
            return GetEdgeOrderResourceGroupMockingExtension(resourceGroupResource).GetEdgeOrderItems();
        }

        /// <summary>
        /// Gets an order item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetOrderItemByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<EdgeOrderItemResource>> GetEdgeOrderItemAsync(this ResourceGroupResource resourceGroupResource, string orderItemName, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetEdgeOrderResourceGroupMockingExtension(resourceGroupResource).GetEdgeOrderItemAsync(orderItemName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an order item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetOrderItemByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<EdgeOrderItemResource> GetEdgeOrderItem(this ResourceGroupResource resourceGroupResource, string orderItemName, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderResourceGroupMockingExtension(resourceGroupResource).GetEdgeOrderItem(orderItemName, expand, cancellationToken);
        }

        /// <summary>
        /// Lists order at resource group level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListOrderAtResourceGroupLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EdgeOrderResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<EdgeOrderResource> GetEdgeOrdersAsync(this ResourceGroupResource resourceGroupResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderResourceGroupMockingExtension(resourceGroupResource).GetEdgeOrdersAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists order at resource group level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListOrderAtResourceGroupLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EdgeOrderResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<EdgeOrderResource> GetEdgeOrders(this ResourceGroupResource resourceGroupResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderResourceGroupMockingExtension(resourceGroupResource).GetEdgeOrders(skipToken, cancellationToken);
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
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> $filter is supported to filter based on shipping address properties. Filter supports only equals operation. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of addresses, which provides the next page in the list of addresses. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EdgeOrderAddressResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<EdgeOrderAddressResource> GetEdgeOrderAddressesAsync(this SubscriptionResource subscriptionResource, string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderSubscriptionMockingExtension(subscriptionResource).GetEdgeOrderAddressesAsync(filter, skipToken, cancellationToken);
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
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> $filter is supported to filter based on shipping address properties. Filter supports only equals operation. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of addresses, which provides the next page in the list of addresses. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EdgeOrderAddressResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<EdgeOrderAddressResource> GetEdgeOrderAddresses(this SubscriptionResource subscriptionResource, string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderSubscriptionMockingExtension(subscriptionResource).GetEdgeOrderAddresses(filter, skipToken, cancellationToken);
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
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Filters for showing the product families. </param>
        /// <param name="expand"> $expand is supported on configurations parameter for product, which provides details on the configurations for the product. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families, which provides the next page in the list of product families. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> An async collection of <see cref="ProductFamily" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ProductFamily> GetProductFamiliesAsync(this SubscriptionResource subscriptionResource, ProductFamiliesContent content, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderSubscriptionMockingExtension(subscriptionResource).GetProductFamiliesAsync(content, expand, skipToken, cancellationToken);
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
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Filters for showing the product families. </param>
        /// <param name="expand"> $expand is supported on configurations parameter for product, which provides details on the configurations for the product. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families, which provides the next page in the list of product families. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> A collection of <see cref="ProductFamily" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ProductFamily> GetProductFamilies(this SubscriptionResource subscriptionResource, ProductFamiliesContent content, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderSubscriptionMockingExtension(subscriptionResource).GetProductFamilies(content, expand, skipToken, cancellationToken);
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
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Filters for showing the configurations. </param>
        /// <param name="skipToken"> $skipToken is supported on list of configurations, which provides the next page in the list of configurations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> An async collection of <see cref="ProductConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ProductConfiguration> GetConfigurationsAsync(this SubscriptionResource subscriptionResource, ConfigurationsContent content, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderSubscriptionMockingExtension(subscriptionResource).GetConfigurationsAsync(content, skipToken, cancellationToken);
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
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Filters for showing the configurations. </param>
        /// <param name="skipToken"> $skipToken is supported on list of configurations, which provides the next page in the list of configurations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> A collection of <see cref="ProductConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ProductConfiguration> GetConfigurations(this SubscriptionResource subscriptionResource, ConfigurationsContent content, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderSubscriptionMockingExtension(subscriptionResource).GetConfigurations(content, skipToken, cancellationToken);
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
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families metadata, which provides the next page in the list of product families metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProductFamiliesMetadata" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ProductFamiliesMetadata> GetProductFamiliesMetadataAsync(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderSubscriptionMockingExtension(subscriptionResource).GetProductFamiliesMetadataAsync(skipToken, cancellationToken);
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
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families metadata, which provides the next page in the list of product families metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProductFamiliesMetadata" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ProductFamiliesMetadata> GetProductFamiliesMetadata(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderSubscriptionMockingExtension(subscriptionResource).GetProductFamiliesMetadata(skipToken, cancellationToken);
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
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EdgeOrderResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<EdgeOrderResource> GetEdgeOrdersAsync(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderSubscriptionMockingExtension(subscriptionResource).GetEdgeOrdersAsync(skipToken, cancellationToken);
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
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EdgeOrderResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<EdgeOrderResource> GetEdgeOrders(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderSubscriptionMockingExtension(subscriptionResource).GetEdgeOrders(skipToken, cancellationToken);
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
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> $filter is supported to filter based on order id. Filter supports only equals operation. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order items, which provides the next page in the list of order items. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EdgeOrderItemResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<EdgeOrderItemResource> GetEdgeOrderItemsAsync(this SubscriptionResource subscriptionResource, string filter = null, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderSubscriptionMockingExtension(subscriptionResource).GetEdgeOrderItemsAsync(filter, expand, skipToken, cancellationToken);
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
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> $filter is supported to filter based on order id. Filter supports only equals operation. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order items, which provides the next page in the list of order items. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EdgeOrderItemResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<EdgeOrderItemResource> GetEdgeOrderItems(this SubscriptionResource subscriptionResource, string filter = null, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderSubscriptionMockingExtension(subscriptionResource).GetEdgeOrderItems(filter, expand, skipToken, cancellationToken);
        }
    }
}
