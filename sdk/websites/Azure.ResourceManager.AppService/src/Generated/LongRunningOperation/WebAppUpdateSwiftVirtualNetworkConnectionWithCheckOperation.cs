// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.AppService;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Description for Integrates this Web App with a Virtual Network. This requires that 1) &quot;swiftSupported&quot; is true when doing a GET against this resource, and 2) that the target Subnet has already been delegated, and is not
    /// in use by another App Service Plan other than the one this App is in.
    /// </summary>
    public partial class WebAppUpdateSwiftVirtualNetworkConnectionWithCheckOperation : Operation<SiteNetworkConfig>
    {
        private readonly OperationOrResponseInternals<SiteNetworkConfig> _operation;

        /// <summary> Initializes a new instance of WebAppUpdateSwiftVirtualNetworkConnectionWithCheckOperation for mocking. </summary>
        protected WebAppUpdateSwiftVirtualNetworkConnectionWithCheckOperation()
        {
        }

        internal WebAppUpdateSwiftVirtualNetworkConnectionWithCheckOperation(ArmResource operationsBase, Response<SwiftVirtualNetworkData> response)
        {
            _operation = new OperationOrResponseInternals<SiteNetworkConfig>(Response.FromValue(new SiteNetworkConfig(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SiteNetworkConfig Value => _operation.Value;

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
        public override ValueTask<Response<SiteNetworkConfig>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SiteNetworkConfig>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
