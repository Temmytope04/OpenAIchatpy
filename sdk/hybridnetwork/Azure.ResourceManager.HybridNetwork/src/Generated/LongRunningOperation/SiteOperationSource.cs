// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork
{
    internal class SiteOperationSource : IOperationSource<SiteResource>
    {
        private readonly ArmClient _client;

        internal SiteOperationSource(ArmClient client)
        {
            _client = client;
        }

        SiteResource IOperationSource<SiteResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SiteData.DeserializeSiteData(document.RootElement);
            return new SiteResource(_client, data);
        }

        async ValueTask<SiteResource> IOperationSource<SiteResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SiteData.DeserializeSiteData(document.RootElement);
            return new SiteResource(_client, data);
        }
    }
}
