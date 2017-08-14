// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ContainerInstance.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ContainerInstance;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The resource requests.
    /// </summary>
    public partial class ResourceRequests
    {
        /// <summary>
        /// Initializes a new instance of the ResourceRequests class.
        /// </summary>
        public ResourceRequests()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceRequests class.
        /// </summary>
        /// <param name="memoryInGB">The memory request in GB of this
        /// container.</param>
        /// <param name="cpu">The CPU request of this container.</param>
        public ResourceRequests(double memoryInGB, double cpu)
        {
            MemoryInGB = memoryInGB;
            Cpu = cpu;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the memory request in GB of this container.
        /// </summary>
        [JsonProperty(PropertyName = "memoryInGB")]
        public double MemoryInGB { get; set; }

        /// <summary>
        /// Gets or sets the CPU request of this container.
        /// </summary>
        [JsonProperty(PropertyName = "cpu")]
        public double Cpu { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
