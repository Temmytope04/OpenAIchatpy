// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// StorageAccountManagementPolicy.
/// </summary>
public partial class StorageAccountManagementPolicy : Resource
{
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The Storage Account ManagementPolicies Rules. See more details in:
    /// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
    /// </summary>
    public BicepList<ManagementPolicyRule> Rules { get => _rules; set => _rules.Assign(value); }
    private readonly BicepList<ManagementPolicyRule> _rules;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Returns the date and time the ManagementPolicies was last modified.
    /// </summary>
    public BicepValue<DateTimeOffset> LastModifiedOn { get => _lastModifiedOn; }
    private readonly BicepValue<DateTimeOffset> _lastModifiedOn;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent StorageAccount.
    /// </summary>
    public StorageAccount? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<StorageAccount> _parent;

    /// <summary>
    /// Get the default value for the Name property.
    /// </summary>
    private partial BicepValue<string> GetNameDefaultValue();

    /// <summary>
    /// Creates a new StorageAccountManagementPolicy.
    /// </summary>
    /// <param name="resourceName">Name of the StorageAccountManagementPolicy.</param>
    /// <param name="resourceVersion">Version of the StorageAccountManagementPolicy.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public StorageAccountManagementPolicy(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Storage/storageAccounts/managementPolicies", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], defaultValue: GetNameDefaultValue());
        _rules = BicepList<ManagementPolicyRule>.DefineProperty(this, "Rules", ["properties", "policy", "rules"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _lastModifiedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "LastModifiedOn", ["properties", "lastModifiedTime"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<StorageAccount>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing StorageAccountManagementPolicy.
    /// </summary>
    /// <param name="resourceName">Name of the StorageAccountManagementPolicy.</param>
    /// <param name="resourceVersion">Version of the StorageAccountManagementPolicy.</param>
    /// <returns>The existing StorageAccountManagementPolicy resource.</returns>
    public static StorageAccountManagementPolicy FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
