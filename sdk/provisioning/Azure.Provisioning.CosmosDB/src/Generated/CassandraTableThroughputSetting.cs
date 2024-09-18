// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// CassandraTableThroughputSetting.
/// </summary>
public partial class CassandraTableThroughputSetting : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// The standard JSON format of a resource throughput.
    /// </summary>
    public BicepValue<ThroughputSettingsResourceInfo> Resource { get => _resource; set => _resource.Assign(value); }
    private readonly BicepValue<ThroughputSettingsResourceInfo> _resource;

    /// <summary>
    /// Identity for the resource.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

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
    /// Gets or sets a reference to the parent CassandraTable.
    /// </summary>
    public CassandraTable? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<CassandraTable> _parent;

    /// <summary>
    /// Creates a new CassandraTableThroughputSetting.
    /// </summary>
    /// <param name="resourceName">Name of the CassandraTableThroughputSetting.</param>
    /// <param name="resourceVersion">Version of the CassandraTableThroughputSetting.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public CassandraTableThroughputSetting(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.DocumentDB/databaseAccounts/cassandraKeyspaces/tables/throughputSettings", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _resource = BicepValue<ThroughputSettingsResourceInfo>.DefineProperty(this, "Resource", ["properties", "resource"], isRequired: true);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<CassandraTable>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing CassandraTableThroughputSetting.
    /// </summary>
    /// <param name="resourceName">Name of the CassandraTableThroughputSetting.</param>
    /// <param name="resourceVersion">Version of the CassandraTableThroughputSetting.</param>
    /// <returns>The existing CassandraTableThroughputSetting resource.</returns>
    public static CassandraTableThroughputSetting FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
