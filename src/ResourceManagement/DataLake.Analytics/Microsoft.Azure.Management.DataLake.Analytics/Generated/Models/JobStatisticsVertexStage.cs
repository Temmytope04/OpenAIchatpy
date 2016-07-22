// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The Data Lake Analytics job statistics vertex stage information.
    /// </summary>
    public partial class JobStatisticsVertexStage
    {
        /// <summary>
        /// Initializes a new instance of the JobStatisticsVertexStage class.
        /// </summary>
        public JobStatisticsVertexStage() { }

        /// <summary>
        /// Initializes a new instance of the JobStatisticsVertexStage class.
        /// </summary>
        /// <param name="dataRead">the amount of data read, in bytes.</param>
        /// <param name="dataReadCrossPod">the amount of data read across multiple pods, in bytes.</param>
        /// <param name="dataReadIntraPod">the amount of data read in one pod, in bytes.</param>
        /// <param name="dataToRead">the amount of data remaining to be read, in bytes.</param>
        /// <param name="dataWritten">the amount of data written, in bytes.</param>
        /// <param name="duplicateDiscardCount">the number of duplicates that were discarded.</param>
        /// <param name="failedCount">the number of failures that occured in this stage.</param>
        /// <param name="maxVertexDataRead">the maximum amount of data read in a single vertex, in bytes.</param>
        /// <param name="minVertexDataRead">the minimum amount of data read in a single vertex, in bytes.</param>
        /// <param name="readFailureCount">the number of read failures in this stage.</param>
        /// <param name="revocationCount">the number of vertices that were revoked during this stage.</param>
        /// <param name="runningCount">the number of currently running vertices in this stage.</param>
        /// <param name="scheduledCount">the number of currently scheduled vertices in this stage</param>
        /// <param name="stageName">the name of this stage in job execution.</param>
        /// <param name="succeededCount">the number of vertices that succeeded in this stage.</param>
        /// <param name="tempDataWritten">the amount of temporary data written, in bytes.</param>
        /// <param name="totalCount">the total vertex count for this stage.</param>
        /// <param name="totalFailedTime">the amount of time that failed vertices took up in this stage.</param>
        /// <param name="totalProgress">the current progress of this stage, as a percentage.</param>
        /// <param name="totalSucceededTime">the amount of time all successful vertices took in this stage.</param>
        public JobStatisticsVertexStage(long? dataRead = default(long?), long? dataReadCrossPod = default(long?), long? dataReadIntraPod = default(long?), long? dataToRead = default(long?), long? dataWritten = default(long?), int? duplicateDiscardCount = default(int?), int? failedCount = default(int?), long? maxVertexDataRead = default(long?), long? minVertexDataRead = default(long?), int? readFailureCount = default(int?), int? revocationCount = default(int?), int? runningCount = default(int?), int? scheduledCount = default(int?), string stageName = default(string), int? succeededCount = default(int?), long? tempDataWritten = default(long?), int? totalCount = default(int?), TimeSpan? totalFailedTime = default(TimeSpan?), int? totalProgress = default(int?), TimeSpan? totalSucceededTime = default(TimeSpan?))
        {
            DataRead = dataRead;
            DataReadCrossPod = dataReadCrossPod;
            DataReadIntraPod = dataReadIntraPod;
            DataToRead = dataToRead;
            DataWritten = dataWritten;
            DuplicateDiscardCount = duplicateDiscardCount;
            FailedCount = failedCount;
            MaxVertexDataRead = maxVertexDataRead;
            MinVertexDataRead = minVertexDataRead;
            ReadFailureCount = readFailureCount;
            RevocationCount = revocationCount;
            RunningCount = runningCount;
            ScheduledCount = scheduledCount;
            StageName = stageName;
            SucceededCount = succeededCount;
            TempDataWritten = tempDataWritten;
            TotalCount = totalCount;
            TotalFailedTime = totalFailedTime;
            TotalProgress = totalProgress;
            TotalSucceededTime = totalSucceededTime;
        }

        /// <summary>
        /// Gets the amount of data read, in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "dataRead")]
        public long? DataRead { get; private set; }

        /// <summary>
        /// Gets the amount of data read across multiple pods, in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "dataReadCrossPod")]
        public long? DataReadCrossPod { get; private set; }

        /// <summary>
        /// Gets the amount of data read in one pod, in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "dataReadIntraPod")]
        public long? DataReadIntraPod { get; private set; }

        /// <summary>
        /// Gets the amount of data remaining to be read, in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "dataToRead")]
        public long? DataToRead { get; private set; }

        /// <summary>
        /// Gets the amount of data written, in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "dataWritten")]
        public long? DataWritten { get; private set; }

        /// <summary>
        /// Gets the number of duplicates that were discarded.
        /// </summary>
        [JsonProperty(PropertyName = "duplicateDiscardCount")]
        public int? DuplicateDiscardCount { get; private set; }

        /// <summary>
        /// Gets the number of failures that occured in this stage.
        /// </summary>
        [JsonProperty(PropertyName = "failedCount")]
        public int? FailedCount { get; private set; }

        /// <summary>
        /// Gets the maximum amount of data read in a single vertex, in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "maxVertexDataRead")]
        public long? MaxVertexDataRead { get; private set; }

        /// <summary>
        /// Gets the minimum amount of data read in a single vertex, in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "minVertexDataRead")]
        public long? MinVertexDataRead { get; private set; }

        /// <summary>
        /// Gets the number of read failures in this stage.
        /// </summary>
        [JsonProperty(PropertyName = "readFailureCount")]
        public int? ReadFailureCount { get; private set; }

        /// <summary>
        /// Gets the number of vertices that were revoked during this stage.
        /// </summary>
        [JsonProperty(PropertyName = "revocationCount")]
        public int? RevocationCount { get; private set; }

        /// <summary>
        /// Gets the number of currently running vertices in this stage.
        /// </summary>
        [JsonProperty(PropertyName = "runningCount")]
        public int? RunningCount { get; private set; }

        /// <summary>
        /// Gets the number of currently scheduled vertices in this stage
        /// </summary>
        [JsonProperty(PropertyName = "scheduledCount")]
        public int? ScheduledCount { get; private set; }

        /// <summary>
        /// Gets the name of this stage in job execution.
        /// </summary>
        [JsonProperty(PropertyName = "stageName")]
        public string StageName { get; private set; }

        /// <summary>
        /// Gets the number of vertices that succeeded in this stage.
        /// </summary>
        [JsonProperty(PropertyName = "succeededCount")]
        public int? SucceededCount { get; private set; }

        /// <summary>
        /// Gets the amount of temporary data written, in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "tempDataWritten")]
        public long? TempDataWritten { get; private set; }

        /// <summary>
        /// Gets the total vertex count for this stage.
        /// </summary>
        [JsonProperty(PropertyName = "totalCount")]
        public int? TotalCount { get; private set; }

        /// <summary>
        /// Gets the amount of time that failed vertices took up in this stage.
        /// </summary>
        [JsonProperty(PropertyName = "totalFailedTime")]
        public TimeSpan? TotalFailedTime { get; private set; }

        /// <summary>
        /// Gets the current progress of this stage, as a percentage.
        /// </summary>
        [JsonProperty(PropertyName = "totalProgress")]
        public int? TotalProgress { get; private set; }

        /// <summary>
        /// Gets the amount of time all successful vertices took in this stage.
        /// </summary>
        [JsonProperty(PropertyName = "totalSucceededTime")]
        public TimeSpan? TotalSucceededTime { get; private set; }

    }
}
