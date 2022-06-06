// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The RestorePointExpandOptions. </summary>
    public readonly partial struct RestorePointExpandOptions : IEquatable<RestorePointExpandOptions>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RestorePointExpandOptions"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RestorePointExpandOptions(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InstanceViewValue = "instanceView";

        /// <summary> instanceView. </summary>
        public static RestorePointExpandOptions InstanceView { get; } = new RestorePointExpandOptions(InstanceViewValue);
        /// <summary> Determines if two <see cref="RestorePointExpandOptions"/> values are the same. </summary>
        public static bool operator ==(RestorePointExpandOptions left, RestorePointExpandOptions right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RestorePointExpandOptions"/> values are not the same. </summary>
        public static bool operator !=(RestorePointExpandOptions left, RestorePointExpandOptions right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RestorePointExpandOptions"/>. </summary>
        public static implicit operator RestorePointExpandOptions(string value) => new RestorePointExpandOptions(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RestorePointExpandOptions other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RestorePointExpandOptions other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
