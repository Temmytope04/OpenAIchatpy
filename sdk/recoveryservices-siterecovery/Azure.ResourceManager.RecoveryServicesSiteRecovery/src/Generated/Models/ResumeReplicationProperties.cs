// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Resume replication input properties. </summary>
    public partial class ResumeReplicationProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResumeReplicationProperties"/>. </summary>
        /// <param name="providerSpecificDetails">
        /// The provider specific input for resume replication.
        /// Please note <see cref="ResumeReplicationProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VMwareCbtResumeReplicationContent"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerSpecificDetails"/> is null. </exception>
        public ResumeReplicationProperties(ResumeReplicationProviderSpecificContent providerSpecificDetails)
        {
            Argument.AssertNotNull(providerSpecificDetails, nameof(providerSpecificDetails));

            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary> Initializes a new instance of <see cref="ResumeReplicationProperties"/>. </summary>
        /// <param name="providerSpecificDetails">
        /// The provider specific input for resume replication.
        /// Please note <see cref="ResumeReplicationProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VMwareCbtResumeReplicationContent"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResumeReplicationProperties(ResumeReplicationProviderSpecificContent providerSpecificDetails, Dictionary<string, BinaryData> rawData)
        {
            ProviderSpecificDetails = providerSpecificDetails;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResumeReplicationProperties"/> for deserialization. </summary>
        internal ResumeReplicationProperties()
        {
        }

        /// <summary>
        /// The provider specific input for resume replication.
        /// Please note <see cref="ResumeReplicationProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VMwareCbtResumeReplicationContent"/>.
        /// </summary>
        public ResumeReplicationProviderSpecificContent ProviderSpecificDetails { get; }
    }
}
