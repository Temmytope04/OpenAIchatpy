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
    /// Represents NRT alert rule template.
    /// Serialized Name: NrtAlertRuleTemplate
    /// </summary>
    public partial class NrtAlertRuleTemplate : SecurityInsightsAlertRuleTemplateData
    {
        /// <summary> Initializes a new instance of <see cref="NrtAlertRuleTemplate"/>. </summary>
        public NrtAlertRuleTemplate()
        {
            RequiredDataConnectors = new ChangeTrackingList<AlertRuleTemplateDataSource>();
            Tactics = new ChangeTrackingList<SecurityInsightsAttackTactic>();
            Techniques = new ChangeTrackingList<string>();
            CustomDetails = new ChangeTrackingDictionary<string, string>();
            EntityMappings = new ChangeTrackingList<SecurityInsightsAlertRuleEntityMapping>();
            SentinelEntitiesMappings = new ChangeTrackingList<SentinelEntityMapping>();
            Kind = AlertRuleKind.NRT;
        }

        /// <summary> Initializes a new instance of <see cref="NrtAlertRuleTemplate"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind">
        /// The kind of the alert rule
        /// Serialized Name: AlertRuleTemplate.kind
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="alertRulesCreatedByTemplateCount">
        /// the number of alert rules that were created by this template
        /// Serialized Name: NrtAlertRuleTemplate.properties.alertRulesCreatedByTemplateCount
        /// </param>
        /// <param name="lastUpdatedDateUTC">
        /// The last time that this alert rule template has been updated.
        /// Serialized Name: NrtAlertRuleTemplate.properties.lastUpdatedDateUTC
        /// </param>
        /// <param name="createdDateUTC">
        /// The time that this alert rule template has been added.
        /// Serialized Name: NrtAlertRuleTemplate.properties.createdDateUTC
        /// </param>
        /// <param name="description">
        /// The description of the alert rule template.
        /// Serialized Name: NrtAlertRuleTemplate.properties.description
        /// </param>
        /// <param name="displayName">
        /// The display name for alert rule template.
        /// Serialized Name: NrtAlertRuleTemplate.properties.displayName
        /// </param>
        /// <param name="requiredDataConnectors">
        /// The required data sources for this template
        /// Serialized Name: NrtAlertRuleTemplate.properties.requiredDataConnectors
        /// </param>
        /// <param name="status">
        /// The alert rule template status.
        /// Serialized Name: NrtAlertRuleTemplate.properties.status
        /// </param>
        /// <param name="tactics">
        /// The tactics of the alert rule
        /// Serialized Name: NrtAlertRuleTemplate.properties.tactics
        /// </param>
        /// <param name="techniques">
        /// The techniques of the alert rule
        /// Serialized Name: NrtAlertRuleTemplate.properties.techniques
        /// </param>
        /// <param name="query">
        /// The query that creates alerts for this rule.
        /// Serialized Name: NrtAlertRuleTemplate.properties.query
        /// </param>
        /// <param name="severity">
        /// The severity for alerts created by this alert rule.
        /// Serialized Name: NrtAlertRuleTemplate.properties.severity
        /// </param>
        /// <param name="version">
        /// The version of this template - in format &lt;a.b.c&gt;, where all are numbers. For example &lt;1.0.2&gt;.
        /// Serialized Name: NrtAlertRuleTemplate.properties.version
        /// </param>
        /// <param name="customDetails">
        /// Dictionary of string key-value pairs of columns to be attached to the alert
        /// Serialized Name: NrtAlertRuleTemplate.properties.customDetails
        /// </param>
        /// <param name="entityMappings">
        /// Array of the entity mappings of the alert rule
        /// Serialized Name: NrtAlertRuleTemplate.properties.entityMappings
        /// </param>
        /// <param name="alertDetailsOverride">
        /// The alert details override settings
        /// Serialized Name: NrtAlertRuleTemplate.properties.alertDetailsOverride
        /// </param>
        /// <param name="eventGroupingSettings">
        /// The event grouping settings.
        /// Serialized Name: NrtAlertRuleTemplate.properties.eventGroupingSettings
        /// </param>
        /// <param name="sentinelEntitiesMappings">
        /// Array of the sentinel entity mappings of the alert rule
        /// Serialized Name: NrtAlertRuleTemplate.properties.sentinelEntitiesMappings
        /// </param>
        internal NrtAlertRuleTemplate(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AlertRuleKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, int? alertRulesCreatedByTemplateCount, DateTimeOffset? lastUpdatedDateUTC, DateTimeOffset? createdDateUTC, string description, string displayName, IList<AlertRuleTemplateDataSource> requiredDataConnectors, SecurityInsightsAlertRuleTemplateStatus? status, IList<SecurityInsightsAttackTactic> tactics, IList<string> techniques, string query, SecurityInsightsAlertSeverity? severity, string version, IDictionary<string, string> customDetails, IList<SecurityInsightsAlertRuleEntityMapping> entityMappings, SecurityInsightsAlertDetailsOverride alertDetailsOverride, EventGroupingSettings eventGroupingSettings, IList<SentinelEntityMapping> sentinelEntitiesMappings) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            AlertRulesCreatedByTemplateCount = alertRulesCreatedByTemplateCount;
            LastUpdatedDateUTC = lastUpdatedDateUTC;
            CreatedDateUTC = createdDateUTC;
            Description = description;
            DisplayName = displayName;
            RequiredDataConnectors = requiredDataConnectors;
            Status = status;
            Tactics = tactics;
            Techniques = techniques;
            Query = query;
            Severity = severity;
            Version = version;
            CustomDetails = customDetails;
            EntityMappings = entityMappings;
            AlertDetailsOverride = alertDetailsOverride;
            EventGroupingSettings = eventGroupingSettings;
            SentinelEntitiesMappings = sentinelEntitiesMappings;
            Kind = kind;
        }

        /// <summary>
        /// the number of alert rules that were created by this template
        /// Serialized Name: NrtAlertRuleTemplate.properties.alertRulesCreatedByTemplateCount
        /// </summary>
        public int? AlertRulesCreatedByTemplateCount { get; set; }
        /// <summary>
        /// The last time that this alert rule template has been updated.
        /// Serialized Name: NrtAlertRuleTemplate.properties.lastUpdatedDateUTC
        /// </summary>
        public DateTimeOffset? LastUpdatedDateUTC { get; }
        /// <summary>
        /// The time that this alert rule template has been added.
        /// Serialized Name: NrtAlertRuleTemplate.properties.createdDateUTC
        /// </summary>
        public DateTimeOffset? CreatedDateUTC { get; }
        /// <summary>
        /// The description of the alert rule template.
        /// Serialized Name: NrtAlertRuleTemplate.properties.description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The display name for alert rule template.
        /// Serialized Name: NrtAlertRuleTemplate.properties.displayName
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// The required data sources for this template
        /// Serialized Name: NrtAlertRuleTemplate.properties.requiredDataConnectors
        /// </summary>
        public IList<AlertRuleTemplateDataSource> RequiredDataConnectors { get; }
        /// <summary>
        /// The alert rule template status.
        /// Serialized Name: NrtAlertRuleTemplate.properties.status
        /// </summary>
        public SecurityInsightsAlertRuleTemplateStatus? Status { get; set; }
        /// <summary>
        /// The tactics of the alert rule
        /// Serialized Name: NrtAlertRuleTemplate.properties.tactics
        /// </summary>
        public IList<SecurityInsightsAttackTactic> Tactics { get; }
        /// <summary>
        /// The techniques of the alert rule
        /// Serialized Name: NrtAlertRuleTemplate.properties.techniques
        /// </summary>
        public IList<string> Techniques { get; }
        /// <summary>
        /// The query that creates alerts for this rule.
        /// Serialized Name: NrtAlertRuleTemplate.properties.query
        /// </summary>
        public string Query { get; set; }
        /// <summary>
        /// The severity for alerts created by this alert rule.
        /// Serialized Name: NrtAlertRuleTemplate.properties.severity
        /// </summary>
        public SecurityInsightsAlertSeverity? Severity { get; set; }
        /// <summary>
        /// The version of this template - in format &lt;a.b.c&gt;, where all are numbers. For example &lt;1.0.2&gt;.
        /// Serialized Name: NrtAlertRuleTemplate.properties.version
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// Dictionary of string key-value pairs of columns to be attached to the alert
        /// Serialized Name: NrtAlertRuleTemplate.properties.customDetails
        /// </summary>
        public IDictionary<string, string> CustomDetails { get; }
        /// <summary>
        /// Array of the entity mappings of the alert rule
        /// Serialized Name: NrtAlertRuleTemplate.properties.entityMappings
        /// </summary>
        public IList<SecurityInsightsAlertRuleEntityMapping> EntityMappings { get; }
        /// <summary>
        /// The alert details override settings
        /// Serialized Name: NrtAlertRuleTemplate.properties.alertDetailsOverride
        /// </summary>
        public SecurityInsightsAlertDetailsOverride AlertDetailsOverride { get; set; }
        /// <summary>
        /// The event grouping settings.
        /// Serialized Name: NrtAlertRuleTemplate.properties.eventGroupingSettings
        /// </summary>
        internal EventGroupingSettings EventGroupingSettings { get; set; }
        /// <summary>
        /// The event grouping aggregation kinds
        /// Serialized Name: EventGroupingSettings.aggregationKind
        /// </summary>
        public EventGroupingAggregationKind? EventGroupingAggregationKind
        {
            get => EventGroupingSettings is null ? default : EventGroupingSettings.AggregationKind;
            set
            {
                if (EventGroupingSettings is null)
                    EventGroupingSettings = new EventGroupingSettings();
                EventGroupingSettings.AggregationKind = value;
            }
        }

        /// <summary>
        /// Array of the sentinel entity mappings of the alert rule
        /// Serialized Name: NrtAlertRuleTemplate.properties.sentinelEntitiesMappings
        /// </summary>
        public IList<SentinelEntityMapping> SentinelEntitiesMappings { get; }
    }
}
