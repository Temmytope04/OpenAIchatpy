// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the StaticSite data model.
    /// Static Site ARM resource.
    /// </summary>
    public partial class StaticSiteData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StaticSiteData"/>. </summary>
        /// <param name="location"> The location. </param>
        public StaticSiteData(AzureLocation location) : base(location)
        {
            CustomDomains = new ChangeTrackingList<string>();
            PrivateEndpointConnections = new ChangeTrackingList<ResponseMessageEnvelopeRemotePrivateEndpointConnection>();
            UserProvidedFunctionApps = new ChangeTrackingList<StaticSiteUserProvidedFunctionAppData>();
        }

        /// <summary> Initializes a new instance of <see cref="StaticSiteData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Description of a SKU for a scalable resource. </param>
        /// <param name="identity"> Managed service identity. </param>
        /// <param name="defaultHostname"> The default autogenerated hostname for the static site. </param>
        /// <param name="repositoryUri"> URL for the repository of the static site. </param>
        /// <param name="branch"> The target branch in the repository. </param>
        /// <param name="customDomains"> The custom domains associated with this static site. </param>
        /// <param name="repositoryToken"> A user's github repository token. This is used to setup the Github Actions workflow file and API secrets. </param>
        /// <param name="buildProperties"> Build properties to configure on the repository. </param>
        /// <param name="privateEndpointConnections"> Private endpoint connections. </param>
        /// <param name="stagingEnvironmentPolicy"> State indicating whether staging environments are allowed or not allowed for a static web app. </param>
        /// <param name="allowConfigFileUpdates"> &lt;code&gt;false&lt;/code&gt; if config file is locked for this static web app; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="templateProperties"> Template options for generating a new repository. </param>
        /// <param name="contentDistributionEndpoint"> The content distribution endpoint for the static site. </param>
        /// <param name="keyVaultReferenceIdentity"> Identity to use for Key Vault Reference authentication. </param>
        /// <param name="userProvidedFunctionApps"> User provided function apps registered with the static site. </param>
        /// <param name="provider"> The provider that submitted the last deployment to the primary environment of the static site. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StaticSiteData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, AppServiceSkuDescription sku, ManagedServiceIdentity identity, string defaultHostname, Uri repositoryUri, string branch, IReadOnlyList<string> customDomains, string repositoryToken, StaticSiteBuildProperties buildProperties, IReadOnlyList<ResponseMessageEnvelopeRemotePrivateEndpointConnection> privateEndpointConnections, StagingEnvironmentPolicy? stagingEnvironmentPolicy, bool? allowConfigFileUpdates, StaticSiteTemplate templateProperties, string contentDistributionEndpoint, string keyVaultReferenceIdentity, IReadOnlyList<StaticSiteUserProvidedFunctionAppData> userProvidedFunctionApps, string provider, string kind, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Identity = identity;
            DefaultHostname = defaultHostname;
            RepositoryUri = repositoryUri;
            Branch = branch;
            CustomDomains = customDomains;
            RepositoryToken = repositoryToken;
            BuildProperties = buildProperties;
            PrivateEndpointConnections = privateEndpointConnections;
            StagingEnvironmentPolicy = stagingEnvironmentPolicy;
            AllowConfigFileUpdates = allowConfigFileUpdates;
            TemplateProperties = templateProperties;
            ContentDistributionEndpoint = contentDistributionEndpoint;
            KeyVaultReferenceIdentity = keyVaultReferenceIdentity;
            UserProvidedFunctionApps = userProvidedFunctionApps;
            Provider = provider;
            Kind = kind;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="StaticSiteData"/> for deserialization. </summary>
        internal StaticSiteData()
        {
        }

        /// <summary> Description of a SKU for a scalable resource. </summary>
        public AppServiceSkuDescription Sku { get; set; }
        /// <summary> Managed service identity. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The default autogenerated hostname for the static site. </summary>
        public string DefaultHostname { get; }
        /// <summary> URL for the repository of the static site. </summary>
        public Uri RepositoryUri { get; set; }
        /// <summary> The target branch in the repository. </summary>
        public string Branch { get; set; }
        /// <summary> The custom domains associated with this static site. </summary>
        public IReadOnlyList<string> CustomDomains { get; }
        /// <summary> A user's github repository token. This is used to setup the Github Actions workflow file and API secrets. </summary>
        public string RepositoryToken { get; set; }
        /// <summary> Build properties to configure on the repository. </summary>
        public StaticSiteBuildProperties BuildProperties { get; set; }
        /// <summary> Private endpoint connections. </summary>
        public IReadOnlyList<ResponseMessageEnvelopeRemotePrivateEndpointConnection> PrivateEndpointConnections { get; }
        /// <summary> State indicating whether staging environments are allowed or not allowed for a static web app. </summary>
        public StagingEnvironmentPolicy? StagingEnvironmentPolicy { get; set; }
        /// <summary> &lt;code&gt;false&lt;/code&gt; if config file is locked for this static web app; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? AllowConfigFileUpdates { get; set; }
        /// <summary> Template options for generating a new repository. </summary>
        public StaticSiteTemplate TemplateProperties { get; set; }
        /// <summary> The content distribution endpoint for the static site. </summary>
        public string ContentDistributionEndpoint { get; }
        /// <summary> Identity to use for Key Vault Reference authentication. </summary>
        public string KeyVaultReferenceIdentity { get; }
        /// <summary> User provided function apps registered with the static site. </summary>
        public IReadOnlyList<StaticSiteUserProvidedFunctionAppData> UserProvidedFunctionApps { get; }
        /// <summary> The provider that submitted the last deployment to the primary environment of the static site. </summary>
        public string Provider { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
