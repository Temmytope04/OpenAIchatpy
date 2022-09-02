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

namespace Azure.ResourceManager.Media
{
    internal class MediaServicesAccountOperationSource : IOperationSource<MediaServicesAccountResource>
    {
        private readonly ArmClient _client;

        internal MediaServicesAccountOperationSource(ArmClient client)
        {
            _client = client;
        }

        MediaServicesAccountResource IOperationSource<MediaServicesAccountResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MediaServicesAccountData.DeserializeMediaServicesAccountData(document.RootElement);
            return new MediaServicesAccountResource(_client, data);
        }

        async ValueTask<MediaServicesAccountResource> IOperationSource<MediaServicesAccountResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MediaServicesAccountData.DeserializeMediaServicesAccountData(document.RootElement);
            return new MediaServicesAccountResource(_client, data);
        }
    }
}
