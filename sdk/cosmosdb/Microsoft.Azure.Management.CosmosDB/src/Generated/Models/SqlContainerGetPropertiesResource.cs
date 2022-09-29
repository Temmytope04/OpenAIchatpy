// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SqlContainerGetPropertiesResource
    {
        /// <summary>
        /// Initializes a new instance of the SqlContainerGetPropertiesResource
        /// class.
        /// </summary>
        public SqlContainerGetPropertiesResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlContainerGetPropertiesResource
        /// class.
        /// </summary>
        /// <param name="id">Name of the Cosmos DB SQL container</param>
        /// <param name="indexingPolicy">The configuration of the indexing
        /// policy. By default, the indexing is automatic for all document
        /// paths within the container</param>
        /// <param name="partitionKey">The configuration of the partition key
        /// to be used for partitioning data into multiple partitions</param>
        /// <param name="defaultTtl">Default time to live</param>
        /// <param name="uniqueKeyPolicy">The unique key policy configuration
        /// for specifying uniqueness constraints on documents in the
        /// collection in the Azure Cosmos DB service.</param>
        /// <param name="conflictResolutionPolicy">The conflict resolution
        /// policy for the container.</param>
        /// <param name="clientEncryptionPolicy">The client encryption policy
        /// for the container.</param>
        /// <param name="analyticalStorageTtl">Analytical TTL.</param>
        /// <param name="restoreParameters">Parameters to indicate the
        /// information about the restore</param>
        /// <param name="createMode">Enum to indicate the mode of resource
        /// creation. Possible values include: 'Default', 'Restore'</param>
        /// <param name="_rid">A system generated property. A unique
        /// identifier.</param>
        /// <param name="_ts">A system generated property that denotes the last
        /// updated timestamp of the resource.</param>
        /// <param name="_etag">A system generated property representing the
        /// resource etag required for optimistic concurrency control.</param>
        public SqlContainerGetPropertiesResource(string id, IndexingPolicy indexingPolicy = default(IndexingPolicy), ContainerPartitionKey partitionKey = default(ContainerPartitionKey), int? defaultTtl = default(int?), UniqueKeyPolicy uniqueKeyPolicy = default(UniqueKeyPolicy), ConflictResolutionPolicy conflictResolutionPolicy = default(ConflictResolutionPolicy), ClientEncryptionPolicy clientEncryptionPolicy = default(ClientEncryptionPolicy), long? analyticalStorageTtl = default(long?), ResourceRestoreParameters restoreParameters = default(ResourceRestoreParameters), string createMode = default(string), string _rid = default(string), double? _ts = default(double?), string _etag = default(string))
        {
            Id = id;
            IndexingPolicy = indexingPolicy;
            PartitionKey = partitionKey;
            DefaultTtl = defaultTtl;
            UniqueKeyPolicy = uniqueKeyPolicy;
            ConflictResolutionPolicy = conflictResolutionPolicy;
            ClientEncryptionPolicy = clientEncryptionPolicy;
            AnalyticalStorageTtl = analyticalStorageTtl;
            RestoreParameters = restoreParameters;
            CreateMode = createMode;
            this._rid = _rid;
            this._ts = _ts;
            this._etag = _etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Cosmos DB SQL container
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the configuration of the indexing policy. By default,
        /// the indexing is automatic for all document paths within the
        /// container
        /// </summary>
        [JsonProperty(PropertyName = "indexingPolicy")]
        public IndexingPolicy IndexingPolicy { get; set; }

        /// <summary>
        /// Gets or sets the configuration of the partition key to be used for
        /// partitioning data into multiple partitions
        /// </summary>
        [JsonProperty(PropertyName = "partitionKey")]
        public ContainerPartitionKey PartitionKey { get; set; }

        /// <summary>
        /// Gets or sets default time to live
        /// </summary>
        [JsonProperty(PropertyName = "defaultTtl")]
        public int? DefaultTtl { get; set; }

        /// <summary>
        /// Gets or sets the unique key policy configuration for specifying
        /// uniqueness constraints on documents in the collection in the Azure
        /// Cosmos DB service.
        /// </summary>
        [JsonProperty(PropertyName = "uniqueKeyPolicy")]
        public UniqueKeyPolicy UniqueKeyPolicy { get; set; }

        /// <summary>
        /// Gets or sets the conflict resolution policy for the container.
        /// </summary>
        [JsonProperty(PropertyName = "conflictResolutionPolicy")]
        public ConflictResolutionPolicy ConflictResolutionPolicy { get; set; }

        /// <summary>
        /// Gets or sets the client encryption policy for the container.
        /// </summary>
        [JsonProperty(PropertyName = "clientEncryptionPolicy")]
        public ClientEncryptionPolicy ClientEncryptionPolicy { get; set; }

        /// <summary>
        /// Gets or sets analytical TTL.
        /// </summary>
        [JsonProperty(PropertyName = "analyticalStorageTtl")]
        public long? AnalyticalStorageTtl { get; set; }

        /// <summary>
        /// Gets or sets parameters to indicate the information about the
        /// restore
        /// </summary>
        [JsonProperty(PropertyName = "restoreParameters")]
        public ResourceRestoreParameters RestoreParameters { get; set; }

        /// <summary>
        /// Gets or sets enum to indicate the mode of resource creation.
        /// Possible values include: 'Default', 'Restore'
        /// </summary>
        [JsonProperty(PropertyName = "createMode")]
        public string CreateMode { get; set; }

        /// <summary>
        /// Gets a system generated property. A unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "_rid")]
        public string _rid { get; private set; }

        /// <summary>
        /// Gets a system generated property that denotes the last updated
        /// timestamp of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "_ts")]
        public double? _ts { get; private set; }

        /// <summary>
        /// Gets a system generated property representing the resource etag
        /// required for optimistic concurrency control.
        /// </summary>
        [JsonProperty(PropertyName = "_etag")]
        public string _etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (PartitionKey != null)
            {
                PartitionKey.Validate();
            }
            if (ClientEncryptionPolicy != null)
            {
                ClientEncryptionPolicy.Validate();
            }
        }
    }
}
