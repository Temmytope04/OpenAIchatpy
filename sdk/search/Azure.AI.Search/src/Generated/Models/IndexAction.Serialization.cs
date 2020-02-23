// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Search.Models
{
    public partial class IndexAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ActionType != null)
            {
                writer.WritePropertyName("@search.action");
                writer.WriteStringValue(ActionType.Value.ToSerialString());
            }
            foreach (var item in this)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }
        internal static IndexAction DeserializeIndexAction(JsonElement element)
        {
            IndexAction result = new IndexAction();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@search.action"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ActionType = property.Value.GetString().ToIndexActionType();
                    continue;
                }
                result.Add(property.Name, property.Value.GetObject());
            }
            return result;
        }
    }
}
