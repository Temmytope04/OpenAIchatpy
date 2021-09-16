// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Application stack.
    /// </summary>
    public partial class ApplicationStack
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationStack class.
        /// </summary>
        public ApplicationStack()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationStack class.
        /// </summary>
        /// <param name="name">Application stack name.</param>
        /// <param name="display">Application stack display name.</param>
        /// <param name="dependency">Application stack dependency.</param>
        /// <param name="majorVersions">List of major versions
        /// available.</param>
        /// <param name="frameworks">List of frameworks associated with
        /// application stack.</param>
        public ApplicationStack(string name = default(string), string display = default(string), string dependency = default(string), IList<StackMajorVersion> majorVersions = default(IList<StackMajorVersion>), IList<ApplicationStack> frameworks = default(IList<ApplicationStack>))
        {
            Name = name;
            Display = display;
            Dependency = dependency;
            MajorVersions = majorVersions;
            Frameworks = frameworks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets application stack name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets application stack display name.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public string Display { get; set; }

        /// <summary>
        /// Gets or sets application stack dependency.
        /// </summary>
        [JsonProperty(PropertyName = "dependency")]
        public string Dependency { get; set; }

        /// <summary>
        /// Gets or sets list of major versions available.
        /// </summary>
        [JsonProperty(PropertyName = "majorVersions")]
        public IList<StackMajorVersion> MajorVersions { get; set; }

        /// <summary>
        /// Gets or sets list of frameworks associated with application stack.
        /// </summary>
        [JsonProperty(PropertyName = "frameworks")]
        public IList<ApplicationStack> Frameworks { get; set; }

    }
}
