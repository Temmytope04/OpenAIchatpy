// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagementGroups.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The details of a management group.
    /// </summary>
    public partial class ManagementGroupDetails
    {
        /// <summary>
        /// Initializes a new instance of the ManagementGroupDetails class.
        /// </summary>
        public ManagementGroupDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagementGroupDetails class.
        /// </summary>
        /// <param name="version">The version number of the object.</param>
        /// <param name="updatedTime">The date and time when this object was
        /// last updated.</param>
        /// <param name="updatedBy">The identity of the principal or process
        /// that updated the object.</param>
        /// <param name="parent">Parent</param>
        /// <param name="path">The path from the root to the current
        /// group.</param>
        /// <param name="managementGroupAncestors">The ancestors of the
        /// management group.</param>
        /// <param name="managementGroupAncestorsChain">The ancestors of the
        /// management group displayed in reversed order, from immediate parent
        /// to the root.</param>
        public ManagementGroupDetails(double? version = default(double?), System.DateTime? updatedTime = default(System.DateTime?), string updatedBy = default(string), ParentGroupInfo parent = default(ParentGroupInfo), IList<ManagementGroupPathElement> path = default(IList<ManagementGroupPathElement>), IList<string> managementGroupAncestors = default(IList<string>), IList<ManagementGroupPathElement> managementGroupAncestorsChain = default(IList<ManagementGroupPathElement>))
        {
            Version = version;
            UpdatedTime = updatedTime;
            UpdatedBy = updatedBy;
            Parent = parent;
            Path = path;
            ManagementGroupAncestors = managementGroupAncestors;
            ManagementGroupAncestorsChain = managementGroupAncestorsChain;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the version number of the object.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public double? Version { get; set; }

        /// <summary>
        /// Gets or sets the date and time when this object was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "updatedTime")]
        public System.DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// Gets or sets the identity of the principal or process that updated
        /// the object.
        /// </summary>
        [JsonProperty(PropertyName = "updatedBy")]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets parent
        /// </summary>
        [JsonProperty(PropertyName = "parent")]
        public ParentGroupInfo Parent { get; set; }

        /// <summary>
        /// Gets or sets the path from the root to the current group.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public IList<ManagementGroupPathElement> Path { get; set; }

        /// <summary>
        /// Gets or sets the ancestors of the management group.
        /// </summary>
        [JsonProperty(PropertyName = "managementGroupAncestors")]
        public IList<string> ManagementGroupAncestors { get; set; }

        /// <summary>
        /// Gets or sets the ancestors of the management group displayed in
        /// reversed order, from immediate parent to the root.
        /// </summary>
        [JsonProperty(PropertyName = "managementGroupAncestorsChain")]
        public IList<ManagementGroupPathElement> ManagementGroupAncestorsChain { get; set; }

    }
}
