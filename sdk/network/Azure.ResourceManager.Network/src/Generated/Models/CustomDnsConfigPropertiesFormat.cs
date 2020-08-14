// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Contains custom Dns resolution configuration from customer. </summary>
    public partial class CustomDnsConfigPropertiesFormat
    {
        /// <summary> Initializes a new instance of CustomDnsConfigPropertiesFormat. </summary>
        public CustomDnsConfigPropertiesFormat()
        {
            IpAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of CustomDnsConfigPropertiesFormat. </summary>
        /// <param name="fqdn"> Fqdn that resolves to private endpoint ip address. </param>
        /// <param name="ipAddresses"> A list of private ip addresses of the private endpoint. </param>
        internal CustomDnsConfigPropertiesFormat(string fqdn, IList<string> ipAddresses)
        {
            Fqdn = fqdn;
            IpAddresses = ipAddresses;
        }

        /// <summary> Fqdn that resolves to private endpoint ip address. </summary>
        public string Fqdn { get; set; }
        /// <summary> A list of private ip addresses of the private endpoint. </summary>
        public IList<string> IpAddresses { get; }
    }
}
