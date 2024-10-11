// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The Source NAT direction of a VPN NAT. </summary>
    public readonly partial struct VpnNatRuleMode : IEquatable<VpnNatRuleMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VpnNatRuleMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VpnNatRuleMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EgressSnatValue = "EgressSnat";
        private const string IngressSnatValue = "IngressSnat";

        /// <summary> EgressSnat. </summary>
        public static VpnNatRuleMode EgressSnat { get; } = new VpnNatRuleMode(EgressSnatValue);
        /// <summary> IngressSnat. </summary>
        public static VpnNatRuleMode IngressSnat { get; } = new VpnNatRuleMode(IngressSnatValue);
        /// <summary> Determines if two <see cref="VpnNatRuleMode"/> values are the same. </summary>
        public static bool operator ==(VpnNatRuleMode left, VpnNatRuleMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VpnNatRuleMode"/> values are not the same. </summary>
        public static bool operator !=(VpnNatRuleMode left, VpnNatRuleMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VpnNatRuleMode"/>. </summary>
        public static implicit operator VpnNatRuleMode(string value) => new VpnNatRuleMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VpnNatRuleMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VpnNatRuleMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
