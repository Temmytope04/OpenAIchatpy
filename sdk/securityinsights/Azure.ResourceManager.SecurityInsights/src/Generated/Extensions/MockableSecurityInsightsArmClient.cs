// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableSecurityInsightsArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableSecurityInsightsArmClient"/> class for mocking. </summary>
        protected MockableSecurityInsightsArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableSecurityInsightsArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableSecurityInsightsArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableSecurityInsightsArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsAlertRuleResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsAlertRuleResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsAlertRuleResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsAlertRuleResource"/> object. </returns>
        public virtual SecurityInsightsAlertRuleResource GetSecurityInsightsAlertRuleResource(ResourceIdentifier id)
        {
            SecurityInsightsAlertRuleResource.ValidateResourceId(id);
            return new SecurityInsightsAlertRuleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsAlertRuleActionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsAlertRuleActionResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsAlertRuleActionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsAlertRuleActionResource"/> object. </returns>
        public virtual SecurityInsightsAlertRuleActionResource GetSecurityInsightsAlertRuleActionResource(ResourceIdentifier id)
        {
            SecurityInsightsAlertRuleActionResource.ValidateResourceId(id);
            return new SecurityInsightsAlertRuleActionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsAlertRuleTemplateResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsAlertRuleTemplateResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsAlertRuleTemplateResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsAlertRuleTemplateResource"/> object. </returns>
        public virtual SecurityInsightsAlertRuleTemplateResource GetSecurityInsightsAlertRuleTemplateResource(ResourceIdentifier id)
        {
            SecurityInsightsAlertRuleTemplateResource.ValidateResourceId(id);
            return new SecurityInsightsAlertRuleTemplateResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsAutomationRuleResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsAutomationRuleResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsAutomationRuleResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsAutomationRuleResource"/> object. </returns>
        public virtual SecurityInsightsAutomationRuleResource GetSecurityInsightsAutomationRuleResource(ResourceIdentifier id)
        {
            SecurityInsightsAutomationRuleResource.ValidateResourceId(id);
            return new SecurityInsightsAutomationRuleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsEntityResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsEntityResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsEntityResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsEntityResource"/> object. </returns>
        public virtual SecurityInsightsEntityResource GetSecurityInsightsEntityResource(ResourceIdentifier id)
        {
            SecurityInsightsEntityResource.ValidateResourceId(id);
            return new SecurityInsightsEntityResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsIncidentResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsIncidentResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsIncidentResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsIncidentResource"/> object. </returns>
        public virtual SecurityInsightsIncidentResource GetSecurityInsightsIncidentResource(ResourceIdentifier id)
        {
            SecurityInsightsIncidentResource.ValidateResourceId(id);
            return new SecurityInsightsIncidentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BillingStatisticResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BillingStatisticResource.CreateResourceIdentifier" /> to create a <see cref="BillingStatisticResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BillingStatisticResource"/> object. </returns>
        public virtual BillingStatisticResource GetBillingStatisticResource(ResourceIdentifier id)
        {
            BillingStatisticResource.ValidateResourceId(id);
            return new BillingStatisticResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsBookmarkResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsBookmarkResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsBookmarkResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsBookmarkResource"/> object. </returns>
        public virtual SecurityInsightsBookmarkResource GetSecurityInsightsBookmarkResource(ResourceIdentifier id)
        {
            SecurityInsightsBookmarkResource.ValidateResourceId(id);
            return new SecurityInsightsBookmarkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsBookmarkRelationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsBookmarkRelationResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsBookmarkRelationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsBookmarkRelationResource"/> object. </returns>
        public virtual SecurityInsightsBookmarkRelationResource GetSecurityInsightsBookmarkRelationResource(ResourceIdentifier id)
        {
            SecurityInsightsBookmarkRelationResource.ValidateResourceId(id);
            return new SecurityInsightsBookmarkRelationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsEntityRelationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsEntityRelationResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsEntityRelationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsEntityRelationResource"/> object. </returns>
        public virtual SecurityInsightsEntityRelationResource GetSecurityInsightsEntityRelationResource(ResourceIdentifier id)
        {
            SecurityInsightsEntityRelationResource.ValidateResourceId(id);
            return new SecurityInsightsEntityRelationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsIncidentRelationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsIncidentRelationResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsIncidentRelationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsIncidentRelationResource"/> object. </returns>
        public virtual SecurityInsightsIncidentRelationResource GetSecurityInsightsIncidentRelationResource(ResourceIdentifier id)
        {
            SecurityInsightsIncidentRelationResource.ValidateResourceId(id);
            return new SecurityInsightsIncidentRelationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PackageModelResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PackageModelResource.CreateResourceIdentifier" /> to create a <see cref="PackageModelResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PackageModelResource"/> object. </returns>
        public virtual PackageModelResource GetPackageModelResource(ResourceIdentifier id)
        {
            PackageModelResource.ValidateResourceId(id);
            return new PackageModelResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ProductPackageModelResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ProductPackageModelResource.CreateResourceIdentifier" /> to create a <see cref="ProductPackageModelResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ProductPackageModelResource"/> object. </returns>
        public virtual ProductPackageModelResource GetProductPackageModelResource(ResourceIdentifier id)
        {
            ProductPackageModelResource.ValidateResourceId(id);
            return new ProductPackageModelResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ProductTemplateModelResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ProductTemplateModelResource.CreateResourceIdentifier" /> to create a <see cref="ProductTemplateModelResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ProductTemplateModelResource"/> object. </returns>
        public virtual ProductTemplateModelResource GetProductTemplateModelResource(ResourceIdentifier id)
        {
            ProductTemplateModelResource.ValidateResourceId(id);
            return new ProductTemplateModelResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TemplateModelResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TemplateModelResource.CreateResourceIdentifier" /> to create a <see cref="TemplateModelResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TemplateModelResource"/> object. </returns>
        public virtual TemplateModelResource GetTemplateModelResource(ResourceIdentifier id)
        {
            TemplateModelResource.ValidateResourceId(id);
            return new TemplateModelResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EntityQueryResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EntityQueryResource.CreateResourceIdentifier" /> to create an <see cref="EntityQueryResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EntityQueryResource"/> object. </returns>
        public virtual EntityQueryResource GetEntityQueryResource(ResourceIdentifier id)
        {
            EntityQueryResource.ValidateResourceId(id);
            return new EntityQueryResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EntityQueryTemplateResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EntityQueryTemplateResource.CreateResourceIdentifier" /> to create an <see cref="EntityQueryTemplateResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EntityQueryTemplateResource"/> object. </returns>
        public virtual EntityQueryTemplateResource GetEntityQueryTemplateResource(ResourceIdentifier id)
        {
            EntityQueryTemplateResource.ValidateResourceId(id);
            return new EntityQueryTemplateResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FileImportResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FileImportResource.CreateResourceIdentifier" /> to create a <see cref="FileImportResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FileImportResource"/> object. </returns>
        public virtual FileImportResource GetFileImportResource(ResourceIdentifier id)
        {
            FileImportResource.ValidateResourceId(id);
            return new FileImportResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsHuntResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsHuntResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsHuntResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsHuntResource"/> object. </returns>
        public virtual SecurityInsightsHuntResource GetSecurityInsightsHuntResource(ResourceIdentifier id)
        {
            SecurityInsightsHuntResource.ValidateResourceId(id);
            return new SecurityInsightsHuntResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsHuntRelationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsHuntRelationResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsHuntRelationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsHuntRelationResource"/> object. </returns>
        public virtual SecurityInsightsHuntRelationResource GetSecurityInsightsHuntRelationResource(ResourceIdentifier id)
        {
            SecurityInsightsHuntRelationResource.ValidateResourceId(id);
            return new SecurityInsightsHuntRelationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsHuntCommentResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsHuntCommentResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsHuntCommentResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsHuntCommentResource"/> object. </returns>
        public virtual SecurityInsightsHuntCommentResource GetSecurityInsightsHuntCommentResource(ResourceIdentifier id)
        {
            SecurityInsightsHuntCommentResource.ValidateResourceId(id);
            return new SecurityInsightsHuntCommentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsIncidentCommentResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsIncidentCommentResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsIncidentCommentResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsIncidentCommentResource"/> object. </returns>
        public virtual SecurityInsightsIncidentCommentResource GetSecurityInsightsIncidentCommentResource(ResourceIdentifier id)
        {
            SecurityInsightsIncidentCommentResource.ValidateResourceId(id);
            return new SecurityInsightsIncidentCommentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="IncidentTaskResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IncidentTaskResource.CreateResourceIdentifier" /> to create an <see cref="IncidentTaskResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="IncidentTaskResource"/> object. </returns>
        public virtual IncidentTaskResource GetIncidentTaskResource(ResourceIdentifier id)
        {
            IncidentTaskResource.ValidateResourceId(id);
            return new IncidentTaskResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MetadataModelResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MetadataModelResource.CreateResourceIdentifier" /> to create a <see cref="MetadataModelResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MetadataModelResource"/> object. </returns>
        public virtual MetadataModelResource GetMetadataModelResource(ResourceIdentifier id)
        {
            MetadataModelResource.ValidateResourceId(id);
            return new MetadataModelResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OfficeConsentResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OfficeConsentResource.CreateResourceIdentifier" /> to create an <see cref="OfficeConsentResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OfficeConsentResource"/> object. </returns>
        public virtual OfficeConsentResource GetOfficeConsentResource(ResourceIdentifier id)
        {
            OfficeConsentResource.ValidateResourceId(id);
            return new OfficeConsentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsSentinelOnboardingStateResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsSentinelOnboardingStateResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsSentinelOnboardingStateResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsSentinelOnboardingStateResource"/> object. </returns>
        public virtual SecurityInsightsSentinelOnboardingStateResource GetSecurityInsightsSentinelOnboardingStateResource(ResourceIdentifier id)
        {
            SecurityInsightsSentinelOnboardingStateResource.ValidateResourceId(id);
            return new SecurityInsightsSentinelOnboardingStateResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsRecommendationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsRecommendationResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsRecommendationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsRecommendationResource"/> object. </returns>
        public virtual SecurityInsightsRecommendationResource GetSecurityInsightsRecommendationResource(ResourceIdentifier id)
        {
            SecurityInsightsRecommendationResource.ValidateResourceId(id);
            return new SecurityInsightsRecommendationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityMLAnalyticsSettingResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityMLAnalyticsSettingResource.CreateResourceIdentifier" /> to create a <see cref="SecurityMLAnalyticsSettingResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityMLAnalyticsSettingResource"/> object. </returns>
        public virtual SecurityMLAnalyticsSettingResource GetSecurityMLAnalyticsSettingResource(ResourceIdentifier id)
        {
            SecurityMLAnalyticsSettingResource.ValidateResourceId(id);
            return new SecurityMLAnalyticsSettingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SettingResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SettingResource.CreateResourceIdentifier" /> to create a <see cref="SettingResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SettingResource"/> object. </returns>
        public virtual SettingResource GetSettingResource(ResourceIdentifier id)
        {
            SettingResource.ValidateResourceId(id);
            return new SettingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SourceControlResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SourceControlResource.CreateResourceIdentifier" /> to create a <see cref="SourceControlResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SourceControlResource"/> object. </returns>
        public virtual SourceControlResource GetSourceControlResource(ResourceIdentifier id)
        {
            SourceControlResource.ValidateResourceId(id);
            return new SourceControlResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsThreatIntelligenceIndicatorResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsThreatIntelligenceIndicatorResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsThreatIntelligenceIndicatorResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsThreatIntelligenceIndicatorResource"/> object. </returns>
        public virtual SecurityInsightsThreatIntelligenceIndicatorResource GetSecurityInsightsThreatIntelligenceIndicatorResource(ResourceIdentifier id)
        {
            SecurityInsightsThreatIntelligenceIndicatorResource.ValidateResourceId(id);
            return new SecurityInsightsThreatIntelligenceIndicatorResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TriggeredAnalyticsRuleRunResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TriggeredAnalyticsRuleRunResource.CreateResourceIdentifier" /> to create a <see cref="TriggeredAnalyticsRuleRunResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TriggeredAnalyticsRuleRunResource"/> object. </returns>
        public virtual TriggeredAnalyticsRuleRunResource GetTriggeredAnalyticsRuleRunResource(ResourceIdentifier id)
        {
            TriggeredAnalyticsRuleRunResource.ValidateResourceId(id);
            return new TriggeredAnalyticsRuleRunResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsWatchlistResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsWatchlistResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsWatchlistResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsWatchlistResource"/> object. </returns>
        public virtual SecurityInsightsWatchlistResource GetSecurityInsightsWatchlistResource(ResourceIdentifier id)
        {
            SecurityInsightsWatchlistResource.ValidateResourceId(id);
            return new SecurityInsightsWatchlistResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsWatchlistItemResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsWatchlistItemResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsWatchlistItemResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsWatchlistItemResource"/> object. </returns>
        public virtual SecurityInsightsWatchlistItemResource GetSecurityInsightsWatchlistItemResource(ResourceIdentifier id)
        {
            SecurityInsightsWatchlistItemResource.ValidateResourceId(id);
            return new SecurityInsightsWatchlistItemResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="WorkspaceManagerAssignmentResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WorkspaceManagerAssignmentResource.CreateResourceIdentifier" /> to create a <see cref="WorkspaceManagerAssignmentResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WorkspaceManagerAssignmentResource"/> object. </returns>
        public virtual WorkspaceManagerAssignmentResource GetWorkspaceManagerAssignmentResource(ResourceIdentifier id)
        {
            WorkspaceManagerAssignmentResource.ValidateResourceId(id);
            return new WorkspaceManagerAssignmentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AssignmentJobResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AssignmentJobResource.CreateResourceIdentifier" /> to create an <see cref="AssignmentJobResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AssignmentJobResource"/> object. </returns>
        public virtual AssignmentJobResource GetAssignmentJobResource(ResourceIdentifier id)
        {
            AssignmentJobResource.ValidateResourceId(id);
            return new AssignmentJobResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="WorkspaceManagerConfigurationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WorkspaceManagerConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="WorkspaceManagerConfigurationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WorkspaceManagerConfigurationResource"/> object. </returns>
        public virtual WorkspaceManagerConfigurationResource GetWorkspaceManagerConfigurationResource(ResourceIdentifier id)
        {
            WorkspaceManagerConfigurationResource.ValidateResourceId(id);
            return new WorkspaceManagerConfigurationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="WorkspaceManagerGroupResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WorkspaceManagerGroupResource.CreateResourceIdentifier" /> to create a <see cref="WorkspaceManagerGroupResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WorkspaceManagerGroupResource"/> object. </returns>
        public virtual WorkspaceManagerGroupResource GetWorkspaceManagerGroupResource(ResourceIdentifier id)
        {
            WorkspaceManagerGroupResource.ValidateResourceId(id);
            return new WorkspaceManagerGroupResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="WorkspaceManagerMemberResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WorkspaceManagerMemberResource.CreateResourceIdentifier" /> to create a <see cref="WorkspaceManagerMemberResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WorkspaceManagerMemberResource"/> object. </returns>
        public virtual WorkspaceManagerMemberResource GetWorkspaceManagerMemberResource(ResourceIdentifier id)
        {
            WorkspaceManagerMemberResource.ValidateResourceId(id);
            return new WorkspaceManagerMemberResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataConnectorDefinitionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataConnectorDefinitionResource.CreateResourceIdentifier" /> to create a <see cref="DataConnectorDefinitionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataConnectorDefinitionResource"/> object. </returns>
        public virtual DataConnectorDefinitionResource GetDataConnectorDefinitionResource(ResourceIdentifier id)
        {
            DataConnectorDefinitionResource.ValidateResourceId(id);
            return new DataConnectorDefinitionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsDataConnectorResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsDataConnectorResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsDataConnectorResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityInsightsDataConnectorResource"/> object. </returns>
        public virtual SecurityInsightsDataConnectorResource GetSecurityInsightsDataConnectorResource(ResourceIdentifier id)
        {
            SecurityInsightsDataConnectorResource.ValidateResourceId(id);
            return new SecurityInsightsDataConnectorResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OperationalInsightsWorkspaceSecurityInsightsResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OperationalInsightsWorkspaceSecurityInsightsResource.CreateResourceIdentifier" /> to create an <see cref="OperationalInsightsWorkspaceSecurityInsightsResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OperationalInsightsWorkspaceSecurityInsightsResource"/> object. </returns>
        public virtual OperationalInsightsWorkspaceSecurityInsightsResource GetOperationalInsightsWorkspaceSecurityInsightsResource(ResourceIdentifier id)
        {
            OperationalInsightsWorkspaceSecurityInsightsResource.ValidateResourceId(id);
            return new OperationalInsightsWorkspaceSecurityInsightsResource(Client, id);
        }
    }
}
