// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machines scale set IP Configuration's PublicIPAddress configuration. </summary>
    public partial class VirtualMachineScaleSetUpdatePublicIPAddressConfiguration
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetUpdatePublicIPAddressConfiguration. </summary>
        public VirtualMachineScaleSetUpdatePublicIPAddressConfiguration()
        {
        }

        /// <summary> The publicIP address configuration name. </summary>
        public string Name { get; set; }
        /// <summary> The idle timeout of the public IP address. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
        /// <summary> The dns settings to be applied on the publicIP addresses . </summary>
        internal VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings DnsSettings { get; set; }
        /// <summary> The Domain name label.The concatenation of the domain name label and vm index will be the domain name labels of the PublicIPAddress resources that will be created. </summary>
        public string DnsDomainNameLabel
        {
            get => DnsSettings is null ? default : DnsSettings.DomainNameLabel;
            set => DnsSettings = new VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(value);
        }

        /// <summary> The PublicIPPrefix from which to allocate publicIP addresses. </summary>
        internal WritableSubResource PublicIPPrefix { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PublicIPPrefixId
        {
            get => PublicIPPrefix is null ? default : PublicIPPrefix.Id;
            set
            {
                if (PublicIPPrefix is null)
                    PublicIPPrefix = new WritableSubResource();
                PublicIPPrefix.Id = value;
            }
        }

        /// <summary> Specify what happens to the public IP when the VM is deleted. </summary>
        public ComputeDeleteOption? DeleteOption { get; set; }
    }
}
