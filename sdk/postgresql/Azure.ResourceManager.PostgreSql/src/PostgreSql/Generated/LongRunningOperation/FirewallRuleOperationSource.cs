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

namespace Azure.ResourceManager.PostgreSql
{
    internal class FirewallRuleOperationSource : IOperationSource<FirewallRuleResource>
    {
        private readonly ArmClient _client;

        internal FirewallRuleOperationSource(ArmClient client)
        {
            _client = client;
        }

        FirewallRuleResource IOperationSource<FirewallRuleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = FirewallRuleData.DeserializeFirewallRuleData(document.RootElement);
            return new FirewallRuleResource(_client, data);
        }

        async ValueTask<FirewallRuleResource> IOperationSource<FirewallRuleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = FirewallRuleData.DeserializeFirewallRuleData(document.RootElement);
            return new FirewallRuleResource(_client, data);
        }
    }
}
