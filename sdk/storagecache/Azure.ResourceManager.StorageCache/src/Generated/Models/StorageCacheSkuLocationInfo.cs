// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Resource SKU location information. </summary>
    public partial class StorageCacheSkuLocationInfo
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageCacheSkuLocationInfo"/>. </summary>
        internal StorageCacheSkuLocationInfo()
        {
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageCacheSkuLocationInfo"/>. </summary>
        /// <param name="location"> Location where this SKU is available. </param>
        /// <param name="zones"> Zones if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageCacheSkuLocationInfo(AzureLocation? location, IReadOnlyList<string> zones, Dictionary<string, BinaryData> rawData)
        {
            Location = location;
            Zones = zones;
            _rawData = rawData;
        }

        /// <summary> Location where this SKU is available. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Zones if any. </summary>
        public IReadOnlyList<string> Zones { get; }
    }
}
