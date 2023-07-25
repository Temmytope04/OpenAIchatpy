// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The pattern type to be used for resource naming. </summary>
    internal readonly partial struct SapNamingPatternType : IEquatable<SapNamingPatternType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SapNamingPatternType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SapNamingPatternType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FullResourceNameValue = "FullResourceName";

        /// <summary> FullResourceName. </summary>
        public static SapNamingPatternType FullResourceName { get; } = new SapNamingPatternType(FullResourceNameValue);
        /// <summary> Determines if two <see cref="SapNamingPatternType"/> values are the same. </summary>
        public static bool operator ==(SapNamingPatternType left, SapNamingPatternType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SapNamingPatternType"/> values are not the same. </summary>
        public static bool operator !=(SapNamingPatternType left, SapNamingPatternType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SapNamingPatternType"/>. </summary>
        public static implicit operator SapNamingPatternType(string value) => new SapNamingPatternType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SapNamingPatternType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SapNamingPatternType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
