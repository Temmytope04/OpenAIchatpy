// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary>
    /// Set the Operation for the POST method. Ping or Delete
    /// Serialized Name: Operation
    /// </summary>
    public readonly partial struct Operation : IEquatable<Operation>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Operation"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Operation(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeletePrivateStoreOfferValue = "DeletePrivateStoreOffer";
        private const string DeletePrivateStoreCollectionValue = "DeletePrivateStoreCollection";
        private const string DeletePrivateStoreCollectionOfferValue = "DeletePrivateStoreCollectionOffer";
        private const string PingValue = "Ping";

        /// <summary>
        /// DeletePrivateStoreOffer
        /// Serialized Name: Operation.DeletePrivateStoreOffer
        /// </summary>
        public static Operation DeletePrivateStoreOffer { get; } = new Operation(DeletePrivateStoreOfferValue);
        /// <summary>
        /// DeletePrivateStoreCollection
        /// Serialized Name: Operation.DeletePrivateStoreCollection
        /// </summary>
        public static Operation DeletePrivateStoreCollection { get; } = new Operation(DeletePrivateStoreCollectionValue);
        /// <summary>
        /// DeletePrivateStoreCollectionOffer
        /// Serialized Name: Operation.DeletePrivateStoreCollectionOffer
        /// </summary>
        public static Operation DeletePrivateStoreCollectionOffer { get; } = new Operation(DeletePrivateStoreCollectionOfferValue);
        /// <summary>
        /// Ping
        /// Serialized Name: Operation.Ping
        /// </summary>
        public static Operation Ping { get; } = new Operation(PingValue);
        /// <summary> Determines if two <see cref="Operation"/> values are the same. </summary>
        public static bool operator ==(Operation left, Operation right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Operation"/> values are not the same. </summary>
        public static bool operator !=(Operation left, Operation right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Operation"/>. </summary>
        public static implicit operator Operation(string value) => new Operation(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Operation other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Operation other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
