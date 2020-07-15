// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The ReplicationStatusTypes. </summary>
    public readonly partial struct ReplicationStatusTypes : IEquatable<ReplicationStatusTypes>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ReplicationStatusTypes"/> values are the same. </summary>
        public ReplicationStatusTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReplicationStatusValue = "ReplicationStatus";

        /// <summary> ReplicationStatus. </summary>
        public static ReplicationStatusTypes ReplicationStatus { get; } = new ReplicationStatusTypes(ReplicationStatusValue);
        /// <summary> Determines if two <see cref="ReplicationStatusTypes"/> values are the same. </summary>
        public static bool operator ==(ReplicationStatusTypes left, ReplicationStatusTypes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReplicationStatusTypes"/> values are not the same. </summary>
        public static bool operator !=(ReplicationStatusTypes left, ReplicationStatusTypes right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReplicationStatusTypes"/>. </summary>
        public static implicit operator ReplicationStatusTypes(string value) => new ReplicationStatusTypes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReplicationStatusTypes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReplicationStatusTypes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
