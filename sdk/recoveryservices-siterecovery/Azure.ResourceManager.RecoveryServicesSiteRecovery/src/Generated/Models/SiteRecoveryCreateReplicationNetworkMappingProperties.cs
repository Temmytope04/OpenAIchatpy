// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Common input details for network mapping operation. </summary>
    public partial class SiteRecoveryCreateReplicationNetworkMappingProperties
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

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryCreateReplicationNetworkMappingProperties"/>. </summary>
        /// <param name="recoveryNetworkId"> Recovery network Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryNetworkId"/> is null. </exception>
        public SiteRecoveryCreateReplicationNetworkMappingProperties(ResourceIdentifier recoveryNetworkId)
        {
            if (recoveryNetworkId == null)
            {
                throw new ArgumentNullException(nameof(recoveryNetworkId));
            }

            RecoveryNetworkId = recoveryNetworkId;
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryCreateReplicationNetworkMappingProperties"/>. </summary>
        /// <param name="recoveryFabricName"> Recovery fabric Name. </param>
        /// <param name="recoveryNetworkId"> Recovery network Id. </param>
        /// <param name="fabricSpecificDetails">
        /// Fabric specific input properties.
        /// Please note <see cref="FabricSpecificCreateNetworkMappingContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2ACreateNetworkMappingContent"/>, <see cref="VmmToAzureCreateNetworkMappingContent"/> and <see cref="VmmToVmmCreateNetworkMappingContent"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryCreateReplicationNetworkMappingProperties(string recoveryFabricName, ResourceIdentifier recoveryNetworkId, FabricSpecificCreateNetworkMappingContent fabricSpecificDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RecoveryFabricName = recoveryFabricName;
            RecoveryNetworkId = recoveryNetworkId;
            FabricSpecificDetails = fabricSpecificDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryCreateReplicationNetworkMappingProperties"/> for deserialization. </summary>
        internal SiteRecoveryCreateReplicationNetworkMappingProperties()
        {
        }

        /// <summary> Recovery fabric Name. </summary>
        public string RecoveryFabricName { get; set; }
        /// <summary> Recovery network Id. </summary>
        public ResourceIdentifier RecoveryNetworkId { get; }
        /// <summary>
        /// Fabric specific input properties.
        /// Please note <see cref="FabricSpecificCreateNetworkMappingContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2ACreateNetworkMappingContent"/>, <see cref="VmmToAzureCreateNetworkMappingContent"/> and <see cref="VmmToVmmCreateNetworkMappingContent"/>.
        /// </summary>
        public FabricSpecificCreateNetworkMappingContent FabricSpecificDetails { get; set; }
    }
}
