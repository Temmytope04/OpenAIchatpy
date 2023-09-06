// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Http logs to azure blob storage configuration. </summary>
    public partial class AppServiceBlobStorageHttpLogsConfig
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceBlobStorageHttpLogsConfig"/>. </summary>
        public AppServiceBlobStorageHttpLogsConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceBlobStorageHttpLogsConfig"/>. </summary>
        /// <param name="sasUri"> SAS url to a azure blob container with read/write/list/delete permissions. </param>
        /// <param name="retentionInDays">
        /// Retention in days.
        /// Remove blobs older than X days.
        /// 0 or lower means no retention.
        /// </param>
        /// <param name="isEnabled"> True if configuration is enabled, false if it is disabled and null if configuration is not set. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceBlobStorageHttpLogsConfig(Uri sasUri, int? retentionInDays, bool? isEnabled, Dictionary<string, BinaryData> rawData)
        {
            SasUri = sasUri;
            RetentionInDays = retentionInDays;
            IsEnabled = isEnabled;
            _rawData = rawData;
        }

        /// <summary> SAS url to a azure blob container with read/write/list/delete permissions. </summary>
        public Uri SasUri { get; set; }
        /// <summary>
        /// Retention in days.
        /// Remove blobs older than X days.
        /// 0 or lower means no retention.
        /// </summary>
        public int? RetentionInDays { get; set; }
        /// <summary> True if configuration is enabled, false if it is disabled and null if configuration is not set. </summary>
        public bool? IsEnabled { get; set; }
    }
}
