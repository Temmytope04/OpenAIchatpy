// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Vault x-cool state. </summary>
    public readonly partial struct XcoolState : IEquatable<XcoolState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="XcoolState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public XcoolState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Invalid. </summary>
        public static XcoolState Invalid { get; } = new XcoolState(InvalidValue);
        /// <summary> Enabled. </summary>
        public static XcoolState Enabled { get; } = new XcoolState(EnabledValue);
        /// <summary> Disabled. </summary>
        public static XcoolState Disabled { get; } = new XcoolState(DisabledValue);
        /// <summary> Determines if two <see cref="XcoolState"/> values are the same. </summary>
        public static bool operator ==(XcoolState left, XcoolState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="XcoolState"/> values are not the same. </summary>
        public static bool operator !=(XcoolState left, XcoolState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="XcoolState"/>. </summary>
        public static implicit operator XcoolState(string value) => new XcoolState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is XcoolState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(XcoolState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
