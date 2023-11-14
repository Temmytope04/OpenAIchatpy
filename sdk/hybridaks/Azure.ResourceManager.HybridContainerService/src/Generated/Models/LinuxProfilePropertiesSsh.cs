// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> SSH - SSH configuration for Linux-based VMs running on Azure. </summary>
    internal partial class LinuxProfilePropertiesSsh
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LinuxProfilePropertiesSsh"/>. </summary>
        public LinuxProfilePropertiesSsh()
        {
            PublicKeys = new ChangeTrackingList<LinuxProfilePropertiesSshPublicKeysItem>();
        }

        /// <summary> Initializes a new instance of <see cref="LinuxProfilePropertiesSsh"/>. </summary>
        /// <param name="publicKeys"> PublicKeys - The list of SSH public keys used to authenticate with Linux-based VMs. Only expect one key specified. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LinuxProfilePropertiesSsh(IList<LinuxProfilePropertiesSshPublicKeysItem> publicKeys, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PublicKeys = publicKeys;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> PublicKeys - The list of SSH public keys used to authenticate with Linux-based VMs. Only expect one key specified. </summary>
        public IList<LinuxProfilePropertiesSshPublicKeysItem> PublicKeys { get; }
    }
}
