// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Vault Dedup state. </summary>
    public readonly partial struct DedupState : IEquatable<DedupState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DedupState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DedupState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Invalid. </summary>
        public static DedupState Invalid { get; } = new DedupState(InvalidValue);
        /// <summary> Enabled. </summary>
        public static DedupState Enabled { get; } = new DedupState(EnabledValue);
        /// <summary> Disabled. </summary>
        public static DedupState Disabled { get; } = new DedupState(DisabledValue);
        /// <summary> Determines if two <see cref="DedupState"/> values are the same. </summary>
        public static bool operator ==(DedupState left, DedupState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DedupState"/> values are not the same. </summary>
        public static bool operator !=(DedupState left, DedupState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DedupState"/>. </summary>
        public static implicit operator DedupState(string value) => new DedupState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DedupState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DedupState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
