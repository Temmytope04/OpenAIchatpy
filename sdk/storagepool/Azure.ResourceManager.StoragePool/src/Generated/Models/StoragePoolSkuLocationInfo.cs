// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> Zone and capability info for resource sku. </summary>
    public partial class StoragePoolSkuLocationInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StoragePoolSkuLocationInfo"/>. </summary>
        internal StoragePoolSkuLocationInfo()
        {
            Zones = new ChangeTrackingList<string>();
            ZoneDetails = new ChangeTrackingList<StoragePoolSkuZoneDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="StoragePoolSkuLocationInfo"/>. </summary>
        /// <param name="location"> Location of the SKU. </param>
        /// <param name="zones"> List of availability zones where the SKU is supported. </param>
        /// <param name="zoneDetails"> Details of capabilities available to a SKU in specific zones. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StoragePoolSkuLocationInfo(AzureLocation? location, IReadOnlyList<string> zones, IReadOnlyList<StoragePoolSkuZoneDetails> zoneDetails, Dictionary<string, BinaryData> rawData)
        {
            Location = location;
            Zones = zones;
            ZoneDetails = zoneDetails;
            _rawData = rawData;
        }

        /// <summary> Location of the SKU. </summary>
        public AzureLocation? Location { get; }
        /// <summary> List of availability zones where the SKU is supported. </summary>
        public IReadOnlyList<string> Zones { get; }
        /// <summary> Details of capabilities available to a SKU in specific zones. </summary>
        public IReadOnlyList<StoragePoolSkuZoneDetails> ZoneDetails { get; }
    }
}
