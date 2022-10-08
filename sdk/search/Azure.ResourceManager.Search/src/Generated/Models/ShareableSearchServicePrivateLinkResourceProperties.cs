// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Describes the properties of a resource type that has been onboarded to private link service, supported by Azure Cognitive Search. </summary>
    public partial class ShareableSearchServicePrivateLinkResourceProperties
    {
        /// <summary> Initializes a new instance of ShareableSearchServicePrivateLinkResourceProperties. </summary>
        internal ShareableSearchServicePrivateLinkResourceProperties()
        {
        }

        /// <summary> Initializes a new instance of ShareableSearchServicePrivateLinkResourceProperties. </summary>
        /// <param name="shareablePrivateLinkResourcePropertiesType"> The resource provider type for the resource that has been onboarded to private link service, supported by Azure Cognitive Search. </param>
        /// <param name="groupId"> The resource provider group id for the resource that has been onboarded to private link service, supported by Azure Cognitive Search. </param>
        /// <param name="description"> The description of the resource type that has been onboarded to private link service, supported by Azure Cognitive Search. </param>
        internal ShareableSearchServicePrivateLinkResourceProperties(string shareablePrivateLinkResourcePropertiesType, string groupId, string description)
        {
            ShareablePrivateLinkResourcePropertiesType = shareablePrivateLinkResourcePropertiesType;
            GroupId = groupId;
            Description = description;
        }

        /// <summary> The resource provider type for the resource that has been onboarded to private link service, supported by Azure Cognitive Search. </summary>
        public string ShareablePrivateLinkResourcePropertiesType { get; }
        /// <summary> The resource provider group id for the resource that has been onboarded to private link service, supported by Azure Cognitive Search. </summary>
        public string GroupId { get; }
        /// <summary> The description of the resource type that has been onboarded to private link service, supported by Azure Cognitive Search. </summary>
        public string Description { get; }
    }
}
