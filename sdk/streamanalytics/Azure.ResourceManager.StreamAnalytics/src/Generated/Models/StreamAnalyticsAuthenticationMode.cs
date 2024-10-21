// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Authentication Mode. Valid modes are `ConnectionString`, `Msi` and 'UserToken'. </summary>
    public readonly partial struct StreamAnalyticsAuthenticationMode : IEquatable<StreamAnalyticsAuthenticationMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsAuthenticationMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StreamAnalyticsAuthenticationMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MsiValue = "Msi";
        private const string UserTokenValue = "UserToken";
        private const string ConnectionStringValue = "ConnectionString";

        /// <summary> Msi. </summary>
        public static StreamAnalyticsAuthenticationMode Msi { get; } = new StreamAnalyticsAuthenticationMode(MsiValue);
        /// <summary> UserToken. </summary>
        public static StreamAnalyticsAuthenticationMode UserToken { get; } = new StreamAnalyticsAuthenticationMode(UserTokenValue);
        /// <summary> ConnectionString. </summary>
        public static StreamAnalyticsAuthenticationMode ConnectionString { get; } = new StreamAnalyticsAuthenticationMode(ConnectionStringValue);
        /// <summary> Determines if two <see cref="StreamAnalyticsAuthenticationMode"/> values are the same. </summary>
        public static bool operator ==(StreamAnalyticsAuthenticationMode left, StreamAnalyticsAuthenticationMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StreamAnalyticsAuthenticationMode"/> values are not the same. </summary>
        public static bool operator !=(StreamAnalyticsAuthenticationMode left, StreamAnalyticsAuthenticationMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="StreamAnalyticsAuthenticationMode"/>. </summary>
        public static implicit operator StreamAnalyticsAuthenticationMode(string value) => new StreamAnalyticsAuthenticationMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StreamAnalyticsAuthenticationMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StreamAnalyticsAuthenticationMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
