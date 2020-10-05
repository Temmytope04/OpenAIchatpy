// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The units that the limit is expressed in. </summary>
    public readonly partial struct LogSizeUnit : IEquatable<LogSizeUnit>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="LogSizeUnit"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogSizeUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MegabytesValue = "Megabytes";
        private const string GigabytesValue = "Gigabytes";
        private const string TerabytesValue = "Terabytes";
        private const string PetabytesValue = "Petabytes";
        private const string PercentValue = "Percent";

        /// <summary> Megabytes. </summary>
        public static LogSizeUnit Megabytes { get; } = new LogSizeUnit(MegabytesValue);
        /// <summary> Gigabytes. </summary>
        public static LogSizeUnit Gigabytes { get; } = new LogSizeUnit(GigabytesValue);
        /// <summary> Terabytes. </summary>
        public static LogSizeUnit Terabytes { get; } = new LogSizeUnit(TerabytesValue);
        /// <summary> Petabytes. </summary>
        public static LogSizeUnit Petabytes { get; } = new LogSizeUnit(PetabytesValue);
        /// <summary> Percent. </summary>
        public static LogSizeUnit Percent { get; } = new LogSizeUnit(PercentValue);
        /// <summary> Determines if two <see cref="LogSizeUnit"/> values are the same. </summary>
        public static bool operator ==(LogSizeUnit left, LogSizeUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogSizeUnit"/> values are not the same. </summary>
        public static bool operator !=(LogSizeUnit left, LogSizeUnit right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LogSizeUnit"/>. </summary>
        public static implicit operator LogSizeUnit(string value) => new LogSizeUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogSizeUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogSizeUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
