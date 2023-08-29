// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Describes Az Resiliency status of Base resources. </summary>
    public partial class ResourceAzStatus
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceAzStatus"/>. </summary>
        internal ResourceAzStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceAzStatus"/>. </summary>
        /// <param name="resourceName"> VM Size properties. </param>
        /// <param name="resourceType"> VM Size id. </param>
        /// <param name="isZoneResilient"> VM Size name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceAzStatus(string resourceName, ResourceType? resourceType, bool? isZoneResilient, Dictionary<string, BinaryData> rawData)
        {
            ResourceName = resourceName;
            ResourceType = resourceType;
            IsZoneResilient = isZoneResilient;
            _rawData = rawData;
        }

        /// <summary> VM Size properties. </summary>
        public string ResourceName { get; }
        /// <summary> VM Size id. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> VM Size name. </summary>
        public bool? IsZoneResilient { get; }
    }
}
