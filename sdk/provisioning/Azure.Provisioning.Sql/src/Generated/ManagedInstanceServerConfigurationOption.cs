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
/// ManagedInstanceServerConfigurationOption.
/// </summary>
public partial class ManagedInstanceServerConfigurationOption : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Value of the server configuration option.
    /// </summary>
    public BicepValue<int> ServerConfigurationOptionValue { get => _serverConfigurationOptionValue; set => _serverConfigurationOptionValue.Assign(value); }
    private readonly BicepValue<int> _serverConfigurationOptionValue;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Provisioning state of server configuration option.
    /// </summary>
    public BicepValue<JobExecutionProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<JobExecutionProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ManagedInstance.
    /// </summary>
    public ManagedInstance? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ManagedInstance> _parent;

    /// <summary>
    /// Creates a new ManagedInstanceServerConfigurationOption.
    /// </summary>
    /// <param name="resourceName">Name of the ManagedInstanceServerConfigurationOption.</param>
    /// <param name="resourceVersion">Version of the ManagedInstanceServerConfigurationOption.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public ManagedInstanceServerConfigurationOption(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Sql/managedInstances/serverConfigurationOptions", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _serverConfigurationOptionValue = BicepValue<int>.DefineProperty(this, "ServerConfigurationOptionValue", ["properties", "serverConfigurationOptionValue"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<JobExecutionProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ManagedInstance>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing
    /// ManagedInstanceServerConfigurationOption.
    /// </summary>
    /// <param name="resourceName">Name of the ManagedInstanceServerConfigurationOption.</param>
    /// <param name="resourceVersion">Version of the ManagedInstanceServerConfigurationOption.</param>
    /// <returns>The existing ManagedInstanceServerConfigurationOption resource.</returns>
    public static ManagedInstanceServerConfigurationOption FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
