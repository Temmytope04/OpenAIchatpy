// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Datadog.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The definition of a filtering tag. Filtering tags are used for
    /// capturing resources and include/exclude them from being monitored.
    /// </summary>
    public partial class FilteringTag
    {
        /// <summary>
        /// Initializes a new instance of the FilteringTag class.
        /// </summary>
        public FilteringTag()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FilteringTag class.
        /// </summary>
        /// <param name="name">The name (also known as the key) of the
        /// tag.</param>
        /// <param name="value">The value of the tag.</param>
        /// <param name="action">Possible values include: 'Include',
        /// 'Exclude'</param>
        public FilteringTag(string name = default(string), string value = default(string), string action = default(string))
        {
            Name = name;
            Value = value;
            Action = action;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name (also known as the key) of the tag.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the tag.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Include', 'Exclude'
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

    }
}
