// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.TrafficManager.Models
{
    /// <summary> Min and max value of a status code range. </summary>
    public partial class ExpectedStatusCodeRangeInfo
    {
        /// <summary> Initializes a new instance of ExpectedStatusCodeRangeInfo. </summary>
        public ExpectedStatusCodeRangeInfo()
        {
        }

        /// <summary> Initializes a new instance of ExpectedStatusCodeRangeInfo. </summary>
        /// <param name="min"> Min status code. </param>
        /// <param name="max"> Max status code. </param>
        internal ExpectedStatusCodeRangeInfo(int? min, int? max)
        {
            Min = min;
            Max = max;
        }

        /// <summary> Min status code. </summary>
        public int? Min { get; set; }
        /// <summary> Max status code. </summary>
        public int? Max { get; set; }
    }
}
