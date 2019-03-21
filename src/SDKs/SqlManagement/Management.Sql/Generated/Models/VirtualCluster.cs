// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure SQL virtual cluster.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualCluster : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualCluster class.
        /// </summary>
        public VirtualCluster()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualCluster class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="subnetId">Subnet resource ID for the virtual
        /// cluster.</param>
        /// <param name="family">If the service has different generations of
        /// hardware, for the same SKU, then that can be captured here.</param>
        /// <param name="childResources">List of resources in this virtual
        /// cluster.</param>
        public VirtualCluster(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string subnetId = default(string), string family = default(string), IList<string> childResources = default(IList<string>))
            : base(location, id, name, type, tags)
        {
            SubnetId = subnetId;
            Family = family;
            ChildResources = childResources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets subnet resource ID for the virtual cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnetId")]
        public string SubnetId { get; private set; }

        /// <summary>
        /// Gets or sets if the service has different generations of hardware,
        /// for the same SKU, then that can be captured here.
        /// </summary>
        [JsonProperty(PropertyName = "properties.family")]
        public string Family { get; set; }

        /// <summary>
        /// Gets list of resources in this virtual cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.childResources")]
        public IList<string> ChildResources { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
