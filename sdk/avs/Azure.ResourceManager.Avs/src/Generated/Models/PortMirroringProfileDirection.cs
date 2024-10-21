// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Direction of port mirroring profile. </summary>
    public readonly partial struct PortMirroringProfileDirection : IEquatable<PortMirroringProfileDirection>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PortMirroringProfileDirection"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PortMirroringProfileDirection(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IngressValue = "INGRESS";
        private const string EgressValue = "EGRESS";
        private const string BidirectionalValue = "BIDIRECTIONAL";

        /// <summary> INGRESS. </summary>
        public static PortMirroringProfileDirection Ingress { get; } = new PortMirroringProfileDirection(IngressValue);
        /// <summary> EGRESS. </summary>
        public static PortMirroringProfileDirection Egress { get; } = new PortMirroringProfileDirection(EgressValue);
        /// <summary> BIDIRECTIONAL. </summary>
        public static PortMirroringProfileDirection Bidirectional { get; } = new PortMirroringProfileDirection(BidirectionalValue);
        /// <summary> Determines if two <see cref="PortMirroringProfileDirection"/> values are the same. </summary>
        public static bool operator ==(PortMirroringProfileDirection left, PortMirroringProfileDirection right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PortMirroringProfileDirection"/> values are not the same. </summary>
        public static bool operator !=(PortMirroringProfileDirection left, PortMirroringProfileDirection right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PortMirroringProfileDirection"/>. </summary>
        public static implicit operator PortMirroringProfileDirection(string value) => new PortMirroringProfileDirection(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PortMirroringProfileDirection other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PortMirroringProfileDirection other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
