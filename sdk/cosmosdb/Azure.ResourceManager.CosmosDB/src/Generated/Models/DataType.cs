// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The datatype for which the indexing behavior is applied to. </summary>
    public readonly partial struct DataType : IEquatable<DataType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StringValue = "String";
        private const string NumberValue = "Number";
        private const string PointValue = "Point";
        private const string PolygonValue = "Polygon";
        private const string LineStringValue = "LineString";
        private const string MultiPolygonValue = "MultiPolygon";

        /// <summary> String. </summary>
        public static DataType String { get; } = new DataType(StringValue);
        /// <summary> Number. </summary>
        public static DataType Number { get; } = new DataType(NumberValue);
        /// <summary> Point. </summary>
        public static DataType Point { get; } = new DataType(PointValue);
        /// <summary> Polygon. </summary>
        public static DataType Polygon { get; } = new DataType(PolygonValue);
        /// <summary> LineString. </summary>
        public static DataType LineString { get; } = new DataType(LineStringValue);
        /// <summary> MultiPolygon. </summary>
        public static DataType MultiPolygon { get; } = new DataType(MultiPolygonValue);
        /// <summary> Determines if two <see cref="DataType"/> values are the same. </summary>
        public static bool operator ==(DataType left, DataType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataType"/> values are not the same. </summary>
        public static bool operator !=(DataType left, DataType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataType"/>. </summary>
        public static implicit operator DataType(string value) => new DataType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
