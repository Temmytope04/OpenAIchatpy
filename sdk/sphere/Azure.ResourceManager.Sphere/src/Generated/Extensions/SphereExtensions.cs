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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sphere.Mocking;

namespace Azure.ResourceManager.Sphere
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Sphere. </summary>
    public static partial class SphereExtensions
    {
        private static MockableSphereArmClient GetMockableSphereArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableSphereArmClient(client0));
        }

        private static MockableSphereResourceGroupResource GetMockableSphereResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableSphereResourceGroupResource(client, resource.Id));
        }

        private static MockableSphereSubscriptionResource GetMockableSphereSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableSphereSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="SphereCatalogResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SphereCatalogResource.CreateResourceIdentifier" /> to create a <see cref="SphereCatalogResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSphereArmClient.GetSphereCatalogResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SphereCatalogResource" /> object. </returns>
        public static SphereCatalogResource GetSphereCatalogResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableSphereArmClient(client).GetSphereCatalogResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SphereCertificateResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SphereCertificateResource.CreateResourceIdentifier" /> to create a <see cref="SphereCertificateResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSphereArmClient.GetSphereCertificateResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SphereCertificateResource" /> object. </returns>
        public static SphereCertificateResource GetSphereCertificateResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableSphereArmClient(client).GetSphereCertificateResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SphereImageResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SphereImageResource.CreateResourceIdentifier" /> to create a <see cref="SphereImageResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSphereArmClient.GetSphereImageResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SphereImageResource" /> object. </returns>
        public static SphereImageResource GetSphereImageResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableSphereArmClient(client).GetSphereImageResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SphereProductResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SphereProductResource.CreateResourceIdentifier" /> to create a <see cref="SphereProductResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSphereArmClient.GetSphereProductResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SphereProductResource" /> object. </returns>
        public static SphereProductResource GetSphereProductResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableSphereArmClient(client).GetSphereProductResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SphereDeviceGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SphereDeviceGroupResource.CreateResourceIdentifier" /> to create a <see cref="SphereDeviceGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSphereArmClient.GetSphereDeviceGroupResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SphereDeviceGroupResource" /> object. </returns>
        public static SphereDeviceGroupResource GetSphereDeviceGroupResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableSphereArmClient(client).GetSphereDeviceGroupResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SphereDeploymentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SphereDeploymentResource.CreateResourceIdentifier" /> to create a <see cref="SphereDeploymentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSphereArmClient.GetSphereDeploymentResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SphereDeploymentResource" /> object. </returns>
        public static SphereDeploymentResource GetSphereDeploymentResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableSphereArmClient(client).GetSphereDeploymentResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SphereDeviceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SphereDeviceResource.CreateResourceIdentifier" /> to create a <see cref="SphereDeviceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSphereArmClient.GetSphereDeviceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SphereDeviceResource" /> object. </returns>
        public static SphereDeviceResource GetSphereDeviceResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableSphereArmClient(client).GetSphereDeviceResource(id);
        }

        /// <summary>
        /// Gets a collection of SphereCatalogResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSphereResourceGroupResource.GetSphereCatalogs()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of SphereCatalogResources and their operations over a SphereCatalogResource. </returns>
        public static SphereCatalogCollection GetSphereCatalogs(this ResourceGroupResource resourceGroupResource)
        {
            return GetMockableSphereResourceGroupResource(resourceGroupResource).GetSphereCatalogs();
        }

        /// <summary>
        /// Get a Catalog
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSphereResourceGroupResource.GetSphereCatalogAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<SphereCatalogResource>> GetSphereCatalogAsync(this ResourceGroupResource resourceGroupResource, string catalogName, CancellationToken cancellationToken = default)
        {
            return await GetMockableSphereResourceGroupResource(resourceGroupResource).GetSphereCatalogAsync(catalogName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Catalog
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSphereResourceGroupResource.GetSphereCatalog(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<SphereCatalogResource> GetSphereCatalog(this ResourceGroupResource resourceGroupResource, string catalogName, CancellationToken cancellationToken = default)
        {
            return GetMockableSphereResourceGroupResource(resourceGroupResource).GetSphereCatalog(catalogName, cancellationToken);
        }

        /// <summary>
        /// List Catalog resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureSphere/catalogs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSphereSubscriptionResource.GetSphereCatalogs(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SphereCatalogResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SphereCatalogResource> GetSphereCatalogsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableSphereSubscriptionResource(subscriptionResource).GetSphereCatalogsAsync(cancellationToken);
        }

        /// <summary>
        /// List Catalog resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureSphere/catalogs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSphereSubscriptionResource.GetSphereCatalogs(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SphereCatalogResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SphereCatalogResource> GetSphereCatalogs(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableSphereSubscriptionResource(subscriptionResource).GetSphereCatalogs(cancellationToken);
        }
    }
}
