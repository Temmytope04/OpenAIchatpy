// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The streaming endpoint sku capacity. </summary>
    public partial class StreamingEndpointCapacity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StreamingEndpointCapacity"/>. </summary>
        internal StreamingEndpointCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StreamingEndpointCapacity"/>. </summary>
        /// <param name="scaleType"></param>
        /// <param name="default"> The streaming endpoint default capacity. </param>
        /// <param name="minimum"> The streaming endpoint minimum capacity. </param>
        /// <param name="maximum"> The streaming endpoint maximum capacity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamingEndpointCapacity(string scaleType, int? @default, int? minimum, int? maximum, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ScaleType = scaleType;
            Default = @default;
            Minimum = minimum;
            Maximum = maximum;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the scale type. </summary>
        public string ScaleType { get; }
        /// <summary> The streaming endpoint default capacity. </summary>
        public int? Default { get; }
        /// <summary> The streaming endpoint minimum capacity. </summary>
        public int? Minimum { get; }
        /// <summary> The streaming endpoint maximum capacity. </summary>
        public int? Maximum { get; }
    }
}
