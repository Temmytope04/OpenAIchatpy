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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a SqlJob along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SqlJobResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSqlJobResource method.
    /// Otherwise you can get one from its parent resource <see cref="JobAgentResource" /> using the GetSqlJob method.
    /// </summary>
    public partial class SqlJobResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlJobResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlJobJobsClientDiagnostics;
        private readonly JobsRestOperations _sqlJobJobsRestClient;
        private readonly ClientDiagnostics _serverJobAgentJobExecutionJobExecutionsClientDiagnostics;
        private readonly JobExecutionsRestOperations _serverJobAgentJobExecutionJobExecutionsRestClient;
        private readonly SqlJobData _data;

        /// <summary> Initializes a new instance of the <see cref="SqlJobResource"/> class for mocking. </summary>
        protected SqlJobResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SqlJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlJobResource(ArmClient client, SqlJobData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SqlJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlJobResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlJobJobsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlJobJobsApiVersion);
            _sqlJobJobsRestClient = new JobsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlJobJobsApiVersion);
            _serverJobAgentJobExecutionJobExecutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerJobAgentJobExecutionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServerJobAgentJobExecutionResource.ResourceType, out string serverJobAgentJobExecutionJobExecutionsApiVersion);
            _serverJobAgentJobExecutionJobExecutionsRestClient = new JobExecutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serverJobAgentJobExecutionJobExecutionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/jobAgents/jobs";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SqlJobData Data
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

        /// <summary> Gets a collection of ServerJobAgentJobExecutionResources in the SqlJob. </summary>
        /// <returns> An object representing collection of ServerJobAgentJobExecutionResources and their operations over a ServerJobAgentJobExecutionResource. </returns>
        public virtual ServerJobAgentJobExecutionCollection GetServerJobAgentJobExecutions()
        {
            return GetCachedClient(Client => new ServerJobAgentJobExecutionCollection(Client, Id));
        }

        /// <summary>
        /// Gets a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}
        /// Operation Id: JobExecutions_Get
        /// </summary>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<ServerJobAgentJobExecutionResource>> GetServerJobAgentJobExecutionAsync(Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            return await GetServerJobAgentJobExecutions().GetAsync(jobExecutionId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}
        /// Operation Id: JobExecutions_Get
        /// </summary>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<ServerJobAgentJobExecutionResource> GetServerJobAgentJobExecution(Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            return GetServerJobAgentJobExecutions().Get(jobExecutionId, cancellationToken);
        }

        /// <summary> Gets a collection of ServerJobAgentJobStepResources in the SqlJob. </summary>
        /// <returns> An object representing collection of ServerJobAgentJobStepResources and their operations over a ServerJobAgentJobStepResource. </returns>
        public virtual ServerJobAgentJobStepCollection GetServerJobAgentJobSteps()
        {
            return GetCachedClient(Client => new ServerJobAgentJobStepCollection(Client, Id));
        }

        /// <summary>
        /// Gets a job step in a job&apos;s current version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/steps/{stepName}
        /// Operation Id: JobSteps_Get
        /// </summary>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ServerJobAgentJobStepResource>> GetServerJobAgentJobStepAsync(string stepName, CancellationToken cancellationToken = default)
        {
            return await GetServerJobAgentJobSteps().GetAsync(stepName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a job step in a job&apos;s current version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/steps/{stepName}
        /// Operation Id: JobSteps_Get
        /// </summary>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<ServerJobAgentJobStepResource> GetServerJobAgentJobStep(string stepName, CancellationToken cancellationToken = default)
        {
            return GetServerJobAgentJobSteps().Get(stepName, cancellationToken);
        }

        /// <summary> Gets a collection of JobVersionResources in the SqlJob. </summary>
        /// <returns> An object representing collection of JobVersionResources and their operations over a JobVersionResource. </returns>
        public virtual JobVersionCollection GetJobVersions()
        {
            return GetCachedClient(Client => new JobVersionCollection(Client, Id));
        }

        /// <summary>
        /// Gets a job version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}
        /// Operation Id: JobVersions_Get
        /// </summary>
        /// <param name="jobVersion"> The version of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<JobVersionResource>> GetJobVersionAsync(int jobVersion, CancellationToken cancellationToken = default)
        {
            return await GetJobVersions().GetAsync(jobVersion, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a job version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}
        /// Operation Id: JobVersions_Get
        /// </summary>
        /// <param name="jobVersion"> The version of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<JobVersionResource> GetJobVersion(int jobVersion, CancellationToken cancellationToken = default)
        {
            return GetJobVersions().Get(jobVersion, cancellationToken);
        }

        /// <summary>
        /// Gets a job.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}
        /// Operation Id: Jobs_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlJobResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlJobJobsClientDiagnostics.CreateScope("SqlJobResource.Get");
            scope.Start();
            try
            {
                var response = await _sqlJobJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a job.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}
        /// Operation Id: Jobs_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlJobResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlJobJobsClientDiagnostics.CreateScope("SqlJobResource.Get");
            scope.Start();
            try
            {
                var response = _sqlJobJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a job.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}
        /// Operation Id: Jobs_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlJobJobsClientDiagnostics.CreateScope("SqlJobResource.Delete");
            scope.Start();
            try
            {
                var response = await _sqlJobJobsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a job.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}
        /// Operation Id: Jobs_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlJobJobsClientDiagnostics.CreateScope("SqlJobResource.Delete");
            scope.Start();
            try
            {
                var response = _sqlJobJobsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Starts an elastic job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/start
        /// Operation Id: JobExecutions_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<ServerJobAgentJobExecutionResource>> CreateJobExecutionAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _serverJobAgentJobExecutionJobExecutionsClientDiagnostics.CreateScope("SqlJobResource.CreateJobExecution");
            scope.Start();
            try
            {
                var response = await _serverJobAgentJobExecutionJobExecutionsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ServerJobAgentJobExecutionResource>(new ServerJobAgentJobExecutionOperationSource(Client), _serverJobAgentJobExecutionJobExecutionsClientDiagnostics, Pipeline, _serverJobAgentJobExecutionJobExecutionsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Starts an elastic job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/start
        /// Operation Id: JobExecutions_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<ServerJobAgentJobExecutionResource> CreateJobExecution(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _serverJobAgentJobExecutionJobExecutionsClientDiagnostics.CreateScope("SqlJobResource.CreateJobExecution");
            scope.Start();
            try
            {
                var response = _serverJobAgentJobExecutionJobExecutionsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation<ServerJobAgentJobExecutionResource>(new ServerJobAgentJobExecutionOperationSource(Client), _serverJobAgentJobExecutionJobExecutionsClientDiagnostics, Pipeline, _serverJobAgentJobExecutionJobExecutionsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
    }
}
