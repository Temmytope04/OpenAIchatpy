// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A list of SSIS object metadata. </summary>
    internal partial class SynapseSsisObjectMetadataListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseSsisObjectMetadataListResult"/>. </summary>
        internal SynapseSsisObjectMetadataListResult()
        {
            Value = new ChangeTrackingList<SynapseSsisObjectMetadata>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseSsisObjectMetadataListResult"/>. </summary>
        /// <param name="value">
        /// List of SSIS object metadata.
        /// Please note <see cref="SynapseSsisObjectMetadata"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseSsisEnvironment"/>, <see cref="SynapseSsisFolder"/>, <see cref="SynapseSsisPackage"/> and <see cref="SynapseSsisProject"/>.
        /// </param>
        /// <param name="nextLink"> The link to the next page of results, if any remaining results exist. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseSsisObjectMetadataListResult(IReadOnlyList<SynapseSsisObjectMetadata> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary>
        /// List of SSIS object metadata.
        /// Please note <see cref="SynapseSsisObjectMetadata"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseSsisEnvironment"/>, <see cref="SynapseSsisFolder"/>, <see cref="SynapseSsisPackage"/> and <see cref="SynapseSsisProject"/>.
        /// </summary>
        public IReadOnlyList<SynapseSsisObjectMetadata> Value { get; }
        /// <summary> The link to the next page of results, if any remaining results exist. </summary>
        public string NextLink { get; }
    }
}
