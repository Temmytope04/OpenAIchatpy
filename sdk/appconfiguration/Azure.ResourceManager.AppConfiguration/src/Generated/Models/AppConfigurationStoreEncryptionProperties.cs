// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> The encryption settings for a configuration store. </summary>
    internal partial class AppConfigurationStoreEncryptionProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppConfigurationStoreEncryptionProperties"/>. </summary>
        public AppConfigurationStoreEncryptionProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppConfigurationStoreEncryptionProperties"/>. </summary>
        /// <param name="keyVaultProperties"> Key vault properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppConfigurationStoreEncryptionProperties(AppConfigurationKeyVaultProperties keyVaultProperties, Dictionary<string, BinaryData> rawData)
        {
            KeyVaultProperties = keyVaultProperties;
            _rawData = rawData;
        }

        /// <summary> Key vault properties. </summary>
        public AppConfigurationKeyVaultProperties KeyVaultProperties { get; set; }
    }
}
