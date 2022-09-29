// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Elastic.Models
{
    /// <summary> Update VM resource collection. </summary>
    public partial class VmCollectionUpdate
    {
        /// <summary> Initializes a new instance of VmCollectionUpdate. </summary>
        public VmCollectionUpdate()
        {
        }

        /// <summary> ARM id of the VM resource. </summary>
        public string VmResourceId { get; set; }
        /// <summary> Operation to be performed for given VM. </summary>
        public OperationName? OperationName { get; set; }
    }
}
