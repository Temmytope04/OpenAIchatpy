// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Supported connector properties. </summary>
    public partial class SupportedConnectorProperties
    {
        /// <summary> Initializes a new instance of <see cref="SupportedConnectorProperties"/>. </summary>
        public SupportedConnectorProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SupportedConnectorProperties"/>. </summary>
        /// <param name="connectorType"> Type of connector used. Example: Optical. </param>
        /// <param name="maxSpeedInMbps"> Maximum speed of the connector in Mbps. </param>
        internal SupportedConnectorProperties(string connectorType, int? maxSpeedInMbps)
        {
            ConnectorType = connectorType;
            MaxSpeedInMbps = maxSpeedInMbps;
        }

        /// <summary> Type of connector used. Example: Optical. </summary>
        public string ConnectorType { get; set; }
        /// <summary> Maximum speed of the connector in Mbps. </summary>
        public int? MaxSpeedInMbps { get; set; }
    }
}
