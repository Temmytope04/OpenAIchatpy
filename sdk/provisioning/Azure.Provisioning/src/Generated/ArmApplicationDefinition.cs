// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// ArmApplicationDefinition.
/// </summary>
public partial class ArmApplicationDefinition : ProvisionableResource
{
    /// <summary>
    /// The name of the managed application definition.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// The managed application lock level.
    /// </summary>
    public BicepValue<ArmApplicationLockLevel> LockLevel { get => _lockLevel; set => _lockLevel.Assign(value); }
    private readonly BicepValue<ArmApplicationLockLevel> _lockLevel;

    /// <summary>
    /// The collection of managed application artifacts. The portal will use
    /// the files specified as artifacts to construct the user experience of
    /// creating a managed application from a managed application definition.
    /// </summary>
    public BicepList<ArmApplicationDefinitionArtifact> Artifacts { get => _artifacts; set => _artifacts.Assign(value); }
    private readonly BicepList<ArmApplicationDefinitionArtifact> _artifacts;

    /// <summary>
    /// The managed application provider authorizations.
    /// </summary>
    public BicepList<ArmApplicationAuthorization> Authorizations { get => _authorizations; set => _authorizations.Assign(value); }
    private readonly BicepList<ArmApplicationAuthorization> _authorizations;

    /// <summary>
    /// The createUiDefinition json for the backing template with
    /// Microsoft.Solutions/applications resource. It can be a JObject or
    /// well-formed JSON string.                          To assign an object
    /// to this property use
    /// System.BinaryData.FromObjectAsJson``1(``0,System.Text.Json.JsonSerializerOptions).
    /// To assign an already formatted json string to
    /// this property use System.BinaryData.FromString(System.String).
    /// Examples:
    /// BinaryData.FromObjectAsJson(&quot;foo&quot;)Creates a
    /// payload of
    /// &quot;foo&quot;.BinaryData.FromString(&quot;\&quot;foo\&quot;&quot;)Creates
    /// a payload of &quot;foo&quot;.BinaryData.FromObjectAsJson(new { key =
    /// &quot;value&quot; })Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.BinaryData.FromString(&quot;{\&quot;key\&quot;:
    /// \&quot;value\&quot;}&quot;)Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.
    /// </summary>
    public BicepValue<BinaryData> CreateUiDefinition { get => _createUiDefinition; set => _createUiDefinition.Assign(value); }
    private readonly BicepValue<BinaryData> _createUiDefinition;

    /// <summary>
    /// The managed application definition description.
    /// </summary>
    public BicepValue<string> Description { get => _description; set => _description.Assign(value); }
    private readonly BicepValue<string> _description;

    /// <summary>
    /// The managed application definition display name.
    /// </summary>
    public BicepValue<string> DisplayName { get => _displayName; set => _displayName.Assign(value); }
    private readonly BicepValue<string> _displayName;

    /// <summary>
    /// A value indicating whether the package is enabled or not.
    /// </summary>
    public BicepValue<bool> IsEnabled { get => _isEnabled; set => _isEnabled.Assign(value); }
    private readonly BicepValue<bool> _isEnabled;

    /// <summary>
    /// The managed application locking policy.
    /// </summary>
    public BicepValue<ArmApplicationPackageLockingPolicy> LockingPolicy { get => _lockingPolicy; set => _lockingPolicy.Assign(value); }
    private readonly BicepValue<ArmApplicationPackageLockingPolicy> _lockingPolicy;

    /// <summary>
    /// The inline main template json which has resources to be provisioned. It
    /// can be a JObject or well-formed JSON string.
    /// To assign an object to this property use
    /// System.BinaryData.FromObjectAsJson``1(``0,System.Text.Json.JsonSerializerOptions).
    /// To assign an already formatted json string to
    /// this property use System.BinaryData.FromString(System.String).
    /// Examples:
    /// BinaryData.FromObjectAsJson(&quot;foo&quot;)Creates a
    /// payload of
    /// &quot;foo&quot;.BinaryData.FromString(&quot;\&quot;foo\&quot;&quot;)Creates
    /// a payload of &quot;foo&quot;.BinaryData.FromObjectAsJson(new { key =
    /// &quot;value&quot; })Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.BinaryData.FromString(&quot;{\&quot;key\&quot;:
    /// \&quot;value\&quot;}&quot;)Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.
    /// </summary>
    public BicepValue<BinaryData> MainTemplate { get => _mainTemplate; set => _mainTemplate.Assign(value); }
    private readonly BicepValue<BinaryData> _mainTemplate;

    /// <summary>
    /// ID of the resource that manages this resource.
    /// </summary>
    public BicepValue<string> ManagedBy { get => _managedBy; set => _managedBy.Assign(value); }
    private readonly BicepValue<string> _managedBy;

    /// <summary>
    /// The managed application management mode.
    /// </summary>
    public BicepValue<ArmApplicationManagementMode> ManagementMode { get => _managementMode; set => _managementMode.Assign(value); }
    private readonly BicepValue<ArmApplicationManagementMode> _managementMode;

    /// <summary>
    /// The managed application notification endpoint.
    /// </summary>
    public BicepList<ArmApplicationNotificationEndpoint> NotificationEndpoints { get => _notificationEndpoints; set => _notificationEndpoints.Assign(value); }
    private readonly BicepList<ArmApplicationNotificationEndpoint> _notificationEndpoints;

    /// <summary>
    /// The managed application definition package file Uri. Use this element.
    /// </summary>
    public BicepValue<Uri> PackageFileUri { get => _packageFileUri; set => _packageFileUri.Assign(value); }
    private readonly BicepValue<Uri> _packageFileUri;

    /// <summary>
    /// The managed application provider policies.
    /// </summary>
    public BicepList<ArmApplicationPolicy> Policies { get => _policies; set => _policies.Assign(value); }
    private readonly BicepList<ArmApplicationPolicy> _policies;

    /// <summary>
    /// The SKU of the resource.
    /// </summary>
    public BicepValue<ArmApplicationSku> Sku { get => _sku; set => _sku.Assign(value); }
    private readonly BicepValue<ArmApplicationSku> _sku;

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
    /// Creates a new ArmApplicationDefinition.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ArmApplicationDefinition resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ArmApplicationDefinition.</param>
    public ArmApplicationDefinition(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Solutions/applicationDefinitions", resourceVersion ?? "2021-07-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _lockLevel = BicepValue<ArmApplicationLockLevel>.DefineProperty(this, "LockLevel", ["properties", "lockLevel"], isRequired: true);
        _artifacts = BicepList<ArmApplicationDefinitionArtifact>.DefineProperty(this, "Artifacts", ["properties", "artifacts"]);
        _authorizations = BicepList<ArmApplicationAuthorization>.DefineProperty(this, "Authorizations", ["properties", "authorizations"]);
        _createUiDefinition = BicepValue<BinaryData>.DefineProperty(this, "CreateUiDefinition", ["properties", "createUiDefinition"]);
        _description = BicepValue<string>.DefineProperty(this, "Description", ["properties", "description"]);
        _displayName = BicepValue<string>.DefineProperty(this, "DisplayName", ["properties", "displayName"]);
        _isEnabled = BicepValue<bool>.DefineProperty(this, "IsEnabled", ["properties", "isEnabled"]);
        _lockingPolicy = BicepValue<ArmApplicationPackageLockingPolicy>.DefineProperty(this, "LockingPolicy", ["properties", "lockingPolicy"]);
        _mainTemplate = BicepValue<BinaryData>.DefineProperty(this, "MainTemplate", ["properties", "mainTemplate"]);
        _managedBy = BicepValue<string>.DefineProperty(this, "ManagedBy", ["managedBy"]);
        _managementMode = BicepValue<ArmApplicationManagementMode>.DefineProperty(this, "ManagementMode", ["properties", "managementPolicy", "mode"]);
        _notificationEndpoints = BicepList<ArmApplicationNotificationEndpoint>.DefineProperty(this, "NotificationEndpoints", ["properties", "notificationPolicy", "notificationEndpoints"]);
        _packageFileUri = BicepValue<Uri>.DefineProperty(this, "PackageFileUri", ["properties", "packageFileUri"]);
        _policies = BicepList<ArmApplicationPolicy>.DefineProperty(this, "Policies", ["properties", "policies"]);
        _sku = BicepValue<ArmApplicationSku>.DefineProperty(this, "Sku", ["sku"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported ArmApplicationDefinition resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2021-07-01.
        /// </summary>
        public static readonly string V2021_07_01 = "2021-07-01";

        /// <summary>
        /// 2019-07-01.
        /// </summary>
        public static readonly string V2019_07_01 = "2019-07-01";

        /// <summary>
        /// 2018-06-01.
        /// </summary>
        public static readonly string V2018_06_01 = "2018-06-01";

        /// <summary>
        /// 2018-03-01.
        /// </summary>
        public static readonly string V2018_03_01 = "2018-03-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2017-12-01.
        /// </summary>
        public static readonly string V2017_12_01 = "2017-12-01";

        /// <summary>
        /// 2017-09-01.
        /// </summary>
        public static readonly string V2017_09_01 = "2017-09-01";
    }

    /// <summary>
    /// Creates a reference to an existing ArmApplicationDefinition.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ArmApplicationDefinition resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ArmApplicationDefinition.</param>
    /// <returns>The existing ArmApplicationDefinition resource.</returns>
    public static ArmApplicationDefinition FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
