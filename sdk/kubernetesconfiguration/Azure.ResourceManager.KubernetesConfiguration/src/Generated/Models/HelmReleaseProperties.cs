// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Properties for HelmRelease objects. </summary>
    public partial class HelmReleaseProperties
    {
        /// <summary> Initializes a new instance of HelmReleaseProperties. </summary>
        internal HelmReleaseProperties()
        {
        }

        /// <summary> Initializes a new instance of HelmReleaseProperties. </summary>
        /// <param name="lastRevisionApplied"> The revision number of the last released object change. </param>
        /// <param name="helmChartRef"> The reference to the HelmChart object used as the source to this HelmRelease. </param>
        /// <param name="failureCount"> Total number of times that the HelmRelease failed to install or upgrade. </param>
        /// <param name="installFailureCount"> Number of times that the HelmRelease failed to install. </param>
        /// <param name="upgradeFailureCount"> Number of times that the HelmRelease failed to upgrade. </param>
        internal HelmReleaseProperties(long? lastRevisionApplied, KubernetesObjectReference helmChartRef, long? failureCount, long? installFailureCount, long? upgradeFailureCount)
        {
            LastRevisionApplied = lastRevisionApplied;
            HelmChartRef = helmChartRef;
            FailureCount = failureCount;
            InstallFailureCount = installFailureCount;
            UpgradeFailureCount = upgradeFailureCount;
        }

        /// <summary> The revision number of the last released object change. </summary>
        public long? LastRevisionApplied { get; }
        /// <summary> The reference to the HelmChart object used as the source to this HelmRelease. </summary>
        public KubernetesObjectReference HelmChartRef { get; }
        /// <summary> Total number of times that the HelmRelease failed to install or upgrade. </summary>
        public long? FailureCount { get; }
        /// <summary> Number of times that the HelmRelease failed to install. </summary>
        public long? InstallFailureCount { get; }
        /// <summary> Number of times that the HelmRelease failed to upgrade. </summary>
        public long? UpgradeFailureCount { get; }
    }
}
