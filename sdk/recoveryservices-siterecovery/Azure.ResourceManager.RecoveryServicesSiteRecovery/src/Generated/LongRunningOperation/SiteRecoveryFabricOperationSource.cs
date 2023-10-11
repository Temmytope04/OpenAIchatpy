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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    internal class SiteRecoveryFabricOperationSource : IOperationSource<SiteRecoveryFabricResource>
    {
        private readonly ArmClient _client;

        internal SiteRecoveryFabricOperationSource(ArmClient client)
        {
            _client = client;
        }

        SiteRecoveryFabricResource IOperationSource<SiteRecoveryFabricResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SiteRecoveryFabricData.DeserializeSiteRecoveryFabricData(document.RootElement);
            return new SiteRecoveryFabricResource(_client, data);
        }

        async ValueTask<SiteRecoveryFabricResource> IOperationSource<SiteRecoveryFabricResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SiteRecoveryFabricData.DeserializeSiteRecoveryFabricData(document.RootElement);
            return new SiteRecoveryFabricResource(_client, data);
        }
    }
}
