// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> The variable type to be excluded. </summary>
    public readonly partial struct ManagedRuleExclusionMatchVariable : IEquatable<ManagedRuleExclusionMatchVariable>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedRuleExclusionMatchVariable"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedRuleExclusionMatchVariable(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RequestHeaderNamesValue = "RequestHeaderNames";
        private const string RequestCookieNamesValue = "RequestCookieNames";
        private const string QueryStringArgNamesValue = "QueryStringArgNames";
        private const string RequestBodyPostArgNamesValue = "RequestBodyPostArgNames";
        private const string RequestBodyJsonArgNamesValue = "RequestBodyJsonArgNames";

        /// <summary> RequestHeaderNames. </summary>
        public static ManagedRuleExclusionMatchVariable RequestHeaderNames { get; } = new ManagedRuleExclusionMatchVariable(RequestHeaderNamesValue);
        /// <summary> RequestCookieNames. </summary>
        public static ManagedRuleExclusionMatchVariable RequestCookieNames { get; } = new ManagedRuleExclusionMatchVariable(RequestCookieNamesValue);
        /// <summary> QueryStringArgNames. </summary>
        public static ManagedRuleExclusionMatchVariable QueryStringArgNames { get; } = new ManagedRuleExclusionMatchVariable(QueryStringArgNamesValue);
        /// <summary> RequestBodyPostArgNames. </summary>
        public static ManagedRuleExclusionMatchVariable RequestBodyPostArgNames { get; } = new ManagedRuleExclusionMatchVariable(RequestBodyPostArgNamesValue);
        /// <summary> RequestBodyJsonArgNames. </summary>
        public static ManagedRuleExclusionMatchVariable RequestBodyJsonArgNames { get; } = new ManagedRuleExclusionMatchVariable(RequestBodyJsonArgNamesValue);
        /// <summary> Determines if two <see cref="ManagedRuleExclusionMatchVariable"/> values are the same. </summary>
        public static bool operator ==(ManagedRuleExclusionMatchVariable left, ManagedRuleExclusionMatchVariable right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedRuleExclusionMatchVariable"/> values are not the same. </summary>
        public static bool operator !=(ManagedRuleExclusionMatchVariable left, ManagedRuleExclusionMatchVariable right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ManagedRuleExclusionMatchVariable"/>. </summary>
        public static implicit operator ManagedRuleExclusionMatchVariable(string value) => new ManagedRuleExclusionMatchVariable(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedRuleExclusionMatchVariable other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedRuleExclusionMatchVariable other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
