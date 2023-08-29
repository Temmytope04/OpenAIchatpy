// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.TrafficManager.Models
{
    /// <summary> Parameters supplied to check Traffic Manager name operation. </summary>
    public partial class TrafficManagerRelativeDnsNameAvailabilityContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TrafficManagerRelativeDnsNameAvailabilityContent"/>. </summary>
        public TrafficManagerRelativeDnsNameAvailabilityContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TrafficManagerRelativeDnsNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TrafficManagerRelativeDnsNameAvailabilityContent(string name, ResourceType? resourceType, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ResourceType = resourceType;
            _rawData = rawData;
        }

        /// <summary> The name of the resource. </summary>
        public string Name { get; set; }
        /// <summary> The type of the resource. </summary>
        public ResourceType? ResourceType { get; set; }
    }
}
