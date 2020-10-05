// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> The current state of the tunnel. </summary>
    public readonly partial struct TunnelConnectionStatus : IEquatable<TunnelConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="TunnelConnectionStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TunnelConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string ConnectingValue = "Connecting";
        private const string ConnectedValue = "Connected";
        private const string NotConnectedValue = "NotConnected";

        /// <summary> Unknown. </summary>
        public static TunnelConnectionStatus Unknown { get; } = new TunnelConnectionStatus(UnknownValue);
        /// <summary> Connecting. </summary>
        public static TunnelConnectionStatus Connecting { get; } = new TunnelConnectionStatus(ConnectingValue);
        /// <summary> Connected. </summary>
        public static TunnelConnectionStatus Connected { get; } = new TunnelConnectionStatus(ConnectedValue);
        /// <summary> NotConnected. </summary>
        public static TunnelConnectionStatus NotConnected { get; } = new TunnelConnectionStatus(NotConnectedValue);
        /// <summary> Determines if two <see cref="TunnelConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(TunnelConnectionStatus left, TunnelConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TunnelConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(TunnelConnectionStatus left, TunnelConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TunnelConnectionStatus"/>. </summary>
        public static implicit operator TunnelConnectionStatus(string value) => new TunnelConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TunnelConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TunnelConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
