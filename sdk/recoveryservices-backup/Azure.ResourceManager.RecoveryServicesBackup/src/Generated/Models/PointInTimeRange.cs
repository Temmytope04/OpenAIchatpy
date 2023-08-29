// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Provides details for log ranges. </summary>
    public partial class PointInTimeRange
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PointInTimeRange"/>. </summary>
        public PointInTimeRange()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PointInTimeRange"/>. </summary>
        /// <param name="startOn"> Start time of the time range for log recovery. </param>
        /// <param name="endOn"> End time of the time range for log recovery. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PointInTimeRange(DateTimeOffset? startOn, DateTimeOffset? endOn, Dictionary<string, BinaryData> rawData)
        {
            StartOn = startOn;
            EndOn = endOn;
            _rawData = rawData;
        }

        /// <summary> Start time of the time range for log recovery. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> End time of the time range for log recovery. </summary>
        public DateTimeOffset? EndOn { get; set; }
    }
}
