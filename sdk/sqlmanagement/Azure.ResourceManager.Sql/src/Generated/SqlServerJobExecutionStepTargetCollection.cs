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
    /// A class representing a collection of <see cref="SqlServerJobExecutionStepTargetResource" /> and their operations.
    /// Each <see cref="SqlServerJobExecutionStepTargetResource" /> in the collection will belong to the same instance of <see cref="SqlServerJobExecutionStepResource" />.
    /// To get a <see cref="SqlServerJobExecutionStepTargetCollection" /> instance call the GetSqlServerJobExecutionStepTargets method from an instance of <see cref="SqlServerJobExecutionStepResource" />.
    /// </summary>
    public partial class SqlServerJobExecutionStepTargetCollection : ArmCollection, IEnumerable<SqlServerJobExecutionStepTargetResource>, IAsyncEnumerable<SqlServerJobExecutionStepTargetResource>
    {
        private readonly ClientDiagnostics _sqlServerJobExecutionStepTargetJobTargetExecutionsClientDiagnostics;
        private readonly JobTargetExecutionsRestOperations _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobExecutionStepTargetCollection"/> class for mocking. </summary>
        protected SqlServerJobExecutionStepTargetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobExecutionStepTargetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerJobExecutionStepTargetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerJobExecutionStepTargetJobTargetExecutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerJobExecutionStepTargetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerJobExecutionStepTargetResource.ResourceType, out string sqlServerJobExecutionStepTargetJobTargetExecutionsApiVersion);
            _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient = new JobTargetExecutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerJobExecutionStepTargetJobTargetExecutionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerJobExecutionStepResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerJobExecutionStepResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a target execution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobTargetExecutions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlServerJobExecutionStepTargetResource>> GetAsync(Guid targetId, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionStepTargetCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, targetId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobExecutionStepTargetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a target execution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobTargetExecutions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlServerJobExecutionStepTargetResource> Get(Guid targetId, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionStepTargetCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, targetId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobExecutionStepTargetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the target executions of a job step execution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobTargetExecutions_ListByStep</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerJobExecutionStepTargetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerJobExecutionStepTargetResource> GetAllAsync(SqlServerJobExecutionStepTargetCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new SqlServerJobExecutionStepTargetCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient.CreateListByStepRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, options.CreateTimeMin, options.CreateTimeMax, options.EndTimeMin, options.EndTimeMax, options.IsActive, options.Skip, options.Top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient.CreateListByStepNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, options.CreateTimeMin, options.CreateTimeMax, options.EndTimeMin, options.EndTimeMax, options.IsActive, options.Skip, options.Top);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SqlServerJobExecutionStepTargetResource(Client, SqlServerJobExecutionData.DeserializeSqlServerJobExecutionData(e)), _sqlServerJobExecutionStepTargetJobTargetExecutionsClientDiagnostics, Pipeline, "SqlServerJobExecutionStepTargetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the target executions of a job step execution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobTargetExecutions_ListByStep</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerJobExecutionStepTargetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerJobExecutionStepTargetResource> GetAll(SqlServerJobExecutionStepTargetCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new SqlServerJobExecutionStepTargetCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient.CreateListByStepRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, options.CreateTimeMin, options.CreateTimeMax, options.EndTimeMin, options.EndTimeMax, options.IsActive, options.Skip, options.Top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient.CreateListByStepNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, options.CreateTimeMin, options.CreateTimeMax, options.EndTimeMin, options.EndTimeMax, options.IsActive, options.Skip, options.Top);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SqlServerJobExecutionStepTargetResource(Client, SqlServerJobExecutionData.DeserializeSqlServerJobExecutionData(e)), _sqlServerJobExecutionStepTargetJobTargetExecutionsClientDiagnostics, Pipeline, "SqlServerJobExecutionStepTargetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobTargetExecutions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(Guid targetId, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionStepTargetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, targetId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobTargetExecutions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(Guid targetId, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionStepTargetCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, targetId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerJobExecutionStepTargetResource> IEnumerable<SqlServerJobExecutionStepTargetResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<SqlServerJobExecutionStepTargetResource> IAsyncEnumerable<SqlServerJobExecutionStepTargetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
