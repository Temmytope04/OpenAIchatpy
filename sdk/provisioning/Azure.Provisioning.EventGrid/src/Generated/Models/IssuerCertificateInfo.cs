// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// Information about the certificate that is used for token validation.
/// </summary>
public partial class IssuerCertificateInfo : ProvisioningConstruct
{
    /// <summary>
    /// Keyvault certificate URL in
    /// https://keyvaultname.vault.azure.net/certificates/certificateName/certificateVersion
    /// format.
    /// </summary>
    public BicepValue<Uri> CertificateUri { get => _certificateUri; set => _certificateUri.Assign(value); }
    private readonly BicepValue<Uri> _certificateUri;

    /// <summary>
    /// The identity that will be used to access the certificate.
    /// </summary>
    public BicepValue<CustomJwtAuthenticationManagedIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<CustomJwtAuthenticationManagedIdentity> _identity;

    /// <summary>
    /// Creates a new IssuerCertificateInfo.
    /// </summary>
    public IssuerCertificateInfo()
    {
        _certificateUri = BicepValue<Uri>.DefineProperty(this, "CertificateUri", ["certificateUrl"]);
        _identity = BicepValue<CustomJwtAuthenticationManagedIdentity>.DefineProperty(this, "Identity", ["identity"]);
    }
}
