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

namespace Azure.ResourceManager.AppPlatform
{
    internal class AppPlatformBuilderOperationSource : IOperationSource<AppPlatformBuilderResource>
    {
        private readonly ArmClient _client;

        internal AppPlatformBuilderOperationSource(ArmClient client)
        {
            _client = client;
        }

        AppPlatformBuilderResource IOperationSource<AppPlatformBuilderResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AppPlatformBuilderData.DeserializeAppPlatformBuilderData(document.RootElement);
            return new AppPlatformBuilderResource(_client, data);
        }

        async ValueTask<AppPlatformBuilderResource> IOperationSource<AppPlatformBuilderResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AppPlatformBuilderData.DeserializeAppPlatformBuilderData(document.RootElement);
            return new AppPlatformBuilderResource(_client, data);
        }
    }
}
