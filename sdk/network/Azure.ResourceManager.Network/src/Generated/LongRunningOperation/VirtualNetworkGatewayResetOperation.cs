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
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Resets the primary of the virtual network gateway in the specified resource group. </summary>
    public partial class VirtualNetworkGatewayResetOperation : Operation<VirtualNetworkGatewayData>, IOperationSource<VirtualNetworkGatewayData>
    {
        private readonly OperationInternals<VirtualNetworkGatewayData> _operation;

        /// <summary> Initializes a new instance of VirtualNetworkGatewayResetOperation for mocking. </summary>
        protected VirtualNetworkGatewayResetOperation()
        {
        }

        internal VirtualNetworkGatewayResetOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VirtualNetworkGatewayData>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "VirtualNetworkGatewayResetOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VirtualNetworkGatewayData Value => _operation.Value;

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
        public override ValueTask<Response<VirtualNetworkGatewayData>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualNetworkGatewayData>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VirtualNetworkGatewayData IOperationSource<VirtualNetworkGatewayData>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return VirtualNetworkGatewayData.DeserializeVirtualNetworkGatewayData(document.RootElement);
        }

        async ValueTask<VirtualNetworkGatewayData> IOperationSource<VirtualNetworkGatewayData>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return VirtualNetworkGatewayData.DeserializeVirtualNetworkGatewayData(document.RootElement);
        }
    }
}
