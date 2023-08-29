// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Capabilities response for Microsoft.RecoveryServices. </summary>
    public partial class CapabilitiesResult : ResourceCapabilitiesBase
    {
        /// <summary> Initializes a new instance of <see cref="CapabilitiesResult"/>. </summary>
        /// <param name="resourceCapabilitiesBaseType"> Describes the Resource type: Microsoft.RecoveryServices/Vaults. </param>
        public CapabilitiesResult(ResourceType resourceCapabilitiesBaseType) : base(resourceCapabilitiesBaseType)
        {
        }

        /// <summary> Initializes a new instance of <see cref="CapabilitiesResult"/>. </summary>
        /// <param name="resourceCapabilitiesBaseType"> Describes the Resource type: Microsoft.RecoveryServices/Vaults. </param>
        /// <param name="properties"> Capabilities properties in response. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CapabilitiesResult(ResourceType resourceCapabilitiesBaseType, CapabilitiesResultProperties properties, Dictionary<string, BinaryData> rawData) : base(resourceCapabilitiesBaseType, rawData)
        {
            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="CapabilitiesResult"/> for deserialization. </summary>
        internal CapabilitiesResult()
        {
        }

        /// <summary> Capabilities properties in response. </summary>
        internal CapabilitiesResultProperties Properties { get; set; }
        /// <summary> Gets the capabilities result dns zones. </summary>
        public IList<DnsZoneResult> CapabilitiesResultDnsZones
        {
            get
            {
                if (Properties is null)
                    Properties = new CapabilitiesResultProperties();
                return Properties.DnsZones;
            }
        }
    }
}
