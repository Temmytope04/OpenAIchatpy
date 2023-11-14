// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> Information about the container service backing the cluster. </summary>
    public partial class AcsClusterProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AcsClusterProperties"/>. </summary>
        /// <param name="orchestratorType"> Type of orchestrator. It cannot be changed once the cluster is created. </param>
        public AcsClusterProperties(OrchestratorType orchestratorType)
        {
            OrchestratorType = orchestratorType;
            SystemServices = new ChangeTrackingList<SystemService>();
        }

        /// <summary> Initializes a new instance of <see cref="AcsClusterProperties"/>. </summary>
        /// <param name="clusterFqdn"> The FQDN of the cluster. </param>
        /// <param name="orchestratorType"> Type of orchestrator. It cannot be changed once the cluster is created. </param>
        /// <param name="orchestratorProperties"> Orchestrator specific properties. </param>
        /// <param name="systemServices"> The system services deployed to the cluster. </param>
        /// <param name="masterCount"> The number of master nodes in the container service. </param>
        /// <param name="agentCount"> The number of agent nodes in the Container Service. This can be changed to scale the cluster. </param>
        /// <param name="agentVmSize"> The Azure VM size of the agent VM nodes. This cannot be changed once the cluster is created. This list is non exhaustive; refer to https://docs.microsoft.com/en-us/azure/virtual-machines/windows/sizes for the possible VM sizes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AcsClusterProperties(string clusterFqdn, OrchestratorType orchestratorType, KubernetesClusterProperties orchestratorProperties, IList<SystemService> systemServices, int? masterCount, int? agentCount, AgentVmSizeType? agentVmSize, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ClusterFqdn = clusterFqdn;
            OrchestratorType = orchestratorType;
            OrchestratorProperties = orchestratorProperties;
            SystemServices = systemServices;
            MasterCount = masterCount;
            AgentCount = agentCount;
            AgentVmSize = agentVmSize;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AcsClusterProperties"/> for deserialization. </summary>
        internal AcsClusterProperties()
        {
        }

        /// <summary> The FQDN of the cluster. </summary>
        public string ClusterFqdn { get; }
        /// <summary> Type of orchestrator. It cannot be changed once the cluster is created. </summary>
        public OrchestratorType OrchestratorType { get; set; }
        /// <summary> Orchestrator specific properties. </summary>
        internal KubernetesClusterProperties OrchestratorProperties { get; set; }
        /// <summary> The Azure Service Principal used by Kubernetes. </summary>
        public ServicePrincipalProperties OrchestratorServicePrincipal
        {
            get => OrchestratorProperties is null ? default : OrchestratorProperties.ServicePrincipal;
            set
            {
                if (OrchestratorProperties is null)
                    OrchestratorProperties = new KubernetesClusterProperties();
                OrchestratorProperties.ServicePrincipal = value;
            }
        }

        /// <summary> The system services deployed to the cluster. </summary>
        public IList<SystemService> SystemServices { get; }
        /// <summary> The number of master nodes in the container service. </summary>
        public int? MasterCount { get; set; }
        /// <summary> The number of agent nodes in the Container Service. This can be changed to scale the cluster. </summary>
        public int? AgentCount { get; set; }
        /// <summary> The Azure VM size of the agent VM nodes. This cannot be changed once the cluster is created. This list is non exhaustive; refer to https://docs.microsoft.com/en-us/azure/virtual-machines/windows/sizes for the possible VM sizes. </summary>
        public AgentVmSizeType? AgentVmSize { get; set; }
    }
}
