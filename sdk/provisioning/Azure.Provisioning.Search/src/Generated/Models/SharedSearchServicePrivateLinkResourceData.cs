// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Search;

/// <summary>
/// A class representing the SharedSearchServicePrivateLinkResource data model.
/// Describes a shared private link resource managed by the Azure
/// AI Search service.
/// </summary>
public partial class SharedSearchServicePrivateLinkResourceData : ProvisionableConstruct
{
    /// <summary>
    /// Describes the properties of a shared private link resource managed by
    /// the Azure AI Search service.
    /// </summary>
    public BicepValue<SharedSearchServicePrivateLinkResourceProperties> Properties { get => _properties; set => _properties.Assign(value); }
    private readonly BicepValue<SharedSearchServicePrivateLinkResourceProperties> _properties;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new SharedSearchServicePrivateLinkResourceData.
    /// </summary>
    public SharedSearchServicePrivateLinkResourceData()
    {
        _properties = BicepValue<SharedSearchServicePrivateLinkResourceProperties>.DefineProperty(this, "Properties", ["properties"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }
}
