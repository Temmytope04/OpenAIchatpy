// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> KeyPolicy assigned to the storage account. </summary>
    internal partial class StorageAccountKeyPolicy
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageAccountKeyPolicy"/>. </summary>
        /// <param name="keyExpirationPeriodInDays"> The key expiration period in days. </param>
        public StorageAccountKeyPolicy(int keyExpirationPeriodInDays)
        {
            KeyExpirationPeriodInDays = keyExpirationPeriodInDays;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountKeyPolicy"/>. </summary>
        /// <param name="keyExpirationPeriodInDays"> The key expiration period in days. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountKeyPolicy(int keyExpirationPeriodInDays, Dictionary<string, BinaryData> rawData)
        {
            KeyExpirationPeriodInDays = keyExpirationPeriodInDays;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountKeyPolicy"/> for deserialization. </summary>
        internal StorageAccountKeyPolicy()
        {
        }

        /// <summary> The key expiration period in days. </summary>
        public int KeyExpirationPeriodInDays { get; set; }
    }
}
