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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> Create and start a packet capture on the specified VM. </summary>
    public partial class PacketCapturesCreateOperation : Operation<PacketCaptureResult>, IOperationSource<PacketCaptureResult>
    {
        private readonly ArmOperationHelpers<PacketCaptureResult> _operation;
        internal PacketCapturesCreateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<PacketCaptureResult>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "PacketCapturesCreateOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override PacketCaptureResult Value => _operation.Value;

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
        public override ValueTask<Response<PacketCaptureResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<PacketCaptureResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        PacketCaptureResult IOperationSource<PacketCaptureResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            if (document.RootElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            else
            {
                return PacketCaptureResult.DeserializePacketCaptureResult(document.RootElement);
            }
        }

        async ValueTask<PacketCaptureResult> IOperationSource<PacketCaptureResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            if (document.RootElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            else
            {
                return PacketCaptureResult.DeserializePacketCaptureResult(document.RootElement);
            }
        }
    }
}
