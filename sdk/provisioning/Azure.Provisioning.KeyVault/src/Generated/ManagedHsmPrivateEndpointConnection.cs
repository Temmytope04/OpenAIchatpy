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

namespace Azure.Provisioning.KeyVault;

/// <summary>
/// ManagedHsmPrivateEndpointConnection.
/// </summary>
public partial class ManagedHsmPrivateEndpointConnection : ProvisionableResource
{
    /// <summary>
    /// Name of the private endpoint connection associated with the managed hsm
    /// pool.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Modified whenever there is a change in the state of private endpoint
    /// connection.
    /// </summary>
    public BicepValue<ETag> ETag { get => _eTag; set => _eTag.Assign(value); }
    private readonly BicepValue<ETag> _eTag;

    /// <summary>
    /// Approval state of the private link connection.
    /// </summary>
    public BicepValue<ManagedHsmPrivateLinkServiceConnectionState> PrivateLinkServiceConnectionState { get => _privateLinkServiceConnectionState; set => _privateLinkServiceConnectionState.Assign(value); }
    private readonly BicepValue<ManagedHsmPrivateLinkServiceConnectionState> _privateLinkServiceConnectionState;

    /// <summary>
    /// SKU details.
    /// </summary>
    public BicepValue<ManagedHsmSku> Sku { get => _sku; set => _sku.Assign(value); }
    private readonly BicepValue<ManagedHsmSku> _sku;

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
    /// Gets Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrivateEndpointId { get => _privateEndpointId; }
    private readonly BicepValue<ResourceIdentifier> _privateEndpointId;

    /// <summary>
    /// Provisioning state of the private endpoint connection.
    /// </summary>
    public BicepValue<ManagedHsmPrivateEndpointConnectionProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<ManagedHsmPrivateEndpointConnectionProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ManagedHsm.
    /// </summary>
    public ManagedHsm? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ManagedHsm> _parent;

    /// <summary>
    /// Creates a new ManagedHsmPrivateEndpointConnection.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// ManagedHsmPrivateEndpointConnection resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagedHsmPrivateEndpointConnection.</param>
    public ManagedHsmPrivateEndpointConnection(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.KeyVault/managedHSMs/privateEndpointConnections", resourceVersion ?? "2023-07-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _eTag = BicepValue<ETag>.DefineProperty(this, "ETag", ["etag"]);
        _privateLinkServiceConnectionState = BicepValue<ManagedHsmPrivateLinkServiceConnectionState>.DefineProperty(this, "PrivateLinkServiceConnectionState", ["properties", "privateLinkServiceConnectionState"]);
        _sku = BicepValue<ManagedHsmSku>.DefineProperty(this, "Sku", ["sku"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _privateEndpointId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PrivateEndpointId", ["properties", "privateEndpoint", "id"], isOutput: true);
        _provisioningState = BicepValue<ManagedHsmPrivateEndpointConnectionProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ManagedHsm>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ManagedHsmPrivateEndpointConnection resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-04-01-preview.
        /// </summary>
        public static readonly string V2024_04_01_preview = "2024-04-01-preview";

        /// <summary>
        /// 2023-08-01-PREVIEW.
        /// </summary>
        public static readonly string V2023_08_01_PREVIEW = "2023-08-01-PREVIEW";

        /// <summary>
        /// 2023-07-01.
        /// </summary>
        public static readonly string V2023_07_01 = "2023-07-01";

        /// <summary>
        /// 2023-02-01.
        /// </summary>
        public static readonly string V2023_02_01 = "2023-02-01";

        /// <summary>
        /// 2022-11-01.
        /// </summary>
        public static readonly string V2022_11_01 = "2022-11-01";

        /// <summary>
        /// 2022-07-01.
        /// </summary>
        public static readonly string V2022_07_01 = "2022-07-01";

        /// <summary>
        /// 2021-10-01.
        /// </summary>
        public static readonly string V2021_10_01 = "2021-10-01";
    }

    /// <summary>
    /// Creates a reference to an existing ManagedHsmPrivateEndpointConnection.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// ManagedHsmPrivateEndpointConnection resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagedHsmPrivateEndpointConnection.</param>
    /// <returns>The existing ManagedHsmPrivateEndpointConnection resource.</returns>
    public static ManagedHsmPrivateEndpointConnection FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
