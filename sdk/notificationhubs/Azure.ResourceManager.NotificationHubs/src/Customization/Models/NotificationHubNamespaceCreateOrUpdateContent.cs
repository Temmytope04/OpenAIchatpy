// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Parameters supplied to the CreateOrUpdate Namespace operation. </summary>
    public partial class NotificationHubNamespaceCreateOrUpdateContent : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="NotificationHubNamespaceCreateOrUpdateContent"/>. </summary>
        /// <param name="location"> The location. </param>
        public NotificationHubNamespaceCreateOrUpdateContent(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubNamespaceCreateOrUpdateContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="namespaceName"> The name of the namespace. </param>
        /// <param name="provisioningState"> Provisioning state of the Namespace. </param>
        /// <param name="region"> Specifies the targeted region in which the namespace should be created. It can be any of the following values: Australia East, Australia Southeast, Central US, East US, East US 2, West US, North Central US, South Central US, East Asia, Southeast Asia, Brazil South, Japan East, Japan West, North Europe, West Europe. </param>
        /// <param name="metricId"> Identifier for Azure Insights metrics. </param>
        /// <param name="status"> Status of the namespace. It can be any of these values:1 = Created/Active2 = Creating3 = Suspended4 = Deleting. </param>
        /// <param name="createdOn"> The time the namespace was created. </param>
        /// <param name="updatedOn"> The time the namespace was updated. </param>
        /// <param name="serviceBusEndpoint"> Endpoint you can use to perform NotificationHub operations. </param>
        /// <param name="subscriptionId"> The Id of the Azure subscription associated with the namespace. </param>
        /// <param name="scaleUnit"> ScaleUnit where the namespace gets created. </param>
        /// <param name="isEnabled"> Whether or not the namespace is currently enabled. </param>
        /// <param name="isCritical"> Whether or not the namespace is set as Critical. </param>
        /// <param name="dataCenter"> Data center for the namespace. </param>
        /// <param name="namespaceType"> The namespace type. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationHubNamespaceCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, ResourceManager.Models.SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string namespaceName, string provisioningState, string region, string metricId, string status, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, Uri serviceBusEndpoint, string subscriptionId, string scaleUnit, bool? isEnabled, bool? isCritical, string dataCenter, NotificationHubNamespaceType? namespaceType, NotificationHubSku sku, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            NamespaceName = namespaceName;
            ProvisioningState = provisioningState;
            Region = region;
            MetricId = metricId;
            Status = status;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            ServiceBusEndpoint = serviceBusEndpoint;
            SubscriptionId = subscriptionId;
            ScaleUnit = scaleUnit;
            IsEnabled = isEnabled;
            IsCritical = isCritical;
            DataCenter = dataCenter;
            NamespaceType = namespaceType;
            Sku = sku;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubNamespaceCreateOrUpdateContent"/> for deserialization. </summary>
        internal NotificationHubNamespaceCreateOrUpdateContent()
        {
        }

        /// <summary> The name of the namespace. </summary>
        public string NamespaceName { get; set; }
        /// <summary> Provisioning state of the Namespace. </summary>
        public string ProvisioningState { get; set; }
        /// <summary> Specifies the targeted region in which the namespace should be created. It can be any of the following values: Australia East, Australia Southeast, Central US, East US, East US 2, West US, North Central US, South Central US, East Asia, Southeast Asia, Brazil South, Japan East, Japan West, North Europe, West Europe. </summary>
        public string Region { get; set; }
        /// <summary> Identifier for Azure Insights metrics. </summary>
        public string MetricId { get; }
        /// <summary> Status of the namespace. It can be any of these values:1 = Created/Active2 = Creating3 = Suspended4 = Deleting. </summary>
        public string Status { get; set; }
        /// <summary> The time the namespace was created. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> The time the namespace was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; set; }
        /// <summary> Endpoint you can use to perform NotificationHub operations. </summary>
        public Uri ServiceBusEndpoint { get; set; }
        /// <summary> The Id of the Azure subscription associated with the namespace. </summary>
        public string SubscriptionId { get; set; }
        /// <summary> ScaleUnit where the namespace gets created. </summary>
        public string ScaleUnit { get; set; }
        /// <summary> Whether or not the namespace is currently enabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Whether or not the namespace is set as Critical. </summary>
        public bool? IsCritical { get; set; }
        /// <summary> Data center for the namespace. </summary>
        public string DataCenter { get; set; }
        /// <summary> The namespace type. </summary>
        public NotificationHubNamespaceType? NamespaceType { get; set; }
        /// <summary> The sku of the created namespace. </summary>
        public NotificationHubSku Sku { get; set; }
    }
}
