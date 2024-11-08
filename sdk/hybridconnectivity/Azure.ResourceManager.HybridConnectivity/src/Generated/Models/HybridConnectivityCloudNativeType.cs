// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridConnectivity.Models
{
    /// <summary> Cloud Native Type enum. </summary>
    public readonly partial struct HybridConnectivityCloudNativeType : IEquatable<HybridConnectivityCloudNativeType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HybridConnectivityCloudNativeType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HybridConnectivityCloudNativeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Ec2Value = "ec2";

        /// <summary> ec2 enum. </summary>
        public static HybridConnectivityCloudNativeType Ec2 { get; } = new HybridConnectivityCloudNativeType(Ec2Value);
        /// <summary> Determines if two <see cref="HybridConnectivityCloudNativeType"/> values are the same. </summary>
        public static bool operator ==(HybridConnectivityCloudNativeType left, HybridConnectivityCloudNativeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HybridConnectivityCloudNativeType"/> values are not the same. </summary>
        public static bool operator !=(HybridConnectivityCloudNativeType left, HybridConnectivityCloudNativeType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HybridConnectivityCloudNativeType"/>. </summary>
        public static implicit operator HybridConnectivityCloudNativeType(string value) => new HybridConnectivityCloudNativeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HybridConnectivityCloudNativeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HybridConnectivityCloudNativeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
