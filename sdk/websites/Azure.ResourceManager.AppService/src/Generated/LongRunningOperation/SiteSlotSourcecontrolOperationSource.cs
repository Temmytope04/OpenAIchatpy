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
    internal class SiteSlotSourcecontrolOperationSource : IOperationSource<SiteSlotSourcecontrolResource>
    {
        private readonly ArmClient _client;

        internal SiteSlotSourcecontrolOperationSource(ArmClient client)
        {
            _client = client;
        }

        SiteSlotSourcecontrolResource IOperationSource<SiteSlotSourcecontrolResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SiteSourceControlData.DeserializeSiteSourceControlData(document.RootElement);
            return new SiteSlotSourcecontrolResource(_client, data);
        }

        async ValueTask<SiteSlotSourcecontrolResource> IOperationSource<SiteSlotSourcecontrolResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SiteSourceControlData.DeserializeSiteSourceControlData(document.RootElement);
            return new SiteSlotSourcecontrolResource(_client, data);
        }
    }
}
