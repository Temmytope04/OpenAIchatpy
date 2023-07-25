// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    internal class L3IsolationDomainOperationSource : IOperationSource<L3IsolationDomainResource>
    {
        private readonly ArmClient _client;

        internal L3IsolationDomainOperationSource(ArmClient client)
        {
            _client = client;
        }

        L3IsolationDomainResource IOperationSource<L3IsolationDomainResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = L3IsolationDomainData.DeserializeL3IsolationDomainData(document.RootElement);
            return new L3IsolationDomainResource(_client, data);
        }

        async ValueTask<L3IsolationDomainResource> IOperationSource<L3IsolationDomainResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = L3IsolationDomainData.DeserializeL3IsolationDomainData(document.RootElement);
            return new L3IsolationDomainResource(_client, data);
        }
    }
}
