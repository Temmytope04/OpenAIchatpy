// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    internal class CsmDeploymentStatusOperationSource : IOperationSource<CsmDeploymentStatus>
    {
        CsmDeploymentStatus IOperationSource<CsmDeploymentStatus>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return CsmDeploymentStatus.DeserializeCsmDeploymentStatus(document.RootElement);
        }

        async ValueTask<CsmDeploymentStatus> IOperationSource<CsmDeploymentStatus>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return CsmDeploymentStatus.DeserializeCsmDeploymentStatus(document.RootElement);
        }
    }
}
