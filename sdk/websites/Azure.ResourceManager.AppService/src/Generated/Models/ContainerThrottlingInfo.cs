// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The ContainerThrottlingInfo. </summary>
    public partial class ContainerThrottlingInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerThrottlingInfo"/>. </summary>
        public ContainerThrottlingInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerThrottlingInfo"/>. </summary>
        /// <param name="periods"></param>
        /// <param name="throttledPeriods"></param>
        /// <param name="throttledTime"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerThrottlingInfo(int? periods, int? throttledPeriods, int? throttledTime, Dictionary<string, BinaryData> rawData)
        {
            Periods = periods;
            ThrottledPeriods = throttledPeriods;
            ThrottledTime = throttledTime;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the periods. </summary>
        public int? Periods { get; set; }
        /// <summary> Gets or sets the throttled periods. </summary>
        public int? ThrottledPeriods { get; set; }
        /// <summary> Gets or sets the throttled time. </summary>
        public int? ThrottledTime { get; set; }
    }
}
