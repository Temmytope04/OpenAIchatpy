// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    /// <summary> A class representing the ConnectionMonitorTest data model. </summary>
    public partial class ConnectionMonitorTestData : ResourceData
    {
        /// <summary> Initializes a new instance of ConnectionMonitorTestData. </summary>
        public ConnectionMonitorTestData()
        {
            Path = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ConnectionMonitorTestData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sourceAgent"> The Connection Monitor test source agent. </param>
        /// <param name="destination"> The Connection Monitor test destination. </param>
        /// <param name="destinationPort"> The Connection Monitor test destination port. </param>
        /// <param name="testFrequencyInSec"> The Connection Monitor test frequency in seconds. </param>
        /// <param name="isTestSuccessful"> The flag that indicates if the Connection Monitor test is successful or not. </param>
        /// <param name="path"> The path representing the Connection Monitor test. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        internal ConnectionMonitorTestData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string sourceAgent, string destination, int? destinationPort, int? testFrequencyInSec, bool? isTestSuccessful, IReadOnlyList<string> path, PeeringProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            SourceAgent = sourceAgent;
            Destination = destination;
            DestinationPort = destinationPort;
            TestFrequencyInSec = testFrequencyInSec;
            IsTestSuccessful = isTestSuccessful;
            Path = path;
            ProvisioningState = provisioningState;
        }

        /// <summary> The Connection Monitor test source agent. </summary>
        public string SourceAgent { get; set; }
        /// <summary> The Connection Monitor test destination. </summary>
        public string Destination { get; set; }
        /// <summary> The Connection Monitor test destination port. </summary>
        public int? DestinationPort { get; set; }
        /// <summary> The Connection Monitor test frequency in seconds. </summary>
        public int? TestFrequencyInSec { get; set; }
        /// <summary> The flag that indicates if the Connection Monitor test is successful or not. </summary>
        public bool? IsTestSuccessful { get; }
        /// <summary> The path representing the Connection Monitor test. </summary>
        public IReadOnlyList<string> Path { get; }
        /// <summary> The provisioning state of the resource. </summary>
        public PeeringProvisioningState? ProvisioningState { get; }
    }
}
