// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing the BandwidthSchedule data model.
    /// The bandwidth schedule details.
    /// </summary>
    public partial class BandwidthScheduleData : ResourceData
    {
        /// <summary> Initializes a new instance of BandwidthScheduleData. </summary>
        /// <param name="startOn"> The start time of the schedule in UTC. </param>
        /// <param name="stopOn"> The stop time of the schedule in UTC. </param>
        /// <param name="rateInMbps"> The bandwidth rate in Mbps. </param>
        /// <param name="days"> The days of the week when this schedule is applicable. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="days"/> is null. </exception>
        public BandwidthScheduleData(TimeSpan startOn, TimeSpan stopOn, int rateInMbps, IEnumerable<DataBoxEdgeDayOfWeek> days)
        {
            Argument.AssertNotNull(days, nameof(days));

            StartOn = startOn;
            StopOn = stopOn;
            RateInMbps = rateInMbps;
            Days = days.ToList();
        }

        /// <summary> Initializes a new instance of BandwidthScheduleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startOn"> The start time of the schedule in UTC. </param>
        /// <param name="stopOn"> The stop time of the schedule in UTC. </param>
        /// <param name="rateInMbps"> The bandwidth rate in Mbps. </param>
        /// <param name="days"> The days of the week when this schedule is applicable. </param>
        internal BandwidthScheduleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, TimeSpan startOn, TimeSpan stopOn, int rateInMbps, IList<DataBoxEdgeDayOfWeek> days) : base(id, name, resourceType, systemData)
        {
            StartOn = startOn;
            StopOn = stopOn;
            RateInMbps = rateInMbps;
            Days = days;
        }

        /// <summary> The start time of the schedule in UTC. </summary>
        public TimeSpan StartOn { get; set; }
        /// <summary> The stop time of the schedule in UTC. </summary>
        public TimeSpan StopOn { get; set; }
        /// <summary> The bandwidth rate in Mbps. </summary>
        public int RateInMbps { get; set; }
        /// <summary> The days of the week when this schedule is applicable. </summary>
        public IList<DataBoxEdgeDayOfWeek> Days { get; }
    }
}
