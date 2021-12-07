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
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Update automatic tuning options on server. </summary>
    public partial class ServerAutomaticTuningUpdateOperation : Operation<ServerAutomaticTuning>
    {
        private readonly OperationOrResponseInternals<ServerAutomaticTuning> _operation;

        /// <summary> Initializes a new instance of ServerAutomaticTuningUpdateOperation for mocking. </summary>
        protected ServerAutomaticTuningUpdateOperation()
        {
        }

        internal ServerAutomaticTuningUpdateOperation(ArmResource operationsBase, Response<ServerAutomaticTuningData> response)
        {
            _operation = new OperationOrResponseInternals<ServerAutomaticTuning>(Response.FromValue(new ServerAutomaticTuning(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ServerAutomaticTuning Value => _operation.Value;

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
        public override ValueTask<Response<ServerAutomaticTuning>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ServerAutomaticTuning>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
