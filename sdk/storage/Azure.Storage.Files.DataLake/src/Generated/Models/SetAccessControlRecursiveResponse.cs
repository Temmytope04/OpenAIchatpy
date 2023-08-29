// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Files.DataLake.Models
{
    /// <summary> The SetAccessControlRecursiveResponse. </summary>
    internal partial class SetAccessControlRecursiveResponse
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SetAccessControlRecursiveResponse"/>. </summary>
        internal SetAccessControlRecursiveResponse()
        {
            FailedEntries = new ChangeTrackingList<AclFailedEntry>();
        }

        /// <summary> Initializes a new instance of <see cref="SetAccessControlRecursiveResponse"/>. </summary>
        /// <param name="directoriesSuccessful"></param>
        /// <param name="filesSuccessful"></param>
        /// <param name="failureCount"></param>
        /// <param name="failedEntries"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SetAccessControlRecursiveResponse(int? directoriesSuccessful, int? filesSuccessful, int? failureCount, IReadOnlyList<AclFailedEntry> failedEntries, Dictionary<string, BinaryData> rawData)
        {
            DirectoriesSuccessful = directoriesSuccessful;
            FilesSuccessful = filesSuccessful;
            FailureCount = failureCount;
            FailedEntries = failedEntries;
            _rawData = rawData;
        }
    }
}
