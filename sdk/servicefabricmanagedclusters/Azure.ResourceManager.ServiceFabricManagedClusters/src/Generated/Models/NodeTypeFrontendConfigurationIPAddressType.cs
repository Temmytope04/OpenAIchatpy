// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary>
    /// The IP address type.
    ///
    /// </summary>
    public readonly partial struct NodeTypeFrontendConfigurationIPAddressType : IEquatable<NodeTypeFrontendConfigurationIPAddressType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NodeTypeFrontendConfigurationIPAddressType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NodeTypeFrontendConfigurationIPAddressType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IPv4Value = "IPv4";
        private const string IPv6Value = "IPv6";

        /// <summary> IPv4 address type. </summary>
        public static NodeTypeFrontendConfigurationIPAddressType IPv4 { get; } = new NodeTypeFrontendConfigurationIPAddressType(IPv4Value);
        /// <summary> IPv6 address type. </summary>
        public static NodeTypeFrontendConfigurationIPAddressType IPv6 { get; } = new NodeTypeFrontendConfigurationIPAddressType(IPv6Value);
        /// <summary> Determines if two <see cref="NodeTypeFrontendConfigurationIPAddressType"/> values are the same. </summary>
        public static bool operator ==(NodeTypeFrontendConfigurationIPAddressType left, NodeTypeFrontendConfigurationIPAddressType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NodeTypeFrontendConfigurationIPAddressType"/> values are not the same. </summary>
        public static bool operator !=(NodeTypeFrontendConfigurationIPAddressType left, NodeTypeFrontendConfigurationIPAddressType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NodeTypeFrontendConfigurationIPAddressType"/>. </summary>
        public static implicit operator NodeTypeFrontendConfigurationIPAddressType(string value) => new NodeTypeFrontendConfigurationIPAddressType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NodeTypeFrontendConfigurationIPAddressType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NodeTypeFrontendConfigurationIPAddressType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
