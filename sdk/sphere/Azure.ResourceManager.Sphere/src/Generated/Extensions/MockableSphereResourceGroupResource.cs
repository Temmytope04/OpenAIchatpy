// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Sphere.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableSphereResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableSphereResourceGroupResource"/> class for mocking. </summary>
        protected MockableSphereResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableSphereResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableSphereResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of SphereCatalogResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of SphereCatalogResources and their operations over a SphereCatalogResource. </returns>
        public virtual SphereCatalogCollection GetSphereCatalogs()
        {
            return GetCachedClient(client => new SphereCatalogCollection(client, Id));
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
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereCatalogResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SphereCatalogResource>> GetSphereCatalogAsync(string catalogName, CancellationToken cancellationToken = default)
        {
            return await GetSphereCatalogs().GetAsync(catalogName, cancellationToken).ConfigureAwait(false);
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
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereCatalogResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SphereCatalogResource> GetSphereCatalog(string catalogName, CancellationToken cancellationToken = default)
        {
            return GetSphereCatalogs().Get(catalogName, cancellationToken);
        }
    }
}
