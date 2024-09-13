// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.AppService;

/// <summary>
/// WebSiteSlot.
/// </summary>
public partial class WebSiteSlot : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Resource ID of the associated App Service plan, formatted as:
    /// &quot;/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}&quot;.
    /// </summary>
    public BicepValue<ResourceIdentifier> AppServicePlanId { get => _appServicePlanId; set => _appServicePlanId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _appServicePlanId;

    /// <summary>
    /// client certificate authentication comma-separated exclusion paths.
    /// </summary>
    public BicepValue<string> ClientCertExclusionPaths { get => _clientCertExclusionPaths; set => _clientCertExclusionPaths.Assign(value); }
    private readonly BicepValue<string> _clientCertExclusionPaths;

    /// <summary>
    /// This composes with ClientCertEnabled setting.             -
    /// ClientCertEnabled: false means ClientCert is ignored.             -
    /// ClientCertEnabled: true and ClientCertMode: Required means ClientCert
    /// is required.             - ClientCertEnabled: true and ClientCertMode:
    /// Optional means ClientCert is optional or accepted.
    /// </summary>
    public BicepValue<ClientCertMode> ClientCertMode { get => _clientCertMode; set => _clientCertMode.Assign(value); }
    private readonly BicepValue<ClientCertMode> _clientCertMode;

    /// <summary>
    /// If specified during app creation, the app is cloned from a source app.
    /// </summary>
    public BicepValue<CloningInfo> CloningInfo { get => _cloningInfo; set => _cloningInfo.Assign(value); }
    private readonly BicepValue<CloningInfo> _cloningInfo;

    /// <summary>
    /// Size of the function container.
    /// </summary>
    public BicepValue<int> ContainerSize { get => _containerSize; set => _containerSize.Assign(value); }
    private readonly BicepValue<int> _containerSize;

    /// <summary>
    /// Unique identifier that verifies the custom domains assigned to the app.
    /// Customer will add this id to a txt record for verification.
    /// </summary>
    public BicepValue<string> CustomDomainVerificationId { get => _customDomainVerificationId; set => _customDomainVerificationId.Assign(value); }
    private readonly BicepValue<string> _customDomainVerificationId;

    /// <summary>
    /// Maximum allowed daily memory-time quota (applicable on dynamic apps
    /// only).
    /// </summary>
    public BicepValue<int> DailyMemoryTimeQuota { get => _dailyMemoryTimeQuota; set => _dailyMemoryTimeQuota.Assign(value); }
    private readonly BicepValue<int> _dailyMemoryTimeQuota;

    /// <summary>
    /// Dapr configuration of the app.
    /// </summary>
    public BicepValue<AppDaprConfig> DaprConfig { get => _daprConfig; set => _daprConfig.Assign(value); }
    private readonly BicepValue<AppDaprConfig> _daprConfig;

    /// <summary>
    /// Property to configure various DNS related settings for a site.
    /// </summary>
    public BicepValue<SiteDnsConfig> DnsConfiguration { get => _dnsConfiguration; set => _dnsConfiguration.Assign(value); }
    private readonly BicepValue<SiteDnsConfig> _dnsConfiguration;

    /// <summary>
    /// Extended Location.
    /// </summary>
    public BicepValue<ExtendedAzureLocation> ExtendedLocation { get => _extendedLocation; set => _extendedLocation.Assign(value); }
    private readonly BicepValue<ExtendedAzureLocation> _extendedLocation;

    /// <summary>
    /// Configuration specific of the Azure Function app.
    /// </summary>
    public BicepValue<FunctionAppConfig> FunctionAppConfig { get => _functionAppConfig; set => _functionAppConfig.Assign(value); }
    private readonly BicepValue<FunctionAppConfig> _functionAppConfig;

    /// <summary>
    /// App Service Environment to use for the app.
    /// </summary>
    public BicepValue<HostingEnvironmentProfile> HostingEnvironmentProfile { get => _hostingEnvironmentProfile; set => _hostingEnvironmentProfile.Assign(value); }
    private readonly BicepValue<HostingEnvironmentProfile> _hostingEnvironmentProfile;

    /// <summary>
    /// Hostname SSL states are used to manage the SSL bindings for app&apos;s
    /// hostnames.
    /// </summary>
    public BicepList<HostNameSslState> HostNameSslStates { get => _hostNameSslStates; set => _hostNameSslStates.Assign(value); }
    private readonly BicepList<HostNameSslState> _hostNameSslStates;

    /// <summary>
    /// Managed service identity.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; to enable client affinity;
    /// &lt;code&gt;false&lt;/code&gt; to stop sending session affinity
    /// cookies, which route client requests in the same session to the same
    /// instance. Default is &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsClientAffinityEnabled { get => _isClientAffinityEnabled; set => _isClientAffinityEnabled.Assign(value); }
    private readonly BicepValue<bool> _isClientAffinityEnabled;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; to enable client certificate
    /// authentication (TLS mutual authentication); otherwise,
    /// &lt;code&gt;false&lt;/code&gt;. Default is
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsClientCertEnabled { get => _isClientCertEnabled; set => _isClientCertEnabled.Assign(value); }
    private readonly BicepValue<bool> _isClientCertEnabled;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if the app is enabled; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;. Setting this value to false disables
    /// the app (takes the app offline).
    /// </summary>
    public BicepValue<bool> IsEnabled { get => _isEnabled; set => _isEnabled.Assign(value); }
    private readonly BicepValue<bool> _isEnabled;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; to disable the public hostnames of the
    /// app; otherwise, &lt;code&gt;false&lt;/code&gt;.              If
    /// &lt;code&gt;true&lt;/code&gt;, the app is only accessible via API
    /// management process.
    /// </summary>
    public BicepValue<bool> IsHostNameDisabled { get => _isHostNameDisabled; set => _isHostNameDisabled.Assign(value); }
    private readonly BicepValue<bool> _isHostNameDisabled;

    /// <summary>
    /// HttpsOnly: configures a web site to accept only https requests. Issues
    /// redirect for             http requests
    /// </summary>
    public BicepValue<bool> IsHttpsOnly { get => _isHttpsOnly; set => _isHttpsOnly.Assign(value); }
    private readonly BicepValue<bool> _isHttpsOnly;

    /// <summary>
    /// Hyper-V sandbox.
    /// </summary>
    public BicepValue<bool> IsHyperV { get => _isHyperV; set => _isHyperV.Assign(value); }
    private readonly BicepValue<bool> _isHyperV;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if reserved; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsReserved { get => _isReserved; set => _isReserved.Assign(value); }
    private readonly BicepValue<bool> _isReserved;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; to stop SCM (KUDU) site when the app is
    /// stopped; otherwise, &lt;code&gt;false&lt;/code&gt;. The default is
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsScmSiteAlsoStopped { get => _isScmSiteAlsoStopped; set => _isScmSiteAlsoStopped.Assign(value); }
    private readonly BicepValue<bool> _isScmSiteAlsoStopped;

    /// <summary>
    /// Checks if Customer provided storage account is required.
    /// </summary>
    public BicepValue<bool> IsStorageAccountRequired { get => _isStorageAccountRequired; set => _isStorageAccountRequired.Assign(value); }
    private readonly BicepValue<bool> _isStorageAccountRequired;

    /// <summary>
    /// To enable Backup and Restore operations over virtual network.
    /// </summary>
    public BicepValue<bool> IsVnetBackupRestoreEnabled { get => _isVnetBackupRestoreEnabled; set => _isVnetBackupRestoreEnabled.Assign(value); }
    private readonly BicepValue<bool> _isVnetBackupRestoreEnabled;

    /// <summary>
    /// To enable accessing content over virtual network.
    /// </summary>
    public BicepValue<bool> IsVnetContentShareEnabled { get => _isVnetContentShareEnabled; set => _isVnetContentShareEnabled.Assign(value); }
    private readonly BicepValue<bool> _isVnetContentShareEnabled;

    /// <summary>
    /// To enable pulling image over Virtual Network.
    /// </summary>
    public BicepValue<bool> IsVnetImagePullEnabled { get => _isVnetImagePullEnabled; set => _isVnetImagePullEnabled.Assign(value); }
    private readonly BicepValue<bool> _isVnetImagePullEnabled;

    /// <summary>
    /// Virtual Network Route All enabled. This causes all outbound traffic to
    /// have Virtual Network Security Groups and User Defined Routes applied.
    /// </summary>
    public BicepValue<bool> IsVnetRouteAllEnabled { get => _isVnetRouteAllEnabled; set => _isVnetRouteAllEnabled.Assign(value); }
    private readonly BicepValue<bool> _isVnetRouteAllEnabled;

    /// <summary>
    /// Obsolete: Hyper-V sandbox.
    /// </summary>
    public BicepValue<bool> IsXenon { get => _isXenon; set => _isXenon.Assign(value); }
    private readonly BicepValue<bool> _isXenon;

    /// <summary>
    /// Identity to use for Key Vault Reference authentication.
    /// </summary>
    public BicepValue<string> KeyVaultReferenceIdentity { get => _keyVaultReferenceIdentity; set => _keyVaultReferenceIdentity.Assign(value); }
    private readonly BicepValue<string> _keyVaultReferenceIdentity;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// Azure Resource Manager ID of the customer&apos;s selected Managed
    /// Environment on which to host this app. This must be of the form
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.App/managedEnvironments/{managedEnvironmentName}.
    /// </summary>
    public BicepValue<string> ManagedEnvironmentId { get => _managedEnvironmentId; set => _managedEnvironmentId.Assign(value); }
    private readonly BicepValue<string> _managedEnvironmentId;

    /// <summary>
    /// Property to allow or block all public traffic. Allowed Values:
    /// &apos;Enabled&apos;, &apos;Disabled&apos; or an empty string.
    /// </summary>
    public BicepValue<string> PublicNetworkAccess { get => _publicNetworkAccess; set => _publicNetworkAccess.Assign(value); }
    private readonly BicepValue<string> _publicNetworkAccess;

    /// <summary>
    /// Site redundancy mode.
    /// </summary>
    public BicepValue<RedundancyMode> RedundancyMode { get => _redundancyMode; set => _redundancyMode.Assign(value); }
    private readonly BicepValue<RedundancyMode> _redundancyMode;

    /// <summary>
    /// Function app resource requirements.
    /// </summary>
    public BicepValue<FunctionAppResourceConfig> ResourceConfig { get => _resourceConfig; set => _resourceConfig.Assign(value); }
    private readonly BicepValue<FunctionAppResourceConfig> _resourceConfig;

    /// <summary>
    /// Configuration of the app.
    /// </summary>
    public BicepValue<SiteConfigProperties> SiteConfig { get => _siteConfig; set => _siteConfig.Assign(value); }
    private readonly BicepValue<SiteConfigProperties> _siteConfig;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Azure Resource Manager ID of the Virtual network and subnet to be
    /// joined by Regional VNET Integration.             This must be of the
    /// form
    /// /subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}
    /// </summary>
    public BicepValue<ResourceIdentifier> VirtualNetworkSubnetId { get => _virtualNetworkSubnetId; set => _virtualNetworkSubnetId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _virtualNetworkSubnetId;

    /// <summary>
    /// Workload profile name for function app to execute on.
    /// </summary>
    public BicepValue<string> WorkloadProfileName { get => _workloadProfileName; set => _workloadProfileName.Assign(value); }
    private readonly BicepValue<string> _workloadProfileName;

    /// <summary>
    /// Management information availability state for the app.
    /// </summary>
    public BicepValue<WebSiteAvailabilityState> AvailabilityState { get => _availabilityState; }
    private readonly BicepValue<WebSiteAvailabilityState> _availabilityState;

    /// <summary>
    /// Default hostname of the app. Read-only.
    /// </summary>
    public BicepValue<string> DefaultHostName { get => _defaultHostName; }
    private readonly BicepValue<string> _defaultHostName;

    /// <summary>
    /// Enabled hostnames for the app.Hostnames need to be assigned (see
    /// HostNames) AND enabled. Otherwise,             the app is not served
    /// on those hostnames.
    /// </summary>
    public BicepList<string> EnabledHostNames { get => _enabledHostNames; }
    private readonly BicepList<string> _enabledHostNames;

    /// <summary>
    /// Hostnames associated with the app.
    /// </summary>
    public BicepList<string> HostNames { get => _hostNames; }
    private readonly BicepList<string> _hostNames;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Specifies an operation id if this site has a pending operation.
    /// </summary>
    public BicepValue<Guid> InProgressOperationId { get => _inProgressOperationId; }
    private readonly BicepValue<Guid> _inProgressOperationId;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if the app is a default container;
    /// otherwise, &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsDefaultContainer { get => _isDefaultContainer; }
    private readonly BicepValue<bool> _isDefaultContainer;

    /// <summary>
    /// Last time the app was modified, in UTC. Read-only.
    /// </summary>
    public BicepValue<DateTimeOffset> LastModifiedTimeUtc { get => _lastModifiedTimeUtc; }
    private readonly BicepValue<DateTimeOffset> _lastModifiedTimeUtc;

    /// <summary>
    /// Maximum number of workers.             This only applies to Functions
    /// container.
    /// </summary>
    public BicepValue<int> MaxNumberOfWorkers { get => _maxNumberOfWorkers; }
    private readonly BicepValue<int> _maxNumberOfWorkers;

    /// <summary>
    /// List of IP addresses that the app uses for outbound connections (e.g.
    /// database access). Includes VIPs from tenants that site can be hosted
    /// with current settings. Read-only.
    /// </summary>
    public BicepValue<string> OutboundIPAddresses { get => _outboundIPAddresses; }
    private readonly BicepValue<string> _outboundIPAddresses;

    /// <summary>
    /// List of IP addresses that the app uses for outbound connections (e.g.
    /// database access). Includes VIPs from all tenants except dataComponent.
    /// Read-only.
    /// </summary>
    public BicepValue<string> PossibleOutboundIPAddresses { get => _possibleOutboundIPAddresses; }
    private readonly BicepValue<string> _possibleOutboundIPAddresses;

    /// <summary>
    /// Name of the repository site.
    /// </summary>
    public BicepValue<string> RepositorySiteName { get => _repositorySiteName; }
    private readonly BicepValue<string> _repositorySiteName;

    /// <summary>
    /// Name of the resource group the app belongs to. Read-only.
    /// </summary>
    public BicepValue<string> ResourceGroup { get => _resourceGroup; }
    private readonly BicepValue<string> _resourceGroup;

    /// <summary>
    /// Status of the last deployment slot swap operation.
    /// </summary>
    public BicepValue<SlotSwapStatus> SlotSwapStatus { get => _slotSwapStatus; }
    private readonly BicepValue<SlotSwapStatus> _slotSwapStatus;

    /// <summary>
    /// Current state of the app.
    /// </summary>
    public BicepValue<string> State { get => _state; }
    private readonly BicepValue<string> _state;

    /// <summary>
    /// App suspended till in case memory-time quota is exceeded.
    /// </summary>
    public BicepValue<DateTimeOffset> SuspendOn { get => _suspendOn; }
    private readonly BicepValue<DateTimeOffset> _suspendOn;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Specifies which deployment slot this app will swap into. Read-only.
    /// </summary>
    public BicepValue<string> TargetSwapSlot { get => _targetSwapSlot; }
    private readonly BicepValue<string> _targetSwapSlot;

    /// <summary>
    /// Azure Traffic Manager hostnames associated with the app. Read-only.
    /// </summary>
    public BicepList<string> TrafficManagerHostNames { get => _trafficManagerHostNames; }
    private readonly BicepList<string> _trafficManagerHostNames;

    /// <summary>
    /// State indicating whether the app has exceeded its quota usage.
    /// Read-only.
    /// </summary>
    public BicepValue<AppServiceUsageState> UsageState { get => _usageState; }
    private readonly BicepValue<AppServiceUsageState> _usageState;

    /// <summary>
    /// Gets or sets a reference to the parent WebSite.
    /// </summary>
    public WebSite? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<WebSite> _parent;

    /// <summary>
    /// Creates a new WebSiteSlot.
    /// </summary>
    /// <param name="resourceName">Name of the WebSiteSlot.</param>
    /// <param name="resourceVersion">Version of the WebSiteSlot.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public WebSiteSlot(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Web/sites/slots", resourceVersion ?? "2023-12-01", context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _appServicePlanId = BicepValue<ResourceIdentifier>.DefineProperty(this, "AppServicePlanId", ["properties", "serverFarmId"]);
        _clientCertExclusionPaths = BicepValue<string>.DefineProperty(this, "ClientCertExclusionPaths", ["properties", "clientCertExclusionPaths"]);
        _clientCertMode = BicepValue<ClientCertMode>.DefineProperty(this, "ClientCertMode", ["properties", "clientCertMode"]);
        _cloningInfo = BicepValue<CloningInfo>.DefineProperty(this, "CloningInfo", ["properties", "cloningInfo"]);
        _containerSize = BicepValue<int>.DefineProperty(this, "ContainerSize", ["properties", "containerSize"]);
        _customDomainVerificationId = BicepValue<string>.DefineProperty(this, "CustomDomainVerificationId", ["properties", "customDomainVerificationId"]);
        _dailyMemoryTimeQuota = BicepValue<int>.DefineProperty(this, "DailyMemoryTimeQuota", ["properties", "dailyMemoryTimeQuota"]);
        _daprConfig = BicepValue<AppDaprConfig>.DefineProperty(this, "DaprConfig", ["properties", "daprConfig"]);
        _dnsConfiguration = BicepValue<SiteDnsConfig>.DefineProperty(this, "DnsConfiguration", ["properties", "dnsConfiguration"]);
        _extendedLocation = BicepValue<ExtendedAzureLocation>.DefineProperty(this, "ExtendedLocation", ["extendedLocation"]);
        _functionAppConfig = BicepValue<FunctionAppConfig>.DefineProperty(this, "FunctionAppConfig", ["properties", "functionAppConfig"]);
        _hostingEnvironmentProfile = BicepValue<HostingEnvironmentProfile>.DefineProperty(this, "HostingEnvironmentProfile", ["properties", "hostingEnvironmentProfile"]);
        _hostNameSslStates = BicepList<HostNameSslState>.DefineProperty(this, "HostNameSslStates", ["properties", "hostNameSslStates"]);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _isClientAffinityEnabled = BicepValue<bool>.DefineProperty(this, "IsClientAffinityEnabled", ["properties", "clientAffinityEnabled"]);
        _isClientCertEnabled = BicepValue<bool>.DefineProperty(this, "IsClientCertEnabled", ["properties", "clientCertEnabled"]);
        _isEnabled = BicepValue<bool>.DefineProperty(this, "IsEnabled", ["properties", "enabled"]);
        _isHostNameDisabled = BicepValue<bool>.DefineProperty(this, "IsHostNameDisabled", ["properties", "hostNamesDisabled"]);
        _isHttpsOnly = BicepValue<bool>.DefineProperty(this, "IsHttpsOnly", ["properties", "httpsOnly"]);
        _isHyperV = BicepValue<bool>.DefineProperty(this, "IsHyperV", ["properties", "hyperV"]);
        _isReserved = BicepValue<bool>.DefineProperty(this, "IsReserved", ["properties", "reserved"]);
        _isScmSiteAlsoStopped = BicepValue<bool>.DefineProperty(this, "IsScmSiteAlsoStopped", ["properties", "scmSiteAlsoStopped"]);
        _isStorageAccountRequired = BicepValue<bool>.DefineProperty(this, "IsStorageAccountRequired", ["properties", "storageAccountRequired"]);
        _isVnetBackupRestoreEnabled = BicepValue<bool>.DefineProperty(this, "IsVnetBackupRestoreEnabled", ["properties", "vnetBackupRestoreEnabled"]);
        _isVnetContentShareEnabled = BicepValue<bool>.DefineProperty(this, "IsVnetContentShareEnabled", ["properties", "vnetContentShareEnabled"]);
        _isVnetImagePullEnabled = BicepValue<bool>.DefineProperty(this, "IsVnetImagePullEnabled", ["properties", "vnetImagePullEnabled"]);
        _isVnetRouteAllEnabled = BicepValue<bool>.DefineProperty(this, "IsVnetRouteAllEnabled", ["properties", "vnetRouteAllEnabled"]);
        _isXenon = BicepValue<bool>.DefineProperty(this, "IsXenon", ["properties", "isXenon"]);
        _keyVaultReferenceIdentity = BicepValue<string>.DefineProperty(this, "KeyVaultReferenceIdentity", ["properties", "keyVaultReferenceIdentity"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _managedEnvironmentId = BicepValue<string>.DefineProperty(this, "ManagedEnvironmentId", ["properties", "managedEnvironmentId"]);
        _publicNetworkAccess = BicepValue<string>.DefineProperty(this, "PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _redundancyMode = BicepValue<RedundancyMode>.DefineProperty(this, "RedundancyMode", ["properties", "redundancyMode"]);
        _resourceConfig = BicepValue<FunctionAppResourceConfig>.DefineProperty(this, "ResourceConfig", ["properties", "resourceConfig"]);
        _siteConfig = BicepValue<SiteConfigProperties>.DefineProperty(this, "SiteConfig", ["properties", "siteConfig"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _virtualNetworkSubnetId = BicepValue<ResourceIdentifier>.DefineProperty(this, "VirtualNetworkSubnetId", ["properties", "virtualNetworkSubnetId"]);
        _workloadProfileName = BicepValue<string>.DefineProperty(this, "WorkloadProfileName", ["properties", "workloadProfileName"]);
        _availabilityState = BicepValue<WebSiteAvailabilityState>.DefineProperty(this, "AvailabilityState", ["properties", "availabilityState"], isOutput: true);
        _defaultHostName = BicepValue<string>.DefineProperty(this, "DefaultHostName", ["properties", "defaultHostName"], isOutput: true);
        _enabledHostNames = BicepList<string>.DefineProperty(this, "EnabledHostNames", ["properties", "enabledHostNames"], isOutput: true);
        _hostNames = BicepList<string>.DefineProperty(this, "HostNames", ["properties", "hostNames"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _inProgressOperationId = BicepValue<Guid>.DefineProperty(this, "InProgressOperationId", ["properties", "inProgressOperationId"], isOutput: true);
        _isDefaultContainer = BicepValue<bool>.DefineProperty(this, "IsDefaultContainer", ["properties", "isDefaultContainer"], isOutput: true);
        _lastModifiedTimeUtc = BicepValue<DateTimeOffset>.DefineProperty(this, "LastModifiedTimeUtc", ["properties", "lastModifiedTimeUtc"], isOutput: true);
        _maxNumberOfWorkers = BicepValue<int>.DefineProperty(this, "MaxNumberOfWorkers", ["properties", "maxNumberOfWorkers"], isOutput: true);
        _outboundIPAddresses = BicepValue<string>.DefineProperty(this, "OutboundIPAddresses", ["properties", "outboundIpAddresses"], isOutput: true);
        _possibleOutboundIPAddresses = BicepValue<string>.DefineProperty(this, "PossibleOutboundIPAddresses", ["properties", "possibleOutboundIpAddresses"], isOutput: true);
        _repositorySiteName = BicepValue<string>.DefineProperty(this, "RepositorySiteName", ["properties", "repositorySiteName"], isOutput: true);
        _resourceGroup = BicepValue<string>.DefineProperty(this, "ResourceGroup", ["properties", "resourceGroup"], isOutput: true);
        _slotSwapStatus = BicepValue<SlotSwapStatus>.DefineProperty(this, "SlotSwapStatus", ["properties", "slotSwapStatus"], isOutput: true);
        _state = BicepValue<string>.DefineProperty(this, "State", ["properties", "state"], isOutput: true);
        _suspendOn = BicepValue<DateTimeOffset>.DefineProperty(this, "SuspendOn", ["properties", "suspendedTill"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _targetSwapSlot = BicepValue<string>.DefineProperty(this, "TargetSwapSlot", ["properties", "targetSwapSlot"], isOutput: true);
        _trafficManagerHostNames = BicepList<string>.DefineProperty(this, "TrafficManagerHostNames", ["properties", "trafficManagerHostNames"], isOutput: true);
        _usageState = BicepValue<AppServiceUsageState>.DefineProperty(this, "UsageState", ["properties", "usageState"], isOutput: true);
        _parent = ResourceReference<WebSite>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported WebSiteSlot resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-12-01.
        /// </summary>
        public static readonly string V2023_12_01 = "2023-12-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";

        /// <summary>
        /// 2021-03-01.
        /// </summary>
        public static readonly string V2021_03_01 = "2021-03-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-15.
        /// </summary>
        public static readonly string V2021_01_15 = "2021-01-15";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";

        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2018-11-01.
        /// </summary>
        public static readonly string V2018_11_01 = "2018-11-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2017-08-01.
        /// </summary>
        public static readonly string V2017_08_01 = "2017-08-01";

        /// <summary>
        /// 2016-09-01.
        /// </summary>
        public static readonly string V2016_09_01 = "2016-09-01";

        /// <summary>
        /// 2016-08-01.
        /// </summary>
        public static readonly string V2016_08_01 = "2016-08-01";

        /// <summary>
        /// 2016-03-01.
        /// </summary>
        public static readonly string V2016_03_01 = "2016-03-01";

        /// <summary>
        /// 2015-11-01.
        /// </summary>
        public static readonly string V2015_11_01 = "2015-11-01";

        /// <summary>
        /// 2015-08-01.
        /// </summary>
        public static readonly string V2015_08_01 = "2015-08-01";

        /// <summary>
        /// 2015-07-01.
        /// </summary>
        public static readonly string V2015_07_01 = "2015-07-01";

        /// <summary>
        /// 2015-06-01.
        /// </summary>
        public static readonly string V2015_06_01 = "2015-06-01";

        /// <summary>
        /// 2015-05-01.
        /// </summary>
        public static readonly string V2015_05_01 = "2015-05-01";

        /// <summary>
        /// 2015-04-01.
        /// </summary>
        public static readonly string V2015_04_01 = "2015-04-01";

        /// <summary>
        /// 2015-02-01.
        /// </summary>
        public static readonly string V2015_02_01 = "2015-02-01";

        /// <summary>
        /// 2015-01-01.
        /// </summary>
        public static readonly string V2015_01_01 = "2015-01-01";

        /// <summary>
        /// 2014-11-01.
        /// </summary>
        public static readonly string V2014_11_01 = "2014-11-01";

        /// <summary>
        /// 2014-06-01.
        /// </summary>
        public static readonly string V2014_06_01 = "2014-06-01";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing WebSiteSlot.
    /// </summary>
    /// <param name="resourceName">Name of the WebSiteSlot.</param>
    /// <param name="resourceVersion">Version of the WebSiteSlot.</param>
    /// <returns>The existing WebSiteSlot resource.</returns>
    public static WebSiteSlot FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this WebSiteSlot resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 2, maxLength: 59, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);
}
