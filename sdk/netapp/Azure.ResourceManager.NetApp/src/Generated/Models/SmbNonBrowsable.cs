// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Enables non browsable property for SMB Shares. Only applicable for SMB/DualProtocol volume. </summary>
    public readonly partial struct SmbNonBrowsable : IEquatable<SmbNonBrowsable>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SmbNonBrowsable"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SmbNonBrowsable(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> smbNonBrowsable share setting is disabled. </summary>
        public static SmbNonBrowsable Disabled { get; } = new SmbNonBrowsable(DisabledValue);
        /// <summary> smbNonBrowsable share setting is enabled. </summary>
        public static SmbNonBrowsable Enabled { get; } = new SmbNonBrowsable(EnabledValue);
        /// <summary> Determines if two <see cref="SmbNonBrowsable"/> values are the same. </summary>
        public static bool operator ==(SmbNonBrowsable left, SmbNonBrowsable right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SmbNonBrowsable"/> values are not the same. </summary>
        public static bool operator !=(SmbNonBrowsable left, SmbNonBrowsable right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SmbNonBrowsable"/>. </summary>
        public static implicit operator SmbNonBrowsable(string value) => new SmbNonBrowsable(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SmbNonBrowsable other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SmbNonBrowsable other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
