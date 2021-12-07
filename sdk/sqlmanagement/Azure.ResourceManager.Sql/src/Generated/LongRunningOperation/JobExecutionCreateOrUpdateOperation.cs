// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Creates or updates a job execution. </summary>
    public partial class JobExecutionCreateOrUpdateOperation : Operation<ServerJobAgentJobExecution>, IOperationSource<ServerJobAgentJobExecution>
    {
        private readonly OperationInternals<ServerJobAgentJobExecution> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of JobExecutionCreateOrUpdateOperation for mocking. </summary>
        protected JobExecutionCreateOrUpdateOperation()
        {
        }

        internal JobExecutionCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ServerJobAgentJobExecution>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "JobExecutionCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ServerJobAgentJobExecution Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ServerJobAgentJobExecution>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ServerJobAgentJobExecution>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ServerJobAgentJobExecution IOperationSource<ServerJobAgentJobExecution>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new ServerJobAgentJobExecution(_operationBase, JobExecutionData.DeserializeJobExecutionData(document.RootElement));
        }

        async ValueTask<ServerJobAgentJobExecution> IOperationSource<ServerJobAgentJobExecution>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new ServerJobAgentJobExecution(_operationBase, JobExecutionData.DeserializeJobExecutionData(document.RootElement));
        }
    }
}
