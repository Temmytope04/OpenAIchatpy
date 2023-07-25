// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Resource request payload of Service Registry. </summary>
    public partial class AppPlatformServiceRegistryResourceRequirements
    {
        /// <summary> Initializes a new instance of AppPlatformServiceRegistryResourceRequirements. </summary>
        internal AppPlatformServiceRegistryResourceRequirements()
        {
        }

        /// <summary> Initializes a new instance of AppPlatformServiceRegistryResourceRequirements. </summary>
        /// <param name="cpu"> Cpu allocated to each Service Registry instance. </param>
        /// <param name="memory"> Memory allocated to each Service Registry instance. </param>
        /// <param name="instanceCount"> Instance count of the Service Registry. </param>
        internal AppPlatformServiceRegistryResourceRequirements(string cpu, string memory, int? instanceCount)
        {
            Cpu = cpu;
            Memory = memory;
            InstanceCount = instanceCount;
        }

        /// <summary> Cpu allocated to each Service Registry instance. </summary>
        public string Cpu { get; }
        /// <summary> Memory allocated to each Service Registry instance. </summary>
        public string Memory { get; }
        /// <summary> Instance count of the Service Registry. </summary>
        public int? InstanceCount { get; }
    }
}
