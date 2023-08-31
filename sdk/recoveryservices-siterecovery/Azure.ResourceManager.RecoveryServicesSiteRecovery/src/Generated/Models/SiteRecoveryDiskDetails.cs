// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Onprem disk details data. </summary>
    public partial class SiteRecoveryDiskDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryDiskDetails"/>. </summary>
        internal SiteRecoveryDiskDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryDiskDetails"/>. </summary>
        /// <param name="maxSizeMB"> The hard disk max size in MB. </param>
        /// <param name="vhdType"> The type of the volume. </param>
        /// <param name="vhdId"> The VHD Id. </param>
        /// <param name="vhdName"> The VHD name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryDiskDetails(long? maxSizeMB, string vhdType, string vhdId, string vhdName, Dictionary<string, BinaryData> rawData)
        {
            MaxSizeMB = maxSizeMB;
            VhdType = vhdType;
            VhdId = vhdId;
            VhdName = vhdName;
            _rawData = rawData;
        }

        /// <summary> The hard disk max size in MB. </summary>
        public long? MaxSizeMB { get; }
        /// <summary> The type of the volume. </summary>
        public string VhdType { get; }
        /// <summary> The VHD Id. </summary>
        public string VhdId { get; }
        /// <summary> The VHD name. </summary>
        public string VhdName { get; }
    }
}
