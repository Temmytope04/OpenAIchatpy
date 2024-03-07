// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Health.Insights.CancerProfiling
{
    /// <summary>
    /// The type of the content's source.
    /// In case the source type is 'inline', the content is given as a string (for instance, text).
    /// In case the source type is 'reference', the content is given as a URI.
    /// </summary>
    public readonly partial struct DocumentContentSourceType : IEquatable<DocumentContentSourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DocumentContentSourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DocumentContentSourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InlineValue = "inline";
        private const string ReferenceValue = "reference";

        /// <summary> inline. </summary>
        public static DocumentContentSourceType Inline { get; } = new DocumentContentSourceType(InlineValue);
        /// <summary> reference. </summary>
        public static DocumentContentSourceType Reference { get; } = new DocumentContentSourceType(ReferenceValue);
        /// <summary> Determines if two <see cref="DocumentContentSourceType"/> values are the same. </summary>
        public static bool operator ==(DocumentContentSourceType left, DocumentContentSourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DocumentContentSourceType"/> values are not the same. </summary>
        public static bool operator !=(DocumentContentSourceType left, DocumentContentSourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DocumentContentSourceType"/>. </summary>
        public static implicit operator DocumentContentSourceType(string value) => new DocumentContentSourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DocumentContentSourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DocumentContentSourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
