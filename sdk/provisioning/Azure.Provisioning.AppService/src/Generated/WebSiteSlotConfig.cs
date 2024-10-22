// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// WebSiteSlotConfig.
/// </summary>
public partial class WebSiteSlotConfig : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// If using user managed identity, the user managed identity ClientId.
    /// </summary>
    public BicepValue<string> AcrUserManagedIdentityId { get => _acrUserManagedIdentityId; set => _acrUserManagedIdentityId.Assign(value); }
    private readonly BicepValue<string> _acrUserManagedIdentityId;

    /// <summary>
    /// IP security restrictions for scm to use main.
    /// </summary>
    public BicepValue<bool> AllowIPSecurityRestrictionsForScmToUseMain { get => _allowIPSecurityRestrictionsForScmToUseMain; set => _allowIPSecurityRestrictionsForScmToUseMain.Assign(value); }
    private readonly BicepValue<bool> _allowIPSecurityRestrictionsForScmToUseMain;

    /// <summary>
    /// The URL of the API definition.
    /// </summary>
    public BicepValue<Uri> ApiDefinitionUri { get => _apiDefinitionUri; set => _apiDefinitionUri.Assign(value); }
    private readonly BicepValue<Uri> _apiDefinitionUri;

    /// <summary>
    /// APIM-Api Identifier.
    /// </summary>
    public BicepValue<string> ApiManagementConfigId { get => _apiManagementConfigId; set => _apiManagementConfigId.Assign(value); }
    private readonly BicepValue<string> _apiManagementConfigId;

    /// <summary>
    /// App command line to launch.
    /// </summary>
    public BicepValue<string> AppCommandLine { get => _appCommandLine; set => _appCommandLine.Assign(value); }
    private readonly BicepValue<string> _appCommandLine;

    /// <summary>
    /// Application settings.
    /// </summary>
    public BicepList<AppServiceNameValuePair> AppSettings { get => _appSettings; set => _appSettings.Assign(value); }
    private readonly BicepList<AppServiceNameValuePair> _appSettings;

    /// <summary>
    /// Auto Heal rules.
    /// </summary>
    public BicepValue<AutoHealRules> AutoHealRules { get => _autoHealRules; set => _autoHealRules.Assign(value); }
    private readonly BicepValue<AutoHealRules> _autoHealRules;

    /// <summary>
    /// Auto-swap slot name.
    /// </summary>
    public BicepValue<string> AutoSwapSlotName { get => _autoSwapSlotName; set => _autoSwapSlotName.Assign(value); }
    private readonly BicepValue<string> _autoSwapSlotName;

    /// <summary>
    /// List of Azure Storage Accounts.
    /// </summary>
    public BicepDictionary<AppServiceStorageAccessInfo> AzureStorageAccounts { get => _azureStorageAccounts; set => _azureStorageAccounts.Assign(value); }
    private readonly BicepDictionary<AppServiceStorageAccessInfo> _azureStorageAccounts;

    /// <summary>
    /// Connection strings.
    /// </summary>
    public BicepList<ConnStringInfo> ConnectionStrings { get => _connectionStrings; set => _connectionStrings.Assign(value); }
    private readonly BicepList<ConnStringInfo> _connectionStrings;

    /// <summary>
    /// Cross-Origin Resource Sharing (CORS) settings.
    /// </summary>
    public BicepValue<AppServiceCorsSettings> Cors { get => _cors; set => _cors.Assign(value); }
    private readonly BicepValue<AppServiceCorsSettings> _cors;

    /// <summary>
    /// Default documents.
    /// </summary>
    public BicepList<string> DefaultDocuments { get => _defaultDocuments; set => _defaultDocuments.Assign(value); }
    private readonly BicepList<string> _defaultDocuments;

    /// <summary>
    /// Document root.
    /// </summary>
    public BicepValue<string> DocumentRoot { get => _documentRoot; set => _documentRoot.Assign(value); }
    private readonly BicepValue<string> _documentRoot;

    /// <summary>
    /// Maximum number of workers that a site can scale out to.
    /// This setting only applies to apps in plans where
    /// ElasticScaleEnabled is &lt;code&gt;true&lt;/code&gt;
    /// </summary>
    public BicepValue<int> ElasticWebAppScaleLimit { get => _elasticWebAppScaleLimit; set => _elasticWebAppScaleLimit.Assign(value); }
    private readonly BicepValue<int> _elasticWebAppScaleLimit;

    /// <summary>
    /// List of ramp-up rules.
    /// </summary>
    public BicepList<RampUpRule> ExperimentsRampUpRules { get => _experimentsRampUpRules; set => _experimentsRampUpRules.Assign(value); }
    private readonly BicepList<RampUpRule> _experimentsRampUpRules;

    /// <summary>
    /// State of FTP / FTPS service.
    /// </summary>
    public BicepValue<AppServiceFtpsState> FtpsState { get => _ftpsState; set => _ftpsState.Assign(value); }
    private readonly BicepValue<AppServiceFtpsState> _ftpsState;

    /// <summary>
    /// Maximum number of workers that a site can scale out to.
    /// This setting only applies to the Consumption and Elastic
    /// Premium Plans
    /// </summary>
    public BicepValue<int> FunctionAppScaleLimit { get => _functionAppScaleLimit; set => _functionAppScaleLimit.Assign(value); }
    private readonly BicepValue<int> _functionAppScaleLimit;

    /// <summary>
    /// Handler mappings.
    /// </summary>
    public BicepList<HttpRequestHandlerMapping> HandlerMappings { get => _handlerMappings; set => _handlerMappings.Assign(value); }
    private readonly BicepList<HttpRequestHandlerMapping> _handlerMappings;

    /// <summary>
    /// Health check path.
    /// </summary>
    public BicepValue<string> HealthCheckPath { get => _healthCheckPath; set => _healthCheckPath.Assign(value); }
    private readonly BicepValue<string> _healthCheckPath;

    /// <summary>
    /// IP security restrictions for main.
    /// </summary>
    public BicepList<AppServiceIPSecurityRestriction> IPSecurityRestrictions { get => _iPSecurityRestrictions; set => _iPSecurityRestrictions.Assign(value); }
    private readonly BicepList<AppServiceIPSecurityRestriction> _iPSecurityRestrictions;

    /// <summary>
    /// Default action for main access restriction if no rules are matched.
    /// </summary>
    public BicepValue<SiteDefaultAction> IPSecurityRestrictionsDefaultAction { get => _iPSecurityRestrictionsDefaultAction; set => _iPSecurityRestrictionsDefaultAction.Assign(value); }
    private readonly BicepValue<SiteDefaultAction> _iPSecurityRestrictionsDefaultAction;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if Always On is enabled; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsAlwaysOn { get => _isAlwaysOn; set => _isAlwaysOn.Assign(value); }
    private readonly BicepValue<bool> _isAlwaysOn;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if Auto Heal is enabled; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsAutoHealEnabled { get => _isAutoHealEnabled; set => _isAutoHealEnabled.Assign(value); }
    private readonly BicepValue<bool> _isAutoHealEnabled;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if detailed error logging is enabled;
    /// otherwise, &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsDetailedErrorLoggingEnabled { get => _isDetailedErrorLoggingEnabled; set => _isDetailedErrorLoggingEnabled.Assign(value); }
    private readonly BicepValue<bool> _isDetailedErrorLoggingEnabled;

    /// <summary>
    /// Gets or sets a value indicating whether functions runtime scale
    /// monitoring is enabled. When enabled,             the ScaleController
    /// will not monitor event sources directly, but will instead call to the
    /// runtime to get scale status.
    /// </summary>
    public BicepValue<bool> IsFunctionsRuntimeScaleMonitoringEnabled { get => _isFunctionsRuntimeScaleMonitoringEnabled; set => _isFunctionsRuntimeScaleMonitoringEnabled.Assign(value); }
    private readonly BicepValue<bool> _isFunctionsRuntimeScaleMonitoringEnabled;

    /// <summary>
    /// Http20Enabled: configures a web site to allow clients to connect over
    /// http2.0.
    /// </summary>
    public BicepValue<bool> IsHttp20Enabled { get => _isHttp20Enabled; set => _isHttp20Enabled.Assign(value); }
    private readonly BicepValue<bool> _isHttp20Enabled;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if HTTP logging is enabled; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsHttpLoggingEnabled { get => _isHttpLoggingEnabled; set => _isHttpLoggingEnabled.Assign(value); }
    private readonly BicepValue<bool> _isHttpLoggingEnabled;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; to enable local MySQL; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsLocalMySqlEnabled { get => _isLocalMySqlEnabled; set => _isLocalMySqlEnabled.Assign(value); }
    private readonly BicepValue<bool> _isLocalMySqlEnabled;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if remote debugging is enabled;
    /// otherwise, &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsRemoteDebuggingEnabled { get => _isRemoteDebuggingEnabled; set => _isRemoteDebuggingEnabled.Assign(value); }
    private readonly BicepValue<bool> _isRemoteDebuggingEnabled;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if request tracing is enabled; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsRequestTracingEnabled { get => _isRequestTracingEnabled; set => _isRequestTracingEnabled.Assign(value); }
    private readonly BicepValue<bool> _isRequestTracingEnabled;

    /// <summary>
    /// Virtual Network Route All enabled. This causes all outbound traffic to
    /// have Virtual Network Security Groups and User Defined Routes applied.
    /// </summary>
    public BicepValue<bool> IsVnetRouteAllEnabled { get => _isVnetRouteAllEnabled; set => _isVnetRouteAllEnabled.Assign(value); }
    private readonly BicepValue<bool> _isVnetRouteAllEnabled;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if WebSocket is enabled; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsWebSocketsEnabled { get => _isWebSocketsEnabled; set => _isWebSocketsEnabled.Assign(value); }
    private readonly BicepValue<bool> _isWebSocketsEnabled;

    /// <summary>
    /// Java container.
    /// </summary>
    public BicepValue<string> JavaContainer { get => _javaContainer; set => _javaContainer.Assign(value); }
    private readonly BicepValue<string> _javaContainer;

    /// <summary>
    /// Java container version.
    /// </summary>
    public BicepValue<string> JavaContainerVersion { get => _javaContainerVersion; set => _javaContainerVersion.Assign(value); }
    private readonly BicepValue<string> _javaContainerVersion;

    /// <summary>
    /// Java version.
    /// </summary>
    public BicepValue<string> JavaVersion { get => _javaVersion; set => _javaVersion.Assign(value); }
    private readonly BicepValue<string> _javaVersion;

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
    /// Site limits.
    /// </summary>
    public BicepValue<SiteLimits> Limits { get => _limits; set => _limits.Assign(value); }
    private readonly BicepValue<SiteLimits> _limits;

    /// <summary>
    /// Linux App Framework and version.
    /// </summary>
    public BicepValue<string> LinuxFxVersion { get => _linuxFxVersion; set => _linuxFxVersion.Assign(value); }
    private readonly BicepValue<string> _linuxFxVersion;

    /// <summary>
    /// Site load balancing.
    /// </summary>
    public BicepValue<SiteLoadBalancing> LoadBalancing { get => _loadBalancing; set => _loadBalancing.Assign(value); }
    private readonly BicepValue<SiteLoadBalancing> _loadBalancing;

    /// <summary>
    /// HTTP logs directory size limit.
    /// </summary>
    public BicepValue<int> LogsDirectorySizeLimit { get => _logsDirectorySizeLimit; set => _logsDirectorySizeLimit.Assign(value); }
    private readonly BicepValue<int> _logsDirectorySizeLimit;

    /// <summary>
    /// Managed pipeline mode.
    /// </summary>
    public BicepValue<ManagedPipelineMode> ManagedPipelineMode { get => _managedPipelineMode; set => _managedPipelineMode.Assign(value); }
    private readonly BicepValue<ManagedPipelineMode> _managedPipelineMode;

    /// <summary>
    /// Managed Service Identity Id.
    /// </summary>
    public BicepValue<int> ManagedServiceIdentityId { get => _managedServiceIdentityId; set => _managedServiceIdentityId.Assign(value); }
    private readonly BicepValue<int> _managedServiceIdentityId;

    /// <summary>
    /// Application metadata. This property cannot be retrieved, since it may
    /// contain secrets.
    /// </summary>
    public BicepList<AppServiceNameValuePair> Metadata { get => _metadata; set => _metadata.Assign(value); }
    private readonly BicepList<AppServiceNameValuePair> _metadata;

    /// <summary>
    /// Number of minimum instance count for a site             This setting
    /// only applies to the Elastic Plans
    /// </summary>
    public BicepValue<int> MinimumElasticInstanceCount { get => _minimumElasticInstanceCount; set => _minimumElasticInstanceCount.Assign(value); }
    private readonly BicepValue<int> _minimumElasticInstanceCount;

    /// <summary>
    /// The minimum strength TLS cipher suite allowed for an application.
    /// </summary>
    public BicepValue<AppServiceTlsCipherSuite> MinTlsCipherSuite { get => _minTlsCipherSuite; set => _minTlsCipherSuite.Assign(value); }
    private readonly BicepValue<AppServiceTlsCipherSuite> _minTlsCipherSuite;

    /// <summary>
    /// MinTlsVersion: configures the minimum version of TLS required for SSL
    /// requests.
    /// </summary>
    public BicepValue<AppServiceSupportedTlsVersion> MinTlsVersion { get => _minTlsVersion; set => _minTlsVersion.Assign(value); }
    private readonly BicepValue<AppServiceSupportedTlsVersion> _minTlsVersion;

    /// <summary>
    /// .NET Framework version.
    /// </summary>
    public BicepValue<string> NetFrameworkVersion { get => _netFrameworkVersion; set => _netFrameworkVersion.Assign(value); }
    private readonly BicepValue<string> _netFrameworkVersion;

    /// <summary>
    /// Version of Node.js.
    /// </summary>
    public BicepValue<string> NodeVersion { get => _nodeVersion; set => _nodeVersion.Assign(value); }
    private readonly BicepValue<string> _nodeVersion;

    /// <summary>
    /// Number of workers.
    /// </summary>
    public BicepValue<int> NumberOfWorkers { get => _numberOfWorkers; set => _numberOfWorkers.Assign(value); }
    private readonly BicepValue<int> _numberOfWorkers;

    /// <summary>
    /// Version of PHP.
    /// </summary>
    public BicepValue<string> PhpVersion { get => _phpVersion; set => _phpVersion.Assign(value); }
    private readonly BicepValue<string> _phpVersion;

    /// <summary>
    /// Version of PowerShell.
    /// </summary>
    public BicepValue<string> PowerShellVersion { get => _powerShellVersion; set => _powerShellVersion.Assign(value); }
    private readonly BicepValue<string> _powerShellVersion;

    /// <summary>
    /// Number of preWarmed instances.             This setting only applies to
    /// the Consumption and Elastic Plans
    /// </summary>
    public BicepValue<int> PreWarmedInstanceCount { get => _preWarmedInstanceCount; set => _preWarmedInstanceCount.Assign(value); }
    private readonly BicepValue<int> _preWarmedInstanceCount;

    /// <summary>
    /// Property to allow or block all public traffic.
    /// </summary>
    public BicepValue<string> PublicNetworkAccess { get => _publicNetworkAccess; set => _publicNetworkAccess.Assign(value); }
    private readonly BicepValue<string> _publicNetworkAccess;

    /// <summary>
    /// Publishing user name.
    /// </summary>
    public BicepValue<string> PublishingUsername { get => _publishingUsername; set => _publishingUsername.Assign(value); }
    private readonly BicepValue<string> _publishingUsername;

    /// <summary>
    /// Push endpoint settings.
    /// </summary>
    public BicepValue<WebAppPushSettings> Push { get => _push; set => _push.Assign(value); }
    private readonly BicepValue<WebAppPushSettings> _push;

    /// <summary>
    /// Version of Python.
    /// </summary>
    public BicepValue<string> PythonVersion { get => _pythonVersion; set => _pythonVersion.Assign(value); }
    private readonly BicepValue<string> _pythonVersion;

    /// <summary>
    /// Remote debugging version.
    /// </summary>
    public BicepValue<string> RemoteDebuggingVersion { get => _remoteDebuggingVersion; set => _remoteDebuggingVersion.Assign(value); }
    private readonly BicepValue<string> _remoteDebuggingVersion;

    /// <summary>
    /// Request tracing expiration time.
    /// </summary>
    public BicepValue<DateTimeOffset> RequestTracingExpirationOn { get => _requestTracingExpirationOn; set => _requestTracingExpirationOn.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _requestTracingExpirationOn;

    /// <summary>
    /// IP security restrictions for scm.
    /// </summary>
    public BicepList<AppServiceIPSecurityRestriction> ScmIPSecurityRestrictions { get => _scmIPSecurityRestrictions; set => _scmIPSecurityRestrictions.Assign(value); }
    private readonly BicepList<AppServiceIPSecurityRestriction> _scmIPSecurityRestrictions;

    /// <summary>
    /// Default action for scm access restriction if no rules are matched.
    /// </summary>
    public BicepValue<SiteDefaultAction> ScmIPSecurityRestrictionsDefaultAction { get => _scmIPSecurityRestrictionsDefaultAction; set => _scmIPSecurityRestrictionsDefaultAction.Assign(value); }
    private readonly BicepValue<SiteDefaultAction> _scmIPSecurityRestrictionsDefaultAction;

    /// <summary>
    /// ScmMinTlsVersion: configures the minimum version of TLS required for
    /// SSL requests for SCM site.
    /// </summary>
    public BicepValue<AppServiceSupportedTlsVersion> ScmMinTlsVersion { get => _scmMinTlsVersion; set => _scmMinTlsVersion.Assign(value); }
    private readonly BicepValue<AppServiceSupportedTlsVersion> _scmMinTlsVersion;

    /// <summary>
    /// SCM type.
    /// </summary>
    public BicepValue<ScmType> ScmType { get => _scmType; set => _scmType.Assign(value); }
    private readonly BicepValue<ScmType> _scmType;

    /// <summary>
    /// Tracing options.
    /// </summary>
    public BicepValue<string> TracingOptions { get => _tracingOptions; set => _tracingOptions.Assign(value); }
    private readonly BicepValue<string> _tracingOptions;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; to use 32-bit worker process; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> Use32BitWorkerProcess { get => _use32BitWorkerProcess; set => _use32BitWorkerProcess.Assign(value); }
    private readonly BicepValue<bool> _use32BitWorkerProcess;

    /// <summary>
    /// Flag to use Managed Identity Creds for ACR pull.
    /// </summary>
    public BicepValue<bool> UseManagedIdentityCreds { get => _useManagedIdentityCreds; set => _useManagedIdentityCreds.Assign(value); }
    private readonly BicepValue<bool> _useManagedIdentityCreds;

    /// <summary>
    /// Virtual applications.
    /// </summary>
    public BicepList<VirtualApplication> VirtualApplications { get => _virtualApplications; set => _virtualApplications.Assign(value); }
    private readonly BicepList<VirtualApplication> _virtualApplications;

    /// <summary>
    /// Virtual Network name.
    /// </summary>
    public BicepValue<string> VnetName { get => _vnetName; set => _vnetName.Assign(value); }
    private readonly BicepValue<string> _vnetName;

    /// <summary>
    /// The number of private ports assigned to this app. These will be
    /// assigned dynamically on runtime.
    /// </summary>
    public BicepValue<int> VnetPrivatePortsCount { get => _vnetPrivatePortsCount; set => _vnetPrivatePortsCount.Assign(value); }
    private readonly BicepValue<int> _vnetPrivatePortsCount;

    /// <summary>
    /// Sets the time zone a site uses for generating timestamps. Compatible
    /// with Linux and Windows App Service. Setting the WEBSITE_TIME_ZONE app
    /// setting takes precedence over this config. For Linux, expects tz
    /// database values https://www.iana.org/time-zones (for a quick reference
    /// see https://en.wikipedia.org/wiki/List_of_tz_database_time_zones). For
    /// Windows, expects one of the time zones listed under
    /// HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time
    /// Zones.
    /// </summary>
    public BicepValue<string> WebsiteTimeZone { get => _websiteTimeZone; set => _websiteTimeZone.Assign(value); }
    private readonly BicepValue<string> _websiteTimeZone;

    /// <summary>
    /// Xenon App Framework and version.
    /// </summary>
    public BicepValue<string> WindowsFxVersion { get => _windowsFxVersion; set => _windowsFxVersion.Assign(value); }
    private readonly BicepValue<string> _windowsFxVersion;

    /// <summary>
    /// Explicit Managed Service Identity Id.
    /// </summary>
    public BicepValue<int> XManagedServiceIdentityId { get => _xManagedServiceIdentityId; set => _xManagedServiceIdentityId.Assign(value); }
    private readonly BicepValue<int> _xManagedServiceIdentityId;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Site MachineKey.
    /// </summary>
    public BicepValue<SiteMachineKey> MachineKey { get => _machineKey; }
    private readonly BicepValue<SiteMachineKey> _machineKey;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent WebSiteSlot.
    /// </summary>
    public WebSiteSlot? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<WebSiteSlot> _parent;

    /// <summary>
    /// Creates a new WebSiteSlotConfig.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the WebSiteSlotConfig resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the WebSiteSlotConfig.</param>
    public WebSiteSlotConfig(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Web/sites/slots/config", resourceVersion ?? "2024-04-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _acrUserManagedIdentityId = BicepValue<string>.DefineProperty(this, "AcrUserManagedIdentityId", ["properties", "acrUserManagedIdentityID"]);
        _allowIPSecurityRestrictionsForScmToUseMain = BicepValue<bool>.DefineProperty(this, "AllowIPSecurityRestrictionsForScmToUseMain", ["properties", "scmIpSecurityRestrictionsUseMain"]);
        _apiDefinitionUri = BicepValue<Uri>.DefineProperty(this, "ApiDefinitionUri", ["properties", "apiDefinition", "url"]);
        _apiManagementConfigId = BicepValue<string>.DefineProperty(this, "ApiManagementConfigId", ["properties", "apiManagementConfig", "id"]);
        _appCommandLine = BicepValue<string>.DefineProperty(this, "AppCommandLine", ["properties", "appCommandLine"]);
        _appSettings = BicepList<AppServiceNameValuePair>.DefineProperty(this, "AppSettings", ["properties", "appSettings"]);
        _autoHealRules = BicepValue<AutoHealRules>.DefineProperty(this, "AutoHealRules", ["properties", "autoHealRules"]);
        _autoSwapSlotName = BicepValue<string>.DefineProperty(this, "AutoSwapSlotName", ["properties", "autoSwapSlotName"]);
        _azureStorageAccounts = BicepDictionary<AppServiceStorageAccessInfo>.DefineProperty(this, "AzureStorageAccounts", ["properties", "azureStorageAccounts"]);
        _connectionStrings = BicepList<ConnStringInfo>.DefineProperty(this, "ConnectionStrings", ["properties", "connectionStrings"]);
        _cors = BicepValue<AppServiceCorsSettings>.DefineProperty(this, "Cors", ["properties", "cors"]);
        _defaultDocuments = BicepList<string>.DefineProperty(this, "DefaultDocuments", ["properties", "defaultDocuments"]);
        _documentRoot = BicepValue<string>.DefineProperty(this, "DocumentRoot", ["properties", "documentRoot"]);
        _elasticWebAppScaleLimit = BicepValue<int>.DefineProperty(this, "ElasticWebAppScaleLimit", ["properties", "elasticWebAppScaleLimit"]);
        _experimentsRampUpRules = BicepList<RampUpRule>.DefineProperty(this, "ExperimentsRampUpRules", ["properties", "experiments", "rampUpRules"]);
        _ftpsState = BicepValue<AppServiceFtpsState>.DefineProperty(this, "FtpsState", ["properties", "ftpsState"]);
        _functionAppScaleLimit = BicepValue<int>.DefineProperty(this, "FunctionAppScaleLimit", ["properties", "functionAppScaleLimit"]);
        _handlerMappings = BicepList<HttpRequestHandlerMapping>.DefineProperty(this, "HandlerMappings", ["properties", "handlerMappings"]);
        _healthCheckPath = BicepValue<string>.DefineProperty(this, "HealthCheckPath", ["properties", "healthCheckPath"]);
        _iPSecurityRestrictions = BicepList<AppServiceIPSecurityRestriction>.DefineProperty(this, "IPSecurityRestrictions", ["properties", "ipSecurityRestrictions"]);
        _iPSecurityRestrictionsDefaultAction = BicepValue<SiteDefaultAction>.DefineProperty(this, "IPSecurityRestrictionsDefaultAction", ["properties", "ipSecurityRestrictionsDefaultAction"]);
        _isAlwaysOn = BicepValue<bool>.DefineProperty(this, "IsAlwaysOn", ["properties", "alwaysOn"]);
        _isAutoHealEnabled = BicepValue<bool>.DefineProperty(this, "IsAutoHealEnabled", ["properties", "autoHealEnabled"]);
        _isDetailedErrorLoggingEnabled = BicepValue<bool>.DefineProperty(this, "IsDetailedErrorLoggingEnabled", ["properties", "detailedErrorLoggingEnabled"]);
        _isFunctionsRuntimeScaleMonitoringEnabled = BicepValue<bool>.DefineProperty(this, "IsFunctionsRuntimeScaleMonitoringEnabled", ["properties", "functionsRuntimeScaleMonitoringEnabled"]);
        _isHttp20Enabled = BicepValue<bool>.DefineProperty(this, "IsHttp20Enabled", ["properties", "http20Enabled"]);
        _isHttpLoggingEnabled = BicepValue<bool>.DefineProperty(this, "IsHttpLoggingEnabled", ["properties", "httpLoggingEnabled"]);
        _isLocalMySqlEnabled = BicepValue<bool>.DefineProperty(this, "IsLocalMySqlEnabled", ["properties", "localMySqlEnabled"]);
        _isRemoteDebuggingEnabled = BicepValue<bool>.DefineProperty(this, "IsRemoteDebuggingEnabled", ["properties", "remoteDebuggingEnabled"]);
        _isRequestTracingEnabled = BicepValue<bool>.DefineProperty(this, "IsRequestTracingEnabled", ["properties", "requestTracingEnabled"]);
        _isVnetRouteAllEnabled = BicepValue<bool>.DefineProperty(this, "IsVnetRouteAllEnabled", ["properties", "vnetRouteAllEnabled"]);
        _isWebSocketsEnabled = BicepValue<bool>.DefineProperty(this, "IsWebSocketsEnabled", ["properties", "webSocketsEnabled"]);
        _javaContainer = BicepValue<string>.DefineProperty(this, "JavaContainer", ["properties", "javaContainer"]);
        _javaContainerVersion = BicepValue<string>.DefineProperty(this, "JavaContainerVersion", ["properties", "javaContainerVersion"]);
        _javaVersion = BicepValue<string>.DefineProperty(this, "JavaVersion", ["properties", "javaVersion"]);
        _keyVaultReferenceIdentity = BicepValue<string>.DefineProperty(this, "KeyVaultReferenceIdentity", ["properties", "keyVaultReferenceIdentity"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _limits = BicepValue<SiteLimits>.DefineProperty(this, "Limits", ["properties", "limits"]);
        _linuxFxVersion = BicepValue<string>.DefineProperty(this, "LinuxFxVersion", ["properties", "linuxFxVersion"]);
        _loadBalancing = BicepValue<SiteLoadBalancing>.DefineProperty(this, "LoadBalancing", ["properties", "loadBalancing"]);
        _logsDirectorySizeLimit = BicepValue<int>.DefineProperty(this, "LogsDirectorySizeLimit", ["properties", "logsDirectorySizeLimit"]);
        _managedPipelineMode = BicepValue<ManagedPipelineMode>.DefineProperty(this, "ManagedPipelineMode", ["properties", "managedPipelineMode"]);
        _managedServiceIdentityId = BicepValue<int>.DefineProperty(this, "ManagedServiceIdentityId", ["properties", "managedServiceIdentityId"]);
        _metadata = BicepList<AppServiceNameValuePair>.DefineProperty(this, "Metadata", ["properties", "metadata"]);
        _minimumElasticInstanceCount = BicepValue<int>.DefineProperty(this, "MinimumElasticInstanceCount", ["properties", "minimumElasticInstanceCount"]);
        _minTlsCipherSuite = BicepValue<AppServiceTlsCipherSuite>.DefineProperty(this, "MinTlsCipherSuite", ["properties", "minTlsCipherSuite"]);
        _minTlsVersion = BicepValue<AppServiceSupportedTlsVersion>.DefineProperty(this, "MinTlsVersion", ["properties", "minTlsVersion"]);
        _netFrameworkVersion = BicepValue<string>.DefineProperty(this, "NetFrameworkVersion", ["properties", "netFrameworkVersion"]);
        _nodeVersion = BicepValue<string>.DefineProperty(this, "NodeVersion", ["properties", "nodeVersion"]);
        _numberOfWorkers = BicepValue<int>.DefineProperty(this, "NumberOfWorkers", ["properties", "numberOfWorkers"]);
        _phpVersion = BicepValue<string>.DefineProperty(this, "PhpVersion", ["properties", "phpVersion"]);
        _powerShellVersion = BicepValue<string>.DefineProperty(this, "PowerShellVersion", ["properties", "powerShellVersion"]);
        _preWarmedInstanceCount = BicepValue<int>.DefineProperty(this, "PreWarmedInstanceCount", ["properties", "preWarmedInstanceCount"]);
        _publicNetworkAccess = BicepValue<string>.DefineProperty(this, "PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _publishingUsername = BicepValue<string>.DefineProperty(this, "PublishingUsername", ["properties", "publishingUsername"]);
        _push = BicepValue<WebAppPushSettings>.DefineProperty(this, "Push", ["properties", "push"]);
        _pythonVersion = BicepValue<string>.DefineProperty(this, "PythonVersion", ["properties", "pythonVersion"]);
        _remoteDebuggingVersion = BicepValue<string>.DefineProperty(this, "RemoteDebuggingVersion", ["properties", "remoteDebuggingVersion"]);
        _requestTracingExpirationOn = BicepValue<DateTimeOffset>.DefineProperty(this, "RequestTracingExpirationOn", ["properties", "requestTracingExpirationTime"]);
        _scmIPSecurityRestrictions = BicepList<AppServiceIPSecurityRestriction>.DefineProperty(this, "ScmIPSecurityRestrictions", ["properties", "scmIpSecurityRestrictions"]);
        _scmIPSecurityRestrictionsDefaultAction = BicepValue<SiteDefaultAction>.DefineProperty(this, "ScmIPSecurityRestrictionsDefaultAction", ["properties", "scmIpSecurityRestrictionsDefaultAction"]);
        _scmMinTlsVersion = BicepValue<AppServiceSupportedTlsVersion>.DefineProperty(this, "ScmMinTlsVersion", ["properties", "scmMinTlsVersion"]);
        _scmType = BicepValue<ScmType>.DefineProperty(this, "ScmType", ["properties", "scmType"]);
        _tracingOptions = BicepValue<string>.DefineProperty(this, "TracingOptions", ["properties", "tracingOptions"]);
        _use32BitWorkerProcess = BicepValue<bool>.DefineProperty(this, "Use32BitWorkerProcess", ["properties", "use32BitWorkerProcess"]);
        _useManagedIdentityCreds = BicepValue<bool>.DefineProperty(this, "UseManagedIdentityCreds", ["properties", "acrUseManagedIdentityCreds"]);
        _virtualApplications = BicepList<VirtualApplication>.DefineProperty(this, "VirtualApplications", ["properties", "virtualApplications"]);
        _vnetName = BicepValue<string>.DefineProperty(this, "VnetName", ["properties", "vnetName"]);
        _vnetPrivatePortsCount = BicepValue<int>.DefineProperty(this, "VnetPrivatePortsCount", ["properties", "vnetPrivatePortsCount"]);
        _websiteTimeZone = BicepValue<string>.DefineProperty(this, "WebsiteTimeZone", ["properties", "websiteTimeZone"]);
        _windowsFxVersion = BicepValue<string>.DefineProperty(this, "WindowsFxVersion", ["properties", "windowsFxVersion"]);
        _xManagedServiceIdentityId = BicepValue<int>.DefineProperty(this, "XManagedServiceIdentityId", ["properties", "xManagedServiceIdentityId"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _machineKey = BicepValue<SiteMachineKey>.DefineProperty(this, "MachineKey", ["properties", "machineKey"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<WebSiteSlot>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported WebSiteSlotConfig resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-04-01.
        /// </summary>
        public static readonly string V2024_04_01 = "2024-04-01";

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
    /// Creates a reference to an existing WebSiteSlotConfig.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the WebSiteSlotConfig resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the WebSiteSlotConfig.</param>
    /// <returns>The existing WebSiteSlotConfig resource.</returns>
    public static WebSiteSlotConfig FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
