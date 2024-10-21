// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.KeyVault;

/// <summary>
/// Properties of the secret.
/// </summary>
public partial class SecretProperties : ProvisionableConstruct
{
    /// <summary>
    /// The value of the secret. NOTE: &apos;value&apos; will never be returned
    /// from the service, as APIs using this model are is intended for
    /// internal use in ARM deployments. Users should use the data-plane REST
    /// service for interaction with vault secrets.
    /// </summary>
    public BicepValue<string> Value { get => _value; set => _value.Assign(value); }
    private readonly BicepValue<string> _value;

    /// <summary>
    /// The content type of the secret.
    /// </summary>
    public BicepValue<string> ContentType { get => _contentType; set => _contentType.Assign(value); }
    private readonly BicepValue<string> _contentType;

    /// <summary>
    /// The attributes of the secret.
    /// </summary>
    public BicepValue<SecretAttributes> Attributes { get => _attributes; set => _attributes.Assign(value); }
    private readonly BicepValue<SecretAttributes> _attributes;

    /// <summary>
    /// The URI to retrieve the current version of the secret.
    /// </summary>
    public BicepValue<Uri> SecretUri { get => _secretUri; }
    private readonly BicepValue<Uri> _secretUri;

    /// <summary>
    /// The URI to retrieve the specific version of the secret.
    /// </summary>
    public BicepValue<string> SecretUriWithVersion { get => _secretUriWithVersion; }
    private readonly BicepValue<string> _secretUriWithVersion;

    /// <summary>
    /// Creates a new SecretProperties.
    /// </summary>
    public SecretProperties()
    {
        _value = BicepValue<string>.DefineProperty(this, "Value", ["value"]);
        _contentType = BicepValue<string>.DefineProperty(this, "ContentType", ["contentType"]);
        _attributes = BicepValue<SecretAttributes>.DefineProperty(this, "Attributes", ["attributes"]);
        _secretUri = BicepValue<Uri>.DefineProperty(this, "SecretUri", ["secretUri"], isOutput: true);
        _secretUriWithVersion = BicepValue<string>.DefineProperty(this, "SecretUriWithVersion", ["secretUriWithVersion"], isOutput: true);
    }
}
