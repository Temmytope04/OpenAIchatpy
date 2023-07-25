// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The type of the rack. </summary>
    public readonly partial struct RackSkuType : IEquatable<RackSkuType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RackSkuType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RackSkuType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AggregatorValue = "Aggregator";
        private const string ComputeValue = "Compute";
        private const string SingleValue = "Single";

        /// <summary> Aggregator. </summary>
        public static RackSkuType Aggregator { get; } = new RackSkuType(AggregatorValue);
        /// <summary> Compute. </summary>
        public static RackSkuType Compute { get; } = new RackSkuType(ComputeValue);
        /// <summary> Single. </summary>
        public static RackSkuType Single { get; } = new RackSkuType(SingleValue);
        /// <summary> Determines if two <see cref="RackSkuType"/> values are the same. </summary>
        public static bool operator ==(RackSkuType left, RackSkuType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RackSkuType"/> values are not the same. </summary>
        public static bool operator !=(RackSkuType left, RackSkuType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RackSkuType"/>. </summary>
        public static implicit operator RackSkuType(string value) => new RackSkuType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RackSkuType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RackSkuType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
