// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Port mappings of container app ingress. </summary>
    public partial class IngressPortMapping
    {
        /// <summary> Initializes a new instance of IngressPortMapping. </summary>
        /// <param name="external"> Specifies whether the app port is accessible outside of the environment. </param>
        /// <param name="targetPort"> Specifies the port user's container listens on. </param>
        public IngressPortMapping(bool external, int targetPort)
        {
            External = external;
            TargetPort = targetPort;
        }

        /// <summary> Initializes a new instance of IngressPortMapping. </summary>
        /// <param name="external"> Specifies whether the app port is accessible outside of the environment. </param>
        /// <param name="targetPort"> Specifies the port user's container listens on. </param>
        /// <param name="exposedPort"> Specifies the exposed port for the target port. If not specified, it defaults to target port. </param>
        internal IngressPortMapping(bool external, int targetPort, int? exposedPort)
        {
            External = external;
            TargetPort = targetPort;
            ExposedPort = exposedPort;
        }

        /// <summary> Specifies whether the app port is accessible outside of the environment. </summary>
        public bool External { get; set; }
        /// <summary> Specifies the port user's container listens on. </summary>
        public int TargetPort { get; set; }
        /// <summary> Specifies the exposed port for the target port. If not specified, it defaults to target port. </summary>
        public int? ExposedPort { get; set; }
    }
}
