// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The StreamingEndpointSkuInfo. </summary>
    public partial class StreamingEndpointSkuInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StreamingEndpointSkuInfo"/>. </summary>
        internal StreamingEndpointSkuInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StreamingEndpointSkuInfo"/>. </summary>
        /// <param name="resourceType"></param>
        /// <param name="capacity"> The streaming endpoint sku capacity. </param>
        /// <param name="sku"> The streaming endpoint sku. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamingEndpointSkuInfo(ResourceType? resourceType, StreamingEndpointCapacity capacity, StreamingEndpointSku sku, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceType = resourceType;
            Capacity = capacity;
            Sku = sku;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the resource type. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> The streaming endpoint sku capacity. </summary>
        public StreamingEndpointCapacity Capacity { get; }
        /// <summary> The streaming endpoint sku. </summary>
        internal StreamingEndpointSku Sku { get; }
        /// <summary> The streaming endpoint sku name. </summary>
        public string SkuName
        {
            get => Sku?.Name;
        }
    }
}
