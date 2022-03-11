// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of Vaults in the Vault. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of Vaults and their operations over a Vault. </returns>
        public static VaultCollection GetVaults(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetVaults();
        }

        /// <summary>
        /// Gets the specified Azure key vault.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
        /// Operation Id: Vaults_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public static async Task<Response<Vault>> GetVaultAsync(this ResourceGroup resourceGroup, string vaultName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetVaults().GetAsync(vaultName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Azure key vault.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
        /// Operation Id: Vaults_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public static Response<Vault> GetVault(this ResourceGroup resourceGroup, string vaultName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetVaults().Get(vaultName, cancellationToken);
        }

        /// <summary> Gets a collection of ManagedHsms in the ManagedHsm. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ManagedHsms and their operations over a ManagedHsm. </returns>
        public static ManagedHsmCollection GetManagedHsms(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetManagedHsms();
        }

        /// <summary>
        /// Gets the specified managed HSM Pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}
        /// Operation Id: ManagedHsms_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The name of the managed HSM Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static async Task<Response<ManagedHsm>> GetManagedHsmAsync(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetManagedHsms().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified managed HSM Pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}
        /// Operation Id: ManagedHsms_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The name of the managed HSM Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static Response<ManagedHsm> GetManagedHsm(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetManagedHsms().Get(name, cancellationToken);
        }
    }
}
