// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The cassandra connector offer type for the Cosmos DB C* database account. </summary>
    public readonly partial struct ConnectorOffer : IEquatable<ConnectorOffer>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConnectorOffer"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectorOffer(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SmallValue = "Small";

        /// <summary> Small. </summary>
        public static ConnectorOffer Small { get; } = new ConnectorOffer(SmallValue);
        /// <summary> Determines if two <see cref="ConnectorOffer"/> values are the same. </summary>
        public static bool operator ==(ConnectorOffer left, ConnectorOffer right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectorOffer"/> values are not the same. </summary>
        public static bool operator !=(ConnectorOffer left, ConnectorOffer right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ConnectorOffer"/>. </summary>
        public static implicit operator ConnectorOffer(string value) => new ConnectorOffer(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectorOffer other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectorOffer other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
