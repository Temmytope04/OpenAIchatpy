// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations. Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start rolling back automatically. Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode. </summary>
    public readonly partial struct FailureAction : IEquatable<FailureAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FailureAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FailureAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RollbackValue = "Rollback";
        private const string ManualValue = "Manual";

        /// <summary> Indicates that a rollback of the upgrade will be performed by Service Fabric if the upgrade fails. </summary>
        public static FailureAction Rollback { get; } = new FailureAction(RollbackValue);
        /// <summary> Indicates that a manual repair will need to be performed by the administrator if the upgrade fails. Service Fabric will not proceed to the next upgrade domain automatically. </summary>
        public static FailureAction Manual { get; } = new FailureAction(ManualValue);
        /// <summary> Determines if two <see cref="FailureAction"/> values are the same. </summary>
        public static bool operator ==(FailureAction left, FailureAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FailureAction"/> values are not the same. </summary>
        public static bool operator !=(FailureAction left, FailureAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FailureAction"/>. </summary>
        public static implicit operator FailureAction(string value) => new FailureAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FailureAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FailureAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
