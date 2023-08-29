// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Base class for request and response capabilities information for Microsoft.RecoveryServices. </summary>
    public partial class ResourceCapabilitiesBase
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceCapabilitiesBase"/>. </summary>
        /// <param name="resourceCapabilitiesBaseType"> Describes the Resource type: Microsoft.RecoveryServices/Vaults. </param>
        public ResourceCapabilitiesBase(ResourceType resourceCapabilitiesBaseType)
        {
            ResourceCapabilitiesBaseType = resourceCapabilitiesBaseType;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceCapabilitiesBase"/>. </summary>
        /// <param name="resourceCapabilitiesBaseType"> Describes the Resource type: Microsoft.RecoveryServices/Vaults. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceCapabilitiesBase(ResourceType resourceCapabilitiesBaseType, Dictionary<string, BinaryData> rawData)
        {
            ResourceCapabilitiesBaseType = resourceCapabilitiesBaseType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceCapabilitiesBase"/> for deserialization. </summary>
        internal ResourceCapabilitiesBase()
        {
        }

        /// <summary> Describes the Resource type: Microsoft.RecoveryServices/Vaults. </summary>
        public ResourceType ResourceCapabilitiesBaseType { get; set; }
    }
}
