// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary>
    /// A resource SKU capability.
    /// Serialized Name: ResourceSkuCapabilities
    /// </summary>
    public partial class StorageCacheSkuCapability
    {
        /// <summary> Initializes a new instance of StorageCacheSkuCapability. </summary>
        internal StorageCacheSkuCapability()
        {
        }

        /// <summary> Initializes a new instance of StorageCacheSkuCapability. </summary>
        /// <param name="name">
        /// Name of a capability, such as ops/sec.
        /// Serialized Name: ResourceSkuCapabilities.name
        /// </param>
        /// <param name="value">
        /// Quantity, if the capability is measured by quantity.
        /// Serialized Name: ResourceSkuCapabilities.value
        /// </param>
        internal StorageCacheSkuCapability(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Name of a capability, such as ops/sec.
        /// Serialized Name: ResourceSkuCapabilities.name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Quantity, if the capability is measured by quantity.
        /// Serialized Name: ResourceSkuCapabilities.value
        /// </summary>
        public string Value { get; }
    }
}
