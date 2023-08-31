// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The ApiManagementSkuRestrictionInfo. </summary>
    public partial class ApiManagementSkuRestrictionInfo
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApiManagementSkuRestrictionInfo"/>. </summary>
        internal ApiManagementSkuRestrictionInfo()
        {
            Locations = new ChangeTrackingList<AzureLocation>();
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementSkuRestrictionInfo"/>. </summary>
        /// <param name="locations"> Locations where the SKU is restricted. </param>
        /// <param name="zones"> List of availability zones where the SKU is restricted. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementSkuRestrictionInfo(IReadOnlyList<AzureLocation> locations, IReadOnlyList<string> zones, Dictionary<string, BinaryData> rawData)
        {
            Locations = locations;
            Zones = zones;
            _rawData = rawData;
        }

        /// <summary> Locations where the SKU is restricted. </summary>
        public IReadOnlyList<AzureLocation> Locations { get; }
        /// <summary> List of availability zones where the SKU is restricted. </summary>
        public IReadOnlyList<string> Zones { get; }
    }
}
