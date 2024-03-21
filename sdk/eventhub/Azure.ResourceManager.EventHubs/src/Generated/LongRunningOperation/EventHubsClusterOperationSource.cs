// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs
{
    internal class EventHubsClusterOperationSource : IOperationSource<EventHubsClusterResource>
    {
        private readonly ArmClient _client;

        internal EventHubsClusterOperationSource(ArmClient client)
        {
            _client = client;
        }

        EventHubsClusterResource IOperationSource<EventHubsClusterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = EventHubsClusterData.DeserializeEventHubsClusterData(document.RootElement);
            return new EventHubsClusterResource(_client, data);
        }

        async ValueTask<EventHubsClusterResource> IOperationSource<EventHubsClusterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = EventHubsClusterData.DeserializeEventHubsClusterData(document.RootElement);
            return new EventHubsClusterResource(_client, data);
        }
    }
}
