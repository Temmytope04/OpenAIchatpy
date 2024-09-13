// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The package kind. </summary>
    public readonly partial struct SecurityInsightsMetadataPackageKind : IEquatable<SecurityInsightsMetadataPackageKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsMetadataPackageKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityInsightsMetadataPackageKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SolutionValue = "Solution";
        private const string StandaloneValue = "Standalone";

        /// <summary> Solution. </summary>
        public static SecurityInsightsMetadataPackageKind Solution { get; } = new SecurityInsightsMetadataPackageKind(SolutionValue);
        /// <summary> Standalone. </summary>
        public static SecurityInsightsMetadataPackageKind Standalone { get; } = new SecurityInsightsMetadataPackageKind(StandaloneValue);
        /// <summary> Determines if two <see cref="SecurityInsightsMetadataPackageKind"/> values are the same. </summary>
        public static bool operator ==(SecurityInsightsMetadataPackageKind left, SecurityInsightsMetadataPackageKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityInsightsMetadataPackageKind"/> values are not the same. </summary>
        public static bool operator !=(SecurityInsightsMetadataPackageKind left, SecurityInsightsMetadataPackageKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityInsightsMetadataPackageKind"/>. </summary>
        public static implicit operator SecurityInsightsMetadataPackageKind(string value) => new SecurityInsightsMetadataPackageKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityInsightsMetadataPackageKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityInsightsMetadataPackageKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
