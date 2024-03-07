// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The page of assets that match the provided metric. </summary>
    public partial class AssetPageResult
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

        /// <summary> Initializes a new instance of <see cref="AssetPageResult"/>. </summary>
        internal AssetPageResult()
        {
            Value = new ChangeTrackingList<AssetResource>();
        }

        /// <summary> Initializes a new instance of <see cref="AssetPageResult"/>. </summary>
        /// <param name="totalElements"> The total number of items available in the full result set. </param>
        /// <param name="mark"> The cursor mark to be used on the next request.  Not set if using paging. </param>
        /// <param name="nextLink"> The link to access the next page of results.  Not set if at the end of the result set. </param>
        /// <param name="value"> The items in the current page of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssetPageResult(long? totalElements, string mark, string nextLink, IReadOnlyList<AssetResource> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TotalElements = totalElements;
            Mark = mark;
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The total number of items available in the full result set. </summary>
        public long? TotalElements { get; }
        /// <summary> The cursor mark to be used on the next request.  Not set if using paging. </summary>
        public string Mark { get; }
        /// <summary> The link to access the next page of results.  Not set if at the end of the result set. </summary>
        public string NextLink { get; }
        /// <summary>
        /// The items in the current page of results.
        /// Please note <see cref="AssetResource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AsAssetResource"/>, <see cref="ContactAssetResource"/>, <see cref="DomainAssetResource"/>, <see cref="HostAssetResource"/>, <see cref="IpAddressAssetResource"/>, <see cref="IpBlockAssetResource"/>, <see cref="PageAssetResource"/> and <see cref="SslCertAssetResource"/>.
        /// </summary>
        public IReadOnlyList<AssetResource> Value { get; }
    }
}
