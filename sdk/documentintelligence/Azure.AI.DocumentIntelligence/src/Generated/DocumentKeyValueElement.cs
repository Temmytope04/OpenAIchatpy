// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> An object representing the field key or value in a key-value pair. </summary>
    public partial class DocumentKeyValueElement
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

        /// <summary> Initializes a new instance of <see cref="DocumentKeyValueElement"/>. </summary>
        /// <param name="content"> Concatenated content of the key-value element in reading order. </param>
        /// <param name="spans"> Location of the key-value element in the reading order concatenated content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> or <paramref name="spans"/> is null. </exception>
        internal DocumentKeyValueElement(string content, IEnumerable<DocumentSpan> spans)
        {
            Argument.AssertNotNull(content, nameof(content));
            Argument.AssertNotNull(spans, nameof(spans));

            Content = content;
            BoundingRegions = new ChangeTrackingList<BoundingRegion>();
            Spans = spans.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentKeyValueElement"/>. </summary>
        /// <param name="content"> Concatenated content of the key-value element in reading order. </param>
        /// <param name="boundingRegions"> Bounding regions covering the key-value element. </param>
        /// <param name="spans"> Location of the key-value element in the reading order concatenated content. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentKeyValueElement(string content, IReadOnlyList<BoundingRegion> boundingRegions, IReadOnlyList<DocumentSpan> spans, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Content = content;
            BoundingRegions = boundingRegions;
            Spans = spans;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentKeyValueElement"/> for deserialization. </summary>
        internal DocumentKeyValueElement()
        {
        }

        /// <summary> Concatenated content of the key-value element in reading order. </summary>
        public string Content { get; }
        /// <summary> Bounding regions covering the key-value element. </summary>
        public IReadOnlyList<BoundingRegion> BoundingRegions { get; }
        /// <summary> Location of the key-value element in the reading order concatenated content. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
    }
}
