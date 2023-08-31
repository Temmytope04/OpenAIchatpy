// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> A VM Family and its associated core quota for the Batch account. </summary>
    public partial class BatchVmFamilyCoreQuota
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BatchVmFamilyCoreQuota"/>. </summary>
        internal BatchVmFamilyCoreQuota()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BatchVmFamilyCoreQuota"/>. </summary>
        /// <param name="name"> The Virtual Machine family name. </param>
        /// <param name="coreQuota"> The core quota for the VM family for the Batch account. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchVmFamilyCoreQuota(string name, int? coreQuota, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            CoreQuota = coreQuota;
            _rawData = rawData;
        }

        /// <summary> The Virtual Machine family name. </summary>
        public string Name { get; }
        /// <summary> The core quota for the VM family for the Batch account. </summary>
        public int? CoreQuota { get; }
    }
}
