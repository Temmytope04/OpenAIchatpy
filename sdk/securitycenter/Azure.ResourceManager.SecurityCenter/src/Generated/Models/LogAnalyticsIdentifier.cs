// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Represents a Log Analytics workspace scope identifier. </summary>
    public partial class LogAnalyticsIdentifier : SecurityAlertResourceIdentifier
    {
        /// <summary> Initializes a new instance of <see cref="LogAnalyticsIdentifier"/>. </summary>
        internal LogAnalyticsIdentifier()
        {
            ResourceIdentifierType = ResourceIdentifierType.LogAnalytics;
        }

        /// <summary> Initializes a new instance of <see cref="LogAnalyticsIdentifier"/>. </summary>
        /// <param name="resourceIdentifierType"> There can be multiple identifiers of different type per alert, this field specify the identifier type. </param>
        /// <param name="workspaceId"> The LogAnalytics workspace id that stores this alert. </param>
        /// <param name="workspaceSubscriptionId"> The azure subscription id for the LogAnalytics workspace storing this alert. </param>
        /// <param name="workspaceResourceGroup"> The azure resource group for the LogAnalytics workspace storing this alert. </param>
        /// <param name="agentId"> (optional) The LogAnalytics agent id reporting the event that this alert is based on. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LogAnalyticsIdentifier(ResourceIdentifierType resourceIdentifierType, Guid? workspaceId, string workspaceSubscriptionId, string workspaceResourceGroup, Guid? agentId, Dictionary<string, BinaryData> rawData) : base(resourceIdentifierType, rawData)
        {
            WorkspaceId = workspaceId;
            WorkspaceSubscriptionId = workspaceSubscriptionId;
            WorkspaceResourceGroup = workspaceResourceGroup;
            AgentId = agentId;
            ResourceIdentifierType = resourceIdentifierType;
        }

        /// <summary> The LogAnalytics workspace id that stores this alert. </summary>
        public Guid? WorkspaceId { get; }
        /// <summary> The azure subscription id for the LogAnalytics workspace storing this alert. </summary>
        public string WorkspaceSubscriptionId { get; }
        /// <summary> The azure resource group for the LogAnalytics workspace storing this alert. </summary>
        public string WorkspaceResourceGroup { get; }
        /// <summary> (optional) The LogAnalytics agent id reporting the event that this alert is based on. </summary>
        public Guid? AgentId { get; }
    }
}
