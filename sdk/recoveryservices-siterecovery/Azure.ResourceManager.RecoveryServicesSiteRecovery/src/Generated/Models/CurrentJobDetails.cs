// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Current job details of the migration item. </summary>
    public partial class CurrentJobDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CurrentJobDetails"/>. </summary>
        internal CurrentJobDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CurrentJobDetails"/>. </summary>
        /// <param name="jobName"> The job name. </param>
        /// <param name="jobId"> The ARM Id of the job being executed. </param>
        /// <param name="startOn"> The start time of the job. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CurrentJobDetails(string jobName, ResourceIdentifier jobId, DateTimeOffset? startOn, Dictionary<string, BinaryData> rawData)
        {
            JobName = jobName;
            JobId = jobId;
            StartOn = startOn;
            _rawData = rawData;
        }

        /// <summary> The job name. </summary>
        public string JobName { get; }
        /// <summary> The ARM Id of the job being executed. </summary>
        public ResourceIdentifier JobId { get; }
        /// <summary> The start time of the job. </summary>
        public DateTimeOffset? StartOn { get; }
    }
}
