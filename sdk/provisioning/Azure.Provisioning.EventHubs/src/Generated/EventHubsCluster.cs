// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Authorization;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using Azure.Provisioning.Roles;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.EventHubs;

/// <summary>
/// EventHubsCluster.
/// </summary>
public partial class EventHubsCluster : Resource
{
    /// <summary>
    /// The name of the Event Hubs Cluster.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Properties of the cluster SKU.
    /// </summary>
    public BicepValue<EventHubsClusterSku> Sku { get => _sku; set => _sku.Assign(value); }
    private readonly BicepValue<EventHubsClusterSku> _sku;

    /// <summary>
    /// A value that indicates whether Scaling is Supported.
    /// </summary>
    public BicepValue<bool> SupportsScaling { get => _supportsScaling; set => _supportsScaling.Assign(value); }
    private readonly BicepValue<bool> _supportsScaling;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// The UTC time when the Event Hubs Cluster was created.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The metric ID of the cluster resource. Provided by the service and not
    /// modifiable by the user.
    /// </summary>
    public BicepValue<string> MetricId { get => _metricId; }
    private readonly BicepValue<string> _metricId;

    /// <summary>
    /// Provisioning state of the Cluster.
    /// </summary>
    public BicepValue<EventHubsClusterProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<EventHubsClusterProvisioningState> _provisioningState;

    /// <summary>
    /// Status of the Cluster resource.
    /// </summary>
    public BicepValue<string> Status { get => _status; }
    private readonly BicepValue<string> _status;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// The UTC time when the Event Hubs Cluster was last updated.
    /// </summary>
    public BicepValue<DateTimeOffset> UpdatedOn { get => _updatedOn; }
    private readonly BicepValue<DateTimeOffset> _updatedOn;

    /// <summary>
    /// Creates a new EventHubsCluster.
    /// </summary>
    /// <param name="resourceName">Name of the EventHubsCluster.</param>
    /// <param name="resourceVersion">Version of the EventHubsCluster.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public EventHubsCluster(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.EventHub/clusters", resourceVersion ?? "2024-01-01", context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _sku = BicepValue<EventHubsClusterSku>.DefineProperty(this, "Sku", ["sku"]);
        _supportsScaling = BicepValue<bool>.DefineProperty(this, "SupportsScaling", ["properties", "supportsScaling"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "createdAt"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _metricId = BicepValue<string>.DefineProperty(this, "MetricId", ["properties", "metricId"], isOutput: true);
        _provisioningState = BicepValue<EventHubsClusterProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _status = BicepValue<string>.DefineProperty(this, "Status", ["properties", "status"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _updatedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "UpdatedOn", ["properties", "updatedAt"], isOutput: true);
    }

    /// <summary>
    /// Supported EventHubsCluster resource versions.
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
    }

    /// <summary>
    /// Creates a reference to an existing EventHubsCluster.
    /// </summary>
    /// <param name="resourceName">Name of the EventHubsCluster.</param>
    /// <param name="resourceVersion">Version of the EventHubsCluster.</param>
    /// <returns>The existing EventHubsCluster resource.</returns>
    public static EventHubsCluster FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this EventHubsCluster resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 6, maxLength: 50, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);

    /// <summary>
    /// Assign a role to a user-assigned identity that grants access to this
    /// EventHubsCluster.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="identity">The <see cref="UserAssignedIdentity"/>.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment AssignRole(EventHubsBuiltInRole role, UserAssignedIdentity identity) =>
        new($"{ResourceName}_{identity.ResourceName}_{EventHubsBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, identity.PrincipalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(ResourceName),
            PrincipalType = RoleManagementPrincipalType.ServicePrincipal,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = identity.PrincipalId
        };

    /// <summary>
    /// Assign a role to a principal that grants access to this
    /// EventHubsCluster.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="principalType">The type of the principal to assign to.</param>
    /// <param name="principalId">The principal to assign to.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment AssignRole(EventHubsBuiltInRole role, BicepValue<RoleManagementPrincipalType> principalType, BicepValue<Guid> principalId) =>
        new($"{ResourceName}_{EventHubsBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, principalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(ResourceName),
            PrincipalType = principalType,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = principalId
        };
}
