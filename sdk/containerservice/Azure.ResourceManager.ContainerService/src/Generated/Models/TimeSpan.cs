// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> For example, between 2021-05-25T13:00:00Z and 2021-05-25T14:00:00Z. </summary>
    public partial class TimeSpan
    {
        /// <summary> Initializes a new instance of TimeSpan. </summary>
        public TimeSpan()
        {
        }

        /// <summary> Initializes a new instance of TimeSpan. </summary>
        /// <param name="start"> The start of a time span. </param>
        /// <param name="end"> The end of a time span. </param>
        internal TimeSpan(DateTimeOffset? start, DateTimeOffset? end)
        {
            Start = start;
            End = end;
        }

        /// <summary> The start of a time span. </summary>
        public DateTimeOffset? Start { get; set; }
        /// <summary> The end of a time span. </summary>
        public DateTimeOffset? End { get; set; }
    }
}
