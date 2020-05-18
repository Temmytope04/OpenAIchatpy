// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> The family of the SKU. </summary>
    public readonly partial struct ExpressRouteCircuitSkuFamily : IEquatable<ExpressRouteCircuitSkuFamily>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ExpressRouteCircuitSkuFamily"/> values are the same. </summary>
        public ExpressRouteCircuitSkuFamily(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnlimitedDataValue = "UnlimitedData";
        private const string MeteredDataValue = "MeteredData";

        /// <summary> UnlimitedData. </summary>
        public static ExpressRouteCircuitSkuFamily UnlimitedData { get; } = new ExpressRouteCircuitSkuFamily(UnlimitedDataValue);
        /// <summary> MeteredData. </summary>
        public static ExpressRouteCircuitSkuFamily MeteredData { get; } = new ExpressRouteCircuitSkuFamily(MeteredDataValue);
        /// <summary> Determines if two <see cref="ExpressRouteCircuitSkuFamily"/> values are the same. </summary>
        public static bool operator ==(ExpressRouteCircuitSkuFamily left, ExpressRouteCircuitSkuFamily right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExpressRouteCircuitSkuFamily"/> values are not the same. </summary>
        public static bool operator !=(ExpressRouteCircuitSkuFamily left, ExpressRouteCircuitSkuFamily right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExpressRouteCircuitSkuFamily"/>. </summary>
        public static implicit operator ExpressRouteCircuitSkuFamily(string value) => new ExpressRouteCircuitSkuFamily(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExpressRouteCircuitSkuFamily other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExpressRouteCircuitSkuFamily other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
