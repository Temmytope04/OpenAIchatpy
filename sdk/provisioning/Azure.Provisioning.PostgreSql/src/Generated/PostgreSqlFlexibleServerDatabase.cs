// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// PostgreSqlFlexibleServerDatabase.
/// </summary>
public partial class PostgreSqlFlexibleServerDatabase : ProvisionableResource
{
    /// <summary>
    /// The name of the database.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The charset of the database.
    /// </summary>
    public BicepValue<string> Charset { get => _charset; set => _charset.Assign(value); }
    private readonly BicepValue<string> _charset;

    /// <summary>
    /// The collation of the database.
    /// </summary>
    public BicepValue<string> Collation { get => _collation; set => _collation.Assign(value); }
    private readonly BicepValue<string> _collation;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent PostgreSqlFlexibleServer.
    /// </summary>
    public PostgreSqlFlexibleServer? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<PostgreSqlFlexibleServer> _parent;

    /// <summary>
    /// Creates a new PostgreSqlFlexibleServerDatabase.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the PostgreSqlFlexibleServerDatabase
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PostgreSqlFlexibleServerDatabase.</param>
    public PostgreSqlFlexibleServerDatabase(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.DBforPostgreSQL/flexibleServers/databases", resourceVersion ?? "2024-08-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _charset = BicepValue<string>.DefineProperty(this, "Charset", ["properties", "charset"]);
        _collation = BicepValue<string>.DefineProperty(this, "Collation", ["properties", "collation"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<PostgreSqlFlexibleServer>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported PostgreSqlFlexibleServerDatabase resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-08-01.
        /// </summary>
        public static readonly string V2024_08_01 = "2024-08-01";

        /// <summary>
        /// 2022-12-01.
        /// </summary>
        public static readonly string V2022_12_01 = "2022-12-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";
    }

    /// <summary>
    /// Creates a reference to an existing PostgreSqlFlexibleServerDatabase.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the PostgreSqlFlexibleServerDatabase
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PostgreSqlFlexibleServerDatabase.</param>
    /// <returns>The existing PostgreSqlFlexibleServerDatabase resource.</returns>
    public static PostgreSqlFlexibleServerDatabase FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
