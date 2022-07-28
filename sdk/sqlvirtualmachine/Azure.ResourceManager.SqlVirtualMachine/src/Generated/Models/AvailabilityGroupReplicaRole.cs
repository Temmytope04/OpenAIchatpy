// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Replica Role in availability group. </summary>
    public readonly partial struct AvailabilityGroupReplicaRole : IEquatable<AvailabilityGroupReplicaRole>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AvailabilityGroupReplicaRole"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AvailabilityGroupReplicaRole(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrimaryValue = "PRIMARY";
        private const string SecondaryValue = "SECONDARY";

        /// <summary> PRIMARY. </summary>
        public static AvailabilityGroupReplicaRole Primary { get; } = new AvailabilityGroupReplicaRole(PrimaryValue);
        /// <summary> SECONDARY. </summary>
        public static AvailabilityGroupReplicaRole Secondary { get; } = new AvailabilityGroupReplicaRole(SecondaryValue);
        /// <summary> Determines if two <see cref="AvailabilityGroupReplicaRole"/> values are the same. </summary>
        public static bool operator ==(AvailabilityGroupReplicaRole left, AvailabilityGroupReplicaRole right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AvailabilityGroupReplicaRole"/> values are not the same. </summary>
        public static bool operator !=(AvailabilityGroupReplicaRole left, AvailabilityGroupReplicaRole right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AvailabilityGroupReplicaRole"/>. </summary>
        public static implicit operator AvailabilityGroupReplicaRole(string value) => new AvailabilityGroupReplicaRole(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AvailabilityGroupReplicaRole other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AvailabilityGroupReplicaRole other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
