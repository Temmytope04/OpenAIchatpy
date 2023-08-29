// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents Fusion alert rule. </summary>
    public partial class SecurityInsightsFusionAlertRule : SecurityInsightsAlertRuleData
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsFusionAlertRule"/>. </summary>
        public SecurityInsightsFusionAlertRule()
        {
            Tactics = new ChangeTrackingList<SecurityInsightsAttackTactic>();
            Techniques = new ChangeTrackingList<string>();
            Kind = AlertRuleKind.Fusion;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsFusionAlertRule"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The alert rule kind. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="alertRuleTemplateName"> The Name of the alert rule template used to create this rule. </param>
        /// <param name="description"> The description of the alert rule. </param>
        /// <param name="displayName"> The display name for alerts created by this alert rule. </param>
        /// <param name="isEnabled"> Determines whether this alert rule is enabled or disabled. </param>
        /// <param name="lastModifiedOn"> The last time that this alert has been modified. </param>
        /// <param name="severity"> The severity for alerts created by this alert rule. </param>
        /// <param name="tactics"> The tactics of the alert rule. </param>
        /// <param name="techniques"> The techniques of the alert rule. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsFusionAlertRule(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AlertRuleKind kind, ETag? etag, string alertRuleTemplateName, string description, string displayName, bool? isEnabled, DateTimeOffset? lastModifiedOn, SecurityInsightsAlertSeverity? severity, IReadOnlyList<SecurityInsightsAttackTactic> tactics, IReadOnlyList<string> techniques, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, kind, etag, rawData)
        {
            AlertRuleTemplateName = alertRuleTemplateName;
            Description = description;
            DisplayName = displayName;
            IsEnabled = isEnabled;
            LastModifiedOn = lastModifiedOn;
            Severity = severity;
            Tactics = tactics;
            Techniques = techniques;
            Kind = kind;
        }

        /// <summary> The Name of the alert rule template used to create this rule. </summary>
        public string AlertRuleTemplateName { get; set; }
        /// <summary> The description of the alert rule. </summary>
        public string Description { get; }
        /// <summary> The display name for alerts created by this alert rule. </summary>
        public string DisplayName { get; }
        /// <summary> Determines whether this alert rule is enabled or disabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The last time that this alert has been modified. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> The severity for alerts created by this alert rule. </summary>
        public SecurityInsightsAlertSeverity? Severity { get; }
        /// <summary> The tactics of the alert rule. </summary>
        public IReadOnlyList<SecurityInsightsAttackTactic> Tactics { get; }
        /// <summary> The techniques of the alert rule. </summary>
        public IReadOnlyList<string> Techniques { get; }
    }
}
