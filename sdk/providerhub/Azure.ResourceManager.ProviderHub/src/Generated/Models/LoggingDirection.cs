// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The LoggingDirection. </summary>
    public readonly partial struct LoggingDirection : IEquatable<LoggingDirection>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LoggingDirection"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LoggingDirection(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string RequestValue = "Request";
        private const string ResponseValue = "Response";

        /// <summary> None. </summary>
        public static LoggingDirection None { get; } = new LoggingDirection(NoneValue);
        /// <summary> Request. </summary>
        public static LoggingDirection Request { get; } = new LoggingDirection(RequestValue);
        /// <summary> Response. </summary>
        public static LoggingDirection Response { get; } = new LoggingDirection(ResponseValue);
        /// <summary> Determines if two <see cref="LoggingDirection"/> values are the same. </summary>
        public static bool operator ==(LoggingDirection left, LoggingDirection right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LoggingDirection"/> values are not the same. </summary>
        public static bool operator !=(LoggingDirection left, LoggingDirection right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="LoggingDirection"/>. </summary>
        public static implicit operator LoggingDirection(string value) => new LoggingDirection(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LoggingDirection other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LoggingDirection other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
