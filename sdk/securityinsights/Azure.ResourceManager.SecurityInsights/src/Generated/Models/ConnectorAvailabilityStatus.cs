// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// The connector Availability Status
    /// Serialized Name: AvailabilityStatus
    /// </summary>
    public readonly partial struct ConnectorAvailabilityStatus : IEquatable<ConnectorAvailabilityStatus>
    {
        private readonly int _value;

        /// <summary> Initializes a new instance of <see cref="ConnectorAvailabilityStatus"/>. </summary>
        public ConnectorAvailabilityStatus(int value)
        {
            _value = value;
        }

        private const int _1Value = 1;

        /// <summary>
        /// 1
        /// Serialized Name: AvailabilityStatus.1
        /// </summary>
        public static ConnectorAvailabilityStatus _1 { get; } = new ConnectorAvailabilityStatus(_1Value);

        internal int ToSerialInt32() => _value;

        /// <summary> Determines if two <see cref="ConnectorAvailabilityStatus"/> values are the same. </summary>
        public static bool operator ==(ConnectorAvailabilityStatus left, ConnectorAvailabilityStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectorAvailabilityStatus"/> values are not the same. </summary>
        public static bool operator !=(ConnectorAvailabilityStatus left, ConnectorAvailabilityStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConnectorAvailabilityStatus"/>. </summary>
        public static implicit operator ConnectorAvailabilityStatus(int value) => new ConnectorAvailabilityStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectorAvailabilityStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectorAvailabilityStatus other) => Equals(_value, other._value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();
        /// <inheritdoc />
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}
