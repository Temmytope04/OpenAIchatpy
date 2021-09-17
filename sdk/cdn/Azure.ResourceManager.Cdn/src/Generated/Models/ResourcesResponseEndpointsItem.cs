// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The ResourcesResponseEndpointsItem. </summary>
    public partial class ResourcesResponseEndpointsItem : SubResource
    {
        /// <summary> Initializes a new instance of ResourcesResponseEndpointsItem. </summary>
        internal ResourcesResponseEndpointsItem()
        {
            CustomDomains = new ChangeTrackingList<ResourcesResponseEndpointsPropertiesItemsItem>();
        }

        /// <summary> Initializes a new instance of ResourcesResponseEndpointsItem. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"></param>
        /// <param name="history"></param>
        /// <param name="customDomains"></param>
        internal ResourcesResponseEndpointsItem(string id, string name, bool? history, IReadOnlyList<ResourcesResponseEndpointsPropertiesItemsItem> customDomains) : base(id)
        {
            Name = name;
            History = history;
            CustomDomains = customDomains;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the history. </summary>
        public bool? History { get; }
        /// <summary> Gets the custom domains. </summary>
        public IReadOnlyList<ResourcesResponseEndpointsPropertiesItemsItem> CustomDomains { get; }
    }
}
