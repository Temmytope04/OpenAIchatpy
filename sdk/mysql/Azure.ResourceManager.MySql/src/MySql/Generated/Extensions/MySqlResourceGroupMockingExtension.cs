// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class MySqlResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MySqlResourceGroupMockingExtension"/> class for mocking. </summary>
        protected MySqlResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MySqlResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of MySqlServerResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of MySqlServerResources and their operations over a MySqlServerResource. </returns>
        public virtual MySqlServerCollection GetMySqlServers()
        {
            return GetCachedClient(Client => new MySqlServerCollection(Client, Id));
        }

        /// <summary>
        /// Gets information about a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<MySqlServerResource>> GetMySqlServerAsync(string serverName, CancellationToken cancellationToken = default)
        {
            return await GetMySqlServers().GetAsync(serverName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<MySqlServerResource> GetMySqlServer(string serverName, CancellationToken cancellationToken = default)
        {
            return GetMySqlServers().Get(serverName, cancellationToken);
        }
    }
}
