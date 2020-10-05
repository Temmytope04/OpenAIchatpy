// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The name of the service. </summary>
    public readonly partial struct OrchestrationServiceNames : IEquatable<OrchestrationServiceNames>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="OrchestrationServiceNames"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OrchestrationServiceNames(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutomaticRepairsValue = "AutomaticRepairs";

        /// <summary> AutomaticRepairs. </summary>
        public static OrchestrationServiceNames AutomaticRepairs { get; } = new OrchestrationServiceNames(AutomaticRepairsValue);
        /// <summary> Determines if two <see cref="OrchestrationServiceNames"/> values are the same. </summary>
        public static bool operator ==(OrchestrationServiceNames left, OrchestrationServiceNames right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OrchestrationServiceNames"/> values are not the same. </summary>
        public static bool operator !=(OrchestrationServiceNames left, OrchestrationServiceNames right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OrchestrationServiceNames"/>. </summary>
        public static implicit operator OrchestrationServiceNames(string value) => new OrchestrationServiceNames(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OrchestrationServiceNames other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OrchestrationServiceNames other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
