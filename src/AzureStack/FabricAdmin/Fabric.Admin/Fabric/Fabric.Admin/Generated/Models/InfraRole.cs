// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Management.Fabric.Admin.Models
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Management;
    using Microsoft.AzureStack.Management.Fabric;
    using Microsoft.AzureStack.Management.Fabric.Admin;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Get an infra role description.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class InfraRole : Resource
    {
        /// <summary>
        /// Initializes a new instance of the InfraRole class.
        /// </summary>
        public InfraRole()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InfraRole class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Region Location of resource.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="instances">List of infra role instances.</param>
        public InfraRole(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<string> instances = default(IList<string>))
            : base(id, name, type, location, tags)
        {
            Instances = instances;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of infra role instances.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instances")]
        public IList<string> Instances { get; set; }

    }
}
