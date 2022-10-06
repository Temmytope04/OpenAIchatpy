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

namespace Azure.ResourceManager.Synapse
{
    internal class SynapsePrivateEndpointConnectionOperationSource : IOperationSource<SynapsePrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal SynapsePrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        SynapsePrivateEndpointConnectionResource IOperationSource<SynapsePrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SynapsePrivateEndpointConnectionData.DeserializeSynapsePrivateEndpointConnectionData(document.RootElement);
            return new SynapsePrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<SynapsePrivateEndpointConnectionResource> IOperationSource<SynapsePrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SynapsePrivateEndpointConnectionData.DeserializeSynapsePrivateEndpointConnectionData(document.RootElement);
            return new SynapsePrivateEndpointConnectionResource(_client, data);
        }
    }
}
