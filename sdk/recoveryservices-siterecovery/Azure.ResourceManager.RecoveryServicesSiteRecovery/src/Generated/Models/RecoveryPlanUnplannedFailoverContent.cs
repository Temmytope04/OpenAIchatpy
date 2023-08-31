// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan unplanned failover input. </summary>
    public partial class RecoveryPlanUnplannedFailoverContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanUnplannedFailoverContent"/>. </summary>
        /// <param name="properties"> The recovery plan unplanned failover input properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public RecoveryPlanUnplannedFailoverContent(RecoveryPlanUnplannedFailoverProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanUnplannedFailoverContent"/>. </summary>
        /// <param name="properties"> The recovery plan unplanned failover input properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RecoveryPlanUnplannedFailoverContent(RecoveryPlanUnplannedFailoverProperties properties, Dictionary<string, BinaryData> rawData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanUnplannedFailoverContent"/> for deserialization. </summary>
        internal RecoveryPlanUnplannedFailoverContent()
        {
        }

        /// <summary> The recovery plan unplanned failover input properties. </summary>
        public RecoveryPlanUnplannedFailoverProperties Properties { get; }
    }
}
