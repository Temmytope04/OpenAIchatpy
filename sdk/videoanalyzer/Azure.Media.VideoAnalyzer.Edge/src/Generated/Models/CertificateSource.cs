// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary>
    /// Base class for certificate sources.
    /// Please note <see cref="CertificateSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="PemCertificateList"/>.
    /// </summary>
    public abstract partial class CertificateSource
    {
        /// <summary> Initializes a new instance of CertificateSource. </summary>
        protected CertificateSource()
        {
        }

        /// <summary> Initializes a new instance of CertificateSource. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        internal CertificateSource(string type)
        {
            Type = type;
        }

        /// <summary> Type discriminator for the derived types. </summary>
        internal string Type { get; set; }
    }
}
