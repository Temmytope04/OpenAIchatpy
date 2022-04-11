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

namespace Azure.ResourceManager.Network
{
    internal class VpnSiteOperationSource : IOperationSource<VpnSiteResource>
    {
        private readonly ArmClient _client;

        internal VpnSiteOperationSource(ArmClient client)
        {
            _client = client;
        }

        VpnSiteResource IOperationSource<VpnSiteResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VpnSiteData.DeserializeVpnSiteData(document.RootElement);
            return new VpnSiteResource(_client, data);
        }

        async ValueTask<VpnSiteResource> IOperationSource<VpnSiteResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VpnSiteData.DeserializeVpnSiteData(document.RootElement);
            return new VpnSiteResource(_client, data);
        }
    }
}
