// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The current state of the VirtualHub to vnet connection. </summary>
    public readonly partial struct HubVirtualNetworkConnectionStatus : IEquatable<HubVirtualNetworkConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="HubVirtualNetworkConnectionStatus"/> values are the same. </summary>
        public HubVirtualNetworkConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string ConnectingValue = "Connecting";
        private const string ConnectedValue = "Connected";
        private const string NotConnectedValue = "NotConnected";

        /// <summary> Unknown. </summary>
        public static HubVirtualNetworkConnectionStatus Unknown { get; } = new HubVirtualNetworkConnectionStatus(UnknownValue);
        /// <summary> Connecting. </summary>
        public static HubVirtualNetworkConnectionStatus Connecting { get; } = new HubVirtualNetworkConnectionStatus(ConnectingValue);
        /// <summary> Connected. </summary>
        public static HubVirtualNetworkConnectionStatus Connected { get; } = new HubVirtualNetworkConnectionStatus(ConnectedValue);
        /// <summary> NotConnected. </summary>
        public static HubVirtualNetworkConnectionStatus NotConnected { get; } = new HubVirtualNetworkConnectionStatus(NotConnectedValue);
        /// <summary> Determines if two <see cref="HubVirtualNetworkConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(HubVirtualNetworkConnectionStatus left, HubVirtualNetworkConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HubVirtualNetworkConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(HubVirtualNetworkConnectionStatus left, HubVirtualNetworkConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HubVirtualNetworkConnectionStatus"/>. </summary>
        public static implicit operator HubVirtualNetworkConnectionStatus(string value) => new HubVirtualNetworkConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HubVirtualNetworkConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HubVirtualNetworkConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
