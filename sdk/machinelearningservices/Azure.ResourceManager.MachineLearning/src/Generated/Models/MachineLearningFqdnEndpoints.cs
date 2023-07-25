// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningFqdnEndpoints. </summary>
    public partial class MachineLearningFqdnEndpoints
    {
        /// <summary> Initializes a new instance of MachineLearningFqdnEndpoints. </summary>
        internal MachineLearningFqdnEndpoints()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningFqdnEndpoints. </summary>
        /// <param name="properties"></param>
        internal MachineLearningFqdnEndpoints(MachineLearningFqdnEndpointsProperties properties)
        {
            Properties = properties;
        }

        /// <summary> Gets the properties. </summary>
        public MachineLearningFqdnEndpointsProperties Properties { get; }
    }
}
