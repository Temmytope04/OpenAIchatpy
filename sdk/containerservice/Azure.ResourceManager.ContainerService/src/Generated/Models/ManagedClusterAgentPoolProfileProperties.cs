// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Properties for the container service agent pool profile. </summary>
    public partial class ManagedClusterAgentPoolProfileProperties
    {
        /// <summary> Initializes a new instance of ManagedClusterAgentPoolProfileProperties. </summary>
        public ManagedClusterAgentPoolProfileProperties()
        {
            AvailabilityZones = new ChangeTrackingList<string>();
            Tags = new ChangeTrackingDictionary<string, string>();
            NodeLabels = new ChangeTrackingDictionary<string, string>();
            NodeTaints = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ManagedClusterAgentPoolProfileProperties. </summary>
        /// <param name="count"> Number of agents (VMs) to host docker containers. Allowed values must be in the range of 0 to 1000 (inclusive) for user pools and in the range of 1 to 1000 (inclusive) for system pools. The default value is 1. </param>
        /// <param name="vmSize"> VM size availability varies by region. If a node contains insufficient compute resources (memory, cpu, etc) pods might fail to run correctly. For more details on restricted VM sizes, see: https://docs.microsoft.com/azure/aks/quotas-skus-regions. </param>
        /// <param name="osDiskSizeInGB"> OS Disk Size in GB to be used to specify the disk size for every machine in the master/agent pool. If you specify 0, it will apply the default osDisk size according to the vmSize specified. </param>
        /// <param name="osDiskType"> The default is 'Ephemeral' if the VM supports it and has a cache disk larger than the requested OSDiskSizeGB. Otherwise, defaults to 'Managed'. May not be changed after creation. For more information see [Ephemeral OS](https://docs.microsoft.com/azure/aks/cluster-configuration#ephemeral-os). </param>
        /// <param name="kubeletDiskType"> Determines the placement of emptyDir volumes, container runtime data root, and Kubelet ephemeral storage. </param>
        /// <param name="workloadRuntime"> Determines the type of workload a node can run. </param>
        /// <param name="messageOfTheDay"> A base64-encoded string which will be written to /etc/motd after decoding. This allows customization of the message of the day for Linux nodes. It must not be specified for Windows nodes. It must be a static string (i.e., will be printed raw and not be executed as a script). </param>
        /// <param name="vnetSubnetId"> If this is not specified, a VNET and subnet will be generated and used. If no podSubnetID is specified, this applies to nodes and pods, otherwise it applies to just nodes. This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}. </param>
        /// <param name="podSubnetId"> If omitted, pod IPs are statically assigned on the node subnet (see vnetSubnetID for more details). This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}. </param>
        /// <param name="maxPods"> The maximum number of pods that can run on a node. </param>
        /// <param name="osType"> The operating system type. The default is Linux. </param>
        /// <param name="osSku"> Specifies the OS SKU used by the agent pool. If not specified, the default is Ubuntu if OSType=Linux or Windows2019 if OSType=Windows. And the default Windows OSSKU will be changed to Windows2022 after Windows2019 is deprecated. </param>
        /// <param name="maxCount"> The maximum number of nodes for auto-scaling. </param>
        /// <param name="minCount"> The minimum number of nodes for auto-scaling. </param>
        /// <param name="enableAutoScaling"> Whether to enable auto-scaler. </param>
        /// <param name="scaleDownMode"> This also effects the cluster autoscaler behavior. If not specified, it defaults to Delete. </param>
        /// <param name="agentPoolType"> The type of Agent Pool. </param>
        /// <param name="mode"> A cluster must have at least one 'System' Agent Pool at all times. For additional information on agent pool restrictions and best practices, see: https://docs.microsoft.com/azure/aks/use-system-pools. </param>
        /// <param name="orchestratorVersion"> Both patch version &lt;major.minor.patch&gt; and &lt;major.minor&gt; are supported. When &lt;major.minor&gt; is specified, the latest supported patch version is chosen automatically. Updating the agent pool with the same &lt;major.minor&gt; once it has been created will not trigger an upgrade, even if a newer patch version is available. As a best practice, you should upgrade all node pools in an AKS cluster to the same Kubernetes version. The node pool version must have the same major version as the control plane. The node pool minor version must be within two minor versions of the control plane version. The node pool version cannot be greater than the control plane version. For more information see [upgrading a node pool](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#upgrade-a-node-pool). </param>
        /// <param name="currentOrchestratorVersion"> If orchestratorVersion was a fully specified version &lt;major.minor.patch&gt;, this field will be exactly equal to it. If orchestratorVersion was &lt;major.minor&gt;, this field will contain the full &lt;major.minor.patch&gt; version being used. </param>
        /// <param name="nodeImageVersion"> The version of node image. </param>
        /// <param name="upgradeSettings"> Settings for upgrading the agentpool. </param>
        /// <param name="provisioningState"> The current deployment or provisioning state. </param>
        /// <param name="powerState"> When an Agent Pool is first created it is initially Running. The Agent Pool can be stopped by setting this field to Stopped. A stopped Agent Pool stops all of its VMs and does not accrue billing charges. An Agent Pool can only be stopped if it is Running and provisioning state is Succeeded. </param>
        /// <param name="availabilityZones"> The list of Availability zones to use for nodes. This can only be specified if the AgentPoolType property is 'VirtualMachineScaleSets'. </param>
        /// <param name="enableNodePublicIP"> Some scenarios may require nodes in a node pool to receive their own dedicated public IP addresses. A common scenario is for gaming workloads, where a console needs to make a direct connection to a cloud virtual machine to minimize hops. For more information see [assigning a public IP per node](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#assign-a-public-ip-per-node-for-your-node-pools). The default is false. </param>
        /// <param name="enableCustomCATrust"> When set to true, AKS adds a label to the node indicating that the feature is enabled and deploys a daemonset along with host services to sync custom certificate authorities from user-provided list of base64 encoded certificates into node trust stores. Defaults to false. </param>
        /// <param name="nodePublicIPPrefixId"> This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}. </param>
        /// <param name="scaleSetPriority"> The Virtual Machine Scale Set priority. If not specified, the default is 'Regular'. </param>
        /// <param name="scaleSetEvictionPolicy"> This cannot be specified unless the scaleSetPriority is 'Spot'. If not specified, the default is 'Delete'. </param>
        /// <param name="spotMaxPrice"> Possible values are any decimal value greater than zero or -1 which indicates the willingness to pay any on-demand price. For more details on spot pricing, see [spot VMs pricing](https://docs.microsoft.com/azure/virtual-machines/spot-vms#pricing). </param>
        /// <param name="tags"> The tags to be persisted on the agent pool virtual machine scale set. </param>
        /// <param name="nodeLabels"> The node labels to be persisted across all nodes in agent pool. </param>
        /// <param name="nodeTaints"> The taints added to new nodes during node pool create and scale. For example, key=value:NoSchedule. </param>
        /// <param name="proximityPlacementGroupId"> The ID for Proximity Placement Group. </param>
        /// <param name="kubeletConfig"> The Kubelet configuration on the agent pool nodes. </param>
        /// <param name="linuxOSConfig"> The OS configuration of Linux agent nodes. </param>
        /// <param name="enableEncryptionAtHost"> This is only supported on certain VM sizes and in certain Azure regions. For more information, see: https://docs.microsoft.com/azure/aks/enable-host-encryption. </param>
        /// <param name="enableUltraSsd"> Whether to enable UltraSSD. </param>
        /// <param name="enableFips"> See [Add a FIPS-enabled node pool](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#add-a-fips-enabled-node-pool-preview) for more details. </param>
        /// <param name="gpuInstanceProfile"> GPUInstanceProfile to be used to specify GPU MIG instance profile for supported GPU VM SKU. </param>
        /// <param name="creationData"> CreationData to be used to specify the source Snapshot ID if the node pool will be created/upgraded using a snapshot. </param>
        /// <param name="capacityReservationGroupId"> AKS will associate the specified agent pool with the Capacity Reservation Group. </param>
        /// <param name="hostGroupId"> This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}. For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts). </param>
        /// <param name="windowsProfile"> The Windows agent pool's specific profile. </param>
        /// <param name="networkProfile"> Network-related settings of an agent pool. </param>
        internal ManagedClusterAgentPoolProfileProperties(int? count, string vmSize, int? osDiskSizeInGB, ContainerServiceOSDiskType? osDiskType, KubeletDiskType? kubeletDiskType, WorkloadRuntime? workloadRuntime, string messageOfTheDay, ResourceIdentifier vnetSubnetId, ResourceIdentifier podSubnetId, int? maxPods, ContainerServiceOSType? osType, ContainerServiceOSSku? osSku, int? maxCount, int? minCount, bool? enableAutoScaling, ScaleDownMode? scaleDownMode, AgentPoolType? agentPoolType, AgentPoolMode? mode, string orchestratorVersion, string currentOrchestratorVersion, string nodeImageVersion, AgentPoolUpgradeSettings upgradeSettings, string provisioningState, ContainerServicePowerState powerState, IList<string> availabilityZones, bool? enableNodePublicIP, bool? enableCustomCATrust, ResourceIdentifier nodePublicIPPrefixId, ScaleSetPriority? scaleSetPriority, ScaleSetEvictionPolicy? scaleSetEvictionPolicy, float? spotMaxPrice, IDictionary<string, string> tags, IDictionary<string, string> nodeLabels, IList<string> nodeTaints, ResourceIdentifier proximityPlacementGroupId, KubeletConfig kubeletConfig, LinuxOSConfig linuxOSConfig, bool? enableEncryptionAtHost, bool? enableUltraSsd, bool? enableFips, GpuInstanceProfile? gpuInstanceProfile, ContainerServiceCreationData creationData, ResourceIdentifier capacityReservationGroupId, ResourceIdentifier hostGroupId, AgentPoolWindowsProfile windowsProfile, AgentPoolNetworkProfile networkProfile)
        {
            Count = count;
            VmSize = vmSize;
            OSDiskSizeInGB = osDiskSizeInGB;
            OSDiskType = osDiskType;
            KubeletDiskType = kubeletDiskType;
            WorkloadRuntime = workloadRuntime;
            MessageOfTheDay = messageOfTheDay;
            VnetSubnetId = vnetSubnetId;
            PodSubnetId = podSubnetId;
            MaxPods = maxPods;
            OSType = osType;
            OSSku = osSku;
            MaxCount = maxCount;
            MinCount = minCount;
            EnableAutoScaling = enableAutoScaling;
            ScaleDownMode = scaleDownMode;
            AgentPoolType = agentPoolType;
            Mode = mode;
            OrchestratorVersion = orchestratorVersion;
            CurrentOrchestratorVersion = currentOrchestratorVersion;
            NodeImageVersion = nodeImageVersion;
            UpgradeSettings = upgradeSettings;
            ProvisioningState = provisioningState;
            PowerState = powerState;
            AvailabilityZones = availabilityZones;
            EnableNodePublicIP = enableNodePublicIP;
            EnableCustomCATrust = enableCustomCATrust;
            NodePublicIPPrefixId = nodePublicIPPrefixId;
            ScaleSetPriority = scaleSetPriority;
            ScaleSetEvictionPolicy = scaleSetEvictionPolicy;
            SpotMaxPrice = spotMaxPrice;
            Tags = tags;
            NodeLabels = nodeLabels;
            NodeTaints = nodeTaints;
            ProximityPlacementGroupId = proximityPlacementGroupId;
            KubeletConfig = kubeletConfig;
            LinuxOSConfig = linuxOSConfig;
            EnableEncryptionAtHost = enableEncryptionAtHost;
            EnableUltraSsd = enableUltraSsd;
            EnableFips = enableFips;
            GpuInstanceProfile = gpuInstanceProfile;
            CreationData = creationData;
            CapacityReservationGroupId = capacityReservationGroupId;
            HostGroupId = hostGroupId;
            WindowsProfile = windowsProfile;
            NetworkProfile = networkProfile;
        }

        /// <summary> Number of agents (VMs) to host docker containers. Allowed values must be in the range of 0 to 1000 (inclusive) for user pools and in the range of 1 to 1000 (inclusive) for system pools. The default value is 1. </summary>
        public int? Count { get; set; }
        /// <summary> VM size availability varies by region. If a node contains insufficient compute resources (memory, cpu, etc) pods might fail to run correctly. For more details on restricted VM sizes, see: https://docs.microsoft.com/azure/aks/quotas-skus-regions. </summary>
        public string VmSize { get; set; }
        /// <summary> OS Disk Size in GB to be used to specify the disk size for every machine in the master/agent pool. If you specify 0, it will apply the default osDisk size according to the vmSize specified. </summary>
        public int? OSDiskSizeInGB { get; set; }
        /// <summary> The default is 'Ephemeral' if the VM supports it and has a cache disk larger than the requested OSDiskSizeGB. Otherwise, defaults to 'Managed'. May not be changed after creation. For more information see [Ephemeral OS](https://docs.microsoft.com/azure/aks/cluster-configuration#ephemeral-os). </summary>
        public ContainerServiceOSDiskType? OSDiskType { get; set; }
        /// <summary> Determines the placement of emptyDir volumes, container runtime data root, and Kubelet ephemeral storage. </summary>
        public KubeletDiskType? KubeletDiskType { get; set; }
        /// <summary> Determines the type of workload a node can run. </summary>
        public WorkloadRuntime? WorkloadRuntime { get; set; }
        /// <summary> A base64-encoded string which will be written to /etc/motd after decoding. This allows customization of the message of the day for Linux nodes. It must not be specified for Windows nodes. It must be a static string (i.e., will be printed raw and not be executed as a script). </summary>
        public string MessageOfTheDay { get; set; }
        /// <summary> If this is not specified, a VNET and subnet will be generated and used. If no podSubnetID is specified, this applies to nodes and pods, otherwise it applies to just nodes. This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}. </summary>
        public ResourceIdentifier VnetSubnetId { get; set; }
        /// <summary> If omitted, pod IPs are statically assigned on the node subnet (see vnetSubnetID for more details). This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}. </summary>
        public ResourceIdentifier PodSubnetId { get; set; }
        /// <summary> The maximum number of pods that can run on a node. </summary>
        public int? MaxPods { get; set; }
        /// <summary> The operating system type. The default is Linux. </summary>
        public ContainerServiceOSType? OSType { get; set; }
        /// <summary> Specifies the OS SKU used by the agent pool. If not specified, the default is Ubuntu if OSType=Linux or Windows2019 if OSType=Windows. And the default Windows OSSKU will be changed to Windows2022 after Windows2019 is deprecated. </summary>
        public ContainerServiceOSSku? OSSku { get; set; }
        /// <summary> The maximum number of nodes for auto-scaling. </summary>
        public int? MaxCount { get; set; }
        /// <summary> The minimum number of nodes for auto-scaling. </summary>
        public int? MinCount { get; set; }
        /// <summary> Whether to enable auto-scaler. </summary>
        public bool? EnableAutoScaling { get; set; }
        /// <summary> This also effects the cluster autoscaler behavior. If not specified, it defaults to Delete. </summary>
        public ScaleDownMode? ScaleDownMode { get; set; }
        /// <summary> The type of Agent Pool. </summary>
        public AgentPoolType? AgentPoolType { get; set; }
        /// <summary> A cluster must have at least one 'System' Agent Pool at all times. For additional information on agent pool restrictions and best practices, see: https://docs.microsoft.com/azure/aks/use-system-pools. </summary>
        public AgentPoolMode? Mode { get; set; }
        /// <summary> Both patch version &lt;major.minor.patch&gt; and &lt;major.minor&gt; are supported. When &lt;major.minor&gt; is specified, the latest supported patch version is chosen automatically. Updating the agent pool with the same &lt;major.minor&gt; once it has been created will not trigger an upgrade, even if a newer patch version is available. As a best practice, you should upgrade all node pools in an AKS cluster to the same Kubernetes version. The node pool version must have the same major version as the control plane. The node pool minor version must be within two minor versions of the control plane version. The node pool version cannot be greater than the control plane version. For more information see [upgrading a node pool](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#upgrade-a-node-pool). </summary>
        public string OrchestratorVersion { get; set; }
        /// <summary> If orchestratorVersion was a fully specified version &lt;major.minor.patch&gt;, this field will be exactly equal to it. If orchestratorVersion was &lt;major.minor&gt;, this field will contain the full &lt;major.minor.patch&gt; version being used. </summary>
        public string CurrentOrchestratorVersion { get; }
        /// <summary> The version of node image. </summary>
        public string NodeImageVersion { get; }
        /// <summary> Settings for upgrading the agentpool. </summary>
        internal AgentPoolUpgradeSettings UpgradeSettings { get; set; }
        /// <summary> This can either be set to an integer (e.g. '5') or a percentage (e.g. '50%'). If a percentage is specified, it is the percentage of the total agent pool size at the time of the upgrade. For percentages, fractional nodes are rounded up. If not specified, the default is 1. For more information, including best practices, see: https://docs.microsoft.com/azure/aks/upgrade-cluster#customize-node-surge-upgrade. </summary>
        public string UpgradeMaxSurge
        {
            get => UpgradeSettings is null ? default : UpgradeSettings.MaxSurge;
            set
            {
                if (UpgradeSettings is null)
                    UpgradeSettings = new AgentPoolUpgradeSettings();
                UpgradeSettings.MaxSurge = value;
            }
        }

        /// <summary> The current deployment or provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> When an Agent Pool is first created it is initially Running. The Agent Pool can be stopped by setting this field to Stopped. A stopped Agent Pool stops all of its VMs and does not accrue billing charges. An Agent Pool can only be stopped if it is Running and provisioning state is Succeeded. </summary>
        internal ContainerServicePowerState PowerState { get; set; }
        /// <summary> Tells whether the cluster is Running or Stopped. </summary>
        public ContainerServiceStateCode? PowerStateCode
        {
            get => PowerState is null ? default : PowerState.Code;
            set
            {
                if (PowerState is null)
                    PowerState = new ContainerServicePowerState();
                PowerState.Code = value;
            }
        }

        /// <summary> The list of Availability zones to use for nodes. This can only be specified if the AgentPoolType property is 'VirtualMachineScaleSets'. </summary>
        public IList<string> AvailabilityZones { get; }
        /// <summary> Some scenarios may require nodes in a node pool to receive their own dedicated public IP addresses. A common scenario is for gaming workloads, where a console needs to make a direct connection to a cloud virtual machine to minimize hops. For more information see [assigning a public IP per node](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#assign-a-public-ip-per-node-for-your-node-pools). The default is false. </summary>
        public bool? EnableNodePublicIP { get; set; }
        /// <summary> When set to true, AKS adds a label to the node indicating that the feature is enabled and deploys a daemonset along with host services to sync custom certificate authorities from user-provided list of base64 encoded certificates into node trust stores. Defaults to false. </summary>
        public bool? EnableCustomCATrust { get; set; }
        /// <summary> This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}. </summary>
        public ResourceIdentifier NodePublicIPPrefixId { get; set; }
        /// <summary> The Virtual Machine Scale Set priority. If not specified, the default is 'Regular'. </summary>
        public ScaleSetPriority? ScaleSetPriority { get; set; }
        /// <summary> This cannot be specified unless the scaleSetPriority is 'Spot'. If not specified, the default is 'Delete'. </summary>
        public ScaleSetEvictionPolicy? ScaleSetEvictionPolicy { get; set; }
        /// <summary> Possible values are any decimal value greater than zero or -1 which indicates the willingness to pay any on-demand price. For more details on spot pricing, see [spot VMs pricing](https://docs.microsoft.com/azure/virtual-machines/spot-vms#pricing). </summary>
        public float? SpotMaxPrice { get; set; }
        /// <summary> The tags to be persisted on the agent pool virtual machine scale set. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The node labels to be persisted across all nodes in agent pool. </summary>
        public IDictionary<string, string> NodeLabels { get; }
        /// <summary> The taints added to new nodes during node pool create and scale. For example, key=value:NoSchedule. </summary>
        public IList<string> NodeTaints { get; }
        /// <summary> The ID for Proximity Placement Group. </summary>
        public ResourceIdentifier ProximityPlacementGroupId { get; set; }
        /// <summary> The Kubelet configuration on the agent pool nodes. </summary>
        public KubeletConfig KubeletConfig { get; set; }
        /// <summary> The OS configuration of Linux agent nodes. </summary>
        public LinuxOSConfig LinuxOSConfig { get; set; }
        /// <summary> This is only supported on certain VM sizes and in certain Azure regions. For more information, see: https://docs.microsoft.com/azure/aks/enable-host-encryption. </summary>
        public bool? EnableEncryptionAtHost { get; set; }
        /// <summary> Whether to enable UltraSSD. </summary>
        public bool? EnableUltraSsd { get; set; }
        /// <summary> See [Add a FIPS-enabled node pool](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#add-a-fips-enabled-node-pool-preview) for more details. </summary>
        public bool? EnableFips { get; set; }
        /// <summary> GPUInstanceProfile to be used to specify GPU MIG instance profile for supported GPU VM SKU. </summary>
        public GpuInstanceProfile? GpuInstanceProfile { get; set; }
        /// <summary> CreationData to be used to specify the source Snapshot ID if the node pool will be created/upgraded using a snapshot. </summary>
        internal ContainerServiceCreationData CreationData { get; set; }
        /// <summary> This is the ARM ID of the source object to be used to create the target object. </summary>
        public ResourceIdentifier CreationDataSourceResourceId
        {
            get => CreationData is null ? default : CreationData.SourceResourceId;
            set
            {
                if (CreationData is null)
                    CreationData = new ContainerServiceCreationData();
                CreationData.SourceResourceId = value;
            }
        }

        /// <summary> AKS will associate the specified agent pool with the Capacity Reservation Group. </summary>
        public ResourceIdentifier CapacityReservationGroupId { get; set; }
        /// <summary> This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}. For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts). </summary>
        public ResourceIdentifier HostGroupId { get; set; }
        /// <summary> The Windows agent pool's specific profile. </summary>
        internal AgentPoolWindowsProfile WindowsProfile { get; set; }
        /// <summary> The default value is false. Outbound NAT can only be disabled if the cluster outboundType is NAT Gateway and the Windows agent pool does not have node public IP enabled. </summary>
        public bool? DisableOutboundNat
        {
            get => WindowsProfile is null ? default : WindowsProfile.DisableOutboundNat;
            set
            {
                if (WindowsProfile is null)
                    WindowsProfile = new AgentPoolWindowsProfile();
                WindowsProfile.DisableOutboundNat = value;
            }
        }

        /// <summary> Network-related settings of an agent pool. </summary>
        public AgentPoolNetworkProfile NetworkProfile { get; set; }
    }
}
