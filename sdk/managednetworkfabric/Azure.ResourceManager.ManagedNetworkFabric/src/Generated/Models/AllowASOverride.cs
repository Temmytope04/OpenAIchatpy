// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Enable Or Disable state. </summary>
    public readonly partial struct AllowASOverride : IEquatable<AllowASOverride>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AllowASOverride"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AllowASOverride(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnableValue = "Enable";
        private const string DisableValue = "Disable";

        /// <summary> Enable. </summary>
        public static AllowASOverride Enable { get; } = new AllowASOverride(EnableValue);
        /// <summary> Disable. </summary>
        public static AllowASOverride Disable { get; } = new AllowASOverride(DisableValue);
        /// <summary> Determines if two <see cref="AllowASOverride"/> values are the same. </summary>
        public static bool operator ==(AllowASOverride left, AllowASOverride right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AllowASOverride"/> values are not the same. </summary>
        public static bool operator !=(AllowASOverride left, AllowASOverride right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AllowASOverride"/>. </summary>
        public static implicit operator AllowASOverride(string value) => new AllowASOverride(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AllowASOverride other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AllowASOverride other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
