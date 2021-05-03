// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The list of Log Analytics workspaces associated with the cluster.
    /// </summary>
    public partial class AssociatedWorkspace
    {
        /// <summary>
        /// Initializes a new instance of the AssociatedWorkspace class.
        /// </summary>
        public AssociatedWorkspace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AssociatedWorkspace class.
        /// </summary>
        /// <param name="workspaceId">The id of the assigned workspace.</param>
        /// <param name="workspaceName">The name id the assigned
        /// workspace.</param>
        /// <param name="resourceId">The ResourceId id the assigned
        /// workspace.</param>
        /// <param name="associateDate">The time of workspace
        /// association.</param>
        public AssociatedWorkspace(string workspaceId = default(string), string workspaceName = default(string), string resourceId = default(string), string associateDate = default(string))
        {
            WorkspaceId = workspaceId;
            WorkspaceName = workspaceName;
            ResourceId = resourceId;
            AssociateDate = associateDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the id of the assigned workspace.
        /// </summary>
        [JsonProperty(PropertyName = "workspaceId")]
        public string WorkspaceId { get; private set; }

        /// <summary>
        /// Gets the name id the assigned workspace.
        /// </summary>
        [JsonProperty(PropertyName = "workspaceName")]
        public string WorkspaceName { get; private set; }

        /// <summary>
        /// Gets the ResourceId id the assigned workspace.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; private set; }

        /// <summary>
        /// Gets the time of workspace association.
        /// </summary>
        [JsonProperty(PropertyName = "associateDate")]
        public string AssociateDate { get; private set; }

    }
}
