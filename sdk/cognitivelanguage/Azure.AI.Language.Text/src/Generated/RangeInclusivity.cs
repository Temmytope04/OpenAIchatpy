// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Text
{
    /// <summary> The range inclusiveness of this property property. </summary>
    public readonly partial struct RangeInclusivity : IEquatable<RangeInclusivity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RangeInclusivity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RangeInclusivity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneInclusiveValue = "NoneInclusive";
        private const string LeftInclusiveValue = "LeftInclusive";
        private const string RightInclusiveValue = "RightInclusive";
        private const string LeftRightInclusiveValue = "LeftRightInclusive";

        /// <summary> No inclusivity. </summary>
        public static RangeInclusivity NoneInclusive { get; } = new RangeInclusivity(NoneInclusiveValue);
        /// <summary> Left side inclusive. </summary>
        public static RangeInclusivity LeftInclusive { get; } = new RangeInclusivity(LeftInclusiveValue);
        /// <summary> Right side inclusive. </summary>
        public static RangeInclusivity RightInclusive { get; } = new RangeInclusivity(RightInclusiveValue);
        /// <summary> Both sides inclusive. </summary>
        public static RangeInclusivity LeftRightInclusive { get; } = new RangeInclusivity(LeftRightInclusiveValue);
        /// <summary> Determines if two <see cref="RangeInclusivity"/> values are the same. </summary>
        public static bool operator ==(RangeInclusivity left, RangeInclusivity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RangeInclusivity"/> values are not the same. </summary>
        public static bool operator !=(RangeInclusivity left, RangeInclusivity right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RangeInclusivity"/>. </summary>
        public static implicit operator RangeInclusivity(string value) => new RangeInclusivity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RangeInclusivity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RangeInclusivity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
