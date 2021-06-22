// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity ORC sink. </summary>
    public partial class OrcSink : CopySink
    {
        /// <summary> Initializes a new instance of OrcSink. </summary>
        public OrcSink()
        {
            Type = "OrcSink";
        }

        /// <summary> Initializes a new instance of OrcSink. </summary>
        /// <param name="type"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="storeSettings"> ORC store settings. </param>
        /// <param name="formatSettings"> ORC format settings. </param>
        internal OrcSink(string type, object writeBatchSize, object writeBatchTimeout, object sinkRetryCount, object sinkRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, StoreWriteSettings storeSettings, OrcWriteSettings formatSettings) : base(type, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, additionalProperties)
        {
            StoreSettings = storeSettings;
            FormatSettings = formatSettings;
            Type = type ?? "OrcSink";
        }

        /// <summary> ORC store settings. </summary>
        public StoreWriteSettings StoreSettings { get; set; }
        /// <summary> ORC format settings. </summary>
        public OrcWriteSettings FormatSettings { get; set; }
    }
}
