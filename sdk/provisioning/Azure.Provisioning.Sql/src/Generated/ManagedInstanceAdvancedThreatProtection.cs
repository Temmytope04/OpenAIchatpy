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
/// ManagedInstanceAdvancedThreatProtection.
/// </summary>
public partial class ManagedInstanceAdvancedThreatProtection : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Specifies the state of the Advanced Threat Protection, whether it is
    /// enabled or disabled or a state has not been applied yet on the
    /// specific database or server.
    /// </summary>
    public BicepValue<AdvancedThreatProtectionState> State { get => _state; set => _state.Assign(value); }
    private readonly BicepValue<AdvancedThreatProtectionState> _state;

    /// <summary>
    /// Specifies the UTC creation time of the policy.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

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
    /// Gets or sets a reference to the parent ManagedInstance.
    /// </summary>
    public ManagedInstance? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ManagedInstance> _parent;

    /// <summary>
    /// Creates a new ManagedInstanceAdvancedThreatProtection.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// ManagedInstanceAdvancedThreatProtection resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagedInstanceAdvancedThreatProtection.</param>
    public ManagedInstanceAdvancedThreatProtection(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/managedInstances/advancedThreatProtectionSettings", resourceVersion ?? "2024-05-01-preview")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _state = BicepValue<AdvancedThreatProtectionState>.DefineProperty(this, "State", ["properties", "state"]);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "creationTime"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ManagedInstance>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ManagedInstanceAdvancedThreatProtection resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-05-01-preview.
        /// </summary>
        public static readonly string V2024_05_01_preview = "2024-05-01-preview";
    }

    /// <summary>
    /// Creates a reference to an existing
    /// ManagedInstanceAdvancedThreatProtection.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// ManagedInstanceAdvancedThreatProtection resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagedInstanceAdvancedThreatProtection.</param>
    /// <returns>The existing ManagedInstanceAdvancedThreatProtection resource.</returns>
    public static ManagedInstanceAdvancedThreatProtection FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
