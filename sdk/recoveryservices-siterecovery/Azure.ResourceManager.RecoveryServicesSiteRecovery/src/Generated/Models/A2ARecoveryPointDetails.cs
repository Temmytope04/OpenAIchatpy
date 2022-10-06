// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A provider specific recovery point details. </summary>
    public partial class A2ARecoveryPointDetails : ProviderSpecificRecoveryPointDetails
    {
        /// <summary> Initializes a new instance of A2ARecoveryPointDetails. </summary>
        internal A2ARecoveryPointDetails()
        {
            Disks = new ChangeTrackingList<string>();
            InstanceType = "A2A";
        }

        /// <summary> Initializes a new instance of A2ARecoveryPointDetails. </summary>
        /// <param name="instanceType"> Gets the provider type. </param>
        /// <param name="recoveryPointSyncType"> A value indicating whether the recovery point is multi VM consistent. </param>
        /// <param name="disks"> List of disk ids representing a recovery point. </param>
        internal A2ARecoveryPointDetails(string instanceType, RecoveryPointSyncType? recoveryPointSyncType, IReadOnlyList<string> disks) : base(instanceType)
        {
            RecoveryPointSyncType = recoveryPointSyncType;
            Disks = disks;
            InstanceType = instanceType ?? "A2A";
        }

        /// <summary> A value indicating whether the recovery point is multi VM consistent. </summary>
        public RecoveryPointSyncType? RecoveryPointSyncType { get; }
        /// <summary> List of disk ids representing a recovery point. </summary>
        public IReadOnlyList<string> Disks { get; }
    }
}
