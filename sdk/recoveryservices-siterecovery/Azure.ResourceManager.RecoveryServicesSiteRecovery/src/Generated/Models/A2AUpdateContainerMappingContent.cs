// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A update protection container mapping. </summary>
    public partial class A2AUpdateContainerMappingContent : ReplicationProviderSpecificUpdateContainerMappingContent
    {
        /// <summary> Initializes a new instance of A2AUpdateContainerMappingContent. </summary>
        public A2AUpdateContainerMappingContent()
        {
            InstanceType = "A2A";
        }

        /// <summary> A value indicating whether the auto update is enabled. </summary>
        public SiteRecoveryAgentAutoUpdateStatus? AgentAutoUpdateStatus { get; set; }
        /// <summary> The automation account arm id. </summary>
        public ResourceIdentifier AutomationAccountArmId { get; set; }
        /// <summary> A value indicating the type authentication to use for automation Account. </summary>
        public AutomationAccountAuthenticationType? AutomationAccountAuthenticationType { get; set; }
    }
}
