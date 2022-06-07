// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Collection of instances belong to the Application Configuration Service. </summary>
    public partial class ConfigurationServiceInstance
    {
        /// <summary> Initializes a new instance of ConfigurationServiceInstance. </summary>
        internal ConfigurationServiceInstance()
        {
        }

        /// <summary> Initializes a new instance of ConfigurationServiceInstance. </summary>
        /// <param name="name"> Name of the Application Configuration Service instance. </param>
        /// <param name="status"> Status of the Application Configuration Service instance. </param>
        internal ConfigurationServiceInstance(string name, string status)
        {
            Name = name;
            Status = status;
        }

        /// <summary> Name of the Application Configuration Service instance. </summary>
        public string Name { get; }
        /// <summary> Status of the Application Configuration Service instance. </summary>
        public string Status { get; }
    }
}
