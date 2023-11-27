// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.LabServices;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Paged list of schedules. </summary>
    internal partial class PagedSchedules
    {
        /// <summary> Initializes a new instance of <see cref="PagedSchedules"/>. </summary>
        internal PagedSchedules()
        {
            Value = new ChangeTrackingList<LabServicesScheduleData>();
        }

        /// <summary> Initializes a new instance of <see cref="PagedSchedules"/>. </summary>
        /// <param name="value"> The array page of schedule results. </param>
        /// <param name="nextLink"> The link to get the next page of schedule results. </param>
        internal PagedSchedules(IReadOnlyList<LabServicesScheduleData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The array page of schedule results. </summary>
        public IReadOnlyList<LabServicesScheduleData> Value { get; }
        /// <summary> The link to get the next page of schedule results. </summary>
        public string NextLink { get; }
    }
}
