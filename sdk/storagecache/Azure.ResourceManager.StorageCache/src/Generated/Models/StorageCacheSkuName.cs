// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> SKU for the resource. </summary>
    internal partial class StorageCacheSkuName
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageCacheSkuName"/>. </summary>
        public StorageCacheSkuName()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageCacheSkuName"/>. </summary>
        /// <param name="name"> SKU name for this resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageCacheSkuName(string name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary> SKU name for this resource. </summary>
        public string Name { get; set; }
    }
}
