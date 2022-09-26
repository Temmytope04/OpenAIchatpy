// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Base class for provider specific input.
    /// Please note <see cref="PolicyProviderSpecificInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="A2APolicyCreationInput"/>, <see cref="A2ACrossClusterMigrationPolicyCreationInput"/>, <see cref="HyperVReplicaPolicyInput"/>, <see cref="HyperVReplicaBluePolicyInput"/>, <see cref="HyperVReplicaAzurePolicyInput"/>, <see cref="InMagePolicyInput"/>, <see cref="InMageAzureV2PolicyInput"/>, <see cref="InMageRcmPolicyCreationInput"/>, <see cref="InMageRcmFailbackPolicyCreationInput"/> and <see cref="VMwareCbtPolicyCreationInput"/>.
    /// </summary>
    public abstract partial class PolicyProviderSpecificInput
    {
        /// <summary> Initializes a new instance of PolicyProviderSpecificInput. </summary>
        protected PolicyProviderSpecificInput()
        {
        }

        /// <summary> The class type. </summary>
        internal string InstanceType { get; set; }
    }
}
