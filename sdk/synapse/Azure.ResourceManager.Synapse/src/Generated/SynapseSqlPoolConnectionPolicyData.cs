// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseSqlPoolConnectionPolicy data model.
    /// A Sql pool connection policy.
    /// </summary>
    public partial class SynapseSqlPoolConnectionPolicyData : ResourceData
    {
        /// <summary> Initializes a new instance of SynapseSqlPoolConnectionPolicyData. </summary>
        public SynapseSqlPoolConnectionPolicyData()
        {
        }

        /// <summary> Initializes a new instance of SynapseSqlPoolConnectionPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Resource kind. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="securityEnabledAccess"> The state of security access. </param>
        /// <param name="proxyDnsName"> The fully qualified host name of the auditing proxy. </param>
        /// <param name="proxyPort"> The port number of the auditing proxy. </param>
        /// <param name="visibility"> The visibility of the auditing proxy. </param>
        /// <param name="useServerDefault"> Whether server default is enabled or disabled. </param>
        /// <param name="redirectionState"> The state of proxy redirection. </param>
        /// <param name="state"> The connection policy state. </param>
        internal SynapseSqlPoolConnectionPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, AzureLocation? location, string securityEnabledAccess, string proxyDnsName, string proxyPort, string visibility, string useServerDefault, string redirectionState, string state) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            Location = location;
            SecurityEnabledAccess = securityEnabledAccess;
            ProxyDnsName = proxyDnsName;
            ProxyPort = proxyPort;
            Visibility = visibility;
            UseServerDefault = useServerDefault;
            RedirectionState = redirectionState;
            State = state;
        }

        /// <summary> Resource kind. </summary>
        public string Kind { get; }
        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The state of security access. </summary>
        public string SecurityEnabledAccess { get; set; }
        /// <summary> The fully qualified host name of the auditing proxy. </summary>
        public string ProxyDnsName { get; set; }
        /// <summary> The port number of the auditing proxy. </summary>
        public string ProxyPort { get; set; }
        /// <summary> The visibility of the auditing proxy. </summary>
        public string Visibility { get; set; }
        /// <summary> Whether server default is enabled or disabled. </summary>
        public string UseServerDefault { get; set; }
        /// <summary> The state of proxy redirection. </summary>
        public string RedirectionState { get; set; }
        /// <summary> The connection policy state. </summary>
        public string State { get; set; }
    }
}
