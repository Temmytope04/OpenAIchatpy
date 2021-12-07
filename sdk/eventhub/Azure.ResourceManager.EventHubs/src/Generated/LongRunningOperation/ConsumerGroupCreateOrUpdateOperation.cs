// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Creates or updates an Event Hubs consumer group as a nested resource within a Namespace. </summary>
    public partial class ConsumerGroupCreateOrUpdateOperation : Operation<ConsumerGroup>
    {
        private readonly OperationOrResponseInternals<ConsumerGroup> _operation;

        /// <summary> Initializes a new instance of ConsumerGroupCreateOrUpdateOperation for mocking. </summary>
        protected ConsumerGroupCreateOrUpdateOperation()
        {
        }

        internal ConsumerGroupCreateOrUpdateOperation(ArmResource operationsBase, Response<ConsumerGroupData> response)
        {
            _operation = new OperationOrResponseInternals<ConsumerGroup>(Response.FromValue(new ConsumerGroup(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ConsumerGroup Value => _operation.Value;

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
        public override ValueTask<Response<ConsumerGroup>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ConsumerGroup>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
