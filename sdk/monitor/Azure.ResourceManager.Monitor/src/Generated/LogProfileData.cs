// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing the LogProfile data model.
    /// The log profile resource.
    /// </summary>
    public partial class LogProfileData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="LogProfileData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="locations"> List of regions for which Activity Log events should be stored or streamed. It is a comma separated list of valid ARM locations including the 'global' location. </param>
        /// <param name="categories"> the categories of the logs. These categories are created as is convenient to the user. Some values are: 'Write', 'Delete', and/or 'Action.'. </param>
        /// <param name="retentionPolicy"> the retention policy for the events in the log. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locations"/>, <paramref name="categories"/> or <paramref name="retentionPolicy"/> is null. </exception>
        public LogProfileData(AzureLocation location, IEnumerable<AzureLocation> locations, IEnumerable<string> categories, RetentionPolicy retentionPolicy) : base(location)
        {
            if (locations == null)
            {
                throw new ArgumentNullException(nameof(locations));
            }
            if (categories == null)
            {
                throw new ArgumentNullException(nameof(categories));
            }
            if (retentionPolicy == null)
            {
                throw new ArgumentNullException(nameof(retentionPolicy));
            }

            Locations = locations.ToList();
            Categories = categories.ToList();
            RetentionPolicy = retentionPolicy;
        }

        /// <summary> Initializes a new instance of <see cref="LogProfileData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="storageAccountId"> the resource id of the storage account to which you would like to send the Activity Log. </param>
        /// <param name="serviceBusRuleId"> The service bus rule ID of the service bus namespace in which you would like to have Event Hubs created for streaming the Activity Log. The rule ID is of the format: '{service bus resource ID}/authorizationrules/{key name}'. </param>
        /// <param name="locations"> List of regions for which Activity Log events should be stored or streamed. It is a comma separated list of valid ARM locations including the 'global' location. </param>
        /// <param name="categories"> the categories of the logs. These categories are created as is convenient to the user. Some values are: 'Write', 'Delete', and/or 'Action.'. </param>
        /// <param name="retentionPolicy"> the retention policy for the events in the log. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LogProfileData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ResourceIdentifier storageAccountId, ResourceIdentifier serviceBusRuleId, IList<AzureLocation> locations, IList<string> categories, RetentionPolicy retentionPolicy, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            StorageAccountId = storageAccountId;
            ServiceBusRuleId = serviceBusRuleId;
            Locations = locations;
            Categories = categories;
            RetentionPolicy = retentionPolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="LogProfileData"/> for deserialization. </summary>
        internal LogProfileData()
        {
        }

        /// <summary> the resource id of the storage account to which you would like to send the Activity Log. </summary>
        public ResourceIdentifier StorageAccountId { get; set; }
        /// <summary> The service bus rule ID of the service bus namespace in which you would like to have Event Hubs created for streaming the Activity Log. The rule ID is of the format: '{service bus resource ID}/authorizationrules/{key name}'. </summary>
        public ResourceIdentifier ServiceBusRuleId { get; set; }
        /// <summary> List of regions for which Activity Log events should be stored or streamed. It is a comma separated list of valid ARM locations including the 'global' location. </summary>
        public IList<AzureLocation> Locations { get; }
        /// <summary> the categories of the logs. These categories are created as is convenient to the user. Some values are: 'Write', 'Delete', and/or 'Action.'. </summary>
        public IList<string> Categories { get; }
        /// <summary> the retention policy for the events in the log. </summary>
        public RetentionPolicy RetentionPolicy { get; set; }
    }
}
