// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A customer-managed encryption key in Azure Key Vault. Keys that you create and manage can be used to encrypt or decrypt data-at-rest in Azure Cognitive Search, such as indexes and synonym maps. </summary>
    public partial class SearchResourceEncryptionKey
    {
        /// <summary> Initializes a new instance of SearchResourceEncryptionKey. </summary>
        /// <param name="keyName"> The name of your Azure Key Vault key to be used to encrypt your data at rest. </param>
        /// <param name="keyVersion"> The version of your Azure Key Vault key to be used to encrypt your data at rest. </param>
        /// <param name="vaultUri"> The URI of your Azure Key Vault, also referred to as DNS name, that contains the key to be used to encrypt your data at rest. An example URI might be https://my-keyvault-name.vault.azure.net. </param>
        /// <param name="accessCredentialsInternal"> Optional Azure Active Directory credentials used for accessing your Azure Key Vault. Not required if using managed identity instead. </param>
        internal SearchResourceEncryptionKey(string keyName, string keyVersion, string vaultUri, AzureActiveDirectoryApplicationCredentials accessCredentialsInternal)
        {
            KeyName = keyName;
            KeyVersion = keyVersion;
            _vaultUri = vaultUri;
            AccessCredentialsInternal = accessCredentialsInternal;
        }
    }
}
