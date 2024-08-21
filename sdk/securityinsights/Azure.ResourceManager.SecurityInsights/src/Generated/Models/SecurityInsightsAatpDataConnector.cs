// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Represents AATP (Azure Advanced Threat Protection) data connector.
    /// Serialized Name: AatpDataConnector
    /// </summary>
    public partial class SecurityInsightsAatpDataConnector : SecurityInsightsDataConnectorData
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsAatpDataConnector"/>. </summary>
        public SecurityInsightsAatpDataConnector()
        {
            Kind = DataConnectorKind.AzureAdvancedThreatProtection;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsAatpDataConnector"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind">
        /// The data connector kind
        /// Serialized Name: DataConnector.kind
        /// </param>
        /// <param name="etag">
        /// Etag of the azure resource
        /// Serialized Name: ResourceWithEtag.etag
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="tenantId">
        /// The tenant id to connect to, and get the data from.
        /// Serialized Name: AatpDataConnector.properties.tenantId
        /// </param>
        /// <param name="alerts">
        /// Alerts data type connection.
        /// Serialized Name: AatpDataConnector.properties.dataTypes.alerts
        /// </param>
        internal SecurityInsightsAatpDataConnector(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataConnectorKind kind, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData, Guid? tenantId, DataConnectorDataTypeCommon alerts) : base(id, name, resourceType, systemData, kind, etag, serializedAdditionalRawData)
        {
            TenantId = tenantId;
            Alerts = alerts;
            Kind = kind;
        }

        /// <summary>
        /// The tenant id to connect to, and get the data from.
        /// Serialized Name: AatpDataConnector.properties.tenantId
        /// </summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// Alerts data type connection.
        /// Serialized Name: AatpDataConnector.properties.dataTypes.alerts
        /// </summary>
        internal DataConnectorDataTypeCommon Alerts { get; set; }
        /// <summary>
        /// Describe whether this data type connection is enabled or not.
        /// Serialized Name: DataConnectorDataTypeCommon.state
        /// </summary>
        public SecurityInsightsDataTypeConnectionState? AlertsState
        {
            get => Alerts is null ? default(SecurityInsightsDataTypeConnectionState?) : Alerts.State;
            set
            {
                Alerts = value.HasValue ? new DataConnectorDataTypeCommon(value.Value) : null;
            }
        }
    }
}
