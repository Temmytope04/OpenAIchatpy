// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Recovery point specific to PointInTime. </summary>
    public partial class WorkloadSqlPointInTimeRecoveryPoint : WorkloadSqlRecoveryPoint
    {
        /// <summary> Initializes a new instance of <see cref="WorkloadSqlPointInTimeRecoveryPoint"/>. </summary>
        public WorkloadSqlPointInTimeRecoveryPoint()
        {
            TimeRanges = new ChangeTrackingList<PointInTimeRange>();
            ObjectType = "AzureWorkloadSQLPointInTimeRecoveryPoint";
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadSqlPointInTimeRecoveryPoint"/>. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="recoveryPointCreatedOn"> UTC time at which recovery point was created. </param>
        /// <param name="restorePointType"> Type of restore point. </param>
        /// <param name="recoveryPointTierDetails"> Recovery point tier information. </param>
        /// <param name="recoveryPointMoveReadinessInfo"> Eligibility of RP to be moved to another tier. </param>
        /// <param name="recoveryPointProperties"> Properties of Recovery Point. </param>
        /// <param name="extendedInfo">
        /// Extended Info that provides data directory details. Will be populated in two cases:
        /// When a specific recovery point is accessed using GetRecoveryPoint
        /// Or when ListRecoveryPoints is called for Log RP only with ExtendedInfo query filter
        /// </param>
        /// <param name="timeRanges"> List of log ranges. </param>
        internal WorkloadSqlPointInTimeRecoveryPoint(string objectType, IDictionary<string, BinaryData> serializedAdditionalRawData, DateTimeOffset? recoveryPointCreatedOn, RestorePointType? restorePointType, IList<RecoveryPointTierInformationV2> recoveryPointTierDetails, IDictionary<string, RecoveryPointMoveReadinessInfo> recoveryPointMoveReadinessInfo, RecoveryPointProperties recoveryPointProperties, WorkloadSqlRecoveryPointExtendedInfo extendedInfo, IList<PointInTimeRange> timeRanges) : base(objectType, serializedAdditionalRawData, recoveryPointCreatedOn, restorePointType, recoveryPointTierDetails, recoveryPointMoveReadinessInfo, recoveryPointProperties, extendedInfo)
        {
            TimeRanges = timeRanges;
            ObjectType = objectType ?? "AzureWorkloadSQLPointInTimeRecoveryPoint";
        }

        /// <summary> List of log ranges. </summary>
        public IList<PointInTimeRange> TimeRanges { get; }
    }
}
