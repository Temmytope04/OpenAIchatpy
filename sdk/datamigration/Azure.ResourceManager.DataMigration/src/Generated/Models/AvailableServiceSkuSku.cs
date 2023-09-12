// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> SKU name, tier, etc. </summary>
    public partial class AvailableServiceSkuSku
    {
        /// <summary> Initializes a new instance of AvailableServiceSkuSku. </summary>
        internal AvailableServiceSkuSku()
        {
        }

        /// <summary> Initializes a new instance of AvailableServiceSkuSku. </summary>
        /// <param name="name"> The name of the SKU. </param>
        /// <param name="family"> SKU family. </param>
        /// <param name="size"> SKU size. </param>
        /// <param name="tier"> The tier of the SKU, such as "Basic", "General Purpose", or "Business Critical". </param>
        internal AvailableServiceSkuSku(string name, string family, string size, string tier)
        {
            Name = name;
            Family = family;
            Size = size;
            Tier = tier;
        }

        /// <summary> The name of the SKU. </summary>
        public string Name { get; }
        /// <summary> SKU family. </summary>
        public string Family { get; }
        /// <summary> SKU size. </summary>
        public string Size { get; }
        /// <summary> The tier of the SKU, such as "Basic", "General Purpose", or "Business Critical". </summary>
        public string Tier { get; }
    }
}
