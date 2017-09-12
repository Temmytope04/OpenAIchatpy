// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Batch;
    using Microsoft.Azure.Batch.Protocol;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Resource usage statistics for a task.
    /// </summary>
    public partial class TaskStatistics
    {
        /// <summary>
        /// Initializes a new instance of the TaskStatistics class.
        /// </summary>
        public TaskStatistics()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskStatistics class.
        /// </summary>
        /// <param name="url">The URL of the statistics.</param>
        /// <param name="startTime">The start time of the time range covered by
        /// the statistics.</param>
        /// <param name="lastUpdateTime">The time at which the statistics were
        /// last updated. All statistics are limited to the range between
        /// startTime and lastUpdateTime.</param>
        /// <param name="userCPUTime">The total user mode CPU time (summed
        /// across all cores and all compute nodes) consumed by the
        /// task.</param>
        /// <param name="kernelCPUTime">The total kernel mode CPU time (summed
        /// across all cores and all compute nodes) consumed by the
        /// task.</param>
        /// <param name="wallClockTime">The total wall clock time of the
        /// task.</param>
        /// <param name="readIOps">The total number of disk read operations
        /// made by the task.</param>
        /// <param name="writeIOps">The total number of disk write operations
        /// made by the task.</param>
        /// <param name="readIOGiB">The total gibibytes read from disk by the
        /// task.</param>
        /// <param name="writeIOGiB">The total gibibytes written to disk by the
        /// task.</param>
        /// <param name="waitTime">The total wait time of the task. The wait
        /// time for a task is defined as the elapsed time between the creation
        /// of the task and the start of task execution. (If the task is
        /// retried due to failures, the wait time is the time to the most
        /// recent task execution.)</param>
        public TaskStatistics(string url, System.DateTime startTime, System.DateTime lastUpdateTime, System.TimeSpan userCPUTime, System.TimeSpan kernelCPUTime, System.TimeSpan wallClockTime, long readIOps, long writeIOps, double readIOGiB, double writeIOGiB, System.TimeSpan waitTime)
        {
            Url = url;
            StartTime = startTime;
            LastUpdateTime = lastUpdateTime;
            UserCPUTime = userCPUTime;
            KernelCPUTime = kernelCPUTime;
            WallClockTime = wallClockTime;
            ReadIOps = readIOps;
            WriteIOps = writeIOps;
            ReadIOGiB = readIOGiB;
            WriteIOGiB = writeIOGiB;
            WaitTime = waitTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL of the statistics.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the start time of the time range covered by the
        /// statistics.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the statistics were last updated.
        /// All statistics are limited to the range between startTime and
        /// lastUpdateTime.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdateTime")]
        public System.DateTime LastUpdateTime { get; set; }

        /// <summary>
        /// Gets or sets the total user mode CPU time (summed across all cores
        /// and all compute nodes) consumed by the task.
        /// </summary>
        [JsonProperty(PropertyName = "userCPUTime")]
        public System.TimeSpan UserCPUTime { get; set; }

        /// <summary>
        /// Gets or sets the total kernel mode CPU time (summed across all
        /// cores and all compute nodes) consumed by the task.
        /// </summary>
        [JsonProperty(PropertyName = "kernelCPUTime")]
        public System.TimeSpan KernelCPUTime { get; set; }

        /// <summary>
        /// Gets or sets the total wall clock time of the task.
        /// </summary>
        /// <remarks>
        /// The wall clock time is the elapsed time from when the task started
        /// running on a compute node to when it finished (or to the last time
        /// the statistics were updated, if the task had not finished by then).
        /// If the task was retried, this includes the wall clock time of all
        /// the task retries.
        /// </remarks>
        [JsonProperty(PropertyName = "wallClockTime")]
        public System.TimeSpan WallClockTime { get; set; }

        /// <summary>
        /// Gets or sets the total number of disk read operations made by the
        /// task.
        /// </summary>
        [JsonProperty(PropertyName = "readIOps")]
        public long ReadIOps { get; set; }

        /// <summary>
        /// Gets or sets the total number of disk write operations made by the
        /// task.
        /// </summary>
        [JsonProperty(PropertyName = "writeIOps")]
        public long WriteIOps { get; set; }

        /// <summary>
        /// Gets or sets the total gibibytes read from disk by the task.
        /// </summary>
        [JsonProperty(PropertyName = "readIOGiB")]
        public double ReadIOGiB { get; set; }

        /// <summary>
        /// Gets or sets the total gibibytes written to disk by the task.
        /// </summary>
        [JsonProperty(PropertyName = "writeIOGiB")]
        public double WriteIOGiB { get; set; }

        /// <summary>
        /// Gets or sets the total wait time of the task. The wait time for a
        /// task is defined as the elapsed time between the creation of the
        /// task and the start of task execution. (If the task is retried due
        /// to failures, the wait time is the time to the most recent task
        /// execution.)
        /// </summary>
        [JsonProperty(PropertyName = "waitTime")]
        public System.TimeSpan WaitTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
        }
    }
}
