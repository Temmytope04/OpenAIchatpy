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

namespace Azure.ResourceManager.Sql
{
    internal class LongTermRetentionPolicyOperationSource : IOperationSource<LongTermRetentionPolicyResource>
    {
        private readonly ArmClient _client;

        internal LongTermRetentionPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        LongTermRetentionPolicyResource IOperationSource<LongTermRetentionPolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = LongTermRetentionPolicyData.DeserializeLongTermRetentionPolicyData(document.RootElement);
            return new LongTermRetentionPolicyResource(_client, data);
        }

        async ValueTask<LongTermRetentionPolicyResource> IOperationSource<LongTermRetentionPolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = LongTermRetentionPolicyData.DeserializeLongTermRetentionPolicyData(document.RootElement);
            return new LongTermRetentionPolicyResource(_client, data);
        }
    }
}
