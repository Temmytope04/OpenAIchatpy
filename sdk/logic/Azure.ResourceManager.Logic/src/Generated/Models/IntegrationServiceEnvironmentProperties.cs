// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The integration service environment properties. </summary>
    public partial class IntegrationServiceEnvironmentProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmentProperties"/>. </summary>
        public IntegrationServiceEnvironmentProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmentProperties"/>. </summary>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="state"> The integration service environment state. </param>
        /// <param name="integrationServiceEnvironmentId"> Gets the tracking id. </param>
        /// <param name="endpointsConfiguration"> The endpoints configuration. </param>
        /// <param name="networkConfiguration"> The network configuration. </param>
        /// <param name="encryptionConfiguration"> The encryption configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationServiceEnvironmentProperties(LogicWorkflowProvisioningState? provisioningState, LogicWorkflowState? state, string integrationServiceEnvironmentId, FlowEndpointsConfiguration endpointsConfiguration, IntegrationServiceNetworkConfiguration networkConfiguration, IntegrationServiceEnvironmenEncryptionConfiguration encryptionConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            State = state;
            IntegrationServiceEnvironmentId = integrationServiceEnvironmentId;
            EndpointsConfiguration = endpointsConfiguration;
            NetworkConfiguration = networkConfiguration;
            EncryptionConfiguration = encryptionConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The provisioning state. </summary>
        public LogicWorkflowProvisioningState? ProvisioningState { get; set; }
        /// <summary> The integration service environment state. </summary>
        public LogicWorkflowState? State { get; set; }
        /// <summary> Gets the tracking id. </summary>
        public string IntegrationServiceEnvironmentId { get; set; }
        /// <summary> The endpoints configuration. </summary>
        public FlowEndpointsConfiguration EndpointsConfiguration { get; set; }
        /// <summary> The network configuration. </summary>
        public IntegrationServiceNetworkConfiguration NetworkConfiguration { get; set; }
        /// <summary> The encryption configuration. </summary>
        internal IntegrationServiceEnvironmenEncryptionConfiguration EncryptionConfiguration { get; set; }
        /// <summary> The encryption key reference. </summary>
        public IntegrationServiceEnvironmenEncryptionKeyReference EncryptionKeyReference
        {
            get => EncryptionConfiguration is null ? default : EncryptionConfiguration.EncryptionKeyReference;
            set
            {
                if (EncryptionConfiguration is null)
                    EncryptionConfiguration = new IntegrationServiceEnvironmenEncryptionConfiguration();
                EncryptionConfiguration.EncryptionKeyReference = value;
            }
        }
    }
}
