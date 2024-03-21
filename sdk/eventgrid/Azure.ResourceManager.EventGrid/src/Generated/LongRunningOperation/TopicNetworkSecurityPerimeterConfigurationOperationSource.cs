// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid
{
    internal class TopicNetworkSecurityPerimeterConfigurationOperationSource : IOperationSource<TopicNetworkSecurityPerimeterConfigurationResource>
    {
        private readonly ArmClient _client;

        internal TopicNetworkSecurityPerimeterConfigurationOperationSource(ArmClient client)
        {
            _client = client;
        }

        TopicNetworkSecurityPerimeterConfigurationResource IOperationSource<TopicNetworkSecurityPerimeterConfigurationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkSecurityPerimeterConfigurationData.DeserializeNetworkSecurityPerimeterConfigurationData(document.RootElement);
            return new TopicNetworkSecurityPerimeterConfigurationResource(_client, data);
        }

        async ValueTask<TopicNetworkSecurityPerimeterConfigurationResource> IOperationSource<TopicNetworkSecurityPerimeterConfigurationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkSecurityPerimeterConfigurationData.DeserializeNetworkSecurityPerimeterConfigurationData(document.RootElement);
            return new TopicNetworkSecurityPerimeterConfigurationResource(_client, data);
        }
    }
}
