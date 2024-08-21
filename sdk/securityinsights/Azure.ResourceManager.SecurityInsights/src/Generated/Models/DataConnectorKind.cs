// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// The kind of the data connector
    /// Serialized Name: DataConnectorKind
    /// </summary>
    internal readonly partial struct DataConnectorKind : IEquatable<DataConnectorKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataConnectorKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataConnectorKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureActiveDirectoryValue = "AzureActiveDirectory";
        private const string AzureSecurityCenterValue = "AzureSecurityCenter";
        private const string MicrosoftCloudAppSecurityValue = "MicrosoftCloudAppSecurity";
        private const string ThreatIntelligenceValue = "ThreatIntelligence";
        private const string ThreatIntelligenceTaxiiValue = "ThreatIntelligenceTaxii";
        private const string Office365Value = "Office365";
        private const string OfficeATPValue = "OfficeATP";
        private const string OfficeIRMValue = "OfficeIRM";
        private const string Office365ProjectValue = "Office365Project";
        private const string MicrosoftPurviewInformationProtectionValue = "MicrosoftPurviewInformationProtection";
        private const string OfficePowerBIValue = "OfficePowerBI";
        private const string AmazonWebServicesCloudTrailValue = "AmazonWebServicesCloudTrail";
        private const string AmazonWebServicesS3Value = "AmazonWebServicesS3";
        private const string AzureAdvancedThreatProtectionValue = "AzureAdvancedThreatProtection";
        private const string MicrosoftDefenderAdvancedThreatProtectionValue = "MicrosoftDefenderAdvancedThreatProtection";
        private const string Dynamics365Value = "Dynamics365";
        private const string MicrosoftThreatProtectionValue = "MicrosoftThreatProtection";
        private const string MicrosoftThreatIntelligenceValue = "MicrosoftThreatIntelligence";
        private const string GenericUIValue = "GenericUI";
        private const string APIPollingValue = "APIPolling";
        private const string IOTValue = "IOT";
        private const string GCPValue = "GCP";
        private const string RestApiPollerValue = "RestApiPoller";

        /// <summary>
        /// AzureActiveDirectory
        /// Serialized Name: DataConnectorKind.AzureActiveDirectory
        /// </summary>
        public static DataConnectorKind AzureActiveDirectory { get; } = new DataConnectorKind(AzureActiveDirectoryValue);
        /// <summary>
        /// AzureSecurityCenter
        /// Serialized Name: DataConnectorKind.AzureSecurityCenter
        /// </summary>
        public static DataConnectorKind AzureSecurityCenter { get; } = new DataConnectorKind(AzureSecurityCenterValue);
        /// <summary>
        /// MicrosoftCloudAppSecurity
        /// Serialized Name: DataConnectorKind.MicrosoftCloudAppSecurity
        /// </summary>
        public static DataConnectorKind MicrosoftCloudAppSecurity { get; } = new DataConnectorKind(MicrosoftCloudAppSecurityValue);
        /// <summary>
        /// ThreatIntelligence
        /// Serialized Name: DataConnectorKind.ThreatIntelligence
        /// </summary>
        public static DataConnectorKind ThreatIntelligence { get; } = new DataConnectorKind(ThreatIntelligenceValue);
        /// <summary>
        /// ThreatIntelligenceTaxii
        /// Serialized Name: DataConnectorKind.ThreatIntelligenceTaxii
        /// </summary>
        public static DataConnectorKind ThreatIntelligenceTaxii { get; } = new DataConnectorKind(ThreatIntelligenceTaxiiValue);
        /// <summary>
        /// Office365
        /// Serialized Name: DataConnectorKind.Office365
        /// </summary>
        public static DataConnectorKind Office365 { get; } = new DataConnectorKind(Office365Value);
        /// <summary>
        /// OfficeATP
        /// Serialized Name: DataConnectorKind.OfficeATP
        /// </summary>
        public static DataConnectorKind OfficeATP { get; } = new DataConnectorKind(OfficeATPValue);
        /// <summary>
        /// OfficeIRM
        /// Serialized Name: DataConnectorKind.OfficeIRM
        /// </summary>
        public static DataConnectorKind OfficeIRM { get; } = new DataConnectorKind(OfficeIRMValue);
        /// <summary>
        /// Office365Project
        /// Serialized Name: DataConnectorKind.Office365Project
        /// </summary>
        public static DataConnectorKind Office365Project { get; } = new DataConnectorKind(Office365ProjectValue);
        /// <summary>
        /// MicrosoftPurviewInformationProtection
        /// Serialized Name: DataConnectorKind.MicrosoftPurviewInformationProtection
        /// </summary>
        public static DataConnectorKind MicrosoftPurviewInformationProtection { get; } = new DataConnectorKind(MicrosoftPurviewInformationProtectionValue);
        /// <summary>
        /// OfficePowerBI
        /// Serialized Name: DataConnectorKind.OfficePowerBI
        /// </summary>
        public static DataConnectorKind OfficePowerBI { get; } = new DataConnectorKind(OfficePowerBIValue);
        /// <summary>
        /// AmazonWebServicesCloudTrail
        /// Serialized Name: DataConnectorKind.AmazonWebServicesCloudTrail
        /// </summary>
        public static DataConnectorKind AmazonWebServicesCloudTrail { get; } = new DataConnectorKind(AmazonWebServicesCloudTrailValue);
        /// <summary>
        /// AmazonWebServicesS3
        /// Serialized Name: DataConnectorKind.AmazonWebServicesS3
        /// </summary>
        public static DataConnectorKind AmazonWebServicesS3 { get; } = new DataConnectorKind(AmazonWebServicesS3Value);
        /// <summary>
        /// AzureAdvancedThreatProtection
        /// Serialized Name: DataConnectorKind.AzureAdvancedThreatProtection
        /// </summary>
        public static DataConnectorKind AzureAdvancedThreatProtection { get; } = new DataConnectorKind(AzureAdvancedThreatProtectionValue);
        /// <summary>
        /// MicrosoftDefenderAdvancedThreatProtection
        /// Serialized Name: DataConnectorKind.MicrosoftDefenderAdvancedThreatProtection
        /// </summary>
        public static DataConnectorKind MicrosoftDefenderAdvancedThreatProtection { get; } = new DataConnectorKind(MicrosoftDefenderAdvancedThreatProtectionValue);
        /// <summary>
        /// Dynamics365
        /// Serialized Name: DataConnectorKind.Dynamics365
        /// </summary>
        public static DataConnectorKind Dynamics365 { get; } = new DataConnectorKind(Dynamics365Value);
        /// <summary>
        /// MicrosoftThreatProtection
        /// Serialized Name: DataConnectorKind.MicrosoftThreatProtection
        /// </summary>
        public static DataConnectorKind MicrosoftThreatProtection { get; } = new DataConnectorKind(MicrosoftThreatProtectionValue);
        /// <summary>
        /// MicrosoftThreatIntelligence
        /// Serialized Name: DataConnectorKind.MicrosoftThreatIntelligence
        /// </summary>
        public static DataConnectorKind MicrosoftThreatIntelligence { get; } = new DataConnectorKind(MicrosoftThreatIntelligenceValue);
        /// <summary>
        /// GenericUI
        /// Serialized Name: DataConnectorKind.GenericUI
        /// </summary>
        public static DataConnectorKind GenericUI { get; } = new DataConnectorKind(GenericUIValue);
        /// <summary>
        /// APIPolling
        /// Serialized Name: DataConnectorKind.APIPolling
        /// </summary>
        public static DataConnectorKind APIPolling { get; } = new DataConnectorKind(APIPollingValue);
        /// <summary>
        /// IOT
        /// Serialized Name: DataConnectorKind.IOT
        /// </summary>
        public static DataConnectorKind IOT { get; } = new DataConnectorKind(IOTValue);
        /// <summary>
        /// GCP
        /// Serialized Name: DataConnectorKind.GCP
        /// </summary>
        public static DataConnectorKind GCP { get; } = new DataConnectorKind(GCPValue);
        /// <summary>
        /// RestApiPoller
        /// Serialized Name: DataConnectorKind.RestApiPoller
        /// </summary>
        public static DataConnectorKind RestApiPoller { get; } = new DataConnectorKind(RestApiPollerValue);
        /// <summary> Determines if two <see cref="DataConnectorKind"/> values are the same. </summary>
        public static bool operator ==(DataConnectorKind left, DataConnectorKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataConnectorKind"/> values are not the same. </summary>
        public static bool operator !=(DataConnectorKind left, DataConnectorKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataConnectorKind"/>. </summary>
        public static implicit operator DataConnectorKind(string value) => new DataConnectorKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataConnectorKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataConnectorKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
