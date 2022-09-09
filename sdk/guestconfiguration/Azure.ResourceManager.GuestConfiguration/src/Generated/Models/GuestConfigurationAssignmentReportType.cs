// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> Type of report, Consistency or Initial. </summary>
    public readonly partial struct GuestConfigurationAssignmentReportType : IEquatable<GuestConfigurationAssignmentReportType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GuestConfigurationAssignmentReportType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GuestConfigurationAssignmentReportType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ConsistencyValue = "Consistency";
        private const string InitialValue = "Initial";

        /// <summary> Consistency. </summary>
        public static GuestConfigurationAssignmentReportType Consistency { get; } = new GuestConfigurationAssignmentReportType(ConsistencyValue);
        /// <summary> Initial. </summary>
        public static GuestConfigurationAssignmentReportType Initial { get; } = new GuestConfigurationAssignmentReportType(InitialValue);
        /// <summary> Determines if two <see cref="GuestConfigurationAssignmentReportType"/> values are the same. </summary>
        public static bool operator ==(GuestConfigurationAssignmentReportType left, GuestConfigurationAssignmentReportType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GuestConfigurationAssignmentReportType"/> values are not the same. </summary>
        public static bool operator !=(GuestConfigurationAssignmentReportType left, GuestConfigurationAssignmentReportType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GuestConfigurationAssignmentReportType"/>. </summary>
        public static implicit operator GuestConfigurationAssignmentReportType(string value) => new GuestConfigurationAssignmentReportType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GuestConfigurationAssignmentReportType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GuestConfigurationAssignmentReportType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
