// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetwork.Models
{
    /// <summary> Gets or sets the connectivity type of a network structure policy. </summary>
    public readonly partial struct ConnectivityType : IEquatable<ConnectivityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConnectivityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectivityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HubAndSpokeTopologyValue = "HubAndSpokeTopology";
        private const string MeshTopologyValue = "MeshTopology";

        /// <summary> HubAndSpokeTopology. </summary>
        public static ConnectivityType HubAndSpokeTopology { get; } = new ConnectivityType(HubAndSpokeTopologyValue);
        /// <summary> MeshTopology. </summary>
        public static ConnectivityType MeshTopology { get; } = new ConnectivityType(MeshTopologyValue);
        /// <summary> Determines if two <see cref="ConnectivityType"/> values are the same. </summary>
        public static bool operator ==(ConnectivityType left, ConnectivityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectivityType"/> values are not the same. </summary>
        public static bool operator !=(ConnectivityType left, ConnectivityType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ConnectivityType"/>. </summary>
        public static implicit operator ConnectivityType(string value) => new ConnectivityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectivityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectivityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
