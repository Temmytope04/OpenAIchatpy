// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The UpdateLandingZoneCredential. </summary>
    public partial class UpdateLandingZoneCredential
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UpdateLandingZoneCredential"/>. </summary>
        public UpdateLandingZoneCredential()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UpdateLandingZoneCredential"/>. </summary>
        /// <param name="sasToken"> Landing zone's sas token. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UpdateLandingZoneCredential(SecureString sasToken, Dictionary<string, BinaryData> rawData)
        {
            SasToken = sasToken;
            _rawData = rawData;
        }

        /// <summary> Landing zone's sas token. </summary>
        public SecureString SasToken { get; set; }
    }
}
