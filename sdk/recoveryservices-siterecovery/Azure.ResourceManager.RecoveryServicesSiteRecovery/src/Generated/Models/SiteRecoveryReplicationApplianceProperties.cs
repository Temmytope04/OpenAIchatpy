// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Replication appliance properties. </summary>
    internal partial class SiteRecoveryReplicationApplianceProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryReplicationApplianceProperties"/>. </summary>
        internal SiteRecoveryReplicationApplianceProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryReplicationApplianceProperties"/>. </summary>
        /// <param name="providerSpecificDetails">
        /// Provider specific settings.
        /// Please note <see cref="SiteRecoveryApplianceSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="InMageRcmApplianceSpecificDetails"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryReplicationApplianceProperties(SiteRecoveryApplianceSpecificDetails providerSpecificDetails, Dictionary<string, BinaryData> rawData)
        {
            ProviderSpecificDetails = providerSpecificDetails;
            _rawData = rawData;
        }

        /// <summary>
        /// Provider specific settings.
        /// Please note <see cref="SiteRecoveryApplianceSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="InMageRcmApplianceSpecificDetails"/>.
        /// </summary>
        public SiteRecoveryApplianceSpecificDetails ProviderSpecificDetails { get; }
    }
}
