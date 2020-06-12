// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ConnectionMonitorEndpointFilterItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Address != null)
            {
                writer.WritePropertyName("address");
                writer.WriteStringValue(Address);
            }
            writer.WriteEndObject();
        }

        internal static ConnectionMonitorEndpointFilterItem DeserializeConnectionMonitorEndpointFilterItem(JsonElement element)
        {
            string type = default;
            string address = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("address"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    address = property.Value.GetString();
                    continue;
                }
            }
            return new ConnectionMonitorEndpointFilterItem(type, address);
        }
    }
}
