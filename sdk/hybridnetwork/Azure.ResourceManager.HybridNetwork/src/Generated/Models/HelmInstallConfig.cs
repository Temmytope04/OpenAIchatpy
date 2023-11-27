// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The helm deployment install options. </summary>
    public partial class HelmInstallConfig
    {
        /// <summary> Initializes a new instance of <see cref="HelmInstallConfig"/>. </summary>
        public HelmInstallConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HelmInstallConfig"/>. </summary>
        /// <param name="atomic"> The helm deployment atomic options. </param>
        /// <param name="wait"> The helm deployment wait options. </param>
        /// <param name="timeout"> The helm deployment timeout options. </param>
        internal HelmInstallConfig(string atomic, string wait, string timeout)
        {
            Atomic = atomic;
            Wait = wait;
            Timeout = timeout;
        }

        /// <summary> The helm deployment atomic options. </summary>
        public string Atomic { get; set; }
        /// <summary> The helm deployment wait options. </summary>
        public string Wait { get; set; }
        /// <summary> The helm deployment timeout options. </summary>
        public string Timeout { get; set; }
    }
}
