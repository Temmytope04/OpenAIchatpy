// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// The EntityItemQueryKind.
    /// Serialized Name: EntityItemQueryKind
    /// </summary>
    public readonly partial struct EntityItemQueryKind : IEquatable<EntityItemQueryKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EntityItemQueryKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EntityItemQueryKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InsightValue = "Insight";

        /// <summary>
        /// insight
        /// Serialized Name: EntityItemQueryKind.Insight
        /// </summary>
        public static EntityItemQueryKind Insight { get; } = new EntityItemQueryKind(InsightValue);
        /// <summary> Determines if two <see cref="EntityItemQueryKind"/> values are the same. </summary>
        public static bool operator ==(EntityItemQueryKind left, EntityItemQueryKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EntityItemQueryKind"/> values are not the same. </summary>
        public static bool operator !=(EntityItemQueryKind left, EntityItemQueryKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EntityItemQueryKind"/>. </summary>
        public static implicit operator EntityItemQueryKind(string value) => new EntityItemQueryKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EntityItemQueryKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EntityItemQueryKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
