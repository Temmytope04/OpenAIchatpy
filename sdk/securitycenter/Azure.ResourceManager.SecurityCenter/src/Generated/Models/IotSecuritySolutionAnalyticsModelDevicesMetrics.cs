// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The IotSecuritySolutionAnalyticsModelDevicesMetrics. </summary>
    public partial class IotSecuritySolutionAnalyticsModelDevicesMetrics
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IotSecuritySolutionAnalyticsModelDevicesMetrics"/>. </summary>
        internal IotSecuritySolutionAnalyticsModelDevicesMetrics()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IotSecuritySolutionAnalyticsModelDevicesMetrics"/>. </summary>
        /// <param name="date"> Aggregation of IoT Security solution device alert metrics by date. </param>
        /// <param name="devicesMetrics"> Device alert count by severity. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IotSecuritySolutionAnalyticsModelDevicesMetrics(DateTimeOffset? date, IotSeverityMetrics devicesMetrics, Dictionary<string, BinaryData> rawData)
        {
            Date = date;
            DevicesMetrics = devicesMetrics;
            _rawData = rawData;
        }
        /// <summary> Device alert count by severity. </summary>
        public IotSeverityMetrics DevicesMetrics { get; }
    }
}
