// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Post Backup Response. </summary>
    public partial class CloudEndpointPostBackupResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CloudEndpointPostBackupResult"/>. </summary>
        internal CloudEndpointPostBackupResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudEndpointPostBackupResult"/>. </summary>
        /// <param name="cloudEndpointName"> cloud endpoint Name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudEndpointPostBackupResult(string cloudEndpointName, Dictionary<string, BinaryData> rawData)
        {
            CloudEndpointName = cloudEndpointName;
            _rawData = rawData;
        }

        /// <summary> cloud endpoint Name. </summary>
        public string CloudEndpointName { get; }
    }
}
