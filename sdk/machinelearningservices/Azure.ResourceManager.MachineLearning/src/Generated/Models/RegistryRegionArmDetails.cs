// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Details for each region the registry is in. </summary>
    public partial class RegistryRegionArmDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RegistryRegionArmDetails"/>. </summary>
        public RegistryRegionArmDetails()
        {
            AcrDetails = new ChangeTrackingList<RegistryAcrDetails>();
            StorageAccountDetails = new ChangeTrackingList<StorageAccountDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="RegistryRegionArmDetails"/>. </summary>
        /// <param name="acrDetails"> List of ACR accounts. </param>
        /// <param name="location"> The location where the registry exists. </param>
        /// <param name="storageAccountDetails"> List of storage accounts. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RegistryRegionArmDetails(IList<RegistryAcrDetails> acrDetails, AzureLocation? location, IList<StorageAccountDetails> storageAccountDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AcrDetails = acrDetails;
            Location = location;
            StorageAccountDetails = storageAccountDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of ACR accounts. </summary>
        public IList<RegistryAcrDetails> AcrDetails { get; set; }
        /// <summary> The location where the registry exists. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> List of storage accounts. </summary>
        public IList<StorageAccountDetails> StorageAccountDetails { get; set; }
    }
}
