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
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Creates a hub virtual network connection if it doesn&apos;t exist else updates the existing one. </summary>
    public partial class HubVirtualNetworkConnectionCreateOrUpdateOperation : Operation<HubVirtualNetworkConnection>, IOperationSource<HubVirtualNetworkConnection>
    {
        private readonly OperationInternals<HubVirtualNetworkConnection> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of HubVirtualNetworkConnectionCreateOrUpdateOperation for mocking. </summary>
        protected HubVirtualNetworkConnectionCreateOrUpdateOperation()
        {
        }

        internal HubVirtualNetworkConnectionCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<HubVirtualNetworkConnection>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "HubVirtualNetworkConnectionCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override HubVirtualNetworkConnection Value => _operation.Value;

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
        public override ValueTask<Response<HubVirtualNetworkConnection>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<HubVirtualNetworkConnection>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        HubVirtualNetworkConnection IOperationSource<HubVirtualNetworkConnection>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new HubVirtualNetworkConnection(_operationBase, HubVirtualNetworkConnectionData.DeserializeHubVirtualNetworkConnectionData(document.RootElement));
        }

        async ValueTask<HubVirtualNetworkConnection> IOperationSource<HubVirtualNetworkConnection>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new HubVirtualNetworkConnection(_operationBase, HubVirtualNetworkConnectionData.DeserializeHubVirtualNetworkConnectionData(document.RootElement));
        }
    }
}
