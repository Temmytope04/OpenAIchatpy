// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SignalR.Models;

namespace Azure.ResourceManager.SignalR
{
    /// <summary>
    /// A class representing the SignalR data model.
    /// A class represent a resource.
    /// </summary>
    public partial class SignalRData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of SignalRData. </summary>
        /// <param name="location"> The location. </param>
        public SignalRData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<SignalRPrivateEndpointConnectionData>();
            SharedPrivateLinkResources = new ChangeTrackingList<SignalRSharedPrivateLinkResourceData>();
            Features = new ChangeTrackingList<SignalRFeature>();
        }

        /// <summary> Initializes a new instance of SignalRData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The billing information of the resource. </param>
        /// <param name="kind"> The kind of the service, it can be SignalR or RawWebSockets. </param>
        /// <param name="identity"> A class represent managed identities used for request and response. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="externalIP"> The publicly accessible IP of the resource. </param>
        /// <param name="hostName"> FQDN of the service instance. </param>
        /// <param name="publicPort"> The publicly accessible port of the resource which is designed for browser/client side usage. </param>
        /// <param name="serverPort"> The publicly accessible port of the resource which is designed for customer server side usage. </param>
        /// <param name="version"> Version of the resource. Probably you need the same or higher version of client SDKs. </param>
        /// <param name="privateEndpointConnections"> Private endpoint connections to the resource. </param>
        /// <param name="sharedPrivateLinkResources"> The list of shared private link resources. </param>
        /// <param name="tls"> TLS settings for the resource. </param>
        /// <param name="hostNamePrefix"> Deprecated. </param>
        /// <param name="features">
        /// List of the featureFlags.
        ///
        /// FeatureFlags that are not included in the parameters for the update operation will not be modified.
        /// And the response will only include featureFlags that are explicitly set.
        /// When a featureFlag is not explicitly set, its globally default value will be used
        /// But keep in mind, the default value doesn't mean "false". It varies in terms of different FeatureFlags.
        /// </param>
        /// <param name="liveTraceConfiguration"> Live trace configuration of a Microsoft.SignalRService resource. </param>
        /// <param name="resourceLogConfiguration"> Resource log configuration of a Microsoft.SignalRService resource. </param>
        /// <param name="cors"> Cross-Origin Resource Sharing (CORS) settings. </param>
        /// <param name="upstream"> The settings for the Upstream when the service is in server-less mode. </param>
        /// <param name="networkACLs"> Network ACLs for the resource. </param>
        /// <param name="publicNetworkAccess">
        /// Enable or disable public network access. Default to "Enabled".
        /// When it's Enabled, network ACLs still apply.
        /// When it's Disabled, public network access is always disabled no matter what you set in network ACLs.
        /// </param>
        /// <param name="disableLocalAuth">
        /// DisableLocalAuth
        /// Enable or disable local auth with AccessKey
        /// When set as true, connection with AccessKey=xxx won't work.
        /// </param>
        /// <param name="disableAadAuth">
        /// DisableLocalAuth
        /// Enable or disable aad auth
        /// When set as true, connection with AuthType=aad won't work.
        /// </param>
        internal SignalRData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, SignalRResourceSku sku, SignalRServiceKind? kind, ManagedServiceIdentity identity, SignalRProvisioningState? provisioningState, string externalIP, string hostName, int? publicPort, int? serverPort, string version, IReadOnlyList<SignalRPrivateEndpointConnectionData> privateEndpointConnections, IReadOnlyList<SignalRSharedPrivateLinkResourceData> sharedPrivateLinkResources, SignalRTlsSettings tls, string hostNamePrefix, IList<SignalRFeature> features, SignalRLiveTraceConfiguration liveTraceConfiguration, SignalRResourceLogCategoryListResult resourceLogConfiguration, SignalRCorsSettings cors, ServerlessUpstreamSettings upstream, SignalRNetworkAcls networkACLs, string publicNetworkAccess, bool? disableLocalAuth, bool? disableAadAuth) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Kind = kind;
            Identity = identity;
            ProvisioningState = provisioningState;
            ExternalIP = externalIP;
            HostName = hostName;
            PublicPort = publicPort;
            ServerPort = serverPort;
            Version = version;
            PrivateEndpointConnections = privateEndpointConnections;
            SharedPrivateLinkResources = sharedPrivateLinkResources;
            Tls = tls;
            HostNamePrefix = hostNamePrefix;
            Features = features;
            LiveTraceConfiguration = liveTraceConfiguration;
            ResourceLogConfiguration = resourceLogConfiguration;
            Cors = cors;
            Upstream = upstream;
            NetworkACLs = networkACLs;
            PublicNetworkAccess = publicNetworkAccess;
            DisableLocalAuth = disableLocalAuth;
            DisableAadAuth = disableAadAuth;
        }

        /// <summary> The billing information of the resource. </summary>
        public SignalRResourceSku Sku { get; set; }
        /// <summary> The kind of the service, it can be SignalR or RawWebSockets. </summary>
        public SignalRServiceKind? Kind { get; set; }
        /// <summary> A class represent managed identities used for request and response. Current supported identity types: None, SystemAssigned, UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Provisioning state of the resource. </summary>
        public SignalRProvisioningState? ProvisioningState { get; }
        /// <summary> The publicly accessible IP of the resource. </summary>
        public string ExternalIP { get; }
        /// <summary> FQDN of the service instance. </summary>
        public string HostName { get; }
        /// <summary> The publicly accessible port of the resource which is designed for browser/client side usage. </summary>
        public int? PublicPort { get; }
        /// <summary> The publicly accessible port of the resource which is designed for customer server side usage. </summary>
        public int? ServerPort { get; }
        /// <summary> Version of the resource. Probably you need the same or higher version of client SDKs. </summary>
        public string Version { get; }
        /// <summary> Private endpoint connections to the resource. </summary>
        public IReadOnlyList<SignalRPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> The list of shared private link resources. </summary>
        public IReadOnlyList<SignalRSharedPrivateLinkResourceData> SharedPrivateLinkResources { get; }
        /// <summary> TLS settings for the resource. </summary>
        internal SignalRTlsSettings Tls { get; set; }
        /// <summary> Request client certificate during TLS handshake if enabled. </summary>
        public bool? IsClientCertEnabled
        {
            get => Tls is null ? default : Tls.IsClientCertEnabled;
            set
            {
                if (Tls is null)
                    Tls = new SignalRTlsSettings();
                Tls.IsClientCertEnabled = value;
            }
        }

        /// <summary> Deprecated. </summary>
        public string HostNamePrefix { get; }
        /// <summary>
        /// List of the featureFlags.
        ///
        /// FeatureFlags that are not included in the parameters for the update operation will not be modified.
        /// And the response will only include featureFlags that are explicitly set.
        /// When a featureFlag is not explicitly set, its globally default value will be used
        /// But keep in mind, the default value doesn't mean "false". It varies in terms of different FeatureFlags.
        /// </summary>
        public IList<SignalRFeature> Features { get; }
        /// <summary> Live trace configuration of a Microsoft.SignalRService resource. </summary>
        public SignalRLiveTraceConfiguration LiveTraceConfiguration { get; set; }
        /// <summary> Resource log configuration of a Microsoft.SignalRService resource. </summary>
        internal SignalRResourceLogCategoryListResult ResourceLogConfiguration { get; set; }
        /// <summary> Gets or sets the list of category configurations. </summary>
        public IList<SignalRResourceLogCategory> ResourceLogCategories
        {
            get
            {
                if (ResourceLogConfiguration is null)
                    ResourceLogConfiguration = new SignalRResourceLogCategoryListResult();
                return ResourceLogConfiguration.Categories;
            }
        }

        /// <summary> Cross-Origin Resource Sharing (CORS) settings. </summary>
        internal SignalRCorsSettings Cors { get; set; }
        /// <summary> Gets or sets the list of origins that should be allowed to make cross-origin calls (for example: http://example.com:12345). Use "*" to allow all. If omitted, allow all by default. </summary>
        public IList<string> CorsAllowedOrigins
        {
            get
            {
                if (Cors is null)
                    Cors = new SignalRCorsSettings();
                return Cors.AllowedOrigins;
            }
        }

        /// <summary> The settings for the Upstream when the service is in server-less mode. </summary>
        internal ServerlessUpstreamSettings Upstream { get; set; }
        /// <summary> Gets or sets the list of Upstream URL templates. Order matters, and the first matching template takes effects. </summary>
        public IList<SignalRUpstreamTemplate> UpstreamTemplates
        {
            get
            {
                if (Upstream is null)
                    Upstream = new ServerlessUpstreamSettings();
                return Upstream.Templates;
            }
        }

        /// <summary> Network ACLs for the resource. </summary>
        public SignalRNetworkAcls NetworkACLs { get; set; }
        /// <summary>
        /// Enable or disable public network access. Default to "Enabled".
        /// When it's Enabled, network ACLs still apply.
        /// When it's Disabled, public network access is always disabled no matter what you set in network ACLs.
        /// </summary>
        public string PublicNetworkAccess { get; set; }
        /// <summary>
        /// DisableLocalAuth
        /// Enable or disable local auth with AccessKey
        /// When set as true, connection with AccessKey=xxx won't work.
        /// </summary>
        public bool? DisableLocalAuth { get; set; }
        /// <summary>
        /// DisableLocalAuth
        /// Enable or disable aad auth
        /// When set as true, connection with AuthType=aad won't work.
        /// </summary>
        public bool? DisableAadAuth { get; set; }
    }
}
