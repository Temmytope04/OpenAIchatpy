// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> Resource SKU Details. </summary>
    public partial class ResourceSkuInfo
    {
        /// <summary> Initializes a new instance of ResourceSkuInfo. </summary>
        internal ResourceSkuInfo()
        {
            Capabilities = new ChangeTrackingList<ResourceSkuCapability>();
            Restrictions = new ChangeTrackingList<StoragePoolSkuRestrictions>();
        }

        /// <summary> Initializes a new instance of ResourceSkuInfo. </summary>
        /// <param name="apiVersion"> StoragePool RP API version. </param>
        /// <param name="resourceType"> StoragePool resource type. </param>
        /// <param name="capabilities"> List of additional capabilities for StoragePool resource. </param>
        /// <param name="locationInfo"> Zones and zone capabilities in those locations where the SKU is available. </param>
        /// <param name="name"> Sku name. </param>
        /// <param name="tier"> Sku tier. </param>
        /// <param name="restrictions"> The restrictions because of which SKU cannot be used. This is empty if there are no restrictions. </param>
        internal ResourceSkuInfo(string apiVersion, string resourceType, IReadOnlyList<ResourceSkuCapability> capabilities, ResourceSkuLocationInfo locationInfo, string name, string tier, IReadOnlyList<StoragePoolSkuRestrictions> restrictions)
        {
            ApiVersion = apiVersion;
            ResourceType = resourceType;
            Capabilities = capabilities;
            LocationInfo = locationInfo;
            Name = name;
            Tier = tier;
            Restrictions = restrictions;
        }

        /// <summary> StoragePool RP API version. </summary>
        public string ApiVersion { get; }
        /// <summary> StoragePool resource type. </summary>
        public string ResourceType { get; }
        /// <summary> List of additional capabilities for StoragePool resource. </summary>
        public IReadOnlyList<ResourceSkuCapability> Capabilities { get; }
        /// <summary> Zones and zone capabilities in those locations where the SKU is available. </summary>
        public ResourceSkuLocationInfo LocationInfo { get; }
        /// <summary> Sku name. </summary>
        public string Name { get; }
        /// <summary> Sku tier. </summary>
        public string Tier { get; }
        /// <summary> The restrictions because of which SKU cannot be used. This is empty if there are no restrictions. </summary>
        public IReadOnlyList<StoragePoolSkuRestrictions> Restrictions { get; }
    }
}
