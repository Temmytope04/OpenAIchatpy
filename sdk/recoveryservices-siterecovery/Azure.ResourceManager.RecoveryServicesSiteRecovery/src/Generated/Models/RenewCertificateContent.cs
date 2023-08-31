// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Certificate renewal input. </summary>
    public partial class RenewCertificateContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RenewCertificateContent"/>. </summary>
        public RenewCertificateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RenewCertificateContent"/>. </summary>
        /// <param name="properties"> Renew certificate input properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RenewCertificateContent(RenewCertificateContentProperties properties, Dictionary<string, BinaryData> rawData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Renew certificate input properties. </summary>
        internal RenewCertificateContentProperties Properties { get; set; }
        /// <summary> Renew certificate type. </summary>
        public string RenewCertificateType
        {
            get => Properties is null ? default : Properties.RenewCertificateType;
            set
            {
                if (Properties is null)
                    Properties = new RenewCertificateContentProperties();
                Properties.RenewCertificateType = value;
            }
        }
    }
}
