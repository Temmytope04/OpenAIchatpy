// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The retention details of the MT. </summary>
    public partial class SiteRecoveryRetentionVolume
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryRetentionVolume"/>. </summary>
        internal SiteRecoveryRetentionVolume()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryRetentionVolume"/>. </summary>
        /// <param name="volumeName"> The volume name. </param>
        /// <param name="capacityInBytes"> The volume capacity. </param>
        /// <param name="freeSpaceInBytes"> The free space available in this volume. </param>
        /// <param name="thresholdPercentage"> The threshold percentage. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryRetentionVolume(string volumeName, long? capacityInBytes, long? freeSpaceInBytes, int? thresholdPercentage, Dictionary<string, BinaryData> rawData)
        {
            VolumeName = volumeName;
            CapacityInBytes = capacityInBytes;
            FreeSpaceInBytes = freeSpaceInBytes;
            ThresholdPercentage = thresholdPercentage;
            _rawData = rawData;
        }

        /// <summary> The volume name. </summary>
        public string VolumeName { get; }
        /// <summary> The volume capacity. </summary>
        public long? CapacityInBytes { get; }
        /// <summary> The free space available in this volume. </summary>
        public long? FreeSpaceInBytes { get; }
        /// <summary> The threshold percentage. </summary>
        public int? ThresholdPercentage { get; }
    }
}
