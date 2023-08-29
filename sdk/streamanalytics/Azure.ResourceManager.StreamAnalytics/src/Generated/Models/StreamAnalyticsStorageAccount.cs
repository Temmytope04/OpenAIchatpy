// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The properties that are associated with an Azure Storage account. </summary>
    public partial class StreamAnalyticsStorageAccount
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsStorageAccount"/>. </summary>
        public StreamAnalyticsStorageAccount()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsStorageAccount"/>. </summary>
        /// <param name="accountName"> The name of the Azure Storage account. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="accountKey"> The account key for the Azure Storage account. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="authenticationMode"> Authentication Mode. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamAnalyticsStorageAccount(string accountName, string accountKey, StreamAnalyticsAuthenticationMode? authenticationMode, Dictionary<string, BinaryData> rawData)
        {
            AccountName = accountName;
            AccountKey = accountKey;
            AuthenticationMode = authenticationMode;
            _rawData = rawData;
        }

        /// <summary> The name of the Azure Storage account. Required on PUT (CreateOrReplace) requests. </summary>
        public string AccountName { get; set; }
        /// <summary> The account key for the Azure Storage account. Required on PUT (CreateOrReplace) requests. </summary>
        public string AccountKey { get; set; }
        /// <summary> Authentication Mode. </summary>
        public StreamAnalyticsAuthenticationMode? AuthenticationMode { get; set; }
    }
}
