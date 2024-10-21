// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> IP Address type that needs to be matched. </summary>
    public readonly partial struct SourceDestinationType : IEquatable<SourceDestinationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SourceDestinationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SourceDestinationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SourceIPValue = "SourceIP";
        private const string DestinationIPValue = "DestinationIP";

        /// <summary> SourceIP. </summary>
        public static SourceDestinationType SourceIP { get; } = new SourceDestinationType(SourceIPValue);
        /// <summary> DestinationIP. </summary>
        public static SourceDestinationType DestinationIP { get; } = new SourceDestinationType(DestinationIPValue);
        /// <summary> Determines if two <see cref="SourceDestinationType"/> values are the same. </summary>
        public static bool operator ==(SourceDestinationType left, SourceDestinationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SourceDestinationType"/> values are not the same. </summary>
        public static bool operator !=(SourceDestinationType left, SourceDestinationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SourceDestinationType"/>. </summary>
        public static implicit operator SourceDestinationType(string value) => new SourceDestinationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SourceDestinationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SourceDestinationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
