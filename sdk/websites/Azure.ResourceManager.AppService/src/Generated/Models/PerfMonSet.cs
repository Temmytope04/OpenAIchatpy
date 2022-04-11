// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Metric information. </summary>
    public partial class PerfMonSet
    {
        /// <summary> Initializes a new instance of PerfMonSet. </summary>
        internal PerfMonSet()
        {
            Values = new ChangeTrackingList<PerfMonSample>();
        }

        /// <summary> Initializes a new instance of PerfMonSet. </summary>
        /// <param name="name"> Unique key name of the counter. </param>
        /// <param name="startOn"> Start time of the period. </param>
        /// <param name="endOn"> End time of the period. </param>
        /// <param name="timeGrain"> Presented time grain. </param>
        /// <param name="values"> Collection of workers that are active during this time. </param>
        internal PerfMonSet(string name, DateTimeOffset? startOn, DateTimeOffset? endOn, string timeGrain, IReadOnlyList<PerfMonSample> values)
        {
            Name = name;
            StartOn = startOn;
            EndOn = endOn;
            TimeGrain = timeGrain;
            Values = values;
        }

        /// <summary> Unique key name of the counter. </summary>
        public string Name { get; }
        /// <summary> Start time of the period. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> End time of the period. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Presented time grain. </summary>
        public string TimeGrain { get; }
        /// <summary> Collection of workers that are active during this time. </summary>
        public IReadOnlyList<PerfMonSample> Values { get; }
    }
}
