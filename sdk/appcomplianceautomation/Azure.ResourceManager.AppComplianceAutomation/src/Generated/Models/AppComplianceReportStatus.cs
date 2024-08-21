// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> Report status. </summary>
    public readonly partial struct AppComplianceReportStatus : IEquatable<AppComplianceReportStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppComplianceReportStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppComplianceReportStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "Active";
        private const string FailedValue = "Failed";
        private const string ReviewingValue = "Reviewing";
        private const string DisabledValue = "Disabled";

        /// <summary> The report is active. </summary>
        public static AppComplianceReportStatus Active { get; } = new AppComplianceReportStatus(ActiveValue);
        /// <summary> The report is failed. </summary>
        public static AppComplianceReportStatus Failed { get; } = new AppComplianceReportStatus(FailedValue);
        /// <summary> The report is under reviewing. </summary>
        public static AppComplianceReportStatus Reviewing { get; } = new AppComplianceReportStatus(ReviewingValue);
        /// <summary> The report is disabled. </summary>
        public static AppComplianceReportStatus Disabled { get; } = new AppComplianceReportStatus(DisabledValue);
        /// <summary> Determines if two <see cref="AppComplianceReportStatus"/> values are the same. </summary>
        public static bool operator ==(AppComplianceReportStatus left, AppComplianceReportStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppComplianceReportStatus"/> values are not the same. </summary>
        public static bool operator !=(AppComplianceReportStatus left, AppComplianceReportStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AppComplianceReportStatus"/>. </summary>
        public static implicit operator AppComplianceReportStatus(string value) => new AppComplianceReportStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppComplianceReportStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppComplianceReportStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
