// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> MAB workload-specific job task details. </summary>
    public partial class MabJobTaskDetails
    {
        /// <summary> Initializes a new instance of MabJobTaskDetails. </summary>
        public MabJobTaskDetails()
        {
        }

        /// <summary> Initializes a new instance of MabJobTaskDetails. </summary>
        /// <param name="taskId"> The task display name. </param>
        /// <param name="startOn"> The start time. </param>
        /// <param name="endOn"> The end time. </param>
        /// <param name="duration"> Time elapsed for task. </param>
        /// <param name="status"> The status. </param>
        internal MabJobTaskDetails(string taskId, DateTimeOffset? startOn, DateTimeOffset? endOn, TimeSpan? duration, string status)
        {
            TaskId = taskId;
            StartOn = startOn;
            EndOn = endOn;
            Duration = duration;
            Status = status;
        }

        /// <summary> The task display name. </summary>
        public string TaskId { get; set; }
        /// <summary> The start time. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> The end time. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> Time elapsed for task. </summary>
        public TimeSpan? Duration { get; set; }
        /// <summary> The status. </summary>
        public string Status { get; set; }
    }
}
