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
using Azure.ResourceManager.ServiceBus;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Creates or updates an authorization rule for a namespace. </summary>
    public partial class NamespaceAuthorizationRuleCreateOrUpdateOperation : Operation<NamespaceServiceBusAuthorizationRule>
    {
        private readonly OperationOrResponseInternals<NamespaceServiceBusAuthorizationRule> _operation;

        /// <summary> Initializes a new instance of NamespaceAuthorizationRuleCreateOrUpdateOperation for mocking. </summary>
        protected NamespaceAuthorizationRuleCreateOrUpdateOperation()
        {
        }

        internal NamespaceAuthorizationRuleCreateOrUpdateOperation(ArmResource operationsBase, Response<ServiceBusAuthorizationRuleData> response)
        {
            _operation = new OperationOrResponseInternals<NamespaceServiceBusAuthorizationRule>(Response.FromValue(new NamespaceServiceBusAuthorizationRule(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override NamespaceServiceBusAuthorizationRule Value => _operation.Value;

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
        public override ValueTask<Response<NamespaceServiceBusAuthorizationRule>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<NamespaceServiceBusAuthorizationRule>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
