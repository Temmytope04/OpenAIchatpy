// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The authentication info when authType is servicePrincipal certificate. </summary>
    public partial class ServicePrincipalCertificateAuthInfo : AuthBaseInfo
    {
        /// <summary> Initializes a new instance of <see cref="ServicePrincipalCertificateAuthInfo"/>. </summary>
        /// <param name="clientId"> Application clientId for servicePrincipal auth. </param>
        /// <param name="principalId"> Principal Id for servicePrincipal auth. </param>
        /// <param name="certificate"> ServicePrincipal certificate for servicePrincipal auth. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientId"/> or <paramref name="certificate"/> is null. </exception>
        public ServicePrincipalCertificateAuthInfo(string clientId, Guid principalId, string certificate)
        {
            Argument.AssertNotNull(clientId, nameof(clientId));
            Argument.AssertNotNull(certificate, nameof(certificate));

            ClientId = clientId;
            PrincipalId = principalId;
            Certificate = certificate;
            AuthType = LinkerAuthType.ServicePrincipalCertificate;
        }

        /// <summary> Initializes a new instance of <see cref="ServicePrincipalCertificateAuthInfo"/>. </summary>
        /// <param name="authType"> The authentication type. </param>
        /// <param name="clientId"> Application clientId for servicePrincipal auth. </param>
        /// <param name="principalId"> Principal Id for servicePrincipal auth. </param>
        /// <param name="certificate"> ServicePrincipal certificate for servicePrincipal auth. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ServicePrincipalCertificateAuthInfo(LinkerAuthType authType, string clientId, Guid principalId, string certificate, Dictionary<string, BinaryData> rawData) : base(authType, rawData)
        {
            ClientId = clientId;
            PrincipalId = principalId;
            Certificate = certificate;
            AuthType = authType;
        }

        /// <summary> Initializes a new instance of <see cref="ServicePrincipalCertificateAuthInfo"/> for deserialization. </summary>
        internal ServicePrincipalCertificateAuthInfo()
        {
        }

        /// <summary> Application clientId for servicePrincipal auth. </summary>
        public string ClientId { get; set; }
        /// <summary> Principal Id for servicePrincipal auth. </summary>
        public Guid PrincipalId { get; set; }
        /// <summary> ServicePrincipal certificate for servicePrincipal auth. </summary>
        public string Certificate { get; set; }
    }
}
