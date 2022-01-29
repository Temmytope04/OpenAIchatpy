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
using Azure.ResourceManager;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Creates a VirtualWAN resource if it doesn&apos;t exist else updates the existing VirtualWAN. </summary>
    public partial class VirtualWanCreateOrUpdateOperation : Operation<VirtualWan>, IOperationSource<VirtualWan>
    {
        private readonly OperationInternals<VirtualWan> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of VirtualWanCreateOrUpdateOperation for mocking. </summary>
        protected VirtualWanCreateOrUpdateOperation()
        {
        }

        internal VirtualWanCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VirtualWan>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "VirtualWanCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VirtualWan Value => _operation.Value;

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
        public override ValueTask<Response<VirtualWan>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualWan>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VirtualWan IOperationSource<VirtualWan>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VirtualWanData.DeserializeVirtualWanData(document.RootElement);
            return new VirtualWan(_armClient, data);
        }

        async ValueTask<VirtualWan> IOperationSource<VirtualWan>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VirtualWanData.DeserializeVirtualWanData(document.RootElement);
            return new VirtualWan(_armClient, data);
        }
    }
}
