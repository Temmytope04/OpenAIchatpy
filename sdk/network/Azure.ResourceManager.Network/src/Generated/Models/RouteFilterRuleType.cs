// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The rule type of the rule. </summary>
    public readonly partial struct RouteFilterRuleType : IEquatable<RouteFilterRuleType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="RouteFilterRuleType"/> values are the same. </summary>
        public RouteFilterRuleType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CommunityValue = "Community";

        /// <summary> Community. </summary>
        public static RouteFilterRuleType Community { get; } = new RouteFilterRuleType(CommunityValue);
        /// <summary> Determines if two <see cref="RouteFilterRuleType"/> values are the same. </summary>
        public static bool operator ==(RouteFilterRuleType left, RouteFilterRuleType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RouteFilterRuleType"/> values are not the same. </summary>
        public static bool operator !=(RouteFilterRuleType left, RouteFilterRuleType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RouteFilterRuleType"/>. </summary>
        public static implicit operator RouteFilterRuleType(string value) => new RouteFilterRuleType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RouteFilterRuleType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RouteFilterRuleType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
