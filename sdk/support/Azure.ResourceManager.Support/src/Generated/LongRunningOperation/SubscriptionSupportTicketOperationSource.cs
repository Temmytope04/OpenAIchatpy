// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Support
{
    internal class SubscriptionSupportTicketOperationSource : IOperationSource<SubscriptionSupportTicketResource>
    {
        private readonly ArmClient _client;

        internal SubscriptionSupportTicketOperationSource(ArmClient client)
        {
            _client = client;
        }

        SubscriptionSupportTicketResource IOperationSource<SubscriptionSupportTicketResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SupportTicketData.DeserializeSupportTicketData(document.RootElement);
            return new SubscriptionSupportTicketResource(_client, data);
        }

        async ValueTask<SubscriptionSupportTicketResource> IOperationSource<SubscriptionSupportTicketResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SupportTicketData.DeserializeSupportTicketData(document.RootElement);
            return new SubscriptionSupportTicketResource(_client, data);
        }
    }
}
