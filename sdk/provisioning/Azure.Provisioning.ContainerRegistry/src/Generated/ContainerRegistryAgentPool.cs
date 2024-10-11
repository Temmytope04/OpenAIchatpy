// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// ContainerRegistryAgentPool.
/// </summary>
public partial class ContainerRegistryAgentPool : Resource
{
    /// <summary>
    /// The name of the agent pool.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// The count of agent machine.
    /// </summary>
    public BicepValue<int> Count { get => _count; set => _count.Assign(value); }
    private readonly BicepValue<int> _count;

    /// <summary>
    /// The OS of agent machine.
    /// </summary>
    public BicepValue<ContainerRegistryOS> OS { get => _oS; set => _oS.Assign(value); }
    private readonly BicepValue<ContainerRegistryOS> _oS;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// The Tier of agent machine.
    /// </summary>
    public BicepValue<string> Tier { get => _tier; set => _tier.Assign(value); }
    private readonly BicepValue<string> _tier;

    /// <summary>
    /// The Virtual Network Subnet Resource Id of the agent machine.
    /// </summary>
    public BicepValue<ResourceIdentifier> VirtualNetworkSubnetResourceId { get => _virtualNetworkSubnetResourceId; set => _virtualNetworkSubnetResourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _virtualNetworkSubnetResourceId;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The provisioning state of this agent pool.
    /// </summary>
    public BicepValue<ContainerRegistryProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<ContainerRegistryProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ContainerRegistryService.
    /// </summary>
    public ContainerRegistryService? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ContainerRegistryService> _parent;

    /// <summary>
    /// Creates a new ContainerRegistryAgentPool.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the ContainerRegistryAgentPool
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerRegistryAgentPool.</param>
    public ContainerRegistryAgentPool(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.ContainerRegistry/registries/agentPools", resourceVersion ?? "2019-06-01-preview")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _count = BicepValue<int>.DefineProperty(this, "Count", ["properties", "count"]);
        _oS = BicepValue<ContainerRegistryOS>.DefineProperty(this, "OS", ["properties", "os"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _tier = BicepValue<string>.DefineProperty(this, "Tier", ["properties", "tier"]);
        _virtualNetworkSubnetResourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "VirtualNetworkSubnetResourceId", ["properties", "virtualNetworkSubnetResourceId"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<ContainerRegistryProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ContainerRegistryService>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ContainerRegistryAgentPool resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2019-06-01-preview.
        /// </summary>
        public static readonly string V2019_06_01_preview = "2019-06-01-preview";
    }

    /// <summary>
    /// Creates a reference to an existing ContainerRegistryAgentPool.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the ContainerRegistryAgentPool
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerRegistryAgentPool.</param>
    /// <returns>The existing ContainerRegistryAgentPool resource.</returns>
    public static ContainerRegistryAgentPool FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };
}
