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
using Azure.ResourceManager.KeyVault;

namespace Azure.ResourceManager.KeyVault.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class KeyVaultResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="KeyVaultResourceGroupMockingExtension"/> class for mocking. </summary>
        protected KeyVaultResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KeyVaultResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal KeyVaultResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of KeyVaultResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of KeyVaultResources and their operations over a KeyVaultResource. </returns>
        public virtual KeyVaultCollection GetKeyVaults()
        {
            return GetCachedClient(Client => new KeyVaultCollection(Client, Id));
        }

        /// <summary>
        /// Gets the specified Azure key vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<KeyVaultResource>> GetKeyVaultAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            return await GetKeyVaults().GetAsync(vaultName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Azure key vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<KeyVaultResource> GetKeyVault(string vaultName, CancellationToken cancellationToken = default)
        {
            return GetKeyVaults().Get(vaultName, cancellationToken);
        }

        /// <summary> Gets a collection of ManagedHsmResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ManagedHsmResources and their operations over a ManagedHsmResource. </returns>
        public virtual ManagedHsmCollection GetManagedHsms()
        {
            return GetCachedClient(Client => new ManagedHsmCollection(Client, Id));
        }

        /// <summary>
        /// Gets the specified managed HSM Pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedHsms_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the managed HSM Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ManagedHsmResource>> GetManagedHsmAsync(string name, CancellationToken cancellationToken = default)
        {
            return await GetManagedHsms().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified managed HSM Pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedHsms_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the managed HSM Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<ManagedHsmResource> GetManagedHsm(string name, CancellationToken cancellationToken = default)
        {
            return GetManagedHsms().Get(name, cancellationToken);
        }
    }
}
