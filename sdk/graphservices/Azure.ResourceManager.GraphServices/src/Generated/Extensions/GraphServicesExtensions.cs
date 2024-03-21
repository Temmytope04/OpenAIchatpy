// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.GraphServices.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.GraphServices
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.GraphServices. </summary>
    public static partial class GraphServicesExtensions
    {
        private static MockableGraphServicesArmClient GetMockableGraphServicesArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableGraphServicesArmClient(client0));
        }

        private static MockableGraphServicesResourceGroupResource GetMockableGraphServicesResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableGraphServicesResourceGroupResource(client, resource.Id));
        }

        private static MockableGraphServicesSubscriptionResource GetMockableGraphServicesSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableGraphServicesSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="GraphServicesAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GraphServicesAccountResource.CreateResourceIdentifier" /> to create a <see cref="GraphServicesAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableGraphServicesArmClient.GetGraphServicesAccountResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="GraphServicesAccountResource"/> object. </returns>
        public static GraphServicesAccountResource GetGraphServicesAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableGraphServicesArmClient(client).GetGraphServicesAccountResource(id);
        }

        /// <summary>
        /// Gets a collection of GraphServicesAccountResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableGraphServicesResourceGroupResource.GetGraphServicesAccountResources()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of GraphServicesAccountResources and their operations over a GraphServicesAccountResource. </returns>
        public static GraphServicesAccountResourceCollection GetGraphServicesAccountResources(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableGraphServicesResourceGroupResource(resourceGroupResource).GetGraphServicesAccountResources();
        }

        /// <summary>
        /// Returns account resource for a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.GraphServices/accounts/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-13</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GraphServicesAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableGraphServicesResourceGroupResource.GetGraphServicesAccountResourceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<GraphServicesAccountResource>> GetGraphServicesAccountResourceAsync(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableGraphServicesResourceGroupResource(resourceGroupResource).GetGraphServicesAccountResourceAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns account resource for a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.GraphServices/accounts/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-13</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GraphServicesAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableGraphServicesResourceGroupResource.GetGraphServicesAccountResource(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<GraphServicesAccountResource> GetGraphServicesAccountResource(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableGraphServicesResourceGroupResource(resourceGroupResource).GetGraphServicesAccountResource(resourceName, cancellationToken);
        }

        /// <summary>
        /// Returns list of accounts belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.GraphServices/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-13</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GraphServicesAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableGraphServicesSubscriptionResource.GetGraphServicesAccountResources(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="GraphServicesAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GraphServicesAccountResource> GetGraphServicesAccountResourcesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableGraphServicesSubscriptionResource(subscriptionResource).GetGraphServicesAccountResourcesAsync(cancellationToken);
        }

        /// <summary>
        /// Returns list of accounts belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.GraphServices/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-13</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GraphServicesAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableGraphServicesSubscriptionResource.GetGraphServicesAccountResources(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="GraphServicesAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<GraphServicesAccountResource> GetGraphServicesAccountResources(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableGraphServicesSubscriptionResource(subscriptionResource).GetGraphServicesAccountResources(cancellationToken);
        }
    }
}
