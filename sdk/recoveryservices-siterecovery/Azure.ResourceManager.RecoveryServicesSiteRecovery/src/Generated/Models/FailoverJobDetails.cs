// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> This class represents the details for a failover job. </summary>
    public partial class FailoverJobDetails : SiteRecoveryJobDetails
    {
        /// <summary> Initializes a new instance of <see cref="FailoverJobDetails"/>. </summary>
        internal FailoverJobDetails()
        {
            ProtectedItemDetails = new ChangeTrackingList<FailoverReplicationProtectedItemDetails>();
            InstanceType = "FailoverJobDetails";
        }

        /// <summary> Initializes a new instance of <see cref="FailoverJobDetails"/>. </summary>
        /// <param name="instanceType"> Gets the type of job details (see JobDetailsTypes enum for possible values). </param>
        /// <param name="affectedObjectDetails"> The affected object properties like source server, source cloud, target server, target cloud etc. based on the workflow object details. </param>
        /// <param name="protectedItemDetails"> The test VM details. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FailoverJobDetails(string instanceType, IReadOnlyDictionary<string, string> affectedObjectDetails, IReadOnlyList<FailoverReplicationProtectedItemDetails> protectedItemDetails, Dictionary<string, BinaryData> rawData) : base(instanceType, affectedObjectDetails, rawData)
        {
            ProtectedItemDetails = protectedItemDetails;
            InstanceType = instanceType ?? "FailoverJobDetails";
        }

        /// <summary> The test VM details. </summary>
        public IReadOnlyList<FailoverReplicationProtectedItemDetails> ProtectedItemDetails { get; }
    }
}
