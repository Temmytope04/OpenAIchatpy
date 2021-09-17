// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The tracking states for afd resources. </summary>
    public partial class AFDStateProperties
    {
        /// <summary> Initializes a new instance of AFDStateProperties. </summary>
        public AFDStateProperties()
        {
        }

        /// <summary> Provisioning status. </summary>
        public AfdProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the deployment status. </summary>
        public DeploymentStatus? DeploymentStatus { get; }
    }
}
