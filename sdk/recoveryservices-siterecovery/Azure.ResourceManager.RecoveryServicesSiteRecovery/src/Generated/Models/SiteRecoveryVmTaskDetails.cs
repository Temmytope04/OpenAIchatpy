// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> This class represents the virtual machine task details. </summary>
    public partial class SiteRecoveryVmTaskDetails : SiteRecoveryJobTaskDetails
    {
        /// <summary> Initializes a new instance of <see cref="SiteRecoveryVmTaskDetails"/>. </summary>
        internal SiteRecoveryVmTaskDetails()
        {
            InstanceType = "VirtualMachineTaskDetails";
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryVmTaskDetails"/>. </summary>
        /// <param name="instanceType"> The type of task details. </param>
        /// <param name="jobTask"> The job entity. </param>
        /// <param name="skippedReason"> The skipped reason. </param>
        /// <param name="skippedReasonString"> The skipped reason string. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryVmTaskDetails(string instanceType, SiteRecoveryJobEntity jobTask, string skippedReason, string skippedReasonString, Dictionary<string, BinaryData> rawData) : base(instanceType, jobTask, rawData)
        {
            SkippedReason = skippedReason;
            SkippedReasonString = skippedReasonString;
            InstanceType = instanceType ?? "VirtualMachineTaskDetails";
        }

        /// <summary> The skipped reason. </summary>
        public string SkippedReason { get; }
        /// <summary> The skipped reason string. </summary>
        public string SkippedReasonString { get; }
    }
}
