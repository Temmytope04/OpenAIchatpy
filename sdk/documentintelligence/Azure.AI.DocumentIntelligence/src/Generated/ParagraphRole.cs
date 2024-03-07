// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Semantic role of the paragraph. </summary>
    public readonly partial struct ParagraphRole : IEquatable<ParagraphRole>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ParagraphRole"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ParagraphRole(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PageHeaderValue = "pageHeader";
        private const string PageFooterValue = "pageFooter";
        private const string PageNumberValue = "pageNumber";
        private const string TitleValue = "title";
        private const string SectionHeadingValue = "sectionHeading";
        private const string FootnoteValue = "footnote";
        private const string FormulaBlockValue = "formulaBlock";

        /// <summary> Text near the top edge of the page. </summary>
        public static ParagraphRole PageHeader { get; } = new ParagraphRole(PageHeaderValue);
        /// <summary> Text near the bottom edge of the page. </summary>
        public static ParagraphRole PageFooter { get; } = new ParagraphRole(PageFooterValue);
        /// <summary> Page number. </summary>
        public static ParagraphRole PageNumber { get; } = new ParagraphRole(PageNumberValue);
        /// <summary> Top-level title describing the entire document. </summary>
        public static ParagraphRole Title { get; } = new ParagraphRole(TitleValue);
        /// <summary> Sub heading describing a section of the document. </summary>
        public static ParagraphRole SectionHeading { get; } = new ParagraphRole(SectionHeadingValue);
        /// <summary> A note usually placed after the main content on a page. </summary>
        public static ParagraphRole Footnote { get; } = new ParagraphRole(FootnoteValue);
        /// <summary> A block of formulas, often with shared alignment. </summary>
        public static ParagraphRole FormulaBlock { get; } = new ParagraphRole(FormulaBlockValue);
        /// <summary> Determines if two <see cref="ParagraphRole"/> values are the same. </summary>
        public static bool operator ==(ParagraphRole left, ParagraphRole right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ParagraphRole"/> values are not the same. </summary>
        public static bool operator !=(ParagraphRole left, ParagraphRole right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ParagraphRole"/>. </summary>
        public static implicit operator ParagraphRole(string value) => new ParagraphRole(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ParagraphRole other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ParagraphRole other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
