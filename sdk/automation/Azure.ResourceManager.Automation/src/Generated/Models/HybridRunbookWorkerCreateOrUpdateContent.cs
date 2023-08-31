// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create hybrid runbook worker operation. </summary>
    public partial class HybridRunbookWorkerCreateOrUpdateContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HybridRunbookWorkerCreateOrUpdateContent"/>. </summary>
        public HybridRunbookWorkerCreateOrUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HybridRunbookWorkerCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets the name of the resource. </param>
        /// <param name="vmResourceId"> Azure Resource Manager Id for a virtual machine. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HybridRunbookWorkerCreateOrUpdateContent(string name, ResourceIdentifier vmResourceId, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            VmResourceId = vmResourceId;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the name of the resource. </summary>
        public string Name { get; set; }
        /// <summary> Azure Resource Manager Id for a virtual machine. </summary>
        public ResourceIdentifier VmResourceId { get; set; }
    }
}
