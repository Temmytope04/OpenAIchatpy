// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure data lake store write settings. </summary>
    public partial class AzureDataLakeStoreWriteSettings : StoreWriteSettings
    {
        /// <summary> Initializes a new instance of AzureDataLakeStoreWriteSettings. </summary>
        public AzureDataLakeStoreWriteSettings()
        {
            Type = "AzureDataLakeStoreWriteSettings";
        }

        /// <summary> Initializes a new instance of AzureDataLakeStoreWriteSettings. </summary>
        /// <param name="type"> The write setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="copyBehavior"> The type of copy behavior for copy sink. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="expiryDateTime"> Specifies the expiry time of the written files. The time is applied to the UTC time zone in the format of "2018-12-01T05:00:00Z". Default value is NULL. Type: integer (or Expression with resultType integer). </param>
        internal AzureDataLakeStoreWriteSettings(string type, object maxConcurrentConnections, object copyBehavior, IDictionary<string, object> additionalProperties, object expiryDateTime) : base(type, maxConcurrentConnections, copyBehavior, additionalProperties)
        {
            ExpiryDateTime = expiryDateTime;
            Type = type ?? "AzureDataLakeStoreWriteSettings";
        }

        /// <summary> Specifies the expiry time of the written files. The time is applied to the UTC time zone in the format of "2018-12-01T05:00:00Z". Default value is NULL. Type: integer (or Expression with resultType integer). </summary>
        public object ExpiryDateTime { get; set; }
    }
}
