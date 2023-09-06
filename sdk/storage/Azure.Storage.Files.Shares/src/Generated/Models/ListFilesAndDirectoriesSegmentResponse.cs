// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> An enumeration of directories and files. </summary>
    internal partial class ListFilesAndDirectoriesSegmentResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ListFilesAndDirectoriesSegmentResponse"/>. </summary>
        /// <param name="serviceEndpoint"></param>
        /// <param name="shareName"></param>
        /// <param name="directoryPath"></param>
        /// <param name="prefix"></param>
        /// <param name="segment"> Abstract for entries that can be listed from Directory. </param>
        /// <param name="nextMarker"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpoint"/>, <paramref name="shareName"/>, <paramref name="directoryPath"/>, <paramref name="prefix"/>, <paramref name="segment"/> or <paramref name="nextMarker"/> is null. </exception>
        internal ListFilesAndDirectoriesSegmentResponse(string serviceEndpoint, string shareName, string directoryPath, StringEncoded prefix, FilesAndDirectoriesListSegment segment, string nextMarker)
        {
            Argument.AssertNotNull(serviceEndpoint, nameof(serviceEndpoint));
            Argument.AssertNotNull(shareName, nameof(shareName));
            Argument.AssertNotNull(directoryPath, nameof(directoryPath));
            Argument.AssertNotNull(prefix, nameof(prefix));
            Argument.AssertNotNull(segment, nameof(segment));
            Argument.AssertNotNull(nextMarker, nameof(nextMarker));

            ServiceEndpoint = serviceEndpoint;
            ShareName = shareName;
            DirectoryPath = directoryPath;
            Prefix = prefix;
            Segment = segment;
            NextMarker = nextMarker;
        }

        /// <summary> Initializes a new instance of <see cref="ListFilesAndDirectoriesSegmentResponse"/>. </summary>
        /// <param name="serviceEndpoint"></param>
        /// <param name="shareName"></param>
        /// <param name="shareSnapshot"></param>
        /// <param name="encoded"></param>
        /// <param name="directoryPath"></param>
        /// <param name="prefix"></param>
        /// <param name="marker"></param>
        /// <param name="maxResults"></param>
        /// <param name="segment"> Abstract for entries that can be listed from Directory. </param>
        /// <param name="nextMarker"></param>
        /// <param name="directoryId"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ListFilesAndDirectoriesSegmentResponse(string serviceEndpoint, string shareName, string shareSnapshot, bool? encoded, string directoryPath, StringEncoded prefix, string marker, int? maxResults, FilesAndDirectoriesListSegment segment, string nextMarker, string directoryId, Dictionary<string, BinaryData> rawData)
        {
            ServiceEndpoint = serviceEndpoint;
            ShareName = shareName;
            ShareSnapshot = shareSnapshot;
            Encoded = encoded;
            DirectoryPath = directoryPath;
            Prefix = prefix;
            Marker = marker;
            MaxResults = maxResults;
            Segment = segment;
            NextMarker = nextMarker;
            DirectoryId = directoryId;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ListFilesAndDirectoriesSegmentResponse"/> for deserialization. </summary>
        internal ListFilesAndDirectoriesSegmentResponse()
        {
        }

        /// <summary> Gets the service endpoint. </summary>
        public string ServiceEndpoint { get; }
        /// <summary> Gets the share name. </summary>
        public string ShareName { get; }
        /// <summary> Gets the share snapshot. </summary>
        public string ShareSnapshot { get; }
        /// <summary> Gets the encoded. </summary>
        public bool? Encoded { get; }
        /// <summary> Gets the directory path. </summary>
        public string DirectoryPath { get; }
        /// <summary> Gets the prefix. </summary>
        public StringEncoded Prefix { get; }
        /// <summary> Gets the marker. </summary>
        public string Marker { get; }
        /// <summary> Gets the max results. </summary>
        public int? MaxResults { get; }
        /// <summary> Abstract for entries that can be listed from Directory. </summary>
        public FilesAndDirectoriesListSegment Segment { get; }
        /// <summary> Gets the next marker. </summary>
        public string NextMarker { get; }
        /// <summary> Gets the directory id. </summary>
        public string DirectoryId { get; }
    }
}
