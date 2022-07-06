// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class DataCollectionEndpointNetworkAcls : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static DataCollectionEndpointNetworkAcls DeserializeDataCollectionEndpointNetworkAcls(JsonElement element)
        {
            Optional<KnownPublicNetworkAccessOption> publicNetworkAccess = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicNetworkAccess"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    publicNetworkAccess = new KnownPublicNetworkAccessOption(property.Value.GetString());
                    continue;
                }
            }
            return new DataCollectionEndpointNetworkAcls(Optional.ToNullable(publicNetworkAccess));
        }
    }
}
