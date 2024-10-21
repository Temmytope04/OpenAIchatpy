// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Indicates when new cluster runtime version upgrades will be applied after they are released. By default is Wave0. </summary>
    public readonly partial struct ManagedClusterUpgradeCadence : IEquatable<ManagedClusterUpgradeCadence>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterUpgradeCadence"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedClusterUpgradeCadence(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Wave0Value = "Wave0";
        private const string Wave1Value = "Wave1";
        private const string Wave2Value = "Wave2";

        /// <summary> Cluster upgrade starts immediately after a new version is rolled out. Recommended for Test/Dev clusters. </summary>
        public static ManagedClusterUpgradeCadence Wave0 { get; } = new ManagedClusterUpgradeCadence(Wave0Value);
        /// <summary> Cluster upgrade starts 7 days after a new version is rolled out. Recommended for Pre-prod clusters. </summary>
        public static ManagedClusterUpgradeCadence Wave1 { get; } = new ManagedClusterUpgradeCadence(Wave1Value);
        /// <summary> Cluster upgrade starts 14 days after a new version is rolled out. Recommended for Production clusters. </summary>
        public static ManagedClusterUpgradeCadence Wave2 { get; } = new ManagedClusterUpgradeCadence(Wave2Value);
        /// <summary> Determines if two <see cref="ManagedClusterUpgradeCadence"/> values are the same. </summary>
        public static bool operator ==(ManagedClusterUpgradeCadence left, ManagedClusterUpgradeCadence right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedClusterUpgradeCadence"/> values are not the same. </summary>
        public static bool operator !=(ManagedClusterUpgradeCadence left, ManagedClusterUpgradeCadence right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ManagedClusterUpgradeCadence"/>. </summary>
        public static implicit operator ManagedClusterUpgradeCadence(string value) => new ManagedClusterUpgradeCadence(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedClusterUpgradeCadence other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedClusterUpgradeCadence other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
