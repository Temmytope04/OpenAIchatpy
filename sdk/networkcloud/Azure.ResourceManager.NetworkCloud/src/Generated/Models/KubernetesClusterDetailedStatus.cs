// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The current status of the Kubernetes cluster. </summary>
    public readonly partial struct KubernetesClusterDetailedStatus : IEquatable<KubernetesClusterDetailedStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KubernetesClusterDetailedStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KubernetesClusterDetailedStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvailableValue = "Available";
        private const string ErrorValue = "Error";
        private const string ProvisioningValue = "Provisioning";

        /// <summary> Available. </summary>
        public static KubernetesClusterDetailedStatus Available { get; } = new KubernetesClusterDetailedStatus(AvailableValue);
        /// <summary> Error. </summary>
        public static KubernetesClusterDetailedStatus Error { get; } = new KubernetesClusterDetailedStatus(ErrorValue);
        /// <summary> Provisioning. </summary>
        public static KubernetesClusterDetailedStatus Provisioning { get; } = new KubernetesClusterDetailedStatus(ProvisioningValue);
        /// <summary> Determines if two <see cref="KubernetesClusterDetailedStatus"/> values are the same. </summary>
        public static bool operator ==(KubernetesClusterDetailedStatus left, KubernetesClusterDetailedStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KubernetesClusterDetailedStatus"/> values are not the same. </summary>
        public static bool operator !=(KubernetesClusterDetailedStatus left, KubernetesClusterDetailedStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="KubernetesClusterDetailedStatus"/>. </summary>
        public static implicit operator KubernetesClusterDetailedStatus(string value) => new KubernetesClusterDetailedStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KubernetesClusterDetailedStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KubernetesClusterDetailedStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
