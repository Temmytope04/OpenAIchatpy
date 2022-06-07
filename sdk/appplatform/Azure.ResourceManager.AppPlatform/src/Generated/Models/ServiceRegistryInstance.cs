// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Collection of instances belong to the Service Registry. </summary>
    public partial class ServiceRegistryInstance
    {
        /// <summary> Initializes a new instance of ServiceRegistryInstance. </summary>
        internal ServiceRegistryInstance()
        {
        }

        /// <summary> Initializes a new instance of ServiceRegistryInstance. </summary>
        /// <param name="name"> Name of the Service Registry instance. </param>
        /// <param name="status"> Status of the Service Registry instance. </param>
        internal ServiceRegistryInstance(string name, string status)
        {
            Name = name;
            Status = status;
        }

        /// <summary> Name of the Service Registry instance. </summary>
        public string Name { get; }
        /// <summary> Status of the Service Registry instance. </summary>
        public string Status { get; }
    }
}
