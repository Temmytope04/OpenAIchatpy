// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Provider specific test failover input.
    /// Please note <see cref="TestFailoverProviderSpecificInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="A2ATestFailoverInput"/>, <see cref="HyperVReplicaAzureTestFailoverInput"/>, <see cref="InMageTestFailoverInput"/>, <see cref="InMageAzureV2TestFailoverInput"/> and <see cref="InMageRcmTestFailoverInput"/>.
    /// </summary>
    public abstract partial class TestFailoverProviderSpecificInput
    {
        /// <summary> Initializes a new instance of TestFailoverProviderSpecificInput. </summary>
        protected TestFailoverProviderSpecificInput()
        {
        }

        /// <summary> The class type. </summary>
        internal string InstanceType { get; set; }
    }
}
