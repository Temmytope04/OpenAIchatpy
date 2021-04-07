// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.QnaMaker.Models
{
    public partial class QnAdtoContext : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsContextOnly))
            {
                writer.WritePropertyName("isContextOnly");
                writer.WriteBooleanValue(IsContextOnly.Value);
            }
            if (Optional.IsCollectionDefined(Prompts))
            {
                writer.WritePropertyName("prompts");
                writer.WriteStartArray();
                foreach (var item in Prompts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static QnAdtoContext DeserializeQnAdtoContext(JsonElement element)
        {
            Optional<bool> isContextOnly = default;
            Optional<IList<PromptDTO>> prompts = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isContextOnly"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isContextOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("prompts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PromptDTO> array = new List<PromptDTO>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PromptDTO.DeserializePromptDTO(item));
                    }
                    prompts = array;
                    continue;
                }
            }
            return new QnAdtoContext(Optional.ToNullable(isContextOnly), Optional.ToList(prompts));
        }
    }
}
