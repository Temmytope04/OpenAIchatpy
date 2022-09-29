// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Compliance state of the cluster object. </summary>
    public readonly partial struct FluxComplianceState : IEquatable<FluxComplianceState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FluxComplianceState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FluxComplianceState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CompliantValue = "Compliant";
        private const string NonCompliantValue = "Non-Compliant";
        private const string PendingValue = "Pending";
        private const string SuspendedValue = "Suspended";
        private const string UnknownValue = "Unknown";

        /// <summary> Compliant. </summary>
        public static FluxComplianceState Compliant { get; } = new FluxComplianceState(CompliantValue);
        /// <summary> Non-Compliant. </summary>
        public static FluxComplianceState NonCompliant { get; } = new FluxComplianceState(NonCompliantValue);
        /// <summary> Pending. </summary>
        public static FluxComplianceState Pending { get; } = new FluxComplianceState(PendingValue);
        /// <summary> Suspended. </summary>
        public static FluxComplianceState Suspended { get; } = new FluxComplianceState(SuspendedValue);
        /// <summary> Unknown. </summary>
        public static FluxComplianceState Unknown { get; } = new FluxComplianceState(UnknownValue);
        /// <summary> Determines if two <see cref="FluxComplianceState"/> values are the same. </summary>
        public static bool operator ==(FluxComplianceState left, FluxComplianceState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FluxComplianceState"/> values are not the same. </summary>
        public static bool operator !=(FluxComplianceState left, FluxComplianceState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FluxComplianceState"/>. </summary>
        public static implicit operator FluxComplianceState(string value) => new FluxComplianceState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FluxComplianceState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FluxComplianceState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
