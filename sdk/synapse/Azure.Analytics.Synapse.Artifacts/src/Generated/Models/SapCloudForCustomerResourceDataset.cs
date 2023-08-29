// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The path of the SAP Cloud for Customer OData entity. </summary>
    public partial class SapCloudForCustomerResourceDataset : Dataset
    {
        /// <summary> Initializes a new instance of <see cref="SapCloudForCustomerResourceDataset"/>. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="path"> The path of the SAP Cloud for Customer OData entity. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="path"/> is null. </exception>
        public SapCloudForCustomerResourceDataset(LinkedServiceReference linkedServiceName, object path) : base(linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));
            Argument.AssertNotNull(path, nameof(path));

            Path = path;
            Type = "SapCloudForCustomerResource";
        }

        /// <summary> Initializes a new instance of <see cref="SapCloudForCustomerResourceDataset"/>. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="path"> The path of the SAP Cloud for Customer OData entity. Type: string (or Expression with resultType string). </param>
        internal SapCloudForCustomerResourceDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, object path) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            Path = path;
            Type = type ?? "SapCloudForCustomerResource";
        }

        /// <summary> Initializes a new instance of <see cref="SapCloudForCustomerResourceDataset"/> for deserialization. </summary>
        internal SapCloudForCustomerResourceDataset()
        {
        }

        /// <summary> The path of the SAP Cloud for Customer OData entity. Type: string (or Expression with resultType string). </summary>
        public object Path { get; set; }
    }
}
