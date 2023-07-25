// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> PDU session type (IPv4/IPv6). </summary>
    public readonly partial struct PduSessionType : IEquatable<PduSessionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PduSessionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PduSessionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IPv4Value = "IPv4";
        private const string IPv6Value = "IPv6";

        /// <summary> IPv4. </summary>
        public static PduSessionType IPv4 { get; } = new PduSessionType(IPv4Value);
        /// <summary> IPv6. </summary>
        public static PduSessionType IPv6 { get; } = new PduSessionType(IPv6Value);
        /// <summary> Determines if two <see cref="PduSessionType"/> values are the same. </summary>
        public static bool operator ==(PduSessionType left, PduSessionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PduSessionType"/> values are not the same. </summary>
        public static bool operator !=(PduSessionType left, PduSessionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PduSessionType"/>. </summary>
        public static implicit operator PduSessionType(string value) => new PduSessionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PduSessionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PduSessionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
