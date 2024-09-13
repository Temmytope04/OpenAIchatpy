// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// SqlServerAzureADAdministrator.
/// </summary>
public partial class SqlServerAzureADAdministrator : Resource
{
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Type of the sever administrator.
    /// </summary>
    public BicepValue<SqlAdministratorType> AdministratorType { get => _administratorType; set => _administratorType.Assign(value); }
    private readonly BicepValue<SqlAdministratorType> _administratorType;

    /// <summary>
    /// Login name of the server administrator.
    /// </summary>
    public BicepValue<string> Login { get => _login; set => _login.Assign(value); }
    private readonly BicepValue<string> _login;

    /// <summary>
    /// SID (object ID) of the server administrator.
    /// </summary>
    public BicepValue<Guid> Sid { get => _sid; set => _sid.Assign(value); }
    private readonly BicepValue<Guid> _sid;

    /// <summary>
    /// Tenant ID of the administrator.
    /// </summary>
    public BicepValue<Guid> TenantId { get => _tenantId; set => _tenantId.Assign(value); }
    private readonly BicepValue<Guid> _tenantId;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Azure Active Directory only Authentication enabled.
    /// </summary>
    public BicepValue<bool> IsAzureADOnlyAuthenticationEnabled { get => _isAzureADOnlyAuthenticationEnabled; }
    private readonly BicepValue<bool> _isAzureADOnlyAuthenticationEnabled;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent SqlServer.
    /// </summary>
    public SqlServer? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<SqlServer> _parent;

    /// <summary>
    /// Get the default value for the Name property.
    /// </summary>
    private partial BicepValue<string> GetNameDefaultValue();

    /// <summary>
    /// Creates a new SqlServerAzureADAdministrator.
    /// </summary>
    /// <param name="resourceName">Name of the SqlServerAzureADAdministrator.</param>
    /// <param name="resourceVersion">Version of the SqlServerAzureADAdministrator.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public SqlServerAzureADAdministrator(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Sql/servers/administrators", resourceVersion ?? "2021-11-01", context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true, defaultValue: GetNameDefaultValue());
        _administratorType = BicepValue<SqlAdministratorType>.DefineProperty(this, "AdministratorType", ["properties", "administratorType"]);
        _login = BicepValue<string>.DefineProperty(this, "Login", ["properties", "login"]);
        _sid = BicepValue<Guid>.DefineProperty(this, "Sid", ["properties", "sid"]);
        _tenantId = BicepValue<Guid>.DefineProperty(this, "TenantId", ["properties", "tenantId"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _isAzureADOnlyAuthenticationEnabled = BicepValue<bool>.DefineProperty(this, "IsAzureADOnlyAuthenticationEnabled", ["properties", "azureADOnlyAuthentication"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<SqlServer>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SqlServerAzureADAdministrator resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-05-01-preview.
        /// </summary>
        public static readonly string V2024_05_01_preview = "2024-05-01-preview";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";

        /// <summary>
        /// 2014-01-01.
        /// </summary>
        public static readonly string V2014_01_01 = "2014-01-01";
    }

    /// <summary>
    /// Creates a reference to an existing SqlServerAzureADAdministrator.
    /// </summary>
    /// <param name="resourceName">Name of the SqlServerAzureADAdministrator.</param>
    /// <param name="resourceVersion">Version of the SqlServerAzureADAdministrator.</param>
    /// <returns>The existing SqlServerAzureADAdministrator resource.</returns>
    public static SqlServerAzureADAdministrator FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
