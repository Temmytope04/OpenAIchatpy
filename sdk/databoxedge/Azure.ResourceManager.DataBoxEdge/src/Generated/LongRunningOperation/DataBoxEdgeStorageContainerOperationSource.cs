// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge
{
    internal class DataBoxEdgeStorageContainerOperationSource : IOperationSource<DataBoxEdgeStorageContainerResource>
    {
        private readonly ArmClient _client;

        internal DataBoxEdgeStorageContainerOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataBoxEdgeStorageContainerResource IOperationSource<DataBoxEdgeStorageContainerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DataBoxEdgeStorageContainerData.DeserializeDataBoxEdgeStorageContainerData(document.RootElement);
            return new DataBoxEdgeStorageContainerResource(_client, data);
        }

        async ValueTask<DataBoxEdgeStorageContainerResource> IOperationSource<DataBoxEdgeStorageContainerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DataBoxEdgeStorageContainerData.DeserializeDataBoxEdgeStorageContainerData(document.RootElement);
            return new DataBoxEdgeStorageContainerResource(_client, data);
        }
    }
}
