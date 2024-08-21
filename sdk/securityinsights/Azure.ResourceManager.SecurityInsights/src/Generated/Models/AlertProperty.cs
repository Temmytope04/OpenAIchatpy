// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// The V3 alert property
    /// Serialized Name: AlertProperty
    /// </summary>
    public readonly partial struct AlertProperty : IEquatable<AlertProperty>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AlertProperty"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AlertProperty(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AlertLinkValue = "AlertLink";
        private const string ConfidenceLevelValue = "ConfidenceLevel";
        private const string ConfidenceScoreValue = "ConfidenceScore";
        private const string ExtendedLinksValue = "ExtendedLinks";
        private const string ProductNameValue = "ProductName";
        private const string ProviderNameValue = "ProviderName";
        private const string ProductComponentNameValue = "ProductComponentName";
        private const string RemediationStepsValue = "RemediationSteps";
        private const string TechniquesValue = "Techniques";
        private const string SubTechniquesValue = "SubTechniques";

        /// <summary>
        /// Alert's link
        /// Serialized Name: AlertProperty.AlertLink
        /// </summary>
        public static AlertProperty AlertLink { get; } = new AlertProperty(AlertLinkValue);
        /// <summary>
        /// Confidence level property
        /// Serialized Name: AlertProperty.ConfidenceLevel
        /// </summary>
        public static AlertProperty ConfidenceLevel { get; } = new AlertProperty(ConfidenceLevelValue);
        /// <summary>
        /// Confidence score
        /// Serialized Name: AlertProperty.ConfidenceScore
        /// </summary>
        public static AlertProperty ConfidenceScore { get; } = new AlertProperty(ConfidenceScoreValue);
        /// <summary>
        /// Extended links to the alert
        /// Serialized Name: AlertProperty.ExtendedLinks
        /// </summary>
        public static AlertProperty ExtendedLinks { get; } = new AlertProperty(ExtendedLinksValue);
        /// <summary>
        /// Product name alert property
        /// Serialized Name: AlertProperty.ProductName
        /// </summary>
        public static AlertProperty ProductName { get; } = new AlertProperty(ProductNameValue);
        /// <summary>
        /// Provider name alert property
        /// Serialized Name: AlertProperty.ProviderName
        /// </summary>
        public static AlertProperty ProviderName { get; } = new AlertProperty(ProviderNameValue);
        /// <summary>
        /// Product component name alert property
        /// Serialized Name: AlertProperty.ProductComponentName
        /// </summary>
        public static AlertProperty ProductComponentName { get; } = new AlertProperty(ProductComponentNameValue);
        /// <summary>
        /// Remediation steps alert property
        /// Serialized Name: AlertProperty.RemediationSteps
        /// </summary>
        public static AlertProperty RemediationSteps { get; } = new AlertProperty(RemediationStepsValue);
        /// <summary>
        /// Techniques alert property
        /// Serialized Name: AlertProperty.Techniques
        /// </summary>
        public static AlertProperty Techniques { get; } = new AlertProperty(TechniquesValue);
        /// <summary>
        /// SubTechniques alert property
        /// Serialized Name: AlertProperty.SubTechniques
        /// </summary>
        public static AlertProperty SubTechniques { get; } = new AlertProperty(SubTechniquesValue);
        /// <summary> Determines if two <see cref="AlertProperty"/> values are the same. </summary>
        public static bool operator ==(AlertProperty left, AlertProperty right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AlertProperty"/> values are not the same. </summary>
        public static bool operator !=(AlertProperty left, AlertProperty right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AlertProperty"/>. </summary>
        public static implicit operator AlertProperty(string value) => new AlertProperty(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AlertProperty other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AlertProperty other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
