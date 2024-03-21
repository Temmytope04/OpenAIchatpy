// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp
{
    internal class SelfHelpDiagnosticOperationSource : IOperationSource<SelfHelpDiagnosticResource>
    {
        private readonly ArmClient _client;

        internal SelfHelpDiagnosticOperationSource(ArmClient client)
        {
            _client = client;
        }

        SelfHelpDiagnosticResource IOperationSource<SelfHelpDiagnosticResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SelfHelpDiagnosticData.DeserializeSelfHelpDiagnosticData(document.RootElement);
            return new SelfHelpDiagnosticResource(_client, data);
        }

        async ValueTask<SelfHelpDiagnosticResource> IOperationSource<SelfHelpDiagnosticResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SelfHelpDiagnosticData.DeserializeSelfHelpDiagnosticData(document.RootElement);
            return new SelfHelpDiagnosticResource(_client, data);
        }
    }
}
