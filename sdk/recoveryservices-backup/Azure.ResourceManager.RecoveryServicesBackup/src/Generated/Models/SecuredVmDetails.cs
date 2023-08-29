// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Restore request parameters for Secured VMs. </summary>
    internal partial class SecuredVmDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SecuredVmDetails"/>. </summary>
        public SecuredVmDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecuredVmDetails"/>. </summary>
        /// <param name="securedVmOSDiskEncryptionSetId"> Gets or Sets Disk Encryption Set Id for Secured VM OS Disk. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecuredVmDetails(ResourceIdentifier securedVmOSDiskEncryptionSetId, Dictionary<string, BinaryData> rawData)
        {
            SecuredVmOSDiskEncryptionSetId = securedVmOSDiskEncryptionSetId;
            _rawData = rawData;
        }

        /// <summary> Gets or Sets Disk Encryption Set Id for Secured VM OS Disk. </summary>
        public ResourceIdentifier SecuredVmOSDiskEncryptionSetId { get; set; }
    }
}
