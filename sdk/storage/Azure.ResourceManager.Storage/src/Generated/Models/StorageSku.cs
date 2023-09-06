// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The SKU of the storage account. </summary>
    public partial class StorageSku
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageSku"/>. </summary>
        /// <param name="name"> The SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called accountType. </param>
        public StorageSku(StorageSkuName name)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="StorageSku"/>. </summary>
        /// <param name="name"> The SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called accountType. </param>
        /// <param name="tier"> The SKU tier. This is based on the SKU name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageSku(StorageSkuName name, StorageSkuTier? tier, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Tier = tier;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageSku"/> for deserialization. </summary>
        internal StorageSku()
        {
        }

        /// <summary> The SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called accountType. </summary>
        public StorageSkuName Name { get; set; }
        /// <summary> The SKU tier. This is based on the SKU name. </summary>
        public StorageSkuTier? Tier { get; }
    }
}
