// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Ssl predefined policy name enums. </summary>
    public readonly partial struct ApplicationGatewaySslPolicyName : IEquatable<ApplicationGatewaySslPolicyName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewaySslPolicyName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationGatewaySslPolicyName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AppGwSslPolicy20150501Value = "AppGwSslPolicy20150501";
        private const string AppGwSslPolicy20170401Value = "AppGwSslPolicy20170401";
        private const string AppGwSslPolicy20170401SValue = "AppGwSslPolicy20170401S";

        /// <summary> AppGwSslPolicy20150501. </summary>
        public static ApplicationGatewaySslPolicyName AppGwSslPolicy20150501 { get; } = new ApplicationGatewaySslPolicyName(AppGwSslPolicy20150501Value);
        /// <summary> AppGwSslPolicy20170401. </summary>
        public static ApplicationGatewaySslPolicyName AppGwSslPolicy20170401 { get; } = new ApplicationGatewaySslPolicyName(AppGwSslPolicy20170401Value);
        /// <summary> AppGwSslPolicy20170401S. </summary>
        public static ApplicationGatewaySslPolicyName AppGwSslPolicy20170401S { get; } = new ApplicationGatewaySslPolicyName(AppGwSslPolicy20170401SValue);
        /// <summary> Determines if two <see cref="ApplicationGatewaySslPolicyName"/> values are the same. </summary>
        public static bool operator ==(ApplicationGatewaySslPolicyName left, ApplicationGatewaySslPolicyName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGatewaySslPolicyName"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGatewaySslPolicyName left, ApplicationGatewaySslPolicyName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationGatewaySslPolicyName"/>. </summary>
        public static implicit operator ApplicationGatewaySslPolicyName(string value) => new ApplicationGatewaySslPolicyName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGatewaySslPolicyName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGatewaySslPolicyName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
