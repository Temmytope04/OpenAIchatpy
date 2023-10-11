// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> Specifies the kind of charge summary. </summary>
    internal readonly partial struct ChargeSummaryKind : IEquatable<ChargeSummaryKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ChargeSummaryKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ChargeSummaryKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LegacyValue = "legacy";
        private const string ModernValue = "modern";

        /// <summary> legacy. </summary>
        public static ChargeSummaryKind Legacy { get; } = new ChargeSummaryKind(LegacyValue);
        /// <summary> modern. </summary>
        public static ChargeSummaryKind Modern { get; } = new ChargeSummaryKind(ModernValue);
        /// <summary> Determines if two <see cref="ChargeSummaryKind"/> values are the same. </summary>
        public static bool operator ==(ChargeSummaryKind left, ChargeSummaryKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ChargeSummaryKind"/> values are not the same. </summary>
        public static bool operator !=(ChargeSummaryKind left, ChargeSummaryKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ChargeSummaryKind"/>. </summary>
        public static implicit operator ChargeSummaryKind(string value) => new ChargeSummaryKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ChargeSummaryKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ChargeSummaryKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
