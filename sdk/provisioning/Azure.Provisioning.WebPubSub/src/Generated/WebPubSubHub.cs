// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.WebPubSub;

/// <summary>
/// WebPubSubHub.
/// </summary>
public partial class WebPubSubHub : ProvisionableResource
{
    /// <summary>
    /// The hub name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Properties of a hub.
    /// </summary>
    public BicepValue<WebPubSubHubProperties> Properties { get => _properties; set => _properties.Assign(value); }
    private readonly BicepValue<WebPubSubHubProperties> _properties;

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
    /// Gets or sets a reference to the parent WebPubSubService.
    /// </summary>
    public WebPubSubService? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<WebPubSubService> _parent;

    /// <summary>
    /// Creates a new WebPubSubHub.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the WebPubSubHub resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the WebPubSubHub.</param>
    public WebPubSubHub(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.SignalRService/webPubSub/hubs", resourceVersion ?? "2024-03-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _properties = BicepValue<WebPubSubHubProperties>.DefineProperty(this, "Properties", ["properties"], isRequired: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<WebPubSubService>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported WebPubSubHub resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-04-01-preview.
        /// </summary>
        public static readonly string V2024_04_01_preview = "2024-04-01-preview";

        /// <summary>
        /// 2024-03-01.
        /// </summary>
        public static readonly string V2024_03_01 = "2024-03-01";

        /// <summary>
        /// 2023-02-01.
        /// </summary>
        public static readonly string V2023_02_01 = "2023-02-01";

        /// <summary>
        /// 2021-10-01.
        /// </summary>
        public static readonly string V2021_10_01 = "2021-10-01";

        /// <summary>
        /// 2020-05-01.
        /// </summary>
        public static readonly string V2020_05_01 = "2020-05-01";
    }

    /// <summary>
    /// Creates a reference to an existing WebPubSubHub.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the WebPubSubHub resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the WebPubSubHub.</param>
    /// <returns>The existing WebPubSubHub resource.</returns>
    public static WebPubSubHub FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
