// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Creates or updates an unlocked immutability policy. ETag in If-Match is honored if given but not required for this operation. </summary>
    public partial class BlobContainerCreateOrUpdateImmutabilityPolicyOperation : Operation<ImmutabilityPolicy>
    {
        private readonly OperationOrResponseInternals<ImmutabilityPolicy> _operation;

        /// <summary> Initializes a new instance of BlobContainerCreateOrUpdateImmutabilityPolicyOperation for mocking. </summary>
        protected BlobContainerCreateOrUpdateImmutabilityPolicyOperation()
        {
        }

        internal BlobContainerCreateOrUpdateImmutabilityPolicyOperation(Response<ImmutabilityPolicy> response)
        {
            _operation = new OperationOrResponseInternals<ImmutabilityPolicy>(response);
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ImmutabilityPolicy Value => _operation.Value;

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
        public override ValueTask<Response<ImmutabilityPolicy>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ImmutabilityPolicy>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
