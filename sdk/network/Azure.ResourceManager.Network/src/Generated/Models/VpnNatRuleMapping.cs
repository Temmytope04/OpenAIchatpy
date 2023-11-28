// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Vpn NatRule mapping. </summary>
    public partial class VpnNatRuleMapping
    {
        /// <summary> Initializes a new instance of <see cref="VpnNatRuleMapping"/>. </summary>
        public VpnNatRuleMapping()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VpnNatRuleMapping"/>. </summary>
        /// <param name="addressSpace"> Address space for Vpn NatRule mapping. </param>
        /// <param name="portRange"> Port range for Vpn NatRule mapping. </param>
        internal VpnNatRuleMapping(string addressSpace, string portRange)
        {
            AddressSpace = addressSpace;
            PortRange = portRange;
        }

        /// <summary> Address space for Vpn NatRule mapping. </summary>
        public string AddressSpace { get; set; }
        /// <summary> Port range for Vpn NatRule mapping. </summary>
        public string PortRange { get; set; }
    }
}
