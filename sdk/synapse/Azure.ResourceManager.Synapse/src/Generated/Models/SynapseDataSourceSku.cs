// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Azure SKU definition. </summary>
    public partial class SynapseDataSourceSku
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseDataSourceSku"/>. </summary>
        /// <param name="name"> SKU name. </param>
        /// <param name="size"> SKU size. </param>
        public SynapseDataSourceSku(SynapseSkuName name, KustoPoolSkuSize size)
        {
            Name = name;
            Size = size;
        }

        /// <summary> Initializes a new instance of <see cref="SynapseDataSourceSku"/>. </summary>
        /// <param name="name"> SKU name. </param>
        /// <param name="capacity"> The number of instances of the cluster. </param>
        /// <param name="size"> SKU size. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseDataSourceSku(SynapseSkuName name, int? capacity, KustoPoolSkuSize size, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Capacity = capacity;
            Size = size;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SynapseDataSourceSku"/> for deserialization. </summary>
        internal SynapseDataSourceSku()
        {
        }

        /// <summary> SKU name. </summary>
        public SynapseSkuName Name { get; set; }
        /// <summary> The number of instances of the cluster. </summary>
        public int? Capacity { get; set; }
        /// <summary> SKU size. </summary>
        public KustoPoolSkuSize Size { get; set; }
    }
}
