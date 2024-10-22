// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Resources;

/// <summary>
/// ManagementGroup.
/// </summary>
public partial class ManagementGroup : ProvisionableResource
{
    /// <summary>
    /// The name of the management group. For example,
    /// 00000000-0000-0000-0000-000000000000.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The details of a management group used during creation.
    /// </summary>
    public BicepValue<CreateManagementGroupDetails> Details { get => _details; set => _details.Assign(value); }
    private readonly BicepValue<CreateManagementGroupDetails> _details;

    /// <summary>
    /// The friendly name of the management group. If no value is passed then
    /// this  field will be set to the groupId.
    /// </summary>
    public BicepValue<string> DisplayName { get => _displayName; set => _displayName.Assign(value); }
    private readonly BicepValue<string> _displayName;

    /// <summary>
    /// The list of children.
    /// </summary>
    public BicepList<ManagementGroupChildOptions> Children { get => _children; }
    private readonly BicepList<ManagementGroupChildOptions> _children;

    /// <summary>
    /// The fully qualified ID for the management group.  For example,
    /// /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000.
    /// </summary>
    public BicepValue<string> Id { get => _id; }
    private readonly BicepValue<string> _id;

    /// <summary>
    /// Azure Resource Manager metadata containing createdBy and modifiedBy
    /// information.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// The AAD Tenant ID associated with the management group. For example,
    /// 00000000-0000-0000-0000-000000000000.
    /// </summary>
    public BicepValue<Guid> TenantId { get => _tenantId; }
    private readonly BicepValue<Guid> _tenantId;

    /// <summary>
    /// Creates a new ManagementGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ManagementGroup resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagementGroup.</param>
    public ManagementGroup(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Management/managementGroups", resourceVersion ?? "2023-04-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"]);
        _details = BicepValue<CreateManagementGroupDetails>.DefineProperty(this, "Details", ["properties", "details"]);
        _displayName = BicepValue<string>.DefineProperty(this, "DisplayName", ["properties", "displayName"]);
        _children = BicepList<ManagementGroupChildOptions>.DefineProperty(this, "Children", ["properties", "children"], isOutput: true);
        _id = BicepValue<string>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _tenantId = BicepValue<Guid>.DefineProperty(this, "TenantId", ["properties", "tenantId"], isOutput: true);
    }

    /// <summary>
    /// Supported ManagementGroup resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2021-04-01.
        /// </summary>
        public static readonly string V2021_04_01 = "2021-04-01";

        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";

        /// <summary>
        /// 2020-05-01.
        /// </summary>
        public static readonly string V2020_05_01 = "2020-05-01";

        /// <summary>
        /// 2020-02-01.
        /// </summary>
        public static readonly string V2020_02_01 = "2020-02-01";

        /// <summary>
        /// 2019-11-01.
        /// </summary>
        public static readonly string V2019_11_01 = "2019-11-01";

        /// <summary>
        /// 2018-03-01-beta.
        /// </summary>
        public static readonly string V2018_03_01_beta = "2018-03-01-beta";
    }

    /// <summary>
    /// Creates a reference to an existing ManagementGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ManagementGroup resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagementGroup.</param>
    /// <returns>The existing ManagementGroup resource.</returns>
    public static ManagementGroup FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this ManagementGroup resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 90, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore | ResourceNameCharacters.Period | ResourceNameCharacters.Parentheses);
}
