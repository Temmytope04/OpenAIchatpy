// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> The action of virtual network rule. </summary>
    public readonly partial struct VirtualNetworkRuleAction : IEquatable<VirtualNetworkRuleAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkRuleAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VirtualNetworkRuleAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";

        /// <summary> Allow. </summary>
        public static VirtualNetworkRuleAction Allow { get; } = new VirtualNetworkRuleAction(AllowValue);
        /// <summary> Determines if two <see cref="VirtualNetworkRuleAction"/> values are the same. </summary>
        public static bool operator ==(VirtualNetworkRuleAction left, VirtualNetworkRuleAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualNetworkRuleAction"/> values are not the same. </summary>
        public static bool operator !=(VirtualNetworkRuleAction left, VirtualNetworkRuleAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VirtualNetworkRuleAction"/>. </summary>
        public static implicit operator VirtualNetworkRuleAction(string value) => new VirtualNetworkRuleAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualNetworkRuleAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualNetworkRuleAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
