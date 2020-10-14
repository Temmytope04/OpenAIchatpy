// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class StaticRoute : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
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
            if (Optional.IsDefined(NextHopIpAddress))
            {
                writer.WritePropertyName("nextHopIpAddress");
                writer.WriteStringValue(NextHopIpAddress);
            }
            writer.WriteEndObject();
        }

        internal static StaticRoute DeserializeStaticRoute(JsonElement element)
        {
            Optional<string> name = default;
            Optional<IList<string>> addressPrefixes = default;
            Optional<string> nextHopIpAddress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
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
                    nextHopIpAddress = property.Value.GetString();
                    continue;
                }
            }
            return new StaticRoute(name.Value, Optional.ToList(addressPrefixes), nextHopIpAddress.Value);
        }
    }
}
