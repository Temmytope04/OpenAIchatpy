// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary>
    /// Update mode for the cloud service. Role instances are allocated to update domains when the service is deployed. Updates can be initiated manually in each update domain or initiated automatically in all update domains.
    /// Possible Values are &lt;br /&gt;&lt;br /&gt;**Auto**&lt;br /&gt;&lt;br /&gt;**Manual** &lt;br /&gt;&lt;br /&gt;**Simultaneous**&lt;br /&gt;&lt;br /&gt;
    /// If not specified, the default value is Auto. If set to Manual, PUT UpdateDomain must be called to apply the update. If set to Auto, the update is automatically applied to each update domain in sequence.
    /// </summary>
    public readonly partial struct CloudServiceUpgradeMode : IEquatable<CloudServiceUpgradeMode>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CloudServiceUpgradeMode"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CloudServiceUpgradeMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "Auto";
        private const string ManualValue = "Manual";
        private const string SimultaneousValue = "Simultaneous";

        /// <summary> Auto. </summary>
        public static CloudServiceUpgradeMode Auto { get; } = new CloudServiceUpgradeMode(AutoValue);
        /// <summary> Manual. </summary>
        public static CloudServiceUpgradeMode Manual { get; } = new CloudServiceUpgradeMode(ManualValue);
        /// <summary> Simultaneous. </summary>
        public static CloudServiceUpgradeMode Simultaneous { get; } = new CloudServiceUpgradeMode(SimultaneousValue);
        /// <summary> Determines if two <see cref="CloudServiceUpgradeMode"/> values are the same. </summary>
        public static bool operator ==(CloudServiceUpgradeMode left, CloudServiceUpgradeMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CloudServiceUpgradeMode"/> values are not the same. </summary>
        public static bool operator !=(CloudServiceUpgradeMode left, CloudServiceUpgradeMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CloudServiceUpgradeMode"/>. </summary>
        public static implicit operator CloudServiceUpgradeMode(string value) => new CloudServiceUpgradeMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CloudServiceUpgradeMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CloudServiceUpgradeMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
