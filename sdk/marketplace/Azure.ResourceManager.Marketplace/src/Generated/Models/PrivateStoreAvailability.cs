// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Indicates private store availability. </summary>
    public readonly partial struct PrivateStoreAvailability : IEquatable<PrivateStoreAvailability>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PrivateStoreAvailability"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PrivateStoreAvailability(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "enabled";
        private const string DisabledValue = "disabled";

        /// <summary> enabled. </summary>
        public static PrivateStoreAvailability Enabled { get; } = new PrivateStoreAvailability(EnabledValue);
        /// <summary> disabled. </summary>
        public static PrivateStoreAvailability Disabled { get; } = new PrivateStoreAvailability(DisabledValue);
        /// <summary> Determines if two <see cref="PrivateStoreAvailability"/> values are the same. </summary>
        public static bool operator ==(PrivateStoreAvailability left, PrivateStoreAvailability right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PrivateStoreAvailability"/> values are not the same. </summary>
        public static bool operator !=(PrivateStoreAvailability left, PrivateStoreAvailability right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PrivateStoreAvailability"/>. </summary>
        public static implicit operator PrivateStoreAvailability(string value) => new PrivateStoreAvailability(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PrivateStoreAvailability other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PrivateStoreAvailability other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
