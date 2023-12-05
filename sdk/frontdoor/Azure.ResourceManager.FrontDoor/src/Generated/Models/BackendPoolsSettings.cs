// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Settings that apply to all backend pools. </summary>
    public partial class BackendPoolsSettings
    {
        /// <summary> Initializes a new instance of <see cref="BackendPoolsSettings"/>. </summary>
        public BackendPoolsSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackendPoolsSettings"/>. </summary>
        /// <param name="enforceCertificateNameCheck"> Whether to enforce certificate name check on HTTPS requests to all backend pools. No effect on non-HTTPS requests. </param>
        /// <param name="sendRecvTimeoutInSeconds"> Send and receive timeout on forwarding request to the backend. When timeout is reached, the request fails and returns. </param>
        internal BackendPoolsSettings(EnforceCertificateNameCheckEnabledState? enforceCertificateNameCheck, int? sendRecvTimeoutInSeconds)
        {
            EnforceCertificateNameCheck = enforceCertificateNameCheck;
            SendRecvTimeoutInSeconds = sendRecvTimeoutInSeconds;
        }

        /// <summary> Whether to enforce certificate name check on HTTPS requests to all backend pools. No effect on non-HTTPS requests. </summary>
        public EnforceCertificateNameCheckEnabledState? EnforceCertificateNameCheck { get; set; }
        /// <summary> Send and receive timeout on forwarding request to the backend. When timeout is reached, the request fails and returns. </summary>
        public int? SendRecvTimeoutInSeconds { get; set; }
    }
}
