// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary>
    /// Definition of which performance counters will be collected and how they will be collected by this data collection rule.
    /// Collected from both Windows and Linux machines where the counter is present.
    /// </summary>
    public partial class PerfCounterDataSource
    {
        /// <summary> Initializes a new instance of PerfCounterDataSource. </summary>
        public PerfCounterDataSource()
        {
            Streams = new ChangeTrackingList<PerfCounterDataSourceStream>();
            CounterSpecifiers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of PerfCounterDataSource. </summary>
        /// <param name="streams">
        /// List of streams that this data source will be sent to.
        /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        /// </param>
        /// <param name="samplingFrequencyInSeconds"> The number of seconds between consecutive counter measurements (samples). </param>
        /// <param name="counterSpecifiers">
        /// A list of specifier names of the performance counters you want to collect.
        /// Use a wildcard (*) to collect a counter for all instances.
        /// To get a list of performance counters on Windows, run the command &apos;typeperf&apos;.
        /// </param>
        /// <param name="name">
        /// A friendly name for the data source. 
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </param>
        internal PerfCounterDataSource(IList<PerfCounterDataSourceStream> streams, int? samplingFrequencyInSeconds, IList<string> counterSpecifiers, string name)
        {
            Streams = streams;
            SamplingFrequencyInSeconds = samplingFrequencyInSeconds;
            CounterSpecifiers = counterSpecifiers;
            Name = name;
        }

        /// <summary>
        /// List of streams that this data source will be sent to.
        /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        /// </summary>
        public IList<PerfCounterDataSourceStream> Streams { get; }
        /// <summary> The number of seconds between consecutive counter measurements (samples). </summary>
        public int? SamplingFrequencyInSeconds { get; set; }
        /// <summary>
        /// A list of specifier names of the performance counters you want to collect.
        /// Use a wildcard (*) to collect a counter for all instances.
        /// To get a list of performance counters on Windows, run the command &apos;typeperf&apos;.
        /// </summary>
        public IList<string> CounterSpecifiers { get; }
        /// <summary>
        /// A friendly name for the data source. 
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </summary>
        public string Name { get; set; }
    }
}
