// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.EventHubs;

/// <summary>
/// EventHubsSchemaGroup.
/// </summary>
public partial class EventHubsSchemaGroup : ProvisionableResource
{
    /// <summary>
    /// The Schema Group name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// dictionary object for SchemaGroup group properties.
    /// </summary>
    public BicepDictionary<string> GroupProperties { get => _groupProperties; set => _groupProperties.Assign(value); }
    private readonly BicepDictionary<string> _groupProperties;

    /// <summary>
    /// Gets or sets the schema compatibility.
    /// </summary>
    public BicepValue<EventHubsSchemaCompatibility> SchemaCompatibility { get => _schemaCompatibility; set => _schemaCompatibility.Assign(value); }
    private readonly BicepValue<EventHubsSchemaCompatibility> _schemaCompatibility;

    /// <summary>
    /// Gets or sets the schema type.
    /// </summary>
    public BicepValue<EventHubsSchemaType> SchemaType { get => _schemaType; set => _schemaType.Assign(value); }
    private readonly BicepValue<EventHubsSchemaType> _schemaType;

    /// <summary>
    /// Exact time the Schema Group was created.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedAtUtc { get => _createdAtUtc; }
    private readonly BicepValue<DateTimeOffset> _createdAtUtc;

    /// <summary>
    /// The ETag value.
    /// </summary>
    public BicepValue<ETag> ETag { get => _eTag; }
    private readonly BicepValue<ETag> _eTag;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The geo-location where the resource lives.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Exact time the Schema Group was updated.
    /// </summary>
    public BicepValue<DateTimeOffset> UpdatedAtUtc { get => _updatedAtUtc; }
    private readonly BicepValue<DateTimeOffset> _updatedAtUtc;

    /// <summary>
    /// Gets or sets a reference to the parent EventHubsNamespace.
    /// </summary>
    public EventHubsNamespace? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<EventHubsNamespace> _parent;

    /// <summary>
    /// Creates a new EventHubsSchemaGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EventHubsSchemaGroup resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventHubsSchemaGroup.</param>
    public EventHubsSchemaGroup(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.EventHub/namespaces/schemagroups", resourceVersion ?? "2024-01-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _groupProperties = BicepDictionary<string>.DefineProperty(this, "GroupProperties", ["properties", "groupProperties"]);
        _schemaCompatibility = BicepValue<EventHubsSchemaCompatibility>.DefineProperty(this, "SchemaCompatibility", ["properties", "schemaCompatibility"]);
        _schemaType = BicepValue<EventHubsSchemaType>.DefineProperty(this, "SchemaType", ["properties", "schemaType"]);
        _createdAtUtc = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedAtUtc", ["properties", "createdAtUtc"], isOutput: true);
        _eTag = BicepValue<ETag>.DefineProperty(this, "ETag", ["properties", "eTag"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _updatedAtUtc = BicepValue<DateTimeOffset>.DefineProperty(this, "UpdatedAtUtc", ["properties", "updatedAtUtc"], isOutput: true);
        _parent = ResourceReference<EventHubsNamespace>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported EventHubsSchemaGroup resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-05-01-preview.
        /// </summary>
        public static readonly string V2024_05_01_preview = "2024-05-01-preview";

        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";

        /// <summary>
        /// 2017-04-01.
        /// </summary>
        public static readonly string V2017_04_01 = "2017-04-01";

        /// <summary>
        /// 2015-08-01.
        /// </summary>
        public static readonly string V2015_08_01 = "2015-08-01";

        /// <summary>
        /// 2014-09-01.
        /// </summary>
        public static readonly string V2014_09_01 = "2014-09-01";
    }

    /// <summary>
    /// Creates a reference to an existing EventHubsSchemaGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EventHubsSchemaGroup resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventHubsSchemaGroup.</param>
    /// <returns>The existing EventHubsSchemaGroup resource.</returns>
    public static EventHubsSchemaGroup FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
