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

namespace Azure.ResourceManager.AppService
{
    internal class SiteInstanceExtensionOperationSource : IOperationSource<SiteInstanceExtensionResource>
    {
        private readonly ArmClient _client;

        internal SiteInstanceExtensionOperationSource(ArmClient client)
        {
            _client = client;
        }

        SiteInstanceExtensionResource IOperationSource<SiteInstanceExtensionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MSDeployStatusData.DeserializeMSDeployStatusData(document.RootElement);
            return new SiteInstanceExtensionResource(_client, data);
        }

        async ValueTask<SiteInstanceExtensionResource> IOperationSource<SiteInstanceExtensionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MSDeployStatusData.DeserializeMSDeployStatusData(document.RootElement);
            return new SiteInstanceExtensionResource(_client, data);
        }
    }
}
