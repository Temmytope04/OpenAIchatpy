// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A project resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Project : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Project class.
        /// </summary>
        public Project()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Project class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="sourcePlatform">Source platform for the project.
        /// Possible values include: 'SQL', 'Unknown'</param>
        /// <param name="targetPlatform">Target platform for the project.
        /// Possible values include: 'SQLDB', 'Unknown'</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="creationTime">UTC Date and time when project was
        /// created</param>
        /// <param name="sourceConnectionInfo">Information for connecting to
        /// source</param>
        /// <param name="targetConnectionInfo">Information for connecting to
        /// target</param>
        /// <param name="databasesInfo">List of DatabaseInfo</param>
        /// <param name="provisioningState">The project's provisioning state.
        /// Possible values include: 'Deleting', 'Succeeded'</param>
        public Project(string location, ProjectSourcePlatform sourcePlatform, ProjectTargetPlatform targetPlatform, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), System.DateTimeOffset? creationTime = default(System.DateTimeOffset?), ConnectionInfo sourceConnectionInfo = default(ConnectionInfo), ConnectionInfo targetConnectionInfo = default(ConnectionInfo), IList<DatabaseInfo> databasesInfo = default(IList<DatabaseInfo>), ProjectProvisioningState? provisioningState = default(ProjectProvisioningState?))
            : base(location, id, name, type, tags)
        {
            SourcePlatform = sourcePlatform;
            TargetPlatform = targetPlatform;
            CreationTime = creationTime;
            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
            DatabasesInfo = databasesInfo;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets source platform for the project. Possible values
        /// include: 'SQL', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourcePlatform")]
        public ProjectSourcePlatform SourcePlatform { get; set; }

        /// <summary>
        /// Gets or sets target platform for the project. Possible values
        /// include: 'SQLDB', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetPlatform")]
        public ProjectTargetPlatform TargetPlatform { get; set; }

        /// <summary>
        /// Gets UTC Date and time when project was created
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTimeOffset? CreationTime { get; private set; }

        /// <summary>
        /// Gets or sets information for connecting to source
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceConnectionInfo")]
        public ConnectionInfo SourceConnectionInfo { get; set; }

        /// <summary>
        /// Gets or sets information for connecting to target
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetConnectionInfo")]
        public ConnectionInfo TargetConnectionInfo { get; set; }

        /// <summary>
        /// Gets or sets list of DatabaseInfo
        /// </summary>
        [JsonProperty(PropertyName = "properties.databasesInfo")]
        public IList<DatabaseInfo> DatabasesInfo { get; set; }

        /// <summary>
        /// Gets the project's provisioning state. Possible values include:
        /// 'Deleting', 'Succeeded'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProjectProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (DatabasesInfo != null)
            {
                foreach (var element in DatabasesInfo)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
