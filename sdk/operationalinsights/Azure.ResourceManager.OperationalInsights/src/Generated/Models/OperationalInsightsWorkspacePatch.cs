// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The top level Workspace resource container. </summary>
    public partial class OperationalInsightsWorkspacePatch : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="OperationalInsightsWorkspacePatch"/>. </summary>
        public OperationalInsightsWorkspacePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            PrivateLinkScopedResources = new ChangeTrackingList<OperationalInsightsPrivateLinkScopedResourceInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsWorkspacePatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> The identity of the resource. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <param name="tags"> Resource tags. Optional. </param>
        /// <param name="provisioningState"> The provisioning state of the workspace. </param>
        /// <param name="customerId"> This is a read-only property. Represents the ID associated with the workspace. </param>
        /// <param name="sku"> The SKU of the workspace. </param>
        /// <param name="retentionInDays"> The workspace data retention in days. Allowed values are per pricing plan. See pricing tiers documentation for details. </param>
        /// <param name="workspaceCapping"> The daily volume cap for ingestion. </param>
        /// <param name="createdOn"> Workspace creation date. </param>
        /// <param name="modifiedOn"> Workspace modification date. </param>
        /// <param name="publicNetworkAccessForIngestion"> The network access type for accessing Log Analytics ingestion. </param>
        /// <param name="publicNetworkAccessForQuery"> The network access type for accessing Log Analytics query. </param>
        /// <param name="forceCmkForQuery"> Indicates whether customer managed storage is mandatory for query management. </param>
        /// <param name="privateLinkScopedResources"> List of linked private link scope resources. </param>
        /// <param name="features"> Workspace features. </param>
        /// <param name="defaultDataCollectionRuleResourceId"> The resource ID of the default Data Collection Rule to use for this workspace. Expected format is - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dcrName}. </param>
        /// <param name="etag"> Resource Etag. </param>
        internal OperationalInsightsWorkspacePatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedServiceIdentity identity, IDictionary<string, string> tags, OperationalInsightsWorkspaceEntityStatus? provisioningState, Guid? customerId, OperationalInsightsWorkspaceSku sku, int? retentionInDays, OperationalInsightsWorkspaceCapping workspaceCapping, DateTimeOffset? createdOn, DateTimeOffset? modifiedOn, OperationalInsightsPublicNetworkAccessType? publicNetworkAccessForIngestion, OperationalInsightsPublicNetworkAccessType? publicNetworkAccessForQuery, bool? forceCmkForQuery, IReadOnlyList<OperationalInsightsPrivateLinkScopedResourceInfo> privateLinkScopedResources, OperationalInsightsWorkspaceFeatures features, ResourceIdentifier defaultDataCollectionRuleResourceId, ETag? etag) : base(id, name, resourceType, systemData)
        {
            Identity = identity;
            Tags = tags;
            ProvisioningState = provisioningState;
            CustomerId = customerId;
            Sku = sku;
            RetentionInDays = retentionInDays;
            WorkspaceCapping = workspaceCapping;
            CreatedOn = createdOn;
            ModifiedOn = modifiedOn;
            PublicNetworkAccessForIngestion = publicNetworkAccessForIngestion;
            PublicNetworkAccessForQuery = publicNetworkAccessForQuery;
            ForceCmkForQuery = forceCmkForQuery;
            PrivateLinkScopedResources = privateLinkScopedResources;
            Features = features;
            DefaultDataCollectionRuleResourceId = defaultDataCollectionRuleResourceId;
            ETag = etag;
        }

        /// <summary> The identity of the resource. Current supported identity types: None, SystemAssigned, UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Resource tags. Optional. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The provisioning state of the workspace. </summary>
        public OperationalInsightsWorkspaceEntityStatus? ProvisioningState { get; }
        /// <summary> This is a read-only property. Represents the ID associated with the workspace. </summary>
        public Guid? CustomerId { get; }
        /// <summary> The SKU of the workspace. </summary>
        public OperationalInsightsWorkspaceSku Sku { get; set; }
        /// <summary> The workspace data retention in days. Allowed values are per pricing plan. See pricing tiers documentation for details. </summary>
        public int? RetentionInDays { get; set; }
        /// <summary> The daily volume cap for ingestion. </summary>
        public OperationalInsightsWorkspaceCapping WorkspaceCapping { get; set; }
        /// <summary> Workspace creation date. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Workspace modification date. </summary>
        public DateTimeOffset? ModifiedOn { get; }
        /// <summary> The network access type for accessing Log Analytics ingestion. </summary>
        public OperationalInsightsPublicNetworkAccessType? PublicNetworkAccessForIngestion { get; set; }
        /// <summary> The network access type for accessing Log Analytics query. </summary>
        public OperationalInsightsPublicNetworkAccessType? PublicNetworkAccessForQuery { get; set; }
        /// <summary> Indicates whether customer managed storage is mandatory for query management. </summary>
        public bool? ForceCmkForQuery { get; set; }
        /// <summary> List of linked private link scope resources. </summary>
        public IReadOnlyList<OperationalInsightsPrivateLinkScopedResourceInfo> PrivateLinkScopedResources { get; }
        /// <summary> Workspace features. </summary>
        public OperationalInsightsWorkspaceFeatures Features { get; set; }
        /// <summary> The resource ID of the default Data Collection Rule to use for this workspace. Expected format is - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dcrName}. </summary>
        public ResourceIdentifier DefaultDataCollectionRuleResourceId { get; set; }
        /// <summary> Resource Etag. </summary>
        public ETag? ETag { get; }
    }
}
