// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> AzStackHCI cluster properties. </summary>
    public partial class AzStackHciClusterProperties
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

        /// <summary> Initializes a new instance of <see cref="AzStackHciClusterProperties"/>. </summary>
        /// <param name="clusterName"> Gets or sets the AzStackHCICluster FQDN name. </param>
        /// <param name="resourceName"> Gets or sets the AzStackHCICluster resource name. </param>
        /// <param name="storageAccountName"> Gets or sets the Storage account name. </param>
        /// <param name="storageContainers"> Gets or sets the list of AzStackHCICluster Storage Container. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/>, <paramref name="resourceName"/>, <paramref name="storageAccountName"/> or <paramref name="storageContainers"/> is null. </exception>
        public AzStackHciClusterProperties(string clusterName, string resourceName, string storageAccountName, IEnumerable<StorageContainerProperties> storageContainers)
        {
            Argument.AssertNotNull(clusterName, nameof(clusterName));
            Argument.AssertNotNull(resourceName, nameof(resourceName));
            Argument.AssertNotNull(storageAccountName, nameof(storageAccountName));
            Argument.AssertNotNull(storageContainers, nameof(storageContainers));

            ClusterName = clusterName;
            ResourceName = resourceName;
            StorageAccountName = storageAccountName;
            StorageContainers = storageContainers.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AzStackHciClusterProperties"/>. </summary>
        /// <param name="clusterName"> Gets or sets the AzStackHCICluster FQDN name. </param>
        /// <param name="resourceName"> Gets or sets the AzStackHCICluster resource name. </param>
        /// <param name="storageAccountName"> Gets or sets the Storage account name. </param>
        /// <param name="storageContainers"> Gets or sets the list of AzStackHCICluster Storage Container. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzStackHciClusterProperties(string clusterName, string resourceName, string storageAccountName, IList<StorageContainerProperties> storageContainers, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ClusterName = clusterName;
            ResourceName = resourceName;
            StorageAccountName = storageAccountName;
            StorageContainers = storageContainers;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AzStackHciClusterProperties"/> for deserialization. </summary>
        internal AzStackHciClusterProperties()
        {
        }

        /// <summary> Gets or sets the AzStackHCICluster FQDN name. </summary>
        public string ClusterName { get; set; }
        /// <summary> Gets or sets the AzStackHCICluster resource name. </summary>
        public string ResourceName { get; set; }
        /// <summary> Gets or sets the Storage account name. </summary>
        public string StorageAccountName { get; set; }
        /// <summary> Gets or sets the list of AzStackHCICluster Storage Container. </summary>
        public IList<StorageContainerProperties> StorageContainers { get; }
    }
}
