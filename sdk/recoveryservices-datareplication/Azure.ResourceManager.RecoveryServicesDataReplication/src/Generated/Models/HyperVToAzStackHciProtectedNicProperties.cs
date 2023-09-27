// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> HyperVToAzStackHCI NIC properties. </summary>
    public partial class HyperVToAzStackHciProtectedNicProperties
    {
        /// <summary> Initializes a new instance of HyperVToAzStackHciProtectedNicProperties. </summary>
        internal HyperVToAzStackHciProtectedNicProperties()
        {
        }

        /// <summary> Initializes a new instance of HyperVToAzStackHciProtectedNicProperties. </summary>
        /// <param name="nicId"> Gets or sets the NIC Id. </param>
        /// <param name="macAddress"> Gets or sets the NIC mac address. </param>
        /// <param name="networkName"> Gets or sets the network name. </param>
        /// <param name="targetNetworkId"> Gets or sets the target network Id within AzStackHCI Cluster. </param>
        /// <param name="testNetworkId"> Gets or sets the target test network Id within AzStackHCI Cluster. </param>
        /// <param name="selectionTypeForFailover"> Gets or sets the selection type of the NIC. </param>
        internal HyperVToAzStackHciProtectedNicProperties(string nicId, string macAddress, string networkName, string targetNetworkId, string testNetworkId, VmNicSelection? selectionTypeForFailover)
        {
            NicId = nicId;
            MacAddress = macAddress;
            NetworkName = networkName;
            TargetNetworkId = targetNetworkId;
            TestNetworkId = testNetworkId;
            SelectionTypeForFailover = selectionTypeForFailover;
        }

        /// <summary> Gets or sets the NIC Id. </summary>
        public string NicId { get; }
        /// <summary> Gets or sets the NIC mac address. </summary>
        public string MacAddress { get; }
        /// <summary> Gets or sets the network name. </summary>
        public string NetworkName { get; }
        /// <summary> Gets or sets the target network Id within AzStackHCI Cluster. </summary>
        public string TargetNetworkId { get; }
        /// <summary> Gets or sets the target test network Id within AzStackHCI Cluster. </summary>
        public string TestNetworkId { get; }
        /// <summary> Gets or sets the selection type of the NIC. </summary>
        public VmNicSelection? SelectionTypeForFailover { get; }
    }
}
