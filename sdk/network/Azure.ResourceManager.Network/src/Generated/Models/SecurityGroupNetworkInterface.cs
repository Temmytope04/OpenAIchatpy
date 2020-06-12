// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Network interface and all its associated security rules. </summary>
    public partial class SecurityGroupNetworkInterface
    {
        /// <summary> Initializes a new instance of SecurityGroupNetworkInterface. </summary>
        internal SecurityGroupNetworkInterface()
        {
        }

        /// <summary> Initializes a new instance of SecurityGroupNetworkInterface. </summary>
        /// <param name="id"> ID of the network interface. </param>
        /// <param name="securityRuleAssociations"> All security rules associated with the network interface. </param>
        internal SecurityGroupNetworkInterface(string id, SecurityRuleAssociations securityRuleAssociations)
        {
            Id = id;
            SecurityRuleAssociations = securityRuleAssociations;
        }

        /// <summary> ID of the network interface. </summary>
        public string Id { get; }
        /// <summary> All security rules associated with the network interface. </summary>
        public SecurityRuleAssociations SecurityRuleAssociations { get; }
    }
}
