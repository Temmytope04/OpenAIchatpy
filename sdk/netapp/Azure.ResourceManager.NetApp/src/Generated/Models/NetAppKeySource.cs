// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.NetApp, Microsoft.KeyVault. </summary>
    public readonly partial struct NetAppKeySource : IEquatable<NetAppKeySource>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetAppKeySource"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetAppKeySource(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftNetAppValue = "Microsoft.NetApp";
        private const string MicrosoftKeyVaultValue = "Microsoft.KeyVault";

        /// <summary> Microsoft-managed key encryption. </summary>
        public static NetAppKeySource MicrosoftNetApp { get; } = new NetAppKeySource(MicrosoftNetAppValue);
        /// <summary> Customer-managed key encryption. </summary>
        public static NetAppKeySource MicrosoftKeyVault { get; } = new NetAppKeySource(MicrosoftKeyVaultValue);
        /// <summary> Determines if two <see cref="NetAppKeySource"/> values are the same. </summary>
        public static bool operator ==(NetAppKeySource left, NetAppKeySource right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetAppKeySource"/> values are not the same. </summary>
        public static bool operator !=(NetAppKeySource left, NetAppKeySource right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetAppKeySource"/>. </summary>
        public static implicit operator NetAppKeySource(string value) => new NetAppKeySource(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetAppKeySource other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetAppKeySource other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
