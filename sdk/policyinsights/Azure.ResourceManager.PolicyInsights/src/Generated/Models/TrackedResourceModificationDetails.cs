// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> The details of the policy triggered deployment that created or modified the tracked resource. </summary>
    public partial class TrackedResourceModificationDetails
    {
        /// <summary> Initializes a new instance of TrackedResourceModificationDetails. </summary>
        internal TrackedResourceModificationDetails()
        {
        }

        /// <summary> Initializes a new instance of TrackedResourceModificationDetails. </summary>
        /// <param name="policyDetails"> The details of the policy that created or modified the tracked resource. </param>
        /// <param name="deploymentId"> The ID of the deployment that created or modified the tracked resource. </param>
        /// <param name="deploymentOn"> Timestamp of the deployment that created or modified the tracked resource. </param>
        internal TrackedResourceModificationDetails(PolicyDetails policyDetails, string deploymentId, DateTimeOffset? deploymentOn)
        {
            PolicyDetails = policyDetails;
            DeploymentId = deploymentId;
            DeploymentOn = deploymentOn;
        }

        /// <summary> The details of the policy that created or modified the tracked resource. </summary>
        public PolicyDetails PolicyDetails { get; }
        /// <summary> The ID of the deployment that created or modified the tracked resource. </summary>
        public string DeploymentId { get; }
        /// <summary> Timestamp of the deployment that created or modified the tracked resource. </summary>
        public DateTimeOffset? DeploymentOn { get; }
    }
}
