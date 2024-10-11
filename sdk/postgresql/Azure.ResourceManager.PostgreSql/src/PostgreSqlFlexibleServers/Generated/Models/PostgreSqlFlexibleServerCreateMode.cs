// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> The mode to create a new PostgreSQL server. </summary>
    public readonly partial struct PostgreSqlFlexibleServerCreateMode : IEquatable<PostgreSqlFlexibleServerCreateMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerCreateMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlFlexibleServerCreateMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string CreateValue = "Create";
        private const string UpdateValue = "Update";
        private const string PointInTimeRestoreValue = "PointInTimeRestore";
        private const string GeoRestoreValue = "GeoRestore";
        private const string ReplicaValue = "Replica";
        private const string ReviveDroppedValue = "ReviveDropped";

        /// <summary> Default. </summary>
        public static PostgreSqlFlexibleServerCreateMode Default { get; } = new PostgreSqlFlexibleServerCreateMode(DefaultValue);
        /// <summary> Create. </summary>
        public static PostgreSqlFlexibleServerCreateMode Create { get; } = new PostgreSqlFlexibleServerCreateMode(CreateValue);
        /// <summary> Update. </summary>
        public static PostgreSqlFlexibleServerCreateMode Update { get; } = new PostgreSqlFlexibleServerCreateMode(UpdateValue);
        /// <summary> PointInTimeRestore. </summary>
        public static PostgreSqlFlexibleServerCreateMode PointInTimeRestore { get; } = new PostgreSqlFlexibleServerCreateMode(PointInTimeRestoreValue);
        /// <summary> GeoRestore. </summary>
        public static PostgreSqlFlexibleServerCreateMode GeoRestore { get; } = new PostgreSqlFlexibleServerCreateMode(GeoRestoreValue);
        /// <summary> Replica. </summary>
        public static PostgreSqlFlexibleServerCreateMode Replica { get; } = new PostgreSqlFlexibleServerCreateMode(ReplicaValue);
        /// <summary> ReviveDropped. </summary>
        public static PostgreSqlFlexibleServerCreateMode ReviveDropped { get; } = new PostgreSqlFlexibleServerCreateMode(ReviveDroppedValue);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerCreateMode"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlFlexibleServerCreateMode left, PostgreSqlFlexibleServerCreateMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerCreateMode"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlFlexibleServerCreateMode left, PostgreSqlFlexibleServerCreateMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PostgreSqlFlexibleServerCreateMode"/>. </summary>
        public static implicit operator PostgreSqlFlexibleServerCreateMode(string value) => new PostgreSqlFlexibleServerCreateMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlFlexibleServerCreateMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlFlexibleServerCreateMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
