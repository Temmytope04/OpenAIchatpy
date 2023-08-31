// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> Defines the virtualMachineUpdate. </summary>
    public partial class ScVmmVirtualMachinePatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ScVmmVirtualMachinePatch"/>. </summary>
        public ScVmmVirtualMachinePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ScVmmVirtualMachinePatch"/>. </summary>
        /// <param name="properties"> Defines the resource properties. </param>
        /// <param name="tags"> Gets or sets the Resource tags. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ScVmmVirtualMachinePatch(VirtualMachineUpdateProperties properties, IDictionary<string, string> tags, Dictionary<string, BinaryData> rawData)
        {
            Properties = properties;
            Tags = tags;
            _rawData = rawData;
        }

        /// <summary> Defines the resource properties. </summary>
        public VirtualMachineUpdateProperties Properties { get; set; }
        /// <summary> Gets or sets the Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
