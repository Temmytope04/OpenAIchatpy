// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Describes a supported private link resource for the Azure Cognitive Search service. </summary>
    public partial class SearchPrivateLinkResource : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SearchPrivateLinkResource"/>. </summary>
        public SearchPrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SearchPrivateLinkResource"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Describes the properties of a supported private link resource for the Azure Cognitive Search service. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchPrivateLinkResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SearchPrivateLinkResourceProperties properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Describes the properties of a supported private link resource for the Azure Cognitive Search service. </summary>
        public SearchPrivateLinkResourceProperties Properties { get; }
    }
}
