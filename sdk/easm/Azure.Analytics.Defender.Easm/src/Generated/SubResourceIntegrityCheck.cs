// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The SubResourceIntegrityCheck. </summary>
    public partial class SubResourceIntegrityCheck
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

        /// <summary> Initializes a new instance of <see cref="SubResourceIntegrityCheck"/>. </summary>
        internal SubResourceIntegrityCheck()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SubResourceIntegrityCheck"/>. </summary>
        /// <param name="violation"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="causePageUrl"></param>
        /// <param name="crawlGuid"></param>
        /// <param name="pageGuid"></param>
        /// <param name="resourceGuid"></param>
        /// <param name="expectedHash"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SubResourceIntegrityCheck(bool? violation, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, string causePageUrl, string crawlGuid, string pageGuid, string resourceGuid, string expectedHash, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Violation = violation;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            Count = count;
            CausePageUrl = causePageUrl;
            CrawlGuid = crawlGuid;
            PageGuid = pageGuid;
            ResourceGuid = resourceGuid;
            ExpectedHash = expectedHash;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the violation. </summary>
        public bool? Violation { get; }
        /// <summary> Gets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; }
        /// <summary> Gets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; }
        /// <summary> Gets the count. </summary>
        public long? Count { get; }
        /// <summary> Gets the cause page url. </summary>
        public string CausePageUrl { get; }
        /// <summary> Gets the crawl guid. </summary>
        public string CrawlGuid { get; }
        /// <summary> Gets the page guid. </summary>
        public string PageGuid { get; }
        /// <summary> Gets the resource guid. </summary>
        public string ResourceGuid { get; }
        /// <summary> Gets the expected hash. </summary>
        public string ExpectedHash { get; }
    }
}
