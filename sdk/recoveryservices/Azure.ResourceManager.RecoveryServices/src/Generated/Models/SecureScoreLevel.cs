// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Secure Score of Recovery Services Vault. </summary>
    public readonly partial struct SecureScoreLevel : IEquatable<SecureScoreLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecureScoreLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecureScoreLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string MinimumValue = "Minimum";
        private const string AdequateValue = "Adequate";
        private const string MaximumValue = "Maximum";

        /// <summary> None. </summary>
        public static SecureScoreLevel None { get; } = new SecureScoreLevel(NoneValue);
        /// <summary> Minimum. </summary>
        public static SecureScoreLevel Minimum { get; } = new SecureScoreLevel(MinimumValue);
        /// <summary> Adequate. </summary>
        public static SecureScoreLevel Adequate { get; } = new SecureScoreLevel(AdequateValue);
        /// <summary> Maximum. </summary>
        public static SecureScoreLevel Maximum { get; } = new SecureScoreLevel(MaximumValue);
        /// <summary> Determines if two <see cref="SecureScoreLevel"/> values are the same. </summary>
        public static bool operator ==(SecureScoreLevel left, SecureScoreLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecureScoreLevel"/> values are not the same. </summary>
        public static bool operator !=(SecureScoreLevel left, SecureScoreLevel right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SecureScoreLevel"/>. </summary>
        public static implicit operator SecureScoreLevel(string value) => new SecureScoreLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecureScoreLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecureScoreLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
