// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevSpaces.Models
{
    /// <summary> The name of the SKU for Azure Dev Spaces Controller. </summary>
    public readonly partial struct DevSpacesSkuName : IEquatable<DevSpacesSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevSpacesSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevSpacesSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string S1Value = "S1";

        /// <summary> S1. </summary>
        public static DevSpacesSkuName S1 { get; } = new DevSpacesSkuName(S1Value);
        /// <summary> Determines if two <see cref="DevSpacesSkuName"/> values are the same. </summary>
        public static bool operator ==(DevSpacesSkuName left, DevSpacesSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevSpacesSkuName"/> values are not the same. </summary>
        public static bool operator !=(DevSpacesSkuName left, DevSpacesSkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DevSpacesSkuName"/>. </summary>
        public static implicit operator DevSpacesSkuName(string value) => new DevSpacesSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevSpacesSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevSpacesSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
