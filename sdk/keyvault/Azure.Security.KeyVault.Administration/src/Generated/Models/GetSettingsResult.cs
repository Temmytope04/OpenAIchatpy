// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration
{
    /// <summary> The settings list result. </summary>
    public partial class GetSettingsResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GetSettingsResult"/>. </summary>
        internal GetSettingsResult()
        {
            Settings = new ChangeTrackingList<KeyVaultSetting>();
        }

        /// <summary> Initializes a new instance of <see cref="GetSettingsResult"/>. </summary>
        /// <param name="settings"> A response message containing a list of account settings with their associated value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GetSettingsResult(IReadOnlyList<KeyVaultSetting> settings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Settings = settings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A response message containing a list of account settings with their associated value. </summary>
        public IReadOnlyList<KeyVaultSetting> Settings { get; }
    }
}
