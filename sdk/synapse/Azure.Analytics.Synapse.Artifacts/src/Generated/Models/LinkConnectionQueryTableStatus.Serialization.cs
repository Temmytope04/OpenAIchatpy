// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LinkConnectionQueryTableStatusConverter))]
    public partial class LinkConnectionQueryTableStatus
    {
        internal static LinkConnectionQueryTableStatus DeserializeLinkConnectionQueryTableStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<LinkTableStatus>> value = default;
            Optional<object> continuationToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LinkTableStatus> array = new List<LinkTableStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkTableStatus.DeserializeLinkTableStatus(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("continuationToken"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    continuationToken = property.Value.GetObject();
                    continue;
                }
            }
            return new LinkConnectionQueryTableStatus(Optional.ToList(value), continuationToken.Value);
        }

        internal partial class LinkConnectionQueryTableStatusConverter : JsonConverter<LinkConnectionQueryTableStatus>
        {
            public override void Write(Utf8JsonWriter writer, LinkConnectionQueryTableStatus model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override LinkConnectionQueryTableStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkConnectionQueryTableStatus(document.RootElement);
            }
        }
    }
}
