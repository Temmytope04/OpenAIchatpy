// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Compute.Models
{
    /// <summary> The action to be performed. </summary>
    public readonly partial struct OrchestrationServiceStateAction : IEquatable<OrchestrationServiceStateAction>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="OrchestrationServiceStateAction"/> values are the same. </summary>
        public OrchestrationServiceStateAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ResumeValue = "Resume";
        private const string SuspendValue = "Suspend";

        /// <summary> Resume. </summary>
        public static OrchestrationServiceStateAction Resume { get; } = new OrchestrationServiceStateAction(ResumeValue);
        /// <summary> Suspend. </summary>
        public static OrchestrationServiceStateAction Suspend { get; } = new OrchestrationServiceStateAction(SuspendValue);
        /// <summary> Determines if two <see cref="OrchestrationServiceStateAction"/> values are the same. </summary>
        public static bool operator ==(OrchestrationServiceStateAction left, OrchestrationServiceStateAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OrchestrationServiceStateAction"/> values are not the same. </summary>
        public static bool operator !=(OrchestrationServiceStateAction left, OrchestrationServiceStateAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OrchestrationServiceStateAction"/>. </summary>
        public static implicit operator OrchestrationServiceStateAction(string value) => new OrchestrationServiceStateAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OrchestrationServiceStateAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OrchestrationServiceStateAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
