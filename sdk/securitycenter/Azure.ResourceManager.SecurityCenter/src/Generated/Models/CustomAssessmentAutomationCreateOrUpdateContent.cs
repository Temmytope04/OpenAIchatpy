// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Custom Assessment Automation request. </summary>
    public partial class CustomAssessmentAutomationCreateOrUpdateContent : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CustomAssessmentAutomationCreateOrUpdateContent"/>. </summary>
        public CustomAssessmentAutomationCreateOrUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CustomAssessmentAutomationCreateOrUpdateContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="compressedQuery"> Base 64 encoded KQL query representing the assessment automation results required. </param>
        /// <param name="supportedCloud"> Relevant cloud for the custom assessment automation. </param>
        /// <param name="severity"> The severity to relate to the assessments generated by this assessment automation. </param>
        /// <param name="displayName"> The display name of the assessments generated by this assessment automation. </param>
        /// <param name="description"> The description to relate to the assessments generated by this assessment automation. </param>
        /// <param name="remediationDescription"> The remediation description to relate to the assessments generated by this assessment automation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomAssessmentAutomationCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string compressedQuery, CustomAssessmentAutomationSupportedCloud? supportedCloud, CustomAssessmentSeverity? severity, string displayName, string description, string remediationDescription, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            CompressedQuery = compressedQuery;
            SupportedCloud = supportedCloud;
            Severity = severity;
            DisplayName = displayName;
            Description = description;
            RemediationDescription = remediationDescription;
            _rawData = rawData;
        }

        /// <summary> Base 64 encoded KQL query representing the assessment automation results required. </summary>
        public string CompressedQuery { get; set; }
        /// <summary> Relevant cloud for the custom assessment automation. </summary>
        public CustomAssessmentAutomationSupportedCloud? SupportedCloud { get; set; }
        /// <summary> The severity to relate to the assessments generated by this assessment automation. </summary>
        public CustomAssessmentSeverity? Severity { get; set; }
        /// <summary> The display name of the assessments generated by this assessment automation. </summary>
        public string DisplayName { get; set; }
        /// <summary> The description to relate to the assessments generated by this assessment automation. </summary>
        public string Description { get; set; }
        /// <summary> The remediation description to relate to the assessments generated by this assessment automation. </summary>
        public string RemediationDescription { get; set; }
    }
}
