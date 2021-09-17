// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes the parameters for using a user&apos;s KeyVault certificate for securing custom domain. </summary>
    public partial class KeyVaultCertificateSourceParameters
    {
        /// <summary> Initializes a new instance of KeyVaultCertificateSourceParameters. </summary>
        /// <param name="subscriptionId"> Subscription Id of the user&apos;s Key Vault containing the SSL certificate. </param>
        /// <param name="resourceGroupName"> Resource group of the user&apos;s Key Vault containing the SSL certificate. </param>
        /// <param name="vaultName"> The name of the user&apos;s Key Vault containing the SSL certificate. </param>
        /// <param name="secretName"> The name of Key Vault Secret (representing the full certificate PFX) in Key Vault. </param>
        /// <param name="updateRule"> Describes the action that shall be taken when the certificate is updated in Key Vault. </param>
        /// <param name="deleteRule"> Describes the action that shall be taken when the certificate is removed from Key Vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, or <paramref name="secretName"/> is null. </exception>
        public KeyVaultCertificateSourceParameters(string subscriptionId, string resourceGroupName, string vaultName, string secretName, UpdateRule updateRule, DeleteRule deleteRule)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (secretName == null)
            {
                throw new ArgumentNullException(nameof(secretName));
            }

            OdataType = "#Microsoft.Azure.Cdn.Models.KeyVaultCertificateSourceParameters";
            SubscriptionId = subscriptionId;
            ResourceGroupName = resourceGroupName;
            VaultName = vaultName;
            SecretName = secretName;
            UpdateRule = updateRule;
            DeleteRule = deleteRule;
        }

        /// <summary> Gets the odata type. </summary>
        public string OdataType { get; }
        /// <summary> Subscription Id of the user&apos;s Key Vault containing the SSL certificate. </summary>
        public string SubscriptionId { get; }
        /// <summary> Resource group of the user&apos;s Key Vault containing the SSL certificate. </summary>
        public string ResourceGroupName { get; }
        /// <summary> The name of the user&apos;s Key Vault containing the SSL certificate. </summary>
        public string VaultName { get; }
        /// <summary> The name of Key Vault Secret (representing the full certificate PFX) in Key Vault. </summary>
        public string SecretName { get; }
        /// <summary> The version(GUID) of Key Vault Secret in Key Vault. </summary>
        public string SecretVersion { get; set; }
        /// <summary> Describes the action that shall be taken when the certificate is updated in Key Vault. </summary>
        public UpdateRule UpdateRule { get; }
        /// <summary> Describes the action that shall be taken when the certificate is removed from Key Vault. </summary>
        public DeleteRule DeleteRule { get; }
    }
}
