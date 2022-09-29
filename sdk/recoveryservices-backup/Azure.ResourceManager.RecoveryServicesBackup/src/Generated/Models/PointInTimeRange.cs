// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Provides details for log ranges. </summary>
    public partial class PointInTimeRange
    {
        /// <summary> Initializes a new instance of PointInTimeRange. </summary>
        public PointInTimeRange()
        {
        }

        /// <summary> Initializes a new instance of PointInTimeRange. </summary>
        /// <param name="startOn"> Start time of the time range for log recovery. </param>
        /// <param name="endOn"> End time of the time range for log recovery. </param>
        internal PointInTimeRange(DateTimeOffset? startOn, DateTimeOffset? endOn)
        {
            StartOn = startOn;
            EndOn = endOn;
        }

        /// <summary> Start time of the time range for log recovery. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> End time of the time range for log recovery. </summary>
        public DateTimeOffset? EndOn { get; set; }
    }
}
