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

namespace Azure.ResourceManager.DevCenter
{
    internal class DevCenterOperationSource : IOperationSource<DevCenterResource>
    {
        private readonly ArmClient _client;

        internal DevCenterOperationSource(ArmClient client)
        {
            _client = client;
        }

        DevCenterResource IOperationSource<DevCenterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DevCenterData.DeserializeDevCenterData(document.RootElement);
            return new DevCenterResource(_client, data);
        }

        async ValueTask<DevCenterResource> IOperationSource<DevCenterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DevCenterData.DeserializeDevCenterData(document.RootElement);
            return new DevCenterResource(_client, data);
        }
    }
}
