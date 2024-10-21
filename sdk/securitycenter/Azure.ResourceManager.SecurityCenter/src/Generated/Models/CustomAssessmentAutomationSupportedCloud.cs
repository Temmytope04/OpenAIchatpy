// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Relevant cloud for the custom assessment automation. </summary>
    public readonly partial struct CustomAssessmentAutomationSupportedCloud : IEquatable<CustomAssessmentAutomationSupportedCloud>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CustomAssessmentAutomationSupportedCloud"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CustomAssessmentAutomationSupportedCloud(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AwsValue = "AWS";
        private const string GcpValue = "GCP";

        /// <summary> AWS. </summary>
        public static CustomAssessmentAutomationSupportedCloud Aws { get; } = new CustomAssessmentAutomationSupportedCloud(AwsValue);
        /// <summary> GCP. </summary>
        public static CustomAssessmentAutomationSupportedCloud Gcp { get; } = new CustomAssessmentAutomationSupportedCloud(GcpValue);
        /// <summary> Determines if two <see cref="CustomAssessmentAutomationSupportedCloud"/> values are the same. </summary>
        public static bool operator ==(CustomAssessmentAutomationSupportedCloud left, CustomAssessmentAutomationSupportedCloud right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CustomAssessmentAutomationSupportedCloud"/> values are not the same. </summary>
        public static bool operator !=(CustomAssessmentAutomationSupportedCloud left, CustomAssessmentAutomationSupportedCloud right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CustomAssessmentAutomationSupportedCloud"/>. </summary>
        public static implicit operator CustomAssessmentAutomationSupportedCloud(string value) => new CustomAssessmentAutomationSupportedCloud(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CustomAssessmentAutomationSupportedCloud other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CustomAssessmentAutomationSupportedCloud other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
