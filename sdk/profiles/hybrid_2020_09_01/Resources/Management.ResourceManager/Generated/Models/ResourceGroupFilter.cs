// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Resource group filter.
    /// </summary>
    public partial class ResourceGroupFilter
    {
        /// <summary>
        /// Initializes a new instance of the ResourceGroupFilter class.
        /// </summary>
        public ResourceGroupFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceGroupFilter class.
        /// </summary>
        /// <param name="tagName">The tag name.</param>
        /// <param name="tagValue">The tag value.</param>
        public ResourceGroupFilter(string tagName = default(string), string tagValue = default(string))
        {
            TagName = tagName;
            TagValue = tagValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the tag name.
        /// </summary>
        [JsonProperty(PropertyName = "tagName")]
        public string TagName { get; set; }

        /// <summary>
        /// Gets or sets the tag value.
        /// </summary>
        [JsonProperty(PropertyName = "tagValue")]
        public string TagValue { get; set; }

    }
}
