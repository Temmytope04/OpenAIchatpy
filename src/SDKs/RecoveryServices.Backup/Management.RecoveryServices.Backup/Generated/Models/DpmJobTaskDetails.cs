// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// DPM workload-specific job task details.
    /// </summary>
    public partial class DpmJobTaskDetails
    {
        /// <summary>
        /// Initializes a new instance of the DpmJobTaskDetails class.
        /// </summary>
        public DpmJobTaskDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DpmJobTaskDetails class.
        /// </summary>
        /// <param name="taskId">The task display name.</param>
        /// <param name="startTime">The start time.</param>
        /// <param name="endTime">The end time.</param>
        /// <param name="duration">Time elapsed for task.</param>
        /// <param name="status">The status.</param>
        public DpmJobTaskDetails(string taskId = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), System.TimeSpan? duration = default(System.TimeSpan?), string status = default(string))
        {
            TaskId = taskId;
            StartTime = startTime;
            EndTime = endTime;
            Duration = duration;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the task display name.
        /// </summary>
        [JsonProperty(PropertyName = "taskId")]
        public string TaskId { get; set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets time elapsed for task.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public System.TimeSpan? Duration { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

    }
}
