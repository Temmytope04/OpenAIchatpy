// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> An object representing a figure in the document. </summary>
    public partial class DocumentFigure
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

        /// <summary> Initializes a new instance of <see cref="DocumentFigure"/>. </summary>
        /// <param name="spans"> Location of the figure in the reading order concatenated content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="spans"/> is null. </exception>
        internal DocumentFigure(IEnumerable<DocumentSpan> spans)
        {
            Argument.AssertNotNull(spans, nameof(spans));

            BoundingRegions = new ChangeTrackingList<BoundingRegion>();
            Spans = spans.ToList();
            Elements = new ChangeTrackingList<string>();
            Footnotes = new ChangeTrackingList<DocumentFootnote>();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentFigure"/>. </summary>
        /// <param name="boundingRegions"> Bounding regions covering the figure. </param>
        /// <param name="spans"> Location of the figure in the reading order concatenated content. </param>
        /// <param name="elements"> Child elements of the figure, excluding any caption or footnotes. </param>
        /// <param name="caption"> Caption associated with the figure. </param>
        /// <param name="footnotes"> List of footnotes associated with the figure. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentFigure(IReadOnlyList<BoundingRegion> boundingRegions, IReadOnlyList<DocumentSpan> spans, IReadOnlyList<string> elements, DocumentCaption caption, IReadOnlyList<DocumentFootnote> footnotes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BoundingRegions = boundingRegions;
            Spans = spans;
            Elements = elements;
            Caption = caption;
            Footnotes = footnotes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentFigure"/> for deserialization. </summary>
        internal DocumentFigure()
        {
        }

        /// <summary> Bounding regions covering the figure. </summary>
        public IReadOnlyList<BoundingRegion> BoundingRegions { get; }
        /// <summary> Location of the figure in the reading order concatenated content. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
        /// <summary> Child elements of the figure, excluding any caption or footnotes. </summary>
        public IReadOnlyList<string> Elements { get; }
        /// <summary> Caption associated with the figure. </summary>
        public DocumentCaption Caption { get; }
        /// <summary> List of footnotes associated with the figure. </summary>
        public IReadOnlyList<DocumentFootnote> Footnotes { get; }
    }
}
