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
    /// A class representing a collection of <see cref="SqlServerSecurityAlertPolicyResource" /> and their operations.
    /// Each <see cref="SqlServerSecurityAlertPolicyResource" /> in the collection will belong to the same instance of <see cref="SqlServerResource" />.
    /// To get a <see cref="SqlServerSecurityAlertPolicyCollection" /> instance call the GetSqlServerSecurityAlertPolicies method from an instance of <see cref="SqlServerResource" />.
    /// </summary>
    public partial class SqlServerSecurityAlertPolicyCollection : ArmCollection, IEnumerable<SqlServerSecurityAlertPolicyResource>, IAsyncEnumerable<SqlServerSecurityAlertPolicyResource>
    {
        private readonly ClientDiagnostics _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics;
        private readonly ServerSecurityAlertPoliciesRestOperations _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerSecurityAlertPolicyCollection"/> class for mocking. </summary>
        protected SqlServerSecurityAlertPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerSecurityAlertPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerSecurityAlertPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerSecurityAlertPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerSecurityAlertPolicyResource.ResourceType, out string sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesApiVersion);
            _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient = new ServerSecurityAlertPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesApiVersion);
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
        /// Creates or updates a threat detection policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerSecurityAlertPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityAlertPolicyName"> The name of the threat detection policy. </param>
        /// <param name="data"> The server security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerSecurityAlertPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SqlSecurityAlertPolicyName securityAlertPolicyName, SqlServerSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics.CreateScope("SqlServerSecurityAlertPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerSecurityAlertPolicyResource>(new SqlServerSecurityAlertPolicyOperationSource(Client), _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics, Pipeline, _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a threat detection policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerSecurityAlertPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityAlertPolicyName"> The name of the threat detection policy. </param>
        /// <param name="data"> The server security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlServerSecurityAlertPolicyResource> CreateOrUpdate(WaitUntil waitUntil, SqlSecurityAlertPolicyName securityAlertPolicyName, SqlServerSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics.CreateScope("SqlServerSecurityAlertPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, data, cancellationToken);
                var operation = new SqlArmOperation<SqlServerSecurityAlertPolicyResource>(new SqlServerSecurityAlertPolicyOperationSource(Client), _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics, Pipeline, _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a server's security alert policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerSecurityAlertPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlServerSecurityAlertPolicyResource>> GetAsync(SqlSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics.CreateScope("SqlServerSecurityAlertPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a server's security alert policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerSecurityAlertPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlServerSecurityAlertPolicyResource> Get(SqlSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics.CreateScope("SqlServerSecurityAlertPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the server's threat detection policies.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/securityAlertPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerSecurityAlertPolicies_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerSecurityAlertPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerSecurityAlertPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SqlServerSecurityAlertPolicyResource(Client, SqlServerSecurityAlertPolicyData.DeserializeSqlServerSecurityAlertPolicyData(e)), _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics, Pipeline, "SqlServerSecurityAlertPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the server's threat detection policies.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/securityAlertPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerSecurityAlertPolicies_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerSecurityAlertPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerSecurityAlertPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SqlServerSecurityAlertPolicyResource(Client, SqlServerSecurityAlertPolicyData.DeserializeSqlServerSecurityAlertPolicyData(e)), _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics, Pipeline, "SqlServerSecurityAlertPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerSecurityAlertPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SqlSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics.CreateScope("SqlServerSecurityAlertPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerSecurityAlertPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SqlSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics.CreateScope("SqlServerSecurityAlertPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerSecurityAlertPolicyResource> IEnumerable<SqlServerSecurityAlertPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerSecurityAlertPolicyResource> IAsyncEnumerable<SqlServerSecurityAlertPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
