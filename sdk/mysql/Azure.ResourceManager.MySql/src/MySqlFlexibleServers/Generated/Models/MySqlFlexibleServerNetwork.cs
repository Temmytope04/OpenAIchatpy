// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Network related properties of a server. </summary>
    public partial class MySqlFlexibleServerNetwork
    {
        /// <summary> Initializes a new instance of MySqlFlexibleServerNetwork. </summary>
        public MySqlFlexibleServerNetwork()
        {
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerNetwork. </summary>
        /// <param name="publicNetworkAccess"> Whether or not public network access is allowed for this server. Value is 'Disabled' when server has VNet integration. </param>
        /// <param name="delegatedSubnetResourceId"> Delegated subnet resource id used to setup vnet for a server. </param>
        /// <param name="privateDnsZoneResourceId"> Private DNS zone resource id. </param>
        internal MySqlFlexibleServerNetwork(MySqlFlexibleServerEnableStatusEnum? publicNetworkAccess, ResourceIdentifier delegatedSubnetResourceId, ResourceIdentifier privateDnsZoneResourceId)
        {
            PublicNetworkAccess = publicNetworkAccess;
            DelegatedSubnetResourceId = delegatedSubnetResourceId;
            PrivateDnsZoneResourceId = privateDnsZoneResourceId;
        }

        /// <summary> Whether or not public network access is allowed for this server. Value is 'Disabled' when server has VNet integration. </summary>
        public MySqlFlexibleServerEnableStatusEnum? PublicNetworkAccess { get; set; }
        /// <summary> Delegated subnet resource id used to setup vnet for a server. </summary>
        public ResourceIdentifier DelegatedSubnetResourceId { get; set; }
        /// <summary> Private DNS zone resource id. </summary>
        public ResourceIdentifier PrivateDnsZoneResourceId { get; set; }
    }
}
