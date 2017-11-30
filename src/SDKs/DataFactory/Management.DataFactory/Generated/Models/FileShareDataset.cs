// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An on-premises file system dataset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("FileShare")]
    [Rest.Serialization.JsonTransformation]
    public partial class FileShareDataset : Dataset
    {
        /// <summary>
        /// Initializes a new instance of the FileShareDataset class.
        /// </summary>
        public FileShareDataset()
        {
            LinkedServiceName = new LinkedServiceReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileShareDataset class.
        /// </summary>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Dataset description.</param>
        /// <param name="structure">Columns that define the structure of the
        /// dataset. Type: array (or Expression with resultType array),
        /// itemType: DatasetDataElement.</param>
        /// <param name="parameters">Parameters for dataset.</param>
        /// <param name="folderPath">The path of the on-premises file system.
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="fileName">The name of the on-premises file system.
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="format">The format of the files.</param>
        /// <param name="fileFilter">Specify a filter to be used to select a
        /// subset of files in the folderPath rather than all files. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="compression">The data compression method used for the
        /// file system.</param>
        public FileShareDataset(LinkedServiceReference linkedServiceName, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), object structure = default(object), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), object folderPath = default(object), object fileName = default(object), DatasetStorageFormat format = default(DatasetStorageFormat), object fileFilter = default(object), DatasetCompression compression = default(DatasetCompression))
            : base(linkedServiceName, additionalProperties, description, structure, parameters)
        {
            FolderPath = folderPath;
            FileName = fileName;
            Format = format;
            FileFilter = fileFilter;
            Compression = compression;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the path of the on-premises file system. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.folderPath")]
        public object FolderPath { get; set; }

        /// <summary>
        /// Gets or sets the name of the on-premises file system. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.fileName")]
        public object FileName { get; set; }

        /// <summary>
        /// Gets or sets the format of the files.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.format")]
        public DatasetStorageFormat Format { get; set; }

        /// <summary>
        /// Gets or sets specify a filter to be used to select a subset of
        /// files in the folderPath rather than all files. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.fileFilter")]
        public object FileFilter { get; set; }

        /// <summary>
        /// Gets or sets the data compression method used for the file system.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.compression")]
        public DatasetCompression Compression { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
