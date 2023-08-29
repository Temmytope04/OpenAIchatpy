// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The custom resource function definition. </summary>
    public partial class DataManifestCustomResourceFunctionDefinition
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataManifestCustomResourceFunctionDefinition"/>. </summary>
        internal DataManifestCustomResourceFunctionDefinition()
        {
            DefaultProperties = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DataManifestCustomResourceFunctionDefinition"/>. </summary>
        /// <param name="name"> The function name as it will appear in the policy rule. eg - 'vault'. </param>
        /// <param name="fullyQualifiedResourceType"> The fully qualified control plane resource type that this function represents. eg - 'Microsoft.KeyVault/vaults'. </param>
        /// <param name="defaultProperties"> The top-level properties that can be selected on the function's output. eg - [ "name", "location" ] if vault().name and vault().location are supported. </param>
        /// <param name="allowCustomProperties"> A value indicating whether the custom properties within the property bag are allowed. Needs api-version to be specified in the policy rule eg - vault('2019-06-01'). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataManifestCustomResourceFunctionDefinition(string name, ResourceType? fullyQualifiedResourceType, IReadOnlyList<string> defaultProperties, bool? allowCustomProperties, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            FullyQualifiedResourceType = fullyQualifiedResourceType;
            DefaultProperties = defaultProperties;
            AllowCustomProperties = allowCustomProperties;
            _rawData = rawData;
        }

        /// <summary> The function name as it will appear in the policy rule. eg - 'vault'. </summary>
        public string Name { get; }
        /// <summary> The fully qualified control plane resource type that this function represents. eg - 'Microsoft.KeyVault/vaults'. </summary>
        public ResourceType? FullyQualifiedResourceType { get; }
        /// <summary> The top-level properties that can be selected on the function's output. eg - [ "name", "location" ] if vault().name and vault().location are supported. </summary>
        public IReadOnlyList<string> DefaultProperties { get; }
        /// <summary> A value indicating whether the custom properties within the property bag are allowed. Needs api-version to be specified in the policy rule eg - vault('2019-06-01'). </summary>
        public bool? AllowCustomProperties { get; }
    }
}
