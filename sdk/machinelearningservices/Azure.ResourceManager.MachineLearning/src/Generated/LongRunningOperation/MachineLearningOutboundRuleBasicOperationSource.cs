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

namespace Azure.ResourceManager.MachineLearning
{
    internal class MachineLearningOutboundRuleBasicOperationSource : IOperationSource<MachineLearningOutboundRuleBasicResource>
    {
        private readonly ArmClient _client;

        internal MachineLearningOutboundRuleBasicOperationSource(ArmClient client)
        {
            _client = client;
        }

        MachineLearningOutboundRuleBasicResource IOperationSource<MachineLearningOutboundRuleBasicResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MachineLearningOutboundRuleBasicData.DeserializeMachineLearningOutboundRuleBasicData(document.RootElement);
            return new MachineLearningOutboundRuleBasicResource(_client, data);
        }

        async ValueTask<MachineLearningOutboundRuleBasicResource> IOperationSource<MachineLearningOutboundRuleBasicResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MachineLearningOutboundRuleBasicData.DeserializeMachineLearningOutboundRuleBasicData(document.RootElement);
            return new MachineLearningOutboundRuleBasicResource(_client, data);
        }
    }
}
