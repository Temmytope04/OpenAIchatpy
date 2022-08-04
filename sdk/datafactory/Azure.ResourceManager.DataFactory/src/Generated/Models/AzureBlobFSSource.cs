// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity Azure BlobFS source. </summary>
    public partial class AzureBlobFSSource : CopyActivitySource
    {
        /// <summary> Initializes a new instance of AzureBlobFSSource. </summary>
        public AzureBlobFSSource()
        {
            CopySourceType = "AzureBlobFSSource";
        }

        /// <summary> Initializes a new instance of AzureBlobFSSource. </summary>
        /// <param name="copySourceType"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="treatEmptyAsNull"> Treat empty as null. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="skipHeaderLineCount"> Number of header lines to skip from each blob. Type: integer (or Expression with resultType integer). </param>
        /// <param name="recursive"> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </param>
        internal AzureBlobFSSource(string copySourceType, BinaryData sourceRetryCount, BinaryData sourceRetryWait, BinaryData maxConcurrentConnections, BinaryData disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, BinaryData treatEmptyAsNull, BinaryData skipHeaderLineCount, BinaryData recursive) : base(copySourceType, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            TreatEmptyAsNull = treatEmptyAsNull;
            SkipHeaderLineCount = skipHeaderLineCount;
            Recursive = recursive;
            CopySourceType = copySourceType ?? "AzureBlobFSSource";
        }

        /// <summary> Treat empty as null. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData TreatEmptyAsNull { get; set; }
        /// <summary> Number of header lines to skip from each blob. Type: integer (or Expression with resultType integer). </summary>
        public BinaryData SkipHeaderLineCount { get; set; }
        /// <summary> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData Recursive { get; set; }
    }
}
