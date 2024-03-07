// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> Unknown version of DataConnectionPayload. </summary>
    internal partial class UnknownDataConnectionPayload : DataConnectionPayload
    {
        /// <summary> Initializes a new instance of <see cref="UnknownDataConnectionPayload"/>. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="name"> The name of data connection. </param>
        /// <param name="content"> The type of data the data connection will transfer. </param>
        /// <param name="frequency"> The rate at which the data connection will receive updates. </param>
        /// <param name="frequencyOffset"> The day to update the data connection on. (1-7 for weekly, 1-31 for monthly). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownDataConnectionPayload(string kind, string name, DataConnectionContent? content, DataConnectionFrequency? frequency, int? frequencyOffset, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(kind, name, content, frequency, frequencyOffset, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownDataConnectionPayload"/> for deserialization. </summary>
        internal UnknownDataConnectionPayload()
        {
        }
    }
}
