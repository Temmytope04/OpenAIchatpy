// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Unit of time that delay is expressed in. </summary>
    public readonly partial struct PauseDelayTimeUnit : IEquatable<PauseDelayTimeUnit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PauseDelayTimeUnit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PauseDelayTimeUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MinutesValue = "Minutes";

        /// <summary> Minutes. </summary>
        public static PauseDelayTimeUnit Minutes { get; } = new PauseDelayTimeUnit(MinutesValue);
        /// <summary> Determines if two <see cref="PauseDelayTimeUnit"/> values are the same. </summary>
        public static bool operator ==(PauseDelayTimeUnit left, PauseDelayTimeUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PauseDelayTimeUnit"/> values are not the same. </summary>
        public static bool operator !=(PauseDelayTimeUnit left, PauseDelayTimeUnit right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PauseDelayTimeUnit"/>. </summary>
        public static implicit operator PauseDelayTimeUnit(string value) => new PauseDelayTimeUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PauseDelayTimeUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PauseDelayTimeUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
