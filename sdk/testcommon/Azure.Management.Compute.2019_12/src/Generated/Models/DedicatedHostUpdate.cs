// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    /// <summary> Specifies information about the dedicated host. Only tags, autoReplaceOnFailure and licenseType may be updated. </summary>
    public partial class DedicatedHostUpdate : UpdateResource
    {
        /// <summary> Initializes a new instance of DedicatedHostUpdate. </summary>
        public DedicatedHostUpdate()
        {
            VirtualMachines = new ChangeTrackingList<SubResourceReadOnly>();
        }

        /// <summary> Initializes a new instance of DedicatedHostUpdate. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="platformFaultDomain"> Fault domain of the dedicated host within a dedicated host group. </param>
        /// <param name="autoReplaceOnFailure"> Specifies whether the dedicated host should be replaced automatically in case of a failure. The value is defaulted to &apos;true&apos; when not provided. </param>
        /// <param name="hostId"> A unique id generated and assigned to the dedicated host by the platform. &lt;br&gt;&lt;br&gt; Does not change throughout the lifetime of the host. </param>
        /// <param name="virtualMachines"> A list of references to all virtual machines in the Dedicated Host. </param>
        /// <param name="licenseType"> Specifies the software license type that will be applied to the VMs deployed on the dedicated host. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **None** &lt;br&gt;&lt;br&gt; **Windows_Server_Hybrid** &lt;br&gt;&lt;br&gt; **Windows_Server_Perpetual** &lt;br&gt;&lt;br&gt; Default: **None**. </param>
        /// <param name="provisioningTime"> The date when the host was first provisioned. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="instanceView"> The dedicated host instance view. </param>
        internal DedicatedHostUpdate(IDictionary<string, string> tags, int? platformFaultDomain, bool? autoReplaceOnFailure, string hostId, IList<SubResourceReadOnly> virtualMachines, DedicatedHostLicenseTypes? licenseType, DateTimeOffset? provisioningTime, string provisioningState, DedicatedHostInstanceView instanceView) : base(tags)
        {
            PlatformFaultDomain = platformFaultDomain;
            AutoReplaceOnFailure = autoReplaceOnFailure;
            HostId = hostId;
            VirtualMachines = virtualMachines;
            LicenseType = licenseType;
            ProvisioningTime = provisioningTime;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
        }

        /// <summary> Fault domain of the dedicated host within a dedicated host group. </summary>
        public int? PlatformFaultDomain { get; set; }
        /// <summary> Specifies whether the dedicated host should be replaced automatically in case of a failure. The value is defaulted to &apos;true&apos; when not provided. </summary>
        public bool? AutoReplaceOnFailure { get; set; }
        /// <summary> A unique id generated and assigned to the dedicated host by the platform. &lt;br&gt;&lt;br&gt; Does not change throughout the lifetime of the host. </summary>
        public string HostId { get; }
        /// <summary> A list of references to all virtual machines in the Dedicated Host. </summary>
        public IList<SubResourceReadOnly> VirtualMachines { get; }
        /// <summary> Specifies the software license type that will be applied to the VMs deployed on the dedicated host. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **None** &lt;br&gt;&lt;br&gt; **Windows_Server_Hybrid** &lt;br&gt;&lt;br&gt; **Windows_Server_Perpetual** &lt;br&gt;&lt;br&gt; Default: **None**. </summary>
        public DedicatedHostLicenseTypes? LicenseType { get; set; }
        /// <summary> The date when the host was first provisioned. </summary>
        public DateTimeOffset? ProvisioningTime { get; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The dedicated host instance view. </summary>
        public DedicatedHostInstanceView InstanceView { get; }
    }
}
