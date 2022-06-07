// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Indicates whether AAD logs are being sent. </summary>
    public readonly partial struct SendAadLogsStatus : IEquatable<SendAadLogsStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SendAadLogsStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SendAadLogsStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static SendAadLogsStatus Enabled { get; } = new SendAadLogsStatus(EnabledValue);
        /// <summary> Disabled. </summary>
        public static SendAadLogsStatus Disabled { get; } = new SendAadLogsStatus(DisabledValue);
        /// <summary> Determines if two <see cref="SendAadLogsStatus"/> values are the same. </summary>
        public static bool operator ==(SendAadLogsStatus left, SendAadLogsStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SendAadLogsStatus"/> values are not the same. </summary>
        public static bool operator !=(SendAadLogsStatus left, SendAadLogsStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SendAadLogsStatus"/>. </summary>
        public static implicit operator SendAadLogsStatus(string value) => new SendAadLogsStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SendAadLogsStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SendAadLogsStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
