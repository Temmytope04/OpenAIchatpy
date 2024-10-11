// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The type of DNS zone. </summary>
    public readonly partial struct DnsZoneType : IEquatable<DnsZoneType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DnsZoneType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DnsZoneType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PublicValue = "Public";
        private const string PrivateValue = "Private";

        /// <summary> Primary DNS zone. </summary>
        public static DnsZoneType Public { get; } = new DnsZoneType(PublicValue);
        /// <summary> Private DNS zone. </summary>
        public static DnsZoneType Private { get; } = new DnsZoneType(PrivateValue);
        /// <summary> Determines if two <see cref="DnsZoneType"/> values are the same. </summary>
        public static bool operator ==(DnsZoneType left, DnsZoneType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DnsZoneType"/> values are not the same. </summary>
        public static bool operator !=(DnsZoneType left, DnsZoneType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DnsZoneType"/>. </summary>
        public static implicit operator DnsZoneType(string value) => new DnsZoneType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DnsZoneType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DnsZoneType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
