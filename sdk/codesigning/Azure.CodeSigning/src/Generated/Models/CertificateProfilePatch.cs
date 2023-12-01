// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Developer.Signing.Models
{
    /// <summary> Certificate Profile Patch Properties. </summary>
    public partial class CertificateProfilePatch
    {
        /// <summary> Initializes a new instance of CertificateProfilePatch. </summary>
        public CertificateProfilePatch()
        {
            Certificates = new ChangeTrackingList<Certificate>();
        }

        /// <summary> Gets the certificates. </summary>
        public IList<Certificate> Certificates { get; }
    }
}
