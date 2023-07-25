// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The replication state for the replication link. </summary>
    public readonly partial struct SynapseReplicationState : IEquatable<SynapseReplicationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynapseReplicationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapseReplicationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "PENDING";
        private const string SeedingValue = "SEEDING";
        private const string CatchUpValue = "CATCH_UP";
        private const string SuspendedValue = "SUSPENDED";

        /// <summary> PENDING. </summary>
        public static SynapseReplicationState Pending { get; } = new SynapseReplicationState(PendingValue);
        /// <summary> SEEDING. </summary>
        public static SynapseReplicationState Seeding { get; } = new SynapseReplicationState(SeedingValue);
        /// <summary> CATCH_UP. </summary>
        public static SynapseReplicationState CatchUp { get; } = new SynapseReplicationState(CatchUpValue);
        /// <summary> SUSPENDED. </summary>
        public static SynapseReplicationState Suspended { get; } = new SynapseReplicationState(SuspendedValue);
        /// <summary> Determines if two <see cref="SynapseReplicationState"/> values are the same. </summary>
        public static bool operator ==(SynapseReplicationState left, SynapseReplicationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynapseReplicationState"/> values are not the same. </summary>
        public static bool operator !=(SynapseReplicationState left, SynapseReplicationState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SynapseReplicationState"/>. </summary>
        public static implicit operator SynapseReplicationState(string value) => new SynapseReplicationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynapseReplicationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynapseReplicationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
