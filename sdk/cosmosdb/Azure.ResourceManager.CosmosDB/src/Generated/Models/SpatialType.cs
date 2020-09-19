// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Indicates the spatial type of index. </summary>
    public readonly partial struct SpatialType : IEquatable<SpatialType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SpatialType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SpatialType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PointValue = "Point";
        private const string LineStringValue = "LineString";
        private const string PolygonValue = "Polygon";
        private const string MultiPolygonValue = "MultiPolygon";

        /// <summary> Point. </summary>
        public static SpatialType Point { get; } = new SpatialType(PointValue);
        /// <summary> LineString. </summary>
        public static SpatialType LineString { get; } = new SpatialType(LineStringValue);
        /// <summary> Polygon. </summary>
        public static SpatialType Polygon { get; } = new SpatialType(PolygonValue);
        /// <summary> MultiPolygon. </summary>
        public static SpatialType MultiPolygon { get; } = new SpatialType(MultiPolygonValue);
        /// <summary> Determines if two <see cref="SpatialType"/> values are the same. </summary>
        public static bool operator ==(SpatialType left, SpatialType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SpatialType"/> values are not the same. </summary>
        public static bool operator !=(SpatialType left, SpatialType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SpatialType"/>. </summary>
        public static implicit operator SpatialType(string value) => new SpatialType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SpatialType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SpatialType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
