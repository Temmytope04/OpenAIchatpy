// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Kubernetes role compute resource. </summary>
    public partial class EdgeKubernetesRoleCompute
    {
        /// <summary> Initializes a new instance of <see cref="EdgeKubernetesRoleCompute"/>. </summary>
        /// <param name="vmProfile"> VM profile. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmProfile"/> is null. </exception>
        public EdgeKubernetesRoleCompute(string vmProfile)
        {
            Argument.AssertNotNull(vmProfile, nameof(vmProfile));

            VmProfile = vmProfile;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeKubernetesRoleCompute"/>. </summary>
        /// <param name="vmProfile"> VM profile. </param>
        /// <param name="memoryInBytes"> Memory in bytes. </param>
        /// <param name="processorCount"> Processor count. </param>
        internal EdgeKubernetesRoleCompute(string vmProfile, long? memoryInBytes, int? processorCount)
        {
            VmProfile = vmProfile;
            MemoryInBytes = memoryInBytes;
            ProcessorCount = processorCount;
        }

        /// <summary> VM profile. </summary>
        public string VmProfile { get; set; }
        /// <summary> Memory in bytes. </summary>
        public long? MemoryInBytes { get; }
        /// <summary> Processor count. </summary>
        public int? ProcessorCount { get; }
    }
}
