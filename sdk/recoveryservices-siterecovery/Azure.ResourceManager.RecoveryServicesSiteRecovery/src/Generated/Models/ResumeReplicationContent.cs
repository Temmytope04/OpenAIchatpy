// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Resume replication input. </summary>
    public partial class ResumeReplicationContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResumeReplicationContent"/>. </summary>
        /// <param name="properties"> Resume replication input properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public ResumeReplicationContent(ResumeReplicationProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="ResumeReplicationContent"/>. </summary>
        /// <param name="properties"> Resume replication input properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResumeReplicationContent(ResumeReplicationProperties properties, Dictionary<string, BinaryData> rawData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResumeReplicationContent"/> for deserialization. </summary>
        internal ResumeReplicationContent()
        {
        }

        /// <summary> Resume replication input properties. </summary>
        internal ResumeReplicationProperties Properties { get; }
        /// <summary>
        /// The provider specific input for resume replication.
        /// Please note <see cref="ResumeReplicationProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VMwareCbtResumeReplicationContent"/>.
        /// </summary>
        public ResumeReplicationProviderSpecificContent ResumeReplicationProviderSpecificDetails
        {
            get => Properties?.ProviderSpecificDetails;
        }
    }
}
