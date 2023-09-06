// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.TrafficManager.Models
{
    /// <summary> The core properties of ARM resources. </summary>
    public partial class TrafficManagerResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TrafficManagerResourceData"/>. </summary>
        public TrafficManagerResourceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TrafficManagerResourceData"/>. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="resourceType"> The type of the resource. Ex- Microsoft.Network/trafficManagerProfiles. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TrafficManagerResourceData(ResourceIdentifier id, string name, ResourceType? resourceType, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
            _rawData = rawData;
        }

        /// <summary> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{resourceName}. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> The name of the resource. </summary>
        public string Name { get; set; }
        /// <summary> The type of the resource. Ex- Microsoft.Network/trafficManagerProfiles. </summary>
        public ResourceType? ResourceType { get; set; }
    }
}
