// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SignalR.Models
{
    public partial class SignalRPrivateEndpointAcl : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsCollectionDefined(Allow))
            {
                writer.WritePropertyName("allow"u8);
                writer.WriteStartArray();
                foreach (var item in Allow)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Deny))
            {
                writer.WritePropertyName("deny"u8);
                writer.WriteStartArray();
                foreach (var item in Deny)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SignalRPrivateEndpointAcl DeserializeSignalRPrivateEndpointAcl(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<IList<SignalRRequestType>> allow = default;
            Optional<IList<SignalRRequestType>> deny = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SignalRRequestType> array = new List<SignalRRequestType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SignalRRequestType(item.GetString()));
                    }
                    allow = array;
                    continue;
                }
                if (property.NameEquals("deny"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SignalRRequestType> array = new List<SignalRRequestType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SignalRRequestType(item.GetString()));
                    }
                    deny = array;
                    continue;
                }
            }
            return new SignalRPrivateEndpointAcl(Optional.ToList(allow), Optional.ToList(deny), name);
        }
    }
}
