// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The OptInHeaderType. </summary>
    public readonly partial struct OptInHeaderType : IEquatable<OptInHeaderType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OptInHeaderType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OptInHeaderType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string SignedUserTokenValue = "SignedUserToken";
        private const string ClientGroupMembershipValue = "ClientGroupMembership";
        private const string SignedAuxiliaryTokensValue = "SignedAuxiliaryTokens";
        private const string UnboundedClientGroupMembershipValue = "UnboundedClientGroupMembership";

        /// <summary> NotSpecified. </summary>
        public static OptInHeaderType NotSpecified { get; } = new OptInHeaderType(NotSpecifiedValue);
        /// <summary> SignedUserToken. </summary>
        public static OptInHeaderType SignedUserToken { get; } = new OptInHeaderType(SignedUserTokenValue);
        /// <summary> ClientGroupMembership. </summary>
        public static OptInHeaderType ClientGroupMembership { get; } = new OptInHeaderType(ClientGroupMembershipValue);
        /// <summary> SignedAuxiliaryTokens. </summary>
        public static OptInHeaderType SignedAuxiliaryTokens { get; } = new OptInHeaderType(SignedAuxiliaryTokensValue);
        /// <summary> UnboundedClientGroupMembership. </summary>
        public static OptInHeaderType UnboundedClientGroupMembership { get; } = new OptInHeaderType(UnboundedClientGroupMembershipValue);
        /// <summary> Determines if two <see cref="OptInHeaderType"/> values are the same. </summary>
        public static bool operator ==(OptInHeaderType left, OptInHeaderType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OptInHeaderType"/> values are not the same. </summary>
        public static bool operator !=(OptInHeaderType left, OptInHeaderType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OptInHeaderType"/>. </summary>
        public static implicit operator OptInHeaderType(string value) => new OptInHeaderType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OptInHeaderType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OptInHeaderType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
