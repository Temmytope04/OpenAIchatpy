// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Semantic data type of the field value. </summary>
    public readonly partial struct DocumentFieldType : IEquatable<DocumentFieldType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DocumentFieldType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DocumentFieldType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StringValue = "string";
        private const string DateValue = "date";
        private const string TimeValue = "time";
        private const string PhoneNumberValue = "phoneNumber";
        private const string DoubleValue = "number";
        private const string LongValue = "integer";
        private const string SelectionMarkValue = "selectionMark";
        private const string CountryRegionValue = "countryRegion";
        private const string SignatureValue = "signature";
        private const string ListValue = "array";
        private const string DictionaryValue = "object";
        private const string CurrencyValue = "currency";
        private const string AddressValue = "address";
        private const string BooleanValue = "boolean";
        private const string SelectionGroupValue = "selectionGroup";

        /// <summary> Plain text. </summary>
        public static DocumentFieldType String { get; } = new DocumentFieldType(StringValue);
        /// <summary> Date, normalized to ISO 8601 (YYYY-MM-DD) format. </summary>
        public static DocumentFieldType Date { get; } = new DocumentFieldType(DateValue);
        /// <summary> Time, normalized to ISO 8601 (hh:mm:ss) format. </summary>
        public static DocumentFieldType Time { get; } = new DocumentFieldType(TimeValue);
        /// <summary> Phone number, normalized to E.164 (+{CountryCode}{SubscriberNumber}) format. </summary>
        public static DocumentFieldType PhoneNumber { get; } = new DocumentFieldType(PhoneNumberValue);
        /// <summary> Floating point number, normalized to double precision floating point. </summary>
        public static DocumentFieldType Double { get; } = new DocumentFieldType(DoubleValue);
        /// <summary> Integer number, normalized to 64-bit signed integer. </summary>
        public static DocumentFieldType Long { get; } = new DocumentFieldType(LongValue);
        /// <summary> Is field selected?. </summary>
        public static DocumentFieldType SelectionMark { get; } = new DocumentFieldType(SelectionMarkValue);
        /// <summary> Country/region, normalized to ISO 3166-1 alpha-3 format (ex. USA). </summary>
        public static DocumentFieldType CountryRegion { get; } = new DocumentFieldType(CountryRegionValue);
        /// <summary> Is signature present?. </summary>
        public static DocumentFieldType Signature { get; } = new DocumentFieldType(SignatureValue);
        /// <summary> List of subfields of the same type. </summary>
        public static DocumentFieldType List { get; } = new DocumentFieldType(ListValue);
        /// <summary> Named list of subfields of potentially different types. </summary>
        public static DocumentFieldType Dictionary { get; } = new DocumentFieldType(DictionaryValue);
        /// <summary> Currency amount with optional currency symbol and unit. </summary>
        public static DocumentFieldType Currency { get; } = new DocumentFieldType(CurrencyValue);
        /// <summary> Parsed address. </summary>
        public static DocumentFieldType Address { get; } = new DocumentFieldType(AddressValue);
        /// <summary> Boolean value, normalized to true or false. </summary>
        public static DocumentFieldType Boolean { get; } = new DocumentFieldType(BooleanValue);
        /// <summary> Array of selected string values. </summary>
        public static DocumentFieldType SelectionGroup { get; } = new DocumentFieldType(SelectionGroupValue);
        /// <summary> Determines if two <see cref="DocumentFieldType"/> values are the same. </summary>
        public static bool operator ==(DocumentFieldType left, DocumentFieldType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DocumentFieldType"/> values are not the same. </summary>
        public static bool operator !=(DocumentFieldType left, DocumentFieldType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DocumentFieldType"/>. </summary>
        public static implicit operator DocumentFieldType(string value) => new DocumentFieldType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DocumentFieldType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DocumentFieldType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
