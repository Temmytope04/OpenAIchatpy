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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerAzureADAdministratorResource" /> and their operations.
    /// Each <see cref="SqlServerAzureADAdministratorResource" /> in the collection will belong to the same instance of <see cref="SqlServerResource" />.
    /// To get a <see cref="SqlServerAzureADAdministratorCollection" /> instance call the GetSqlServerAzureADAdministrators method from an instance of <see cref="SqlServerResource" />.
    /// </summary>
    public partial class SqlServerAzureADAdministratorCollection : ArmCollection, IEnumerable<SqlServerAzureADAdministratorResource>, IAsyncEnumerable<SqlServerAzureADAdministratorResource>
    {
        private readonly ClientDiagnostics _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics;
        private readonly ServerAzureADAdministratorsRestOperations _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerAzureADAdministratorCollection"/> class for mocking. </summary>
        protected SqlServerAzureADAdministratorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerAzureADAdministratorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerAzureADAdministratorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerAzureADAdministratorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerAzureADAdministratorResource.ResourceType, out string sqlServerAzureADAdministratorServerAzureADAdministratorsApiVersion);
            _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient = new ServerAzureADAdministratorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerAzureADAdministratorServerAzureADAdministratorsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an existing Azure Active Directory administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADAdministrators_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="administratorName"> The name of server active directory administrator. </param>
        /// <param name="data"> The requested Azure Active Directory administrator Resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerAzureADAdministratorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SqlAdministratorName administratorName, SqlServerAzureADAdministratorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics.CreateScope("SqlServerAzureADAdministratorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerAzureADAdministratorResource>(new SqlServerAzureADAdministratorOperationSource(Client), _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics, Pipeline, _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an existing Azure Active Directory administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADAdministrators_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="administratorName"> The name of server active directory administrator. </param>
        /// <param name="data"> The requested Azure Active Directory administrator Resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlServerAzureADAdministratorResource> CreateOrUpdate(WaitUntil waitUntil, SqlAdministratorName administratorName, SqlServerAzureADAdministratorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics.CreateScope("SqlServerAzureADAdministratorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, data, cancellationToken);
                var operation = new SqlArmOperation<SqlServerAzureADAdministratorResource>(new SqlServerAzureADAdministratorOperationSource(Client), _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics, Pipeline, _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a Azure Active Directory administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADAdministrators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="administratorName"> The name of server active directory administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlServerAzureADAdministratorResource>> GetAsync(SqlAdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics.CreateScope("SqlServerAzureADAdministratorCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerAzureADAdministratorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Azure Active Directory administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADAdministrators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="administratorName"> The name of server active directory administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlServerAzureADAdministratorResource> Get(SqlAdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics.CreateScope("SqlServerAzureADAdministratorCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerAzureADAdministratorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of Azure Active Directory administrators in a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADAdministrators_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerAzureADAdministratorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerAzureADAdministratorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SqlServerAzureADAdministratorResource(Client, SqlServerAzureADAdministratorData.DeserializeSqlServerAzureADAdministratorData(e)), _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics, Pipeline, "SqlServerAzureADAdministratorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of Azure Active Directory administrators in a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADAdministrators_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerAzureADAdministratorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerAzureADAdministratorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SqlServerAzureADAdministratorResource(Client, SqlServerAzureADAdministratorData.DeserializeSqlServerAzureADAdministratorData(e)), _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics, Pipeline, "SqlServerAzureADAdministratorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADAdministrators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="administratorName"> The name of server active directory administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SqlAdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics.CreateScope("SqlServerAzureADAdministratorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAzureADAdministrators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="administratorName"> The name of server active directory administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SqlAdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAzureADAdministratorServerAzureADAdministratorsClientDiagnostics.CreateScope("SqlServerAzureADAdministratorCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerAzureADAdministratorServerAzureADAdministratorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerAzureADAdministratorResource> IEnumerable<SqlServerAzureADAdministratorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerAzureADAdministratorResource> IAsyncEnumerable<SqlServerAzureADAdministratorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
