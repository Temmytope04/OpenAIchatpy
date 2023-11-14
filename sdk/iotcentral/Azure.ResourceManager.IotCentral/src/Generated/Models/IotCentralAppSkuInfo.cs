// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> Information about the SKU of the IoT Central application. </summary>
    public partial class IotCentralAppSkuInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotCentralAppSkuInfo"/>. </summary>
        /// <param name="name"> The name of the SKU. </param>
        public IotCentralAppSkuInfo(IotCentralAppSku name)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="IotCentralAppSkuInfo"/>. </summary>
        /// <param name="name"> The name of the SKU. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotCentralAppSkuInfo(IotCentralAppSku name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IotCentralAppSkuInfo"/> for deserialization. </summary>
        internal IotCentralAppSkuInfo()
        {
        }

        /// <summary> The name of the SKU. </summary>
        public IotCentralAppSku Name { get; set; }
    }
}
