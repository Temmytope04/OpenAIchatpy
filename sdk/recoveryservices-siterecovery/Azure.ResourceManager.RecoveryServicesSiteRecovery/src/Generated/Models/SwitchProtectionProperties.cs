// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Switch protection input properties. </summary>
    public partial class SwitchProtectionProperties
    {
        /// <summary> Initializes a new instance of SwitchProtectionProperties. </summary>
        public SwitchProtectionProperties()
        {
        }

        /// <summary> The unique replication protected item name. </summary>
        public string ReplicationProtectedItemName { get; set; }
        /// <summary>
        /// Provider specific switch protection input.
        /// Please note <see cref="SwitchProtectionProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2ASwitchProtectionContent"/>.
        /// </summary>
        public SwitchProtectionProviderSpecificContent ProviderSpecificDetails { get; set; }
    }
}
