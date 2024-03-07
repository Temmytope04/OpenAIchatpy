// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The LogAnalyticsDataConnectionProperties. </summary>
    public partial class LogAnalyticsDataConnectionProperties : DataConnectionProperties
    {
        /// <summary> Initializes a new instance of <see cref="LogAnalyticsDataConnectionProperties"/>. </summary>
        public LogAnalyticsDataConnectionProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogAnalyticsDataConnectionProperties"/>. </summary>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="apiKey"> log analytics api key. </param>
        /// <param name="workspaceId"> log analytics workspace id. </param>
        internal LogAnalyticsDataConnectionProperties(IDictionary<string, BinaryData> serializedAdditionalRawData, string apiKey, string workspaceId) : base(serializedAdditionalRawData)
        {
            ApiKey = apiKey;
            WorkspaceId = workspaceId;
        }

        /// <summary> log analytics api key. </summary>
        public string ApiKey { get; set; }
        /// <summary> log analytics workspace id. </summary>
        public string WorkspaceId { get; set; }
    }
}
