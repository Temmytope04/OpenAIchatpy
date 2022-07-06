// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MySql
{
    /// <summary> A class representing the RecommendationAction data model. </summary>
    public partial class RecommendationActionData : ResourceData
    {
        /// <summary> Initializes a new instance of RecommendationActionData. </summary>
        public RecommendationActionData()
        {
            Details = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of RecommendationActionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="advisorName"> Advisor name. </param>
        /// <param name="sessionId"> Recommendation action session identifier. </param>
        /// <param name="actionId"> Recommendation action identifier. </param>
        /// <param name="createdOn"> Recommendation action creation time. </param>
        /// <param name="expirationOn"> Recommendation action expiration time. </param>
        /// <param name="reason"> Recommendation action reason. </param>
        /// <param name="recommendationType"> Recommendation action type. </param>
        /// <param name="details"> Recommendation action details. </param>
        internal RecommendationActionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string advisorName, string sessionId, int? actionId, DateTimeOffset? createdOn, DateTimeOffset? expirationOn, string reason, string recommendationType, IDictionary<string, string> details) : base(id, name, resourceType, systemData)
        {
            AdvisorName = advisorName;
            SessionId = sessionId;
            ActionId = actionId;
            CreatedOn = createdOn;
            ExpirationOn = expirationOn;
            Reason = reason;
            RecommendationType = recommendationType;
            Details = details;
        }

        /// <summary> Advisor name. </summary>
        public string AdvisorName { get; set; }
        /// <summary> Recommendation action session identifier. </summary>
        public string SessionId { get; set; }
        /// <summary> Recommendation action identifier. </summary>
        public int? ActionId { get; set; }
        /// <summary> Recommendation action creation time. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> Recommendation action expiration time. </summary>
        public DateTimeOffset? ExpirationOn { get; set; }
        /// <summary> Recommendation action reason. </summary>
        public string Reason { get; set; }
        /// <summary> Recommendation action type. </summary>
        public string RecommendationType { get; set; }
        /// <summary> Recommendation action details. </summary>
        public IDictionary<string, string> Details { get; }
    }
}
