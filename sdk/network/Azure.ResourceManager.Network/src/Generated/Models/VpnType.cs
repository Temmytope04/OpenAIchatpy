// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The type of this virtual network gateway. </summary>
    public readonly partial struct VpnType : IEquatable<VpnType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VpnType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VpnType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PolicyBasedValue = "PolicyBased";
        private const string RouteBasedValue = "RouteBased";

        /// <summary> PolicyBased. </summary>
        public static VpnType PolicyBased { get; } = new VpnType(PolicyBasedValue);
        /// <summary> RouteBased. </summary>
        public static VpnType RouteBased { get; } = new VpnType(RouteBasedValue);
        /// <summary> Determines if two <see cref="VpnType"/> values are the same. </summary>
        public static bool operator ==(VpnType left, VpnType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VpnType"/> values are not the same. </summary>
        public static bool operator !=(VpnType left, VpnType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VpnType"/>. </summary>
        public static implicit operator VpnType(string value) => new VpnType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VpnType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VpnType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
