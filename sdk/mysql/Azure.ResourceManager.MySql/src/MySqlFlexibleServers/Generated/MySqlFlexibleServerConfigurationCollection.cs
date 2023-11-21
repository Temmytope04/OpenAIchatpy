// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    /// <summary>
    /// A class representing a collection of <see cref="MySqlFlexibleServerConfigurationResource"/> and their operations.
    /// Each <see cref="MySqlFlexibleServerConfigurationResource"/> in the collection will belong to the same instance of <see cref="MySqlFlexibleServerResource"/>.
    /// To get a <see cref="MySqlFlexibleServerConfigurationCollection"/> instance call the GetMySqlFlexibleServerConfigurations method from an instance of <see cref="MySqlFlexibleServerResource"/>.
    /// </summary>
    public partial class MySqlFlexibleServerConfigurationCollection : ArmCollection, IEnumerable<MySqlFlexibleServerConfigurationResource>, IAsyncEnumerable<MySqlFlexibleServerConfigurationResource>
    {
        private readonly ClientDiagnostics _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics;
        private readonly ConfigurationsRestOperations _mySqlFlexibleServerConfigurationConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MySqlFlexibleServerConfigurationCollection"/> class for mocking. </summary>
        protected MySqlFlexibleServerConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlFlexibleServerConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MySqlFlexibleServerConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", MySqlFlexibleServerConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MySqlFlexibleServerConfigurationResource.ResourceType, out string mySqlFlexibleServerConfigurationConfigurationsApiVersion);
            _mySqlFlexibleServerConfigurationConfigurationsRestClient = new ConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mySqlFlexibleServerConfigurationConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MySqlFlexibleServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MySqlFlexibleServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates a configuration of a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="data"> The required parameters for updating a server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MySqlFlexibleServerConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string configurationName, MySqlFlexibleServerConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerConfigurationConfigurationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new FlexibleServersArmOperation<MySqlFlexibleServerConfigurationResource>(new MySqlFlexibleServerConfigurationOperationSource(Client), _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics, Pipeline, _mySqlFlexibleServerConfigurationConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates a configuration of a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="data"> The required parameters for updating a server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MySqlFlexibleServerConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, string configurationName, MySqlFlexibleServerConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerConfigurationConfigurationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data, cancellationToken);
                var operation = new FlexibleServersArmOperation<MySqlFlexibleServerConfigurationResource>(new MySqlFlexibleServerConfigurationOperationSource(Client), _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics, Pipeline, _mySqlFlexibleServerConfigurationConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a configuration of server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<Response<MySqlFlexibleServerConfigurationResource>> GetAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerConfigurationConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServerConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a configuration of server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual Response<MySqlFlexibleServerConfigurationResource> Get(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerConfigurationConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServerConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the configurations in a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The tags of the server configuration. </param>
        /// <param name="keyword"> The keyword of the server configuration. </param>
        /// <param name="page"> The page of the server configuration. </param>
        /// <param name="pageSize"> The pageSize of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlFlexibleServerConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlFlexibleServerConfigurationResource> GetAllAsync(string tags = null, string keyword = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mySqlFlexibleServerConfigurationConfigurationsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tags, keyword, page, pageSizeHint);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mySqlFlexibleServerConfigurationConfigurationsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tags, keyword, page, pageSizeHint);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new MySqlFlexibleServerConfigurationResource(Client, MySqlFlexibleServerConfigurationData.DeserializeMySqlFlexibleServerConfigurationData(e)), _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics, Pipeline, "MySqlFlexibleServerConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the configurations in a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The tags of the server configuration. </param>
        /// <param name="keyword"> The keyword of the server configuration. </param>
        /// <param name="page"> The page of the server configuration. </param>
        /// <param name="pageSize"> The pageSize of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlFlexibleServerConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlFlexibleServerConfigurationResource> GetAll(string tags = null, string keyword = null, int? page = null, int? pageSize = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mySqlFlexibleServerConfigurationConfigurationsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tags, keyword, page, pageSizeHint);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mySqlFlexibleServerConfigurationConfigurationsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tags, keyword, page, pageSizeHint);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new MySqlFlexibleServerConfigurationResource(Client, MySqlFlexibleServerConfigurationData.DeserializeMySqlFlexibleServerConfigurationData(e)), _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics, Pipeline, "MySqlFlexibleServerConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerConfigurationConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerConfigurationConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<NullableResponse<MySqlFlexibleServerConfigurationResource>> GetIfExistsAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerConfigurationConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MySqlFlexibleServerConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServerConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual NullableResponse<MySqlFlexibleServerConfigurationResource> GetIfExists(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _mySqlFlexibleServerConfigurationConfigurationsClientDiagnostics.CreateScope("MySqlFlexibleServerConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerConfigurationConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MySqlFlexibleServerConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServerConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MySqlFlexibleServerConfigurationResource> IEnumerable<MySqlFlexibleServerConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MySqlFlexibleServerConfigurationResource> IAsyncEnumerable<MySqlFlexibleServerConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
