// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> TLS endpoint describes an endpoint that the pipeline can connect to over TLS transport (data is encrypted in transit). </summary>
    public partial class TlsEndpoint : EndpointBase
    {
        /// <summary> Initializes a new instance of <see cref="TlsEndpoint"/>. </summary>
        /// <param name="url"> The endpoint URL for Video Analyzer to connect to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> is null. </exception>
        public TlsEndpoint(string url) : base(url)
        {
            Argument.AssertNotNull(url, nameof(url));

            Type = "#Microsoft.VideoAnalyzer.TlsEndpoint";
        }

        /// <summary> Initializes a new instance of <see cref="TlsEndpoint"/>. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="credentials">
        /// Credentials to be presented to the endpoint.
        /// Please note <see cref="CredentialsBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HttpHeaderCredentials"/>, <see cref="SymmetricKeyCredentials"/> and <see cref="UsernamePasswordCredentials"/>.
        /// </param>
        /// <param name="url"> The endpoint URL for Video Analyzer to connect to. </param>
        /// <param name="trustedCertificates">
        /// List of trusted certificate authorities when authenticating a TLS connection. A null list designates that Azure Video Analyzer's list of trusted authorities should be used.
        /// Please note <see cref="CertificateSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="PemCertificateList"/>.
        /// </param>
        /// <param name="validationOptions"> Validation options to use when authenticating a TLS connection. By default, strict validation is used. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TlsEndpoint(string type, CredentialsBase credentials, string url, CertificateSource trustedCertificates, TlsValidationOptions validationOptions, Dictionary<string, BinaryData> rawData) : base(type, credentials, url, rawData)
        {
            TrustedCertificates = trustedCertificates;
            ValidationOptions = validationOptions;
            Type = type ?? "#Microsoft.VideoAnalyzer.TlsEndpoint";
        }

        /// <summary> Initializes a new instance of <see cref="TlsEndpoint"/> for deserialization. </summary>
        internal TlsEndpoint()
        {
        }

        /// <summary>
        /// List of trusted certificate authorities when authenticating a TLS connection. A null list designates that Azure Video Analyzer's list of trusted authorities should be used.
        /// Please note <see cref="CertificateSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="PemCertificateList"/>.
        /// </summary>
        public CertificateSource TrustedCertificates { get; set; }
        /// <summary> Validation options to use when authenticating a TLS connection. By default, strict validation is used. </summary>
        public TlsValidationOptions ValidationOptions { get; set; }
    }
}
