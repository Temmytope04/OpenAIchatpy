// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Lab services virtual machine image for updates. </summary>
    public partial class LabVirtualMachineImagePatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LabVirtualMachineImagePatch"/>. </summary>
        public LabVirtualMachineImagePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LabVirtualMachineImagePatch"/>. </summary>
        /// <param name="enabledState"> Is the image enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LabVirtualMachineImagePatch(LabServicesEnableState? enabledState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EnabledState = enabledState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Is the image enabled. </summary>
        public LabServicesEnableState? EnabledState { get; set; }
    }
}
