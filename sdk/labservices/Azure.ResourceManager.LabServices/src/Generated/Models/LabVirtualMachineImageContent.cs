// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Body for the save image POST. </summary>
    public partial class LabVirtualMachineImageContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LabVirtualMachineImageContent"/>. </summary>
        public LabVirtualMachineImageContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LabVirtualMachineImageContent"/>. </summary>
        /// <param name="name"> The name for the image we create. </param>
        /// <param name="labVirtualMachineId"> The ID of the lab virtual machine you want to save an image from. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LabVirtualMachineImageContent(string name, ResourceIdentifier labVirtualMachineId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            LabVirtualMachineId = labVirtualMachineId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name for the image we create. </summary>
        public string Name { get; set; }
        /// <summary> The ID of the lab virtual machine you want to save an image from. </summary>
        public ResourceIdentifier LabVirtualMachineId { get; set; }
    }
}
