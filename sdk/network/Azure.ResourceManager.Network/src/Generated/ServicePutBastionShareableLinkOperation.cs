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
    /// <summary> Creates a Bastion Shareable Links for all the VMs specified in the request. </summary>
    public partial class ServicePutBastionShareableLinkOperation : Operation<BastionShareableLinkListResult>, IOperationSource<BastionShareableLinkListResult>
    {
        private readonly ArmOperationHelpers<BastionShareableLinkListResult> _operation;
        internal ServicePutBastionShareableLinkOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<BastionShareableLinkListResult>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ServicePutBastionShareableLinkOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override BastionShareableLinkListResult Value => _operation.Value;

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
        public override ValueTask<Response<BastionShareableLinkListResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<BastionShareableLinkListResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        BastionShareableLinkListResult IOperationSource<BastionShareableLinkListResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            if (document.RootElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            else
            {
                return BastionShareableLinkListResult.DeserializeBastionShareableLinkListResult(document.RootElement);
            }
        }

        async ValueTask<BastionShareableLinkListResult> IOperationSource<BastionShareableLinkListResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            if (document.RootElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            else
            {
                return BastionShareableLinkListResult.DeserializeBastionShareableLinkListResult(document.RootElement);
            }
        }
    }
}
