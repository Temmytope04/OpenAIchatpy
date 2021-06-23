// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The application resource for patch operations.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationResourceUpdate : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationResourceUpdate class.
        /// </summary>
        public ApplicationResourceUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationResourceUpdate class.
        /// </summary>
        /// <param name="id">Azure resource identifier.</param>
        /// <param name="name">Azure resource name.</param>
        /// <param name="type">Azure resource type.</param>
        /// <param name="location">It will be deprecated in New API, resource
        /// location depends on the parent resource.</param>
        /// <param name="tags">Azure resource tags.</param>
        /// <param name="etag">Azure resource etag.</param>
        /// <param name="minimumNodes">The minimum number of nodes where
        /// Service Fabric will reserve capacity for this application. Note
        /// that this does not mean that the services of this application will
        /// be placed on all of those nodes. If this property is set to zero,
        /// no capacity will be reserved. The value of this property cannot be
        /// more than the value of the MaximumNodes property.</param>
        /// <param name="maximumNodes">The maximum number of nodes where
        /// Service Fabric will reserve capacity for this application. Note
        /// that this does not mean that the services of this application will
        /// be placed on all of those nodes. By default, the value of this
        /// property is zero and it means that the services can be placed on
        /// any node.</param>
        /// <param name="removeApplicationCapacity">Remove the current
        /// application capacity settings.</param>
        /// <param name="managedIdentities">List of user assigned identities
        /// for the application, each mapped to a friendly name.</param>
        public ApplicationResourceUpdate(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), SystemData systemData = default(SystemData), string typeVersion = default(string), IDictionary<string, string> parameters = default(IDictionary<string, string>), ApplicationUpgradePolicy upgradePolicy = default(ApplicationUpgradePolicy), long? minimumNodes = default(long?), long? maximumNodes = default(long?), bool? removeApplicationCapacity = default(bool?), IList<ApplicationMetricDescription> metrics = default(IList<ApplicationMetricDescription>), IList<ApplicationUserAssignedIdentity> managedIdentities = default(IList<ApplicationUserAssignedIdentity>))
            : base(id, name, type, location, tags, etag, systemData)
        {
            TypeVersion = typeVersion;
            Parameters = parameters;
            UpgradePolicy = upgradePolicy;
            MinimumNodes = minimumNodes;
            MaximumNodes = maximumNodes;
            RemoveApplicationCapacity = removeApplicationCapacity;
            Metrics = metrics;
            ManagedIdentities = managedIdentities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.typeVersion")]
        public string TypeVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.upgradePolicy")]
        public ApplicationUpgradePolicy UpgradePolicy { get; set; }

        /// <summary>
        /// Gets or sets the minimum number of nodes where Service Fabric will
        /// reserve capacity for this application. Note that this does not mean
        /// that the services of this application will be placed on all of
        /// those nodes. If this property is set to zero, no capacity will be
        /// reserved. The value of this property cannot be more than the value
        /// of the MaximumNodes property.
        /// </summary>
        [JsonProperty(PropertyName = "properties.minimumNodes")]
        public long? MinimumNodes { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of nodes where Service Fabric will
        /// reserve capacity for this application. Note that this does not mean
        /// that the services of this application will be placed on all of
        /// those nodes. By default, the value of this property is zero and it
        /// means that the services can be placed on any node.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maximumNodes")]
        public long? MaximumNodes { get; set; }

        /// <summary>
        /// Gets or sets remove the current application capacity settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.removeApplicationCapacity")]
        public bool? RemoveApplicationCapacity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.metrics")]
        public IList<ApplicationMetricDescription> Metrics { get; set; }

        /// <summary>
        /// Gets or sets list of user assigned identities for the application,
        /// each mapped to a friendly name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedIdentities")]
        public IList<ApplicationUserAssignedIdentity> ManagedIdentities { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UpgradePolicy != null)
            {
                UpgradePolicy.Validate();
            }
            if (MinimumNodes < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MinimumNodes", 0);
            }
            if (MaximumNodes < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaximumNodes", 0);
            }
            if (ManagedIdentities != null)
            {
                foreach (var element in ManagedIdentities)
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
