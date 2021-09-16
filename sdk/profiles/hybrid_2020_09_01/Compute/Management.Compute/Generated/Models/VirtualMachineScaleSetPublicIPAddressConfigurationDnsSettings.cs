// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Compute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machines scale sets network configuration's DNS
    /// settings.
    /// </summary>
    public partial class VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings
        /// class.
        /// </summary>
        public VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings
        /// class.
        /// </summary>
        /// <param name="domainNameLabel">The Domain name label.The
        /// concatenation of the domain name label and vm index will be the
        /// domain name labels of the PublicIPAddress resources that will be
        /// created</param>
        public VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(string domainNameLabel)
        {
            DomainNameLabel = domainNameLabel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Domain name label.The concatenation of the domain
        /// name label and vm index will be the domain name labels of the
        /// PublicIPAddress resources that will be created
        /// </summary>
        [JsonProperty(PropertyName = "domainNameLabel")]
        public string DomainNameLabel { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DomainNameLabel == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DomainNameLabel");
            }
        }
    }
}
