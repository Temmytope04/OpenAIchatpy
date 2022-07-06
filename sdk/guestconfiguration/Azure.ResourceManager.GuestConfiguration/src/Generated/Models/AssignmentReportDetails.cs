// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> Details of the guest configuration assignment report. </summary>
    public partial class AssignmentReportDetails
    {
        /// <summary> Initializes a new instance of AssignmentReportDetails. </summary>
        internal AssignmentReportDetails()
        {
            Resources = new ChangeTrackingList<AssignmentReportResource>();
        }

        /// <summary> Initializes a new instance of AssignmentReportDetails. </summary>
        /// <param name="complianceStatus"> A value indicating compliance status of the machine for the assigned guest configuration. </param>
        /// <param name="startOn"> Start date and time of the guest configuration assignment compliance status check. </param>
        /// <param name="endOn"> End date and time of the guest configuration assignment compliance status check. </param>
        /// <param name="jobId"> GUID of the report. </param>
        /// <param name="operationType"> Type of report, Consistency or Initial. </param>
        /// <param name="resources"> The list of resources for which guest configuration assignment compliance is checked. </param>
        internal AssignmentReportDetails(ComplianceStatus? complianceStatus, DateTimeOffset? startOn, DateTimeOffset? endOn, string jobId, Type? operationType, IReadOnlyList<AssignmentReportResource> resources)
        {
            ComplianceStatus = complianceStatus;
            StartOn = startOn;
            EndOn = endOn;
            JobId = jobId;
            OperationType = operationType;
            Resources = resources;
        }

        /// <summary> A value indicating compliance status of the machine for the assigned guest configuration. </summary>
        public ComplianceStatus? ComplianceStatus { get; }
        /// <summary> Start date and time of the guest configuration assignment compliance status check. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> End date and time of the guest configuration assignment compliance status check. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> GUID of the report. </summary>
        public string JobId { get; }
        /// <summary> Type of report, Consistency or Initial. </summary>
        public Type? OperationType { get; }
        /// <summary> The list of resources for which guest configuration assignment compliance is checked. </summary>
        public IReadOnlyList<AssignmentReportResource> Resources { get; }
    }
}
