// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Base class for Provider specific details for policies.
    /// Please note <see cref="PolicyProviderSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="A2APolicyDetails"/>, <see cref="HyperVReplicaPolicyDetails"/>, <see cref="HyperVReplicaBluePolicyDetails"/>, <see cref="HyperVReplicaAzurePolicyDetails"/>, <see cref="HyperVReplicaBasePolicyDetails"/>, <see cref="InMagePolicyDetails"/>, <see cref="InMageAzureV2PolicyDetails"/>, <see cref="InMageBasePolicyDetails"/>, <see cref="InMageRcmPolicyDetails"/>, <see cref="InMageRcmFailbackPolicyDetails"/> and <see cref="VMwareCbtPolicyDetails"/>.
    /// </summary>
    public abstract partial class PolicyProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of PolicyProviderSpecificDetails. </summary>
        protected PolicyProviderSpecificDetails()
        {
        }

        /// <summary> Initializes a new instance of PolicyProviderSpecificDetails. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        internal PolicyProviderSpecificDetails(string instanceType)
        {
            InstanceType = instanceType;
        }

        /// <summary> Gets the class type. Overridden in derived classes. </summary>
        internal string InstanceType { get; set; }
    }
}
