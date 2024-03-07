// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary>
    /// A content line object consisting of an adjacent sequence of content elements,
    /// such as words and selection marks.
    /// </summary>
    public partial class DocumentLine
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

        /// <summary> Initializes a new instance of <see cref="DocumentLine"/>. </summary>
        /// <param name="content"> Concatenated content of the contained elements in reading order. </param>
        /// <param name="spans"> Location of the line in the reading order concatenated content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> or <paramref name="spans"/> is null. </exception>
        internal DocumentLine(string content, IEnumerable<DocumentSpan> spans)
        {
            Argument.AssertNotNull(content, nameof(content));
            Argument.AssertNotNull(spans, nameof(spans));

            Content = content;
            Polygon = new ChangeTrackingList<float>();
            Spans = spans.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentLine"/>. </summary>
        /// <param name="content"> Concatenated content of the contained elements in reading order. </param>
        /// <param name="polygon">
        /// Bounding polygon of the line, with coordinates specified relative to the
        /// top-left of the page. The numbers represent the x, y values of the polygon
        /// vertices, clockwise from the left (-180 degrees inclusive) relative to the
        /// element orientation.
        /// </param>
        /// <param name="spans"> Location of the line in the reading order concatenated content. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentLine(string content, IReadOnlyList<float> polygon, IReadOnlyList<DocumentSpan> spans, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Content = content;
            Polygon = polygon;
            Spans = spans;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentLine"/> for deserialization. </summary>
        internal DocumentLine()
        {
        }

        /// <summary> Concatenated content of the contained elements in reading order. </summary>
        public string Content { get; }
        /// <summary>
        /// Bounding polygon of the line, with coordinates specified relative to the
        /// top-left of the page. The numbers represent the x, y values of the polygon
        /// vertices, clockwise from the left (-180 degrees inclusive) relative to the
        /// element orientation.
        /// </summary>
        public IReadOnlyList<float> Polygon { get; }
        /// <summary> Location of the line in the reading order concatenated content. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
    }
}
