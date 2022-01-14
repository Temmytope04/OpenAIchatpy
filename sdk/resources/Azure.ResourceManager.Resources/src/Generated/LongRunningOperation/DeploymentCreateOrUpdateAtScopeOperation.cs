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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> You can provide the template and parameters directly in the request or link to JSON files. </summary>
    public partial class DeploymentCreateOrUpdateAtScopeOperation : Operation<Deployment>, IOperationSource<Deployment>
    {
        private readonly OperationInternals<Deployment> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of DeploymentCreateOrUpdateAtScopeOperation for mocking. </summary>
        protected DeploymentCreateOrUpdateAtScopeOperation()
        {
        }

        internal DeploymentCreateOrUpdateAtScopeOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<Deployment>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DeploymentCreateOrUpdateAtScopeOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override Deployment Value => _operation.Value;

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
        public override ValueTask<Response<Deployment>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<Deployment>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        Deployment IOperationSource<Deployment>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DeploymentData.DeserializeDeploymentData(document.RootElement);
            return new Deployment(_operationBase, data);
        }

        async ValueTask<Deployment> IOperationSource<Deployment>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DeploymentData.DeserializeDeploymentData(document.RootElement);
            return new Deployment(_operationBase, data);
        }
    }
}
