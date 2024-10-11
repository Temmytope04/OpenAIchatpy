// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> Field Deprecated. The field was previously optional, now it will have no defined behavior and will be ignored. The indicator of whether or not to disable IPAM allocation on the network attachment definition injected into the Hybrid AKS Cluster. </summary>
    public readonly partial struct HybridAksIpamEnabled : IEquatable<HybridAksIpamEnabled>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HybridAksIpamEnabled"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HybridAksIpamEnabled(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "True";
        private const string FalseValue = "False";

        /// <summary> True. </summary>
        public static HybridAksIpamEnabled True { get; } = new HybridAksIpamEnabled(TrueValue);
        /// <summary> False. </summary>
        public static HybridAksIpamEnabled False { get; } = new HybridAksIpamEnabled(FalseValue);
        /// <summary> Determines if two <see cref="HybridAksIpamEnabled"/> values are the same. </summary>
        public static bool operator ==(HybridAksIpamEnabled left, HybridAksIpamEnabled right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HybridAksIpamEnabled"/> values are not the same. </summary>
        public static bool operator !=(HybridAksIpamEnabled left, HybridAksIpamEnabled right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HybridAksIpamEnabled"/>. </summary>
        public static implicit operator HybridAksIpamEnabled(string value) => new HybridAksIpamEnabled(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HybridAksIpamEnabled other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HybridAksIpamEnabled other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
