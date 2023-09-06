// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary>
    /// The format definition of a storage.
    /// Please note <see cref="DatasetStorageFormat"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AvroFormat"/>, <see cref="JsonFormat"/>, <see cref="OrcFormat"/>, <see cref="ParquetFormat"/> and <see cref="TextFormat"/>.
    /// </summary>
    public partial class DatasetStorageFormat
    {
        /// <summary> Initializes a new instance of <see cref="DatasetStorageFormat"/>. </summary>
        public DatasetStorageFormat()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="DatasetStorageFormat"/>. </summary>
        /// <param name="type"> Type of dataset storage format. </param>
        /// <param name="serializer"> Serializer. Type: string (or Expression with resultType string). </param>
        /// <param name="deserializer"> Deserializer. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DatasetStorageFormat(string type, object serializer, object deserializer, IDictionary<string, object> additionalProperties)
        {
            Type = type;
            Serializer = serializer;
            Deserializer = deserializer;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Type of dataset storage format. </summary>
        internal string Type { get; set; }
        /// <summary> Serializer. Type: string (or Expression with resultType string). </summary>
        public object Serializer { get; set; }
        /// <summary> Deserializer. Type: string (or Expression with resultType string). </summary>
        public object Deserializer { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
