// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> If the current version is a test version. </summary>
    public readonly partial struct IsTestVersion : IEquatable<IsTestVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IsTestVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IsTestVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "true";
        private const string FalseValue = "false";

        /// <summary> true. </summary>
        public static IsTestVersion True { get; } = new IsTestVersion(TrueValue);
        /// <summary> false. </summary>
        public static IsTestVersion False { get; } = new IsTestVersion(FalseValue);
        /// <summary> Determines if two <see cref="IsTestVersion"/> values are the same. </summary>
        public static bool operator ==(IsTestVersion left, IsTestVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IsTestVersion"/> values are not the same. </summary>
        public static bool operator !=(IsTestVersion left, IsTestVersion right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IsTestVersion"/>. </summary>
        public static implicit operator IsTestVersion(string value) => new IsTestVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IsTestVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IsTestVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
