// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VirtualHubRoute : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AddressPrefixes))
            {
                writer.WritePropertyName("addressPrefixes");
                writer.WriteStartArray();
                foreach (var item in AddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextHopIPAddress))
            {
                writer.WritePropertyName("nextHopIpAddress");
                writer.WriteStringValue(NextHopIPAddress);
            }
            writer.WriteEndObject();
        }

        internal static VirtualHubRoute DeserializeVirtualHubRoute(JsonElement element)
        {
            Optional<IList<string>> addressPrefixes = default;
            Optional<string> nextHopIPAddress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addressPrefixes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    addressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("nextHopIpAddress"))
                {
                    nextHopIPAddress = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualHubRoute(Optional.ToList(addressPrefixes), nextHopIPAddress.Value);
        }
    }
}
