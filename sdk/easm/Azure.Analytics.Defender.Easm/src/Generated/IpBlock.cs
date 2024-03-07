// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The IpBlock. </summary>
    public partial class IpBlock
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IpBlock"/>. </summary>
        internal IpBlock()
        {
            Sources = new ChangeTrackingList<SourceDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="IpBlock"/>. </summary>
        /// <param name="ipBlockName"></param>
        /// <param name="sources"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="recent"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IpBlock(string ipBlockName, IReadOnlyList<SourceDetails> sources, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, bool? recent, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IpBlockName = ipBlockName;
            Sources = sources;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            Count = count;
            Recent = recent;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the ip block name. </summary>
        public string IpBlockName { get; }
        /// <summary> Gets the sources. </summary>
        public IReadOnlyList<SourceDetails> Sources { get; }
        /// <summary> Gets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; }
        /// <summary> Gets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; }
        /// <summary> Gets the count. </summary>
        public long? Count { get; }
        /// <summary> Gets the recent. </summary>
        public bool? Recent { get; }
    }
}
