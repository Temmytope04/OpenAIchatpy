// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class IPCommunityAddOperationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Add))
            {
                writer.WritePropertyName("add"u8);
                writer.WriteObjectValue(Add);
            }
            writer.WriteEndObject();
        }

        internal static IPCommunityAddOperationProperties DeserializeIPCommunityAddOperationProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IPCommunityIdList> @add = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("add"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @add = IPCommunityIdList.DeserializeIPCommunityIdList(property.Value);
                    continue;
                }
            }
            return new IPCommunityAddOperationProperties(@add.Value);
        }
    }
}
