// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Application logs to Azure table storage configuration. </summary>
    public partial class AppServiceTableStorageApplicationLogsConfig
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceTableStorageApplicationLogsConfig"/>. </summary>
        /// <param name="sasUriString"> SAS URL to an Azure table with add/query/delete permissions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sasUriString"/> is null. </exception>
        public AppServiceTableStorageApplicationLogsConfig(string sasUriString)
        {
            Argument.AssertNotNull(sasUriString, nameof(sasUriString));

            SasUriString = sasUriString;
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceTableStorageApplicationLogsConfig"/>. </summary>
        /// <param name="level"> Log level. </param>
        /// <param name="sasUriString"> SAS URL to an Azure table with add/query/delete permissions. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceTableStorageApplicationLogsConfig(WebAppLogLevel? level, string sasUriString, Dictionary<string, BinaryData> rawData)
        {
            Level = level;
            SasUriString = sasUriString;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceTableStorageApplicationLogsConfig"/> for deserialization. </summary>
        internal AppServiceTableStorageApplicationLogsConfig()
        {
        }

        /// <summary> Log level. </summary>
        public WebAppLogLevel? Level { get; set; }
        /// <summary> SAS URL to an Azure table with add/query/delete permissions. </summary>
        public string SasUriString { get; set; }
    }
}
