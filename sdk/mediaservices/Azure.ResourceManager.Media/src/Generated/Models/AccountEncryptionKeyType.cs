// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The type of key used to encrypt the Account Key. </summary>
    public readonly partial struct AccountEncryptionKeyType : IEquatable<AccountEncryptionKeyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AccountEncryptionKeyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AccountEncryptionKeyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SystemKeyValue = "SystemKey";
        private const string CustomerKeyValue = "CustomerKey";

        /// <summary> The Account Key is encrypted with a System Key. </summary>
        public static AccountEncryptionKeyType SystemKey { get; } = new AccountEncryptionKeyType(SystemKeyValue);
        /// <summary> The Account Key is encrypted with a Customer Key. </summary>
        public static AccountEncryptionKeyType CustomerKey { get; } = new AccountEncryptionKeyType(CustomerKeyValue);
        /// <summary> Determines if two <see cref="AccountEncryptionKeyType"/> values are the same. </summary>
        public static bool operator ==(AccountEncryptionKeyType left, AccountEncryptionKeyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AccountEncryptionKeyType"/> values are not the same. </summary>
        public static bool operator !=(AccountEncryptionKeyType left, AccountEncryptionKeyType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AccountEncryptionKeyType"/>. </summary>
        public static implicit operator AccountEncryptionKeyType(string value) => new AccountEncryptionKeyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AccountEncryptionKeyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AccountEncryptionKeyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
