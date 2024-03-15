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

namespace Azure.ResourceManager.NotificationHubs
{
    internal class NotificationHubPrivateEndpointConnectionOperationSource : IOperationSource<NotificationHubPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal NotificationHubPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        NotificationHubPrivateEndpointConnectionResource IOperationSource<NotificationHubPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NotificationHubPrivateEndpointConnectionData.DeserializeNotificationHubPrivateEndpointConnectionData(document.RootElement);
            return new NotificationHubPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<NotificationHubPrivateEndpointConnectionResource> IOperationSource<NotificationHubPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NotificationHubPrivateEndpointConnectionData.DeserializeNotificationHubPrivateEndpointConnectionData(document.RootElement);
            return new NotificationHubPrivateEndpointConnectionResource(_client, data);
        }
    }
}
