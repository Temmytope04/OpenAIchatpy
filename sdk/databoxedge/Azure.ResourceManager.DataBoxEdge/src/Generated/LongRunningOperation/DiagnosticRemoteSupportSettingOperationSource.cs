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

namespace Azure.ResourceManager.DataBoxEdge
{
    internal class DiagnosticRemoteSupportSettingOperationSource : IOperationSource<DiagnosticRemoteSupportSettingResource>
    {
        private readonly ArmClient _client;

        internal DiagnosticRemoteSupportSettingOperationSource(ArmClient client)
        {
            _client = client;
        }

        DiagnosticRemoteSupportSettingResource IOperationSource<DiagnosticRemoteSupportSettingResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DiagnosticRemoteSupportSettingData.DeserializeDiagnosticRemoteSupportSettingData(document.RootElement);
            return new DiagnosticRemoteSupportSettingResource(_client, data);
        }

        async ValueTask<DiagnosticRemoteSupportSettingResource> IOperationSource<DiagnosticRemoteSupportSettingResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DiagnosticRemoteSupportSettingData.DeserializeDiagnosticRemoteSupportSettingData(document.RootElement);
            return new DiagnosticRemoteSupportSettingResource(_client, data);
        }
    }
}
