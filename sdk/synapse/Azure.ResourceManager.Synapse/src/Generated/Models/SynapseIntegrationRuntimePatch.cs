// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Update integration runtime request. </summary>
    public partial class SynapseIntegrationRuntimePatch
    {
        /// <summary> Initializes a new instance of SynapseIntegrationRuntimePatch. </summary>
        public SynapseIntegrationRuntimePatch()
        {
        }

        /// <summary> Enables or disables the auto-update feature of the self-hosted integration runtime. See https://go.microsoft.com/fwlink/?linkid=854189. </summary>
        public SynapseIntegrationRuntimeAutoUpdate? AutoUpdate { get; set; }
        /// <summary> The time offset (in hours) in the day, e.g., PT03H is 3 hours. The integration runtime auto update will happen on that time. </summary>
        public string UpdateDelayOffset { get; set; }
    }
}
