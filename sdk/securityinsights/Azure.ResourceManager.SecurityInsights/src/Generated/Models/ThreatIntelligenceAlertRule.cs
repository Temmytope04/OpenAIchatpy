// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Represents Threat Intelligence alert rule.
    /// Serialized Name: ThreatIntelligenceAlertRule
    /// </summary>
    public partial class ThreatIntelligenceAlertRule : SecurityInsightsAlertRuleData
    {
        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceAlertRule"/>. </summary>
        public ThreatIntelligenceAlertRule()
        {
            Tactics = new ChangeTrackingList<SecurityInsightsAttackTactic>();
            Techniques = new ChangeTrackingList<string>();
            SubTechniques = new ChangeTrackingList<string>();
            Kind = AlertRuleKind.ThreatIntelligence;
        }

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceAlertRule"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind">
        /// The kind of the alert rule
        /// Serialized Name: AlertRule.kind
        /// </param>
        /// <param name="etag">
        /// Etag of the azure resource
        /// Serialized Name: ResourceWithEtag.etag
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="alertRuleTemplateName">
        /// The Name of the alert rule template used to create this rule.
        /// Serialized Name: ThreatIntelligenceAlertRule.properties.alertRuleTemplateName
        /// </param>
        /// <param name="description">
        /// The description of the alert rule.
        /// Serialized Name: ThreatIntelligenceAlertRule.properties.description
        /// </param>
        /// <param name="displayName">
        /// The display name for alerts created by this alert rule.
        /// Serialized Name: ThreatIntelligenceAlertRule.properties.displayName
        /// </param>
        /// <param name="enabled">
        /// Determines whether this alert rule is enabled or disabled.
        /// Serialized Name: ThreatIntelligenceAlertRule.properties.enabled
        /// </param>
        /// <param name="lastModifiedUtc">
        /// The last time that this alert has been modified.
        /// Serialized Name: ThreatIntelligenceAlertRule.properties.lastModifiedUtc
        /// </param>
        /// <param name="severity">
        /// The severity for alerts created by this alert rule.
        /// Serialized Name: ThreatIntelligenceAlertRule.properties.severity
        /// </param>
        /// <param name="tactics">
        /// The tactics of the alert rule
        /// Serialized Name: ThreatIntelligenceAlertRule.properties.tactics
        /// </param>
        /// <param name="techniques">
        /// The techniques of the alert rule
        /// Serialized Name: ThreatIntelligenceAlertRule.properties.techniques
        /// </param>
        /// <param name="subTechniques">
        /// The sub-techniques of the alert rule
        /// Serialized Name: ThreatIntelligenceAlertRule.properties.subTechniques
        /// </param>
        internal ThreatIntelligenceAlertRule(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AlertRuleKind kind, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData, string alertRuleTemplateName, string description, string displayName, bool? enabled, DateTimeOffset? lastModifiedUtc, SecurityInsightsAlertSeverity? severity, IReadOnlyList<SecurityInsightsAttackTactic> tactics, IReadOnlyList<string> techniques, IReadOnlyList<string> subTechniques) : base(id, name, resourceType, systemData, kind, etag, serializedAdditionalRawData)
        {
            AlertRuleTemplateName = alertRuleTemplateName;
            Description = description;
            DisplayName = displayName;
            Enabled = enabled;
            LastModifiedUtc = lastModifiedUtc;
            Severity = severity;
            Tactics = tactics;
            Techniques = techniques;
            SubTechniques = subTechniques;
            Kind = kind;
        }

        /// <summary>
        /// The Name of the alert rule template used to create this rule.
        /// Serialized Name: ThreatIntelligenceAlertRule.properties.alertRuleTemplateName
        /// </summary>
        public string AlertRuleTemplateName { get; set; }
        /// <summary>
        /// The description of the alert rule.
        /// Serialized Name: ThreatIntelligenceAlertRule.properties.description
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// The display name for alerts created by this alert rule.
        /// Serialized Name: ThreatIntelligenceAlertRule.properties.displayName
        /// </summary>
        public string DisplayName { get; }
        /// <summary>
        /// Determines whether this alert rule is enabled or disabled.
        /// Serialized Name: ThreatIntelligenceAlertRule.properties.enabled
        /// </summary>
        public bool? Enabled { get; set; }
        /// <summary>
        /// The last time that this alert has been modified.
        /// Serialized Name: ThreatIntelligenceAlertRule.properties.lastModifiedUtc
        /// </summary>
        public DateTimeOffset? LastModifiedUtc { get; }
        /// <summary>
        /// The severity for alerts created by this alert rule.
        /// Serialized Name: ThreatIntelligenceAlertRule.properties.severity
        /// </summary>
        public SecurityInsightsAlertSeverity? Severity { get; }
        /// <summary>
        /// The tactics of the alert rule
        /// Serialized Name: ThreatIntelligenceAlertRule.properties.tactics
        /// </summary>
        public IReadOnlyList<SecurityInsightsAttackTactic> Tactics { get; }
        /// <summary>
        /// The techniques of the alert rule
        /// Serialized Name: ThreatIntelligenceAlertRule.properties.techniques
        /// </summary>
        public IReadOnlyList<string> Techniques { get; }
        /// <summary>
        /// The sub-techniques of the alert rule
        /// Serialized Name: ThreatIntelligenceAlertRule.properties.subTechniques
        /// </summary>
        public IReadOnlyList<string> SubTechniques { get; }
    }
}
