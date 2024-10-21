// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> The mode to update a new PostgreSQL server. </summary>
    public readonly partial struct PostgreSqlFlexibleServerCreateModeForUpdate : IEquatable<PostgreSqlFlexibleServerCreateModeForUpdate>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerCreateModeForUpdate"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlFlexibleServerCreateModeForUpdate(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string UpdateValue = "Update";

        /// <summary> Default. </summary>
        public static PostgreSqlFlexibleServerCreateModeForUpdate Default { get; } = new PostgreSqlFlexibleServerCreateModeForUpdate(DefaultValue);
        /// <summary> Update. </summary>
        public static PostgreSqlFlexibleServerCreateModeForUpdate Update { get; } = new PostgreSqlFlexibleServerCreateModeForUpdate(UpdateValue);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerCreateModeForUpdate"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlFlexibleServerCreateModeForUpdate left, PostgreSqlFlexibleServerCreateModeForUpdate right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerCreateModeForUpdate"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlFlexibleServerCreateModeForUpdate left, PostgreSqlFlexibleServerCreateModeForUpdate right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PostgreSqlFlexibleServerCreateModeForUpdate"/>. </summary>
        public static implicit operator PostgreSqlFlexibleServerCreateModeForUpdate(string value) => new PostgreSqlFlexibleServerCreateModeForUpdate(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlFlexibleServerCreateModeForUpdate other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlFlexibleServerCreateModeForUpdate other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
