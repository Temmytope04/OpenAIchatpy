// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    /// <summary> System variables for a telemetry item. </summary>
    internal partial class TelemetryItem
    {
        /// <summary> Initializes a new instance of TelemetryItem. </summary>
        /// <param name="name"> Type name of telemetry data item. </param>
        /// <param name="time"> Event date time when telemetry item was created. This is the wall clock time on the client when the event was generated. There is no guarantee that the client's time is accurate. This field must be formatted in UTC ISO 8601 format, with a trailing 'Z' character, as described publicly on https://en.wikipedia.org/wiki/ISO_8601#UTC. Note: the number of decimal seconds digits provided are variable (and unspecified). Consumers should handle this, i.e. managed code consumers should not use format 'O' for parsing as it specifies a fixed length. Example: 2009-06-15T13:45:30.0000000Z. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public TelemetryItem(string name, DateTimeOffset time)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Time = time;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Envelope version. For internal use only. By assigning this the default, it will not be serialized within the payload unless changed to a value other than #1. </summary>
        public int? Version { get; set; }
        /// <summary> Type name of telemetry data item. </summary>
        public string Name { get; }
        /// <summary> Event date time when telemetry item was created. This is the wall clock time on the client when the event was generated. There is no guarantee that the client's time is accurate. This field must be formatted in UTC ISO 8601 format, with a trailing 'Z' character, as described publicly on https://en.wikipedia.org/wiki/ISO_8601#UTC. Note: the number of decimal seconds digits provided are variable (and unspecified). Consumers should handle this, i.e. managed code consumers should not use format 'O' for parsing as it specifies a fixed length. Example: 2009-06-15T13:45:30.0000000Z. </summary>
        public DateTimeOffset Time { get; }
        /// <summary> Sampling rate used in application. This telemetry item represents 100 / sampleRate actual telemetry items. </summary>
        public float? SampleRate { get; set; }
        /// <summary> Sequence field used to track absolute order of uploaded events. </summary>
        public string Sequence { get; set; }
        /// <summary> The instrumentation key of the Application Insights resource. </summary>
        public string InstrumentationKey { get; set; }
        /// <summary> Key/value collection of context properties. See ContextTagKeys for information on available properties. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Telemetry data item. </summary>
        public MonitorBase Data { get; set; }
    }
}
