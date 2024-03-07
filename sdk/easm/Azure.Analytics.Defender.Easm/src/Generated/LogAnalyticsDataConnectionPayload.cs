// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The LogAnalyticsDataConnectionPayload. </summary>
    public partial class LogAnalyticsDataConnectionPayload : DataConnectionPayload
    {
        /// <summary> Initializes a new instance of <see cref="LogAnalyticsDataConnectionPayload"/>. </summary>
        /// <param name="properties"> properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public LogAnalyticsDataConnectionPayload(LogAnalyticsDataConnectionProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Kind = "logAnalytics";
            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="LogAnalyticsDataConnectionPayload"/>. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="name"> The name of data connection. </param>
        /// <param name="content"> The type of data the data connection will transfer. </param>
        /// <param name="frequency"> The rate at which the data connection will receive updates. </param>
        /// <param name="frequencyOffset"> The day to update the data connection on. (1-7 for weekly, 1-31 for monthly). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="properties"> properties. </param>
        internal LogAnalyticsDataConnectionPayload(string kind, string name, DataConnectionContent? content, DataConnectionFrequency? frequency, int? frequencyOffset, IDictionary<string, BinaryData> serializedAdditionalRawData, LogAnalyticsDataConnectionProperties properties) : base(kind, name, content, frequency, frequencyOffset, serializedAdditionalRawData)
        {
            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="LogAnalyticsDataConnectionPayload"/> for deserialization. </summary>
        internal LogAnalyticsDataConnectionPayload()
        {
        }

        /// <summary> properties. </summary>
        public LogAnalyticsDataConnectionProperties Properties { get; }
    }
}
