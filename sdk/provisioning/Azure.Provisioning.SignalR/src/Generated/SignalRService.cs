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

namespace Azure.Provisioning.SignalR;

/// <summary>
/// SignalRService.
/// </summary>
public partial class SignalRService : Resource
{
    /// <summary>
    /// The name of the resource.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Gets or sets the list of origins that should be allowed to make
    /// cross-origin calls (for example: http://example.com:12345). Use
    /// &quot;*&quot; to allow all. If omitted, allow all by default.
    /// </summary>
    public BicepList<string> CorsAllowedOrigins { get => _corsAllowedOrigins; set => _corsAllowedOrigins.Assign(value); }
    private readonly BicepList<string> _corsAllowedOrigins;

    /// <summary>
    /// DisableLocalAuth             Enable or disable aad auth
    /// When set as true, connection with AuthType=aad won&apos;t
    /// work.
    /// </summary>
    public BicepValue<bool> DisableAadAuth { get => _disableAadAuth; set => _disableAadAuth.Assign(value); }
    private readonly BicepValue<bool> _disableAadAuth;

    /// <summary>
    /// DisableLocalAuth             Enable or disable local auth with
    /// AccessKey             When set as true, connection with AccessKey=xxx
    /// won&apos;t work.
    /// </summary>
    public BicepValue<bool> DisableLocalAuth { get => _disableLocalAuth; set => _disableLocalAuth.Assign(value); }
    private readonly BicepValue<bool> _disableLocalAuth;

    /// <summary>
    /// List of the featureFlags.                           FeatureFlags that
    /// are not included in the parameters for the update operation will not
    /// be modified.              And the response will only include
    /// featureFlags that are explicitly set.              When a featureFlag
    /// is not explicitly set, its globally default value will be used
    /// But keep in mind, the default value doesn&apos;t mean
    /// &quot;false&quot;. It varies in terms of different FeatureFlags.
    /// </summary>
    public BicepList<SignalRFeature> Features { get => _features; set => _features.Assign(value); }
    private readonly BicepList<SignalRFeature> _features;

    /// <summary>
    /// A class represent managed identities used for request and response.
    /// Current supported identity types: None, SystemAssigned, UserAssigned.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// Request client certificate during TLS handshake if enabled.
    /// </summary>
    public BicepValue<bool> IsClientCertEnabled { get => _isClientCertEnabled; set => _isClientCertEnabled.Assign(value); }
    private readonly BicepValue<bool> _isClientCertEnabled;

    /// <summary>
    /// The kind of the service, it can be SignalR or RawWebSockets.
    /// </summary>
    public BicepValue<SignalRServiceKind> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<SignalRServiceKind> _kind;

    /// <summary>
    /// Live trace configuration of a Microsoft.SignalRService resource.
    /// </summary>
    public BicepValue<SignalRLiveTraceConfiguration> LiveTraceConfiguration { get => _liveTraceConfiguration; set => _liveTraceConfiguration.Assign(value); }
    private readonly BicepValue<SignalRLiveTraceConfiguration> _liveTraceConfiguration;

    /// <summary>
    /// Network ACLs for the resource.
    /// </summary>
    public BicepValue<SignalRNetworkAcls> NetworkACLs { get => _networkACLs; set => _networkACLs.Assign(value); }
    private readonly BicepValue<SignalRNetworkAcls> _networkACLs;

    /// <summary>
    /// Enable or disable public network access. Default to
    /// &quot;Enabled&quot;.             When it&apos;s Enabled, network ACLs
    /// still apply.             When it&apos;s Disabled, public network
    /// access is always disabled no matter what you set in network ACLs.
    /// </summary>
    public BicepValue<string> PublicNetworkAccess { get => _publicNetworkAccess; set => _publicNetworkAccess.Assign(value); }
    private readonly BicepValue<string> _publicNetworkAccess;

    /// <summary>
    /// Gets or sets the list of category configurations.
    /// </summary>
    public BicepList<SignalRResourceLogCategory> ResourceLogCategories { get => _resourceLogCategories; set => _resourceLogCategories.Assign(value); }
    private readonly BicepList<SignalRResourceLogCategory> _resourceLogCategories;

    /// <summary>
    /// The billing information of the resource.
    /// </summary>
    public BicepValue<SignalRResourceSku> Sku { get => _sku; set => _sku.Assign(value); }
    private readonly BicepValue<SignalRResourceSku> _sku;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Gets or sets the list of Upstream URL templates. Order matters, and the
    /// first matching template takes effects.
    /// </summary>
    public BicepList<SignalRUpstreamTemplate> UpstreamTemplates { get => _upstreamTemplates; set => _upstreamTemplates.Assign(value); }
    private readonly BicepList<SignalRUpstreamTemplate> _upstreamTemplates;

    /// <summary>
    /// The publicly accessible IP of the resource.
    /// </summary>
    public BicepValue<string> ExternalIP { get => _externalIP; }
    private readonly BicepValue<string> _externalIP;

    /// <summary>
    /// FQDN of the service instance.
    /// </summary>
    public BicepValue<string> HostName { get => _hostName; }
    private readonly BicepValue<string> _hostName;

    /// <summary>
    /// Deprecated.
    /// </summary>
    public BicepValue<string> HostNamePrefix { get => _hostNamePrefix; }
    private readonly BicepValue<string> _hostNamePrefix;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Private endpoint connections to the resource.
    /// </summary>
    public BicepList<SignalRPrivateEndpointConnectionData> PrivateEndpointConnections { get => _privateEndpointConnections; }
    private readonly BicepList<SignalRPrivateEndpointConnectionData> _privateEndpointConnections;

    /// <summary>
    /// Provisioning state of the resource.
    /// </summary>
    public BicepValue<SignalRProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<SignalRProvisioningState> _provisioningState;

    /// <summary>
    /// The publicly accessible port of the resource which is designed for
    /// browser/client side usage.
    /// </summary>
    public BicepValue<int> PublicPort { get => _publicPort; }
    private readonly BicepValue<int> _publicPort;

    /// <summary>
    /// The publicly accessible port of the resource which is designed for
    /// customer server side usage.
    /// </summary>
    public BicepValue<int> ServerPort { get => _serverPort; }
    private readonly BicepValue<int> _serverPort;

    /// <summary>
    /// The list of shared private link resources.
    /// </summary>
    public BicepList<SignalRSharedPrivateLinkResourceData> SharedPrivateLinkResources { get => _sharedPrivateLinkResources; }
    private readonly BicepList<SignalRSharedPrivateLinkResourceData> _sharedPrivateLinkResources;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Version of the resource. Probably you need the same or higher version
    /// of client SDKs.
    /// </summary>
    public BicepValue<string> Version { get => _version; }
    private readonly BicepValue<string> _version;

    /// <summary>
    /// Creates a new SignalRService.
    /// </summary>
    /// <param name="resourceName">Name of the SignalRService.</param>
    /// <param name="resourceVersion">Version of the SignalRService.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public SignalRService(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.SignalRService/signalR", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _corsAllowedOrigins = BicepList<string>.DefineProperty(this, "CorsAllowedOrigins", ["properties", "cors", "allowedOrigins"]);
        _disableAadAuth = BicepValue<bool>.DefineProperty(this, "DisableAadAuth", ["properties", "disableAadAuth"]);
        _disableLocalAuth = BicepValue<bool>.DefineProperty(this, "DisableLocalAuth", ["properties", "disableLocalAuth"]);
        _features = BicepList<SignalRFeature>.DefineProperty(this, "Features", ["properties", "features"]);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _isClientCertEnabled = BicepValue<bool>.DefineProperty(this, "IsClientCertEnabled", ["properties", "tls", "clientCertEnabled"]);
        _kind = BicepValue<SignalRServiceKind>.DefineProperty(this, "Kind", ["kind"]);
        _liveTraceConfiguration = BicepValue<SignalRLiveTraceConfiguration>.DefineProperty(this, "LiveTraceConfiguration", ["properties", "liveTraceConfiguration"]);
        _networkACLs = BicepValue<SignalRNetworkAcls>.DefineProperty(this, "NetworkACLs", ["properties", "networkACLs"]);
        _publicNetworkAccess = BicepValue<string>.DefineProperty(this, "PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _resourceLogCategories = BicepList<SignalRResourceLogCategory>.DefineProperty(this, "ResourceLogCategories", ["properties", "resourceLogConfiguration", "categories"]);
        _sku = BicepValue<SignalRResourceSku>.DefineProperty(this, "Sku", ["sku"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _upstreamTemplates = BicepList<SignalRUpstreamTemplate>.DefineProperty(this, "UpstreamTemplates", ["properties", "upstream", "templates"]);
        _externalIP = BicepValue<string>.DefineProperty(this, "ExternalIP", ["properties", "externalIP"], isOutput: true);
        _hostName = BicepValue<string>.DefineProperty(this, "HostName", ["properties", "hostName"], isOutput: true);
        _hostNamePrefix = BicepValue<string>.DefineProperty(this, "HostNamePrefix", ["properties", "hostNamePrefix"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _privateEndpointConnections = BicepList<SignalRPrivateEndpointConnectionData>.DefineProperty(this, "PrivateEndpointConnections", ["properties", "privateEndpointConnections"], isOutput: true);
        _provisioningState = BicepValue<SignalRProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _publicPort = BicepValue<int>.DefineProperty(this, "PublicPort", ["properties", "publicPort"], isOutput: true);
        _serverPort = BicepValue<int>.DefineProperty(this, "ServerPort", ["properties", "serverPort"], isOutput: true);
        _sharedPrivateLinkResources = BicepList<SignalRSharedPrivateLinkResourceData>.DefineProperty(this, "SharedPrivateLinkResources", ["properties", "sharedPrivateLinkResources"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _version = BicepValue<string>.DefineProperty(this, "Version", ["properties", "version"], isOutput: true);
    }

    /// <summary>
    /// Creates a reference to an existing SignalRService.
    /// </summary>
    /// <param name="resourceName">Name of the SignalRService.</param>
    /// <param name="resourceVersion">Version of the SignalRService.</param>
    /// <returns>The existing SignalRService resource.</returns>
    public static SignalRService FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this SignalRService resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 3, maxLength: 63, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);

    /// <summary>
    /// Get access keys for this SignalRService resource.
    /// </summary>
    /// <returns>The keys for this SignalRService resource.</returns>
    public SignalRKeys GetKeys() =>
        SignalRKeys.FromExpression(
            new FunctionCallExpression(new MemberExpression(new IdentifierExpression(ResourceName), "listKeys")));

    /// <summary>
    /// Assign a role to a user-assigned identity that grants access to this
    /// SignalRService.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="identity">The <see cref="UserAssignedIdentity"/>.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment AssignRole(SignalRBuiltInRole role, UserAssignedIdentity identity) =>
        new($"{ResourceName}_{identity.ResourceName}_{SignalRBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, identity.PrincipalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(ResourceName),
            PrincipalType = RoleManagementPrincipalType.ServicePrincipal,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = identity.PrincipalId
        };

    /// <summary>
    /// Assign a role to a principal that grants access to this SignalRService.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="principalType">The type of the principal to assign to.</param>
    /// <param name="principalId">The principal to assign to.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment AssignRole(SignalRBuiltInRole role, BicepValue<RoleManagementPrincipalType> principalType, BicepValue<Guid> principalId) =>
        new($"{ResourceName}_{SignalRBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, principalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(ResourceName),
            PrincipalType = principalType,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = principalId
        };
}
