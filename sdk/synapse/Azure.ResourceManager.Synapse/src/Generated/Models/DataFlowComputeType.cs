// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Compute type of the cluster which will execute data flow job. </summary>
    public readonly partial struct DataFlowComputeType : IEquatable<DataFlowComputeType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataFlowComputeType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataFlowComputeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GeneralValue = "General";
        private const string MemoryOptimizedValue = "MemoryOptimized";
        private const string ComputeOptimizedValue = "ComputeOptimized";

        /// <summary> General. </summary>
        public static DataFlowComputeType General { get; } = new DataFlowComputeType(GeneralValue);
        /// <summary> MemoryOptimized. </summary>
        public static DataFlowComputeType MemoryOptimized { get; } = new DataFlowComputeType(MemoryOptimizedValue);
        /// <summary> ComputeOptimized. </summary>
        public static DataFlowComputeType ComputeOptimized { get; } = new DataFlowComputeType(ComputeOptimizedValue);
        /// <summary> Determines if two <see cref="DataFlowComputeType"/> values are the same. </summary>
        public static bool operator ==(DataFlowComputeType left, DataFlowComputeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataFlowComputeType"/> values are not the same. </summary>
        public static bool operator !=(DataFlowComputeType left, DataFlowComputeType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataFlowComputeType"/>. </summary>
        public static implicit operator DataFlowComputeType(string value) => new DataFlowComputeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataFlowComputeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataFlowComputeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
