// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> Execute a data flow debug command. </summary>
    public partial class DataFlowDebugSessionExecuteCommandOperation : Operation<DataFlowDebugCommandResponse>, IOperationSource<DataFlowDebugCommandResponse>
    {
        private readonly ArmOperationHelpers<DataFlowDebugCommandResponse> _operation;
        internal DataFlowDebugSessionExecuteCommandOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<DataFlowDebugCommandResponse>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DataFlowDebugSessionExecuteCommandOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DataFlowDebugCommandResponse Value => _operation.Value;

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
        public override ValueTask<Response<DataFlowDebugCommandResponse>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DataFlowDebugCommandResponse>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DataFlowDebugCommandResponse IOperationSource<DataFlowDebugCommandResponse>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            if (document.RootElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            else
            {
                return DataFlowDebugCommandResponse.DeserializeDataFlowDebugCommandResponse(document.RootElement);
            }
        }

        async ValueTask<DataFlowDebugCommandResponse> IOperationSource<DataFlowDebugCommandResponse>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            if (document.RootElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            else
            {
                return DataFlowDebugCommandResponse.DeserializeDataFlowDebugCommandResponse(document.RootElement);
            }
        }
    }
}
