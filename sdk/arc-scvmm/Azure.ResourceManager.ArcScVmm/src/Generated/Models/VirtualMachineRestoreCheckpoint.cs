// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> Defines the restore checkpoint action properties. </summary>
    public partial class VirtualMachineRestoreCheckpoint
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineRestoreCheckpoint"/>. </summary>
        public VirtualMachineRestoreCheckpoint()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineRestoreCheckpoint"/>. </summary>
        /// <param name="id"> ID of the checkpoint to be restored to. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineRestoreCheckpoint(string id, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            _rawData = rawData;
        }

        /// <summary> ID of the checkpoint to be restored to. </summary>
        public string Id { get; set; }
    }
}
