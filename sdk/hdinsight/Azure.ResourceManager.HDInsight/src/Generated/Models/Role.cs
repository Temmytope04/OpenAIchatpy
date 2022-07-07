// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> Describes a role on the cluster. </summary>
    public partial class Role
    {
        /// <summary> Initializes a new instance of Role. </summary>
        public Role()
        {
            DataDisksGroups = new ChangeTrackingList<DataDisksGroups>();
            ScriptActions = new ChangeTrackingList<ScriptAction>();
        }

        /// <summary> Initializes a new instance of Role. </summary>
        /// <param name="name"> The name of the role. </param>
        /// <param name="minInstanceCount"> The minimum instance count of the cluster. </param>
        /// <param name="targetInstanceCount"> The instance count of the cluster. </param>
        /// <param name="vmGroupName"> The name of the virtual machine group. </param>
        /// <param name="autoscaleConfiguration"> The autoscale configurations. </param>
        /// <param name="hardwareProfile"> The hardware profile. </param>
        /// <param name="osProfile"> The operating system profile. </param>
        /// <param name="virtualNetworkProfile"> The virtual network profile. </param>
        /// <param name="dataDisksGroups"> The data disks groups for the role. </param>
        /// <param name="scriptActions"> The list of script actions on the role. </param>
        /// <param name="encryptDataDisks"> Indicates whether encrypt the data disks. </param>
        internal Role(string name, int? minInstanceCount, int? targetInstanceCount, string vmGroupName, Autoscale autoscaleConfiguration, HardwareProfile hardwareProfile, OSProfile osProfile, VirtualNetworkProfile virtualNetworkProfile, IList<DataDisksGroups> dataDisksGroups, IList<ScriptAction> scriptActions, bool? encryptDataDisks)
        {
            Name = name;
            MinInstanceCount = minInstanceCount;
            TargetInstanceCount = targetInstanceCount;
            VmGroupName = vmGroupName;
            AutoscaleConfiguration = autoscaleConfiguration;
            HardwareProfile = hardwareProfile;
            OSProfile = osProfile;
            VirtualNetworkProfile = virtualNetworkProfile;
            DataDisksGroups = dataDisksGroups;
            ScriptActions = scriptActions;
            EncryptDataDisks = encryptDataDisks;
        }

        /// <summary> The name of the role. </summary>
        public string Name { get; set; }
        /// <summary> The minimum instance count of the cluster. </summary>
        public int? MinInstanceCount { get; set; }
        /// <summary> The instance count of the cluster. </summary>
        public int? TargetInstanceCount { get; set; }
        /// <summary> The name of the virtual machine group. </summary>
        public string VmGroupName { get; set; }
        /// <summary> The autoscale configurations. </summary>
        public Autoscale AutoscaleConfiguration { get; set; }
        /// <summary> The hardware profile. </summary>
        internal HardwareProfile HardwareProfile { get; set; }
        /// <summary> The size of the VM. </summary>
        public string HardwareVmSize
        {
            get => HardwareProfile is null ? default : HardwareProfile.VmSize;
            set
            {
                if (HardwareProfile is null)
                    HardwareProfile = new HardwareProfile();
                HardwareProfile.VmSize = value;
            }
        }

        /// <summary> The operating system profile. </summary>
        internal OSProfile OSProfile { get; set; }
        /// <summary> The Linux OS profile. </summary>
        public LinuxOperatingSystemProfile OSLinuxOperatingSystemProfile
        {
            get => OSProfile is null ? default : OSProfile.LinuxOperatingSystemProfile;
            set
            {
                if (OSProfile is null)
                    OSProfile = new OSProfile();
                OSProfile.LinuxOperatingSystemProfile = value;
            }
        }

        /// <summary> The virtual network profile. </summary>
        public VirtualNetworkProfile VirtualNetworkProfile { get; set; }
        /// <summary> The data disks groups for the role. </summary>
        public IList<DataDisksGroups> DataDisksGroups { get; }
        /// <summary> The list of script actions on the role. </summary>
        public IList<ScriptAction> ScriptActions { get; }
        /// <summary> Indicates whether encrypt the data disks. </summary>
        public bool? EncryptDataDisks { get; set; }
    }
}
