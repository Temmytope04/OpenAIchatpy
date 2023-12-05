// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the update certificate operation. </summary>
    public partial class AutomationCertificatePatch
    {
        /// <summary> Initializes a new instance of <see cref="AutomationCertificatePatch"/>. </summary>
        public AutomationCertificatePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomationCertificatePatch"/>. </summary>
        /// <param name="name"> Gets or sets the name of the certificate. </param>
        /// <param name="description"> Gets or sets the description of the certificate. </param>
        internal AutomationCertificatePatch(string name, string description)
        {
            Name = name;
            Description = description;
        }

        /// <summary> Gets or sets the name of the certificate. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the description of the certificate. </summary>
        public string Description { get; set; }
    }
}
