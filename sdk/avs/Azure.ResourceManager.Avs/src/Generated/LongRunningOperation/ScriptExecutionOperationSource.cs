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

namespace Azure.ResourceManager.Avs
{
    internal class ScriptExecutionOperationSource : IOperationSource<ScriptExecutionResource>
    {
        private readonly ArmClient _client;

        internal ScriptExecutionOperationSource(ArmClient client)
        {
            _client = client;
        }

        ScriptExecutionResource IOperationSource<ScriptExecutionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ScriptExecutionData.DeserializeScriptExecutionData(document.RootElement);
            return new ScriptExecutionResource(_client, data);
        }

        async ValueTask<ScriptExecutionResource> IOperationSource<ScriptExecutionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ScriptExecutionData.DeserializeScriptExecutionData(document.RootElement);
            return new ScriptExecutionResource(_client, data);
        }
    }
}
