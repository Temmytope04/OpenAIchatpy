// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes operator to be matched. </summary>
    public readonly partial struct SocketAddrOperator : IEquatable<SocketAddrOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SocketAddrOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SocketAddrOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnyValue = "Any";
        private const string IPMatchValue = "IPMatch";

        /// <summary> Any. </summary>
        public static SocketAddrOperator Any { get; } = new SocketAddrOperator(AnyValue);
        /// <summary> IPMatch. </summary>
        public static SocketAddrOperator IPMatch { get; } = new SocketAddrOperator(IPMatchValue);
        /// <summary> Determines if two <see cref="SocketAddrOperator"/> values are the same. </summary>
        public static bool operator ==(SocketAddrOperator left, SocketAddrOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SocketAddrOperator"/> values are not the same. </summary>
        public static bool operator !=(SocketAddrOperator left, SocketAddrOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SocketAddrOperator"/>. </summary>
        public static implicit operator SocketAddrOperator(string value) => new SocketAddrOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SocketAddrOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SocketAddrOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
