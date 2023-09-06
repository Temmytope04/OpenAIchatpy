// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Represents a recommendation result generated by the recommendation engine. </summary>
    public partial class AppServiceRecommendation : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceRecommendation"/>. </summary>
        public AppServiceRecommendation()
        {
            CategoryTags = new ChangeTrackingList<string>();
            States = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceRecommendation"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="createdOn"> Timestamp when this instance was created. </param>
        /// <param name="recommendationId"> A GUID value that each recommendation object is associated with. </param>
        /// <param name="resourceId"> Full ARM resource ID string that this recommendation object is associated with. </param>
        /// <param name="resourceScope"> Name of a resource type this recommendation applies, e.g. Subscription, ServerFarm, Site. </param>
        /// <param name="ruleName"> Unique name of the rule. </param>
        /// <param name="displayName"> UI friendly name of the rule (may not be unique). </param>
        /// <param name="message"> Recommendation text. </param>
        /// <param name="level"> Level indicating how critical this recommendation can impact. </param>
        /// <param name="channels"> List of channels that this recommendation can apply. </param>
        /// <param name="categoryTags"> The list of category tags that this recommendation belongs to. </param>
        /// <param name="actionName"> Name of action recommended by this object. </param>
        /// <param name="enabled"> True if this recommendation is still valid (i.e. "actionable"). False if it is invalid. </param>
        /// <param name="states"> The list of states of this recommendation. If it's null then it should be considered "Active". </param>
        /// <param name="startOn"> The beginning time in UTC of a range that the recommendation refers to. </param>
        /// <param name="endOn"> The end time in UTC of a range that the recommendation refers to. </param>
        /// <param name="nextNotificationOn"> When to notify this recommendation next in UTC. Null means that this will never be notified anymore. </param>
        /// <param name="notificationExpirationOn"> Date and time in UTC when this notification expires. </param>
        /// <param name="notifiedOn"> Last timestamp in UTC this instance was actually notified. Null means that this recommendation hasn't been notified yet. </param>
        /// <param name="score"> A metric value measured by the rule. </param>
        /// <param name="isDynamic"> True if this is associated with a dynamically added rule. </param>
        /// <param name="extensionName"> Extension name of the portal if exists. </param>
        /// <param name="bladeName"> Deep link to a blade on the portal. </param>
        /// <param name="forwardLink"> Forward link to an external document associated with the rule. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceRecommendation(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? createdOn, Guid? recommendationId, ResourceIdentifier resourceId, ResourceScopeType? resourceScope, string ruleName, string displayName, string message, NotificationLevel? level, RecommendationChannel? channels, IReadOnlyList<string> categoryTags, string actionName, int? enabled, IList<string> states, DateTimeOffset? startOn, DateTimeOffset? endOn, DateTimeOffset? nextNotificationOn, DateTimeOffset? notificationExpirationOn, DateTimeOffset? notifiedOn, double? score, bool? isDynamic, string extensionName, string bladeName, string forwardLink, string kind, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            CreatedOn = createdOn;
            RecommendationId = recommendationId;
            ResourceId = resourceId;
            ResourceScope = resourceScope;
            RuleName = ruleName;
            DisplayName = displayName;
            Message = message;
            Level = level;
            Channels = channels;
            CategoryTags = categoryTags;
            ActionName = actionName;
            Enabled = enabled;
            States = states;
            StartOn = startOn;
            EndOn = endOn;
            NextNotificationOn = nextNotificationOn;
            NotificationExpirationOn = notificationExpirationOn;
            NotifiedOn = notifiedOn;
            Score = score;
            IsDynamic = isDynamic;
            ExtensionName = extensionName;
            BladeName = bladeName;
            ForwardLink = forwardLink;
            Kind = kind;
            _rawData = rawData;
        }

        /// <summary> Timestamp when this instance was created. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> A GUID value that each recommendation object is associated with. </summary>
        public Guid? RecommendationId { get; set; }
        /// <summary> Full ARM resource ID string that this recommendation object is associated with. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> Name of a resource type this recommendation applies, e.g. Subscription, ServerFarm, Site. </summary>
        public ResourceScopeType? ResourceScope { get; set; }
        /// <summary> Unique name of the rule. </summary>
        public string RuleName { get; set; }
        /// <summary> UI friendly name of the rule (may not be unique). </summary>
        public string DisplayName { get; set; }
        /// <summary> Recommendation text. </summary>
        public string Message { get; set; }
        /// <summary> Level indicating how critical this recommendation can impact. </summary>
        public NotificationLevel? Level { get; set; }
        /// <summary> List of channels that this recommendation can apply. </summary>
        public RecommendationChannel? Channels { get; set; }
        /// <summary> The list of category tags that this recommendation belongs to. </summary>
        public IReadOnlyList<string> CategoryTags { get; }
        /// <summary> Name of action recommended by this object. </summary>
        public string ActionName { get; set; }
        /// <summary> True if this recommendation is still valid (i.e. "actionable"). False if it is invalid. </summary>
        public int? Enabled { get; set; }
        /// <summary> The list of states of this recommendation. If it's null then it should be considered "Active". </summary>
        public IList<string> States { get; }
        /// <summary> The beginning time in UTC of a range that the recommendation refers to. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> The end time in UTC of a range that the recommendation refers to. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> When to notify this recommendation next in UTC. Null means that this will never be notified anymore. </summary>
        public DateTimeOffset? NextNotificationOn { get; set; }
        /// <summary> Date and time in UTC when this notification expires. </summary>
        public DateTimeOffset? NotificationExpirationOn { get; set; }
        /// <summary> Last timestamp in UTC this instance was actually notified. Null means that this recommendation hasn't been notified yet. </summary>
        public DateTimeOffset? NotifiedOn { get; set; }
        /// <summary> A metric value measured by the rule. </summary>
        public double? Score { get; set; }
        /// <summary> True if this is associated with a dynamically added rule. </summary>
        public bool? IsDynamic { get; set; }
        /// <summary> Extension name of the portal if exists. </summary>
        public string ExtensionName { get; set; }
        /// <summary> Deep link to a blade on the portal. </summary>
        public string BladeName { get; set; }
        /// <summary> Forward link to an external document associated with the rule. </summary>
        public string ForwardLink { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
