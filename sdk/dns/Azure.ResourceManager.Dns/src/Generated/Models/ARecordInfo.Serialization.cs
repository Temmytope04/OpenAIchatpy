// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dns.Models
{
    public partial class ARecordInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IPv4Address))
            {
                writer.WritePropertyName("ipv4Address");
                writer.WriteStringValue(IPv4Address.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ARecordInfo DeserializeARecordInfo(JsonElement element)
        {
            Optional<IPAddress> ipv4Address = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipv4Address"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ipv4Address = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
            }
            return new ARecordInfo(ipv4Address.Value);
        }
    }
}
