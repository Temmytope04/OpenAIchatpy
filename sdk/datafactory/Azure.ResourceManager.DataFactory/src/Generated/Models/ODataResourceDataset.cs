// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The Open Data Protocol (OData) resource dataset. </summary>
    public partial class ODataResourceDataset : DataFactoryDatasetProperties
    {
        /// <summary> Initializes a new instance of <see cref="ODataResourceDataset"/>. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public ODataResourceDataset(DataFactoryLinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            DatasetType = "ODataResource";
        }

        /// <summary> Initializes a new instance of <see cref="ODataResourceDataset"/>. </summary>
        /// <param name="datasetType"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="path"> The OData resource path. Type: string (or Expression with resultType string). </param>
        internal ODataResourceDataset(string datasetType, string description, DataFactoryElement<IList<DatasetDataElement>> structure, DataFactoryElement<IList<DatasetSchemaDataElement>> schema, DataFactoryLinkedServiceReference linkedServiceName, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, DatasetFolder folder, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> path) : base(datasetType, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            Path = path;
            DatasetType = datasetType ?? "ODataResource";
        }

        /// <summary> Initializes a new instance of <see cref="ODataResourceDataset"/> for deserialization. </summary>
        internal ODataResourceDataset()
        {
        }

        /// <summary> The OData resource path. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Path { get; set; }
    }
}
