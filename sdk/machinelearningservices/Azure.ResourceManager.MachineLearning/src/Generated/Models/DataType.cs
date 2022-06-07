// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Enum to determine the type of data. </summary>
    public readonly partial struct DataType : IEquatable<DataType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UriFileValue = "UriFile";
        private const string UriFolderValue = "UriFolder";
        private const string MLTableValue = "MLTable";

        /// <summary> UriFile. </summary>
        public static DataType UriFile { get; } = new DataType(UriFileValue);
        /// <summary> UriFolder. </summary>
        public static DataType UriFolder { get; } = new DataType(UriFolderValue);
        /// <summary> MLTable. </summary>
        public static DataType MLTable { get; } = new DataType(MLTableValue);
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
