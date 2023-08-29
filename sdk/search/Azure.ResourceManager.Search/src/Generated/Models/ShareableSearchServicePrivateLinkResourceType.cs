// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Describes an resource type that has been onboarded to private link service, supported by Azure Cognitive Search. </summary>
    public partial class ShareableSearchServicePrivateLinkResourceType
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ShareableSearchServicePrivateLinkResourceType"/>. </summary>
        internal ShareableSearchServicePrivateLinkResourceType()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ShareableSearchServicePrivateLinkResourceType"/>. </summary>
        /// <param name="name"> The name of the resource type that has been onboarded to private link service, supported by Azure Cognitive Search. </param>
        /// <param name="properties"> Describes the properties of a resource type that has been onboarded to private link service, supported by Azure Cognitive Search. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ShareableSearchServicePrivateLinkResourceType(string name, ShareableSearchServicePrivateLinkResourceProperties properties, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> The name of the resource type that has been onboarded to private link service, supported by Azure Cognitive Search. </summary>
        public string Name { get; }
        /// <summary> Describes the properties of a resource type that has been onboarded to private link service, supported by Azure Cognitive Search. </summary>
        public ShareableSearchServicePrivateLinkResourceProperties Properties { get; }
    }
}
