// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    /// <summary>
    /// A Class representing a CosmosDBForPostgreSqlConfiguration along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="CosmosDBForPostgreSqlConfigurationResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetCosmosDBForPostgreSqlConfigurationResource method.
    /// Otherwise you can get one from its parent resource <see cref="CosmosDBForPostgreSqlClusterResource"/> using the GetCosmosDBForPostgreSqlConfiguration method.
    /// </summary>
    public partial class CosmosDBForPostgreSqlConfigurationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CosmosDBForPostgreSqlConfigurationResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="clusterName"> The clusterName. </param>
        /// <param name="configurationName"> The configurationName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string clusterName, string configurationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/configurations/{configurationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _cosmosDBForPostgreSqlConfigurationConfigurationsClientDiagnostics;
        private readonly ConfigurationsRestOperations _cosmosDBForPostgreSqlConfigurationConfigurationsRestClient;
        private readonly CosmosDBForPostgreSqlConfigurationData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DBforPostgreSQL/serverGroupsv2/configurations";

        /// <summary> Initializes a new instance of the <see cref="CosmosDBForPostgreSqlConfigurationResource"/> class for mocking. </summary>
        protected CosmosDBForPostgreSqlConfigurationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBForPostgreSqlConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CosmosDBForPostgreSqlConfigurationResource(ArmClient client, CosmosDBForPostgreSqlConfigurationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBForPostgreSqlConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CosmosDBForPostgreSqlConfigurationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBForPostgreSqlConfigurationConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDBForPostgreSql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string cosmosDBForPostgreSqlConfigurationConfigurationsApiVersion);
            _cosmosDBForPostgreSqlConfigurationConfigurationsRestClient = new ConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBForPostgreSqlConfigurationConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CosmosDBForPostgreSqlConfigurationData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets information of a configuration for coordinator and nodes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CosmosDBForPostgreSqlConfigurationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBForPostgreSqlConfigurationConfigurationsClientDiagnostics.CreateScope("CosmosDBForPostgreSqlConfigurationResource.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlConfigurationConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information of a configuration for coordinator and nodes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CosmosDBForPostgreSqlConfigurationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBForPostgreSqlConfigurationConfigurationsClientDiagnostics.CreateScope("CosmosDBForPostgreSqlConfigurationResource.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlConfigurationConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
