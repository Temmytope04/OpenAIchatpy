// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> A private IP address bound to the availability group listener. </summary>
    public partial class AvailabilityGroupListenerPrivateIPAddress
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AvailabilityGroupListenerPrivateIPAddress"/>. </summary>
        public AvailabilityGroupListenerPrivateIPAddress()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AvailabilityGroupListenerPrivateIPAddress"/>. </summary>
        /// <param name="ipAddress"> Private IP address bound to the availability group listener. </param>
        /// <param name="subnetResourceId"> Subnet used to include private IP. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AvailabilityGroupListenerPrivateIPAddress(IPAddress ipAddress, ResourceIdentifier subnetResourceId, Dictionary<string, BinaryData> rawData)
        {
            IPAddress = ipAddress;
            SubnetResourceId = subnetResourceId;
            _rawData = rawData;
        }

        /// <summary> Private IP address bound to the availability group listener. </summary>
        public IPAddress IPAddress { get; set; }
        /// <summary> Subnet used to include private IP. </summary>
        public ResourceIdentifier SubnetResourceId { get; set; }
    }
}
