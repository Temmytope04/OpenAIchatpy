// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Configuration group schema properties. </summary>
    public partial class ConfigurationGroupSchemaPropertiesFormat
    {
        /// <summary> Initializes a new instance of ConfigurationGroupSchemaPropertiesFormat. </summary>
        public ConfigurationGroupSchemaPropertiesFormat()
        {
        }

        /// <summary> Initializes a new instance of ConfigurationGroupSchemaPropertiesFormat. </summary>
        /// <param name="provisioningState"> The provisioning state of the Configuration group schema resource. </param>
        /// <param name="versionState"> The configuration group schema version state. </param>
        /// <param name="description"> Description of what schema can contain. </param>
        /// <param name="schemaDefinition"> Name and value pairs that define the configuration value. It can be a well formed escaped JSON string. </param>
        internal ConfigurationGroupSchemaPropertiesFormat(ProvisioningState? provisioningState, VersionState? versionState, string description, string schemaDefinition)
        {
            ProvisioningState = provisioningState;
            VersionState = versionState;
            Description = description;
            SchemaDefinition = schemaDefinition;
        }

        /// <summary> The provisioning state of the Configuration group schema resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The configuration group schema version state. </summary>
        public VersionState? VersionState { get; }
        /// <summary> Description of what schema can contain. </summary>
        public string Description { get; set; }
        /// <summary> Name and value pairs that define the configuration value. It can be a well formed escaped JSON string. </summary>
        public string SchemaDefinition { get; set; }
    }
}
