// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// The properties used to create a new server.             Please note
/// Azure.ResourceManager.PostgreSql.Models.PostgreSqlServerPropertiesForCreate
/// is the base class. According to the scenario, a derived class of the base
/// class might need to be assigned here, or this property needs to be casted
/// to one of the possible derived classes.             The available derived
/// classes include
/// Azure.ResourceManager.PostgreSql.Models.PostgreSqlServerPropertiesForDefaultCreate,
/// Azure.ResourceManager.PostgreSql.Models.PostgreSqlServerPropertiesForGeoRestore,
/// Azure.ResourceManager.PostgreSql.Models.PostgreSqlServerPropertiesForRestore
/// and
/// Azure.ResourceManager.PostgreSql.Models.PostgreSqlServerPropertiesForReplica.
/// </summary>
public partial class PostgreSqlServerPropertiesForCreate : ProvisionableConstruct
{
    /// <summary>
    /// Server version.
    /// </summary>
    public BicepValue<PostgreSqlServerVersion> Version { get => _version; set => _version.Assign(value); }
    private readonly BicepValue<PostgreSqlServerVersion> _version;

    /// <summary>
    /// Enable ssl enforcement or not when connect to server.
    /// </summary>
    public BicepValue<PostgreSqlSslEnforcementEnum> SslEnforcement { get => _sslEnforcement; set => _sslEnforcement.Assign(value); }
    private readonly BicepValue<PostgreSqlSslEnforcementEnum> _sslEnforcement;

    /// <summary>
    /// Enforce a minimal Tls version for the server.
    /// </summary>
    public BicepValue<PostgreSqlMinimalTlsVersionEnum> MinimalTlsVersion { get => _minimalTlsVersion; set => _minimalTlsVersion.Assign(value); }
    private readonly BicepValue<PostgreSqlMinimalTlsVersionEnum> _minimalTlsVersion;

    /// <summary>
    /// Status showing whether the server enabled infrastructure encryption.
    /// </summary>
    public BicepValue<PostgreSqlInfrastructureEncryption> InfrastructureEncryption { get => _infrastructureEncryption; set => _infrastructureEncryption.Assign(value); }
    private readonly BicepValue<PostgreSqlInfrastructureEncryption> _infrastructureEncryption;

    /// <summary>
    /// Whether or not public network access is allowed for this server. Value
    /// is optional but if passed in, must be &apos;Enabled&apos; or
    /// &apos;Disabled&apos;.
    /// </summary>
    public BicepValue<PostgreSqlPublicNetworkAccessEnum> PublicNetworkAccess { get => _publicNetworkAccess; set => _publicNetworkAccess.Assign(value); }
    private readonly BicepValue<PostgreSqlPublicNetworkAccessEnum> _publicNetworkAccess;

    /// <summary>
    /// Storage profile of a server.
    /// </summary>
    public BicepValue<PostgreSqlStorageProfile> StorageProfile { get => _storageProfile; set => _storageProfile.Assign(value); }
    private readonly BicepValue<PostgreSqlStorageProfile> _storageProfile;

    /// <summary>
    /// Creates a new PostgreSqlServerPropertiesForCreate.
    /// </summary>
    public PostgreSqlServerPropertiesForCreate()
    {
        _version = BicepValue<PostgreSqlServerVersion>.DefineProperty(this, "Version", ["version"]);
        _sslEnforcement = BicepValue<PostgreSqlSslEnforcementEnum>.DefineProperty(this, "SslEnforcement", ["sslEnforcement"]);
        _minimalTlsVersion = BicepValue<PostgreSqlMinimalTlsVersionEnum>.DefineProperty(this, "MinimalTlsVersion", ["minimalTlsVersion"]);
        _infrastructureEncryption = BicepValue<PostgreSqlInfrastructureEncryption>.DefineProperty(this, "InfrastructureEncryption", ["infrastructureEncryption"]);
        _publicNetworkAccess = BicepValue<PostgreSqlPublicNetworkAccessEnum>.DefineProperty(this, "PublicNetworkAccess", ["publicNetworkAccess"]);
        _storageProfile = BicepValue<PostgreSqlStorageProfile>.DefineProperty(this, "StorageProfile", ["storageProfile"]);
    }
}
