// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Releases a purchased phone number. </summary>
    internal partial class InternalReleasePhoneNumberOperation : Operation<Response>, IOperationSource<Response>
    {
        private readonly ArmOperationHelpers<Response> _operation;

        /// <summary> Initializes a new instance of InternalReleasePhoneNumberOperation for mocking. </summary>
        protected InternalReleasePhoneNumberOperation()
        {
        }

        /// <inheritdoc />
        public override Response Value => _operation.Value;

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
        public override ValueTask<Response<Response>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<Response>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        Response IOperationSource<Response>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            return response;
        }

        async ValueTask<Response> IOperationSource<Response>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            return await new ValueTask<Response>(response).ConfigureAwait(false);
        }
    }
}
