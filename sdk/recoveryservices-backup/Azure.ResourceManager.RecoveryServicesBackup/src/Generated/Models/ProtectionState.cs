// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Backup state of this backup item. </summary>
    public readonly partial struct ProtectionState : IEquatable<ProtectionState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProtectionState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProtectionState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string IRPendingValue = "IRPending";
        private const string ProtectedValue = "Protected";
        private const string ProtectionErrorValue = "ProtectionError";
        private const string ProtectionStoppedValue = "ProtectionStopped";
        private const string ProtectionPausedValue = "ProtectionPaused";

        /// <summary> Invalid. </summary>
        public static ProtectionState Invalid { get; } = new ProtectionState(InvalidValue);
        /// <summary> IRPending. </summary>
        public static ProtectionState IRPending { get; } = new ProtectionState(IRPendingValue);
        /// <summary> Protected. </summary>
        public static ProtectionState Protected { get; } = new ProtectionState(ProtectedValue);
        /// <summary> ProtectionError. </summary>
        public static ProtectionState ProtectionError { get; } = new ProtectionState(ProtectionErrorValue);
        /// <summary> ProtectionStopped. </summary>
        public static ProtectionState ProtectionStopped { get; } = new ProtectionState(ProtectionStoppedValue);
        /// <summary> ProtectionPaused. </summary>
        public static ProtectionState ProtectionPaused { get; } = new ProtectionState(ProtectionPausedValue);
        /// <summary> Determines if two <see cref="ProtectionState"/> values are the same. </summary>
        public static bool operator ==(ProtectionState left, ProtectionState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProtectionState"/> values are not the same. </summary>
        public static bool operator !=(ProtectionState left, ProtectionState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProtectionState"/>. </summary>
        public static implicit operator ProtectionState(string value) => new ProtectionState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProtectionState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProtectionState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
