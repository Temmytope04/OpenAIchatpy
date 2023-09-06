// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> Storage Service Properties. </summary>
    public partial class BlobServiceProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BlobServiceProperties"/>. </summary>
        /// <param name="logging"> Azure Analytics Logging settings. </param>
        /// <param name="hourMetrics"> a summary of request statistics grouped by API in hour or minute aggregates for blobs. </param>
        /// <param name="minuteMetrics"> a summary of request statistics grouped by API in hour or minute aggregates for blobs. </param>
        /// <param name="cors"> The set of CORS rules. </param>
        /// <param name="defaultServiceVersion"> The default version to use for requests to the Blob service if an incoming request's version is not specified. Possible values include version 2008-10-27 and all more recent versions. </param>
        /// <param name="deleteRetentionPolicy"> the retention policy which determines how long the associated data should persist. </param>
        /// <param name="staticWebsite"> The properties that enable an account to host a static website. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobServiceProperties(BlobAnalyticsLogging logging, BlobMetrics hourMetrics, BlobMetrics minuteMetrics, IList<BlobCorsRule> cors, string defaultServiceVersion, BlobRetentionPolicy deleteRetentionPolicy, BlobStaticWebsite staticWebsite, Dictionary<string, BinaryData> rawData)
        {
            Logging = logging;
            HourMetrics = hourMetrics;
            MinuteMetrics = minuteMetrics;
            Cors = cors;
            DefaultServiceVersion = defaultServiceVersion;
            DeleteRetentionPolicy = deleteRetentionPolicy;
            StaticWebsite = staticWebsite;
            _rawData = rawData;
        }

        /// <summary> Azure Analytics Logging settings. </summary>
        public BlobAnalyticsLogging Logging { get; set; }
        /// <summary> a summary of request statistics grouped by API in hour or minute aggregates for blobs. </summary>
        public BlobMetrics HourMetrics { get; set; }
        /// <summary> a summary of request statistics grouped by API in hour or minute aggregates for blobs. </summary>
        public BlobMetrics MinuteMetrics { get; set; }
        /// <summary> The default version to use for requests to the Blob service if an incoming request's version is not specified. Possible values include version 2008-10-27 and all more recent versions. </summary>
        public string DefaultServiceVersion { get; set; }
        /// <summary> the retention policy which determines how long the associated data should persist. </summary>
        public BlobRetentionPolicy DeleteRetentionPolicy { get; set; }
        /// <summary> The properties that enable an account to host a static website. </summary>
        public BlobStaticWebsite StaticWebsite { get; set; }
    }
}
