// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The state of peering. </summary>
    public readonly partial struct ExpressRouteCircuitPeeringState : IEquatable<ExpressRouteCircuitPeeringState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitPeeringState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExpressRouteCircuitPeeringState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Disabled. </summary>
        public static ExpressRouteCircuitPeeringState Disabled { get; } = new ExpressRouteCircuitPeeringState(DisabledValue);
        /// <summary> Enabled. </summary>
        public static ExpressRouteCircuitPeeringState Enabled { get; } = new ExpressRouteCircuitPeeringState(EnabledValue);
        /// <summary> Determines if two <see cref="ExpressRouteCircuitPeeringState"/> values are the same. </summary>
        public static bool operator ==(ExpressRouteCircuitPeeringState left, ExpressRouteCircuitPeeringState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExpressRouteCircuitPeeringState"/> values are not the same. </summary>
        public static bool operator !=(ExpressRouteCircuitPeeringState left, ExpressRouteCircuitPeeringState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ExpressRouteCircuitPeeringState"/>. </summary>
        public static implicit operator ExpressRouteCircuitPeeringState(string value) => new ExpressRouteCircuitPeeringState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExpressRouteCircuitPeeringState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExpressRouteCircuitPeeringState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
