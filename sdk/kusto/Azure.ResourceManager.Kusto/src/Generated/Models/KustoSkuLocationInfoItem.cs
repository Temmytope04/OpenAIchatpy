// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The locations and zones info for SKU. </summary>
    public partial class KustoSkuLocationInfoItem
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KustoSkuLocationInfoItem"/>. </summary>
        /// <param name="location"> The available location of the SKU. </param>
        internal KustoSkuLocationInfoItem(AzureLocation location)
        {
            Location = location;
            Zones = new ChangeTrackingList<string>();
            ZoneDetails = new ChangeTrackingList<KustoResourceSkuZoneDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="KustoSkuLocationInfoItem"/>. </summary>
        /// <param name="location"> The available location of the SKU. </param>
        /// <param name="zones"> The available zone of the SKU. </param>
        /// <param name="zoneDetails"> Gets details of capabilities available to a SKU in specific zones. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoSkuLocationInfoItem(AzureLocation location, IReadOnlyList<string> zones, IReadOnlyList<KustoResourceSkuZoneDetails> zoneDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Location = location;
            Zones = zones;
            ZoneDetails = zoneDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="KustoSkuLocationInfoItem"/> for deserialization. </summary>
        internal KustoSkuLocationInfoItem()
        {
        }

        /// <summary> The available location of the SKU. </summary>
        public AzureLocation Location { get; }
        /// <summary> The available zone of the SKU. </summary>
        public IReadOnlyList<string> Zones { get; }
        /// <summary> Gets details of capabilities available to a SKU in specific zones. </summary>
        public IReadOnlyList<KustoResourceSkuZoneDetails> ZoneDetails { get; }
    }
}
