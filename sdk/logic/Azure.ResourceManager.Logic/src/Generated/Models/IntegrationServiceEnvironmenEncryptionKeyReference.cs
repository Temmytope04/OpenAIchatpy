// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The encryption key details for the integration service environment. </summary>
    public partial class IntegrationServiceEnvironmenEncryptionKeyReference
    {
        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmenEncryptionKeyReference"/>. </summary>
        public IntegrationServiceEnvironmenEncryptionKeyReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmenEncryptionKeyReference"/>. </summary>
        /// <param name="keyVault"> The key vault reference. </param>
        /// <param name="keyName"> Gets the key name in the Key Vault. </param>
        /// <param name="keyVersion"> Gets the version of the key specified in the keyName property. </param>
        internal IntegrationServiceEnvironmenEncryptionKeyReference(LogicResourceReference keyVault, string keyName, string keyVersion)
        {
            KeyVault = keyVault;
            KeyName = keyName;
            KeyVersion = keyVersion;
        }

        /// <summary> The key vault reference. </summary>
        public LogicResourceReference KeyVault { get; set; }
        /// <summary> Gets the key name in the Key Vault. </summary>
        public string KeyName { get; set; }
        /// <summary> Gets the version of the key specified in the keyName property. </summary>
        public string KeyVersion { get; set; }
    }
}
