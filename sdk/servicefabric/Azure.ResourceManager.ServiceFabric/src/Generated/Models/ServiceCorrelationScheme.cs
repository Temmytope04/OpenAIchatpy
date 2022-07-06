// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The service correlation scheme. </summary>
    public readonly partial struct ServiceCorrelationScheme : IEquatable<ServiceCorrelationScheme>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceCorrelationScheme"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceCorrelationScheme(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string AffinityValue = "Affinity";
        private const string AlignedAffinityValue = "AlignedAffinity";
        private const string NonAlignedAffinityValue = "NonAlignedAffinity";

        /// <summary> An invalid correlation scheme. Cannot be used. The value is zero. </summary>
        public static ServiceCorrelationScheme Invalid { get; } = new ServiceCorrelationScheme(InvalidValue);
        /// <summary> Indicates that this service has an affinity relationship with another service. Provided for backwards compatibility, consider preferring the Aligned or NonAlignedAffinity options. The value is 1. </summary>
        public static ServiceCorrelationScheme Affinity { get; } = new ServiceCorrelationScheme(AffinityValue);
        /// <summary> Aligned affinity ensures that the primaries of the partitions of the affinitized services are collocated on the same nodes. This is the default and is the same as selecting the Affinity scheme. The value is 2. </summary>
        public static ServiceCorrelationScheme AlignedAffinity { get; } = new ServiceCorrelationScheme(AlignedAffinityValue);
        /// <summary> Non-Aligned affinity guarantees that all replicas of each service will be placed on the same nodes. Unlike Aligned Affinity, this does not guarantee that replicas of particular role will be collocated. The value is 3. </summary>
        public static ServiceCorrelationScheme NonAlignedAffinity { get; } = new ServiceCorrelationScheme(NonAlignedAffinityValue);
        /// <summary> Determines if two <see cref="ServiceCorrelationScheme"/> values are the same. </summary>
        public static bool operator ==(ServiceCorrelationScheme left, ServiceCorrelationScheme right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceCorrelationScheme"/> values are not the same. </summary>
        public static bool operator !=(ServiceCorrelationScheme left, ServiceCorrelationScheme right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceCorrelationScheme"/>. </summary>
        public static implicit operator ServiceCorrelationScheme(string value) => new ServiceCorrelationScheme(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceCorrelationScheme other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceCorrelationScheme other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
