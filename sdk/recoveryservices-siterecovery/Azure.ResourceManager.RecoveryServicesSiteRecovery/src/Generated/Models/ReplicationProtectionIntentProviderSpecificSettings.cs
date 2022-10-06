// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Replication provider specific settings.
    /// Please note <see cref="ReplicationProtectionIntentProviderSpecificSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="A2AReplicationIntentDetails"/>.
    /// </summary>
    public abstract partial class ReplicationProtectionIntentProviderSpecificSettings
    {
        /// <summary> Initializes a new instance of ReplicationProtectionIntentProviderSpecificSettings. </summary>
        protected ReplicationProtectionIntentProviderSpecificSettings()
        {
        }

        /// <summary> Initializes a new instance of ReplicationProtectionIntentProviderSpecificSettings. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        internal ReplicationProtectionIntentProviderSpecificSettings(string instanceType)
        {
            InstanceType = instanceType;
        }

        /// <summary> Gets the Instance type. </summary>
        internal string InstanceType { get; set; }
    }
}
