// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.WebSites;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An app cloneability criterion.
    /// </summary>
    public partial class SiteCloneabilityCriterion
    {
        /// <summary>
        /// Initializes a new instance of the SiteCloneabilityCriterion class.
        /// </summary>
        public SiteCloneabilityCriterion()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SiteCloneabilityCriterion class.
        /// </summary>
        /// <param name="name">Name of criterion.</param>
        /// <param name="description">Description of criterion.</param>
        public SiteCloneabilityCriterion(string name = default(string), string description = default(string))
        {
            Name = name;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of criterion.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets description of criterion.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
