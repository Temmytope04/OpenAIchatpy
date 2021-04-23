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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The top level Workspace resource container.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class WorkspacePatch : AzureEntityResource
    {
        /// <summary>
        /// Initializes a new instance of the WorkspacePatch class.
        /// </summary>
        public WorkspacePatch()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspacePatch class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="etag">Resource Etag.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// workspace. Possible values include: 'Creating', 'Succeeded',
        /// 'Failed', 'Canceled', 'Deleting', 'ProvisioningAccount',
        /// 'Updating'</param>
        /// <param name="customerId">This is a read-only property. Represents
        /// the ID associated with the workspace.</param>
        /// <param name="sku">The SKU of the workspace.</param>
        /// <param name="retentionInDays">The workspace data retention in days.
        /// Allowed values are per pricing plan. See pricing tiers
        /// documentation for details.</param>
        /// <param name="workspaceCapping">The daily volume cap for
        /// ingestion.</param>
        /// <param name="createdDate">Workspace creation date.</param>
        /// <param name="modifiedDate">Workspace modification date.</param>
        /// <param name="publicNetworkAccessForIngestion">The network access
        /// type for accessing Log Analytics ingestion. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="publicNetworkAccessForQuery">The network access type
        /// for accessing Log Analytics query. Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="forceCmkForQuery">Indicates whether customer managed
        /// storage is mandatory for query management.</param>
        /// <param name="privateLinkScopedResources">List of linked private
        /// link scope resources.</param>
        /// <param name="features">Workspace features.</param>
        /// <param name="tags">Resource tags. Optional.</param>
        public WorkspacePatch(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), string provisioningState = default(string), string customerId = default(string), WorkspaceSku sku = default(WorkspaceSku), int? retentionInDays = default(int?), WorkspaceCapping workspaceCapping = default(WorkspaceCapping), string createdDate = default(string), string modifiedDate = default(string), string publicNetworkAccessForIngestion = default(string), string publicNetworkAccessForQuery = default(string), bool? forceCmkForQuery = default(bool?), IList<PrivateLinkScopedResource> privateLinkScopedResources = default(IList<PrivateLinkScopedResource>), IDictionary<string, object> features = default(IDictionary<string, object>), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(id, name, type, etag)
        {
            ProvisioningState = provisioningState;
            CustomerId = customerId;
            Sku = sku;
            RetentionInDays = retentionInDays;
            WorkspaceCapping = workspaceCapping;
            CreatedDate = createdDate;
            ModifiedDate = modifiedDate;
            PublicNetworkAccessForIngestion = publicNetworkAccessForIngestion;
            PublicNetworkAccessForQuery = publicNetworkAccessForQuery;
            ForceCmkForQuery = forceCmkForQuery;
            PrivateLinkScopedResources = privateLinkScopedResources;
            Features = features;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the provisioning state of the workspace. Possible
        /// values include: 'Creating', 'Succeeded', 'Failed', 'Canceled',
        /// 'Deleting', 'ProvisioningAccount', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets this is a read-only property. Represents the ID associated
        /// with the workspace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customerId")]
        public string CustomerId { get; private set; }

        /// <summary>
        /// Gets or sets the SKU of the workspace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public WorkspaceSku Sku { get; set; }

        /// <summary>
        /// Gets or sets the workspace data retention in days. Allowed values
        /// are per pricing plan. See pricing tiers documentation for details.
        /// </summary>
        [JsonProperty(PropertyName = "properties.retentionInDays")]
        public int? RetentionInDays { get; set; }

        /// <summary>
        /// Gets or sets the daily volume cap for ingestion.
        /// </summary>
        [JsonProperty(PropertyName = "properties.workspaceCapping")]
        public WorkspaceCapping WorkspaceCapping { get; set; }

        /// <summary>
        /// Gets workspace creation date.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDate")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Gets workspace modification date.
        /// </summary>
        [JsonProperty(PropertyName = "properties.modifiedDate")]
        public string ModifiedDate { get; private set; }

        /// <summary>
        /// Gets or sets the network access type for accessing Log Analytics
        /// ingestion. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccessForIngestion")]
        public string PublicNetworkAccessForIngestion { get; set; }

        /// <summary>
        /// Gets or sets the network access type for accessing Log Analytics
        /// query. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccessForQuery")]
        public string PublicNetworkAccessForQuery { get; set; }

        /// <summary>
        /// Gets or sets indicates whether customer managed storage is
        /// mandatory for query management.
        /// </summary>
        [JsonProperty(PropertyName = "properties.forceCmkForQuery")]
        public bool? ForceCmkForQuery { get; set; }

        /// <summary>
        /// Gets list of linked private link scope resources.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateLinkScopedResources")]
        public IList<PrivateLinkScopedResource> PrivateLinkScopedResources { get; private set; }

        /// <summary>
        /// Gets or sets workspace features.
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.features")]
        public IDictionary<string, object> Features { get; set; }

        /// <summary>
        /// Gets or sets resource tags. Optional.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
