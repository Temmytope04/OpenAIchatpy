// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Update network mappings input properties/behavior specific to vmm to vmm. </summary>
    public partial class VmmToVmmUpdateNetworkMappingContent : FabricSpecificUpdateNetworkMappingContent
    {
        /// <summary> Initializes a new instance of <see cref="VmmToVmmUpdateNetworkMappingContent"/>. </summary>
        public VmmToVmmUpdateNetworkMappingContent()
        {
            InstanceType = "VmmToVmm";
        }

        /// <summary> Initializes a new instance of <see cref="VmmToVmmUpdateNetworkMappingContent"/>. </summary>
        /// <param name="instanceType"> The instance type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VmmToVmmUpdateNetworkMappingContent(string instanceType, Dictionary<string, BinaryData> rawData) : base(instanceType, rawData)
        {
            InstanceType = instanceType ?? "VmmToVmm";
        }
    }
}
