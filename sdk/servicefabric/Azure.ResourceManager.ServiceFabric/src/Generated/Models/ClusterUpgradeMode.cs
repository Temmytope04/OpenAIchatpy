// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The upgrade mode of the cluster when new Service Fabric runtime version is available. </summary>
    public readonly partial struct ClusterUpgradeMode : IEquatable<ClusterUpgradeMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClusterUpgradeMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClusterUpgradeMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutomaticValue = "Automatic";
        private const string ManualValue = "Manual";

        /// <summary> The cluster will be automatically upgraded to the latest Service Fabric runtime version, **upgradeWave** will determine when the upgrade starts after the new version becomes available. </summary>
        public static ClusterUpgradeMode Automatic { get; } = new ClusterUpgradeMode(AutomaticValue);
        /// <summary> The cluster will not be automatically upgraded to the latest Service Fabric runtime version. The cluster is upgraded by setting the **clusterCodeVersion** property in the cluster resource. </summary>
        public static ClusterUpgradeMode Manual { get; } = new ClusterUpgradeMode(ManualValue);
        /// <summary> Determines if two <see cref="ClusterUpgradeMode"/> values are the same. </summary>
        public static bool operator ==(ClusterUpgradeMode left, ClusterUpgradeMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClusterUpgradeMode"/> values are not the same. </summary>
        public static bool operator !=(ClusterUpgradeMode left, ClusterUpgradeMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ClusterUpgradeMode"/>. </summary>
        public static implicit operator ClusterUpgradeMode(string value) => new ClusterUpgradeMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClusterUpgradeMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClusterUpgradeMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
