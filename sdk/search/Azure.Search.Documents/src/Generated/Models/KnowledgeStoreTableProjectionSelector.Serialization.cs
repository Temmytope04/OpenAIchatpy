// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class KnowledgeStoreTableProjectionSelector : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tableName"u8);
            writer.WriteStringValue(TableName);
            if (Optional.IsDefined(ReferenceKeyName))
            {
                writer.WritePropertyName("referenceKeyName"u8);
                writer.WriteStringValue(ReferenceKeyName);
            }
            if (Optional.IsDefined(GeneratedKeyName))
            {
                writer.WritePropertyName("generatedKeyName"u8);
                writer.WriteStringValue(GeneratedKeyName);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (Optional.IsDefined(SourceContext))
            {
                writer.WritePropertyName("sourceContext"u8);
                writer.WriteStringValue(SourceContext);
            }
            if (Optional.IsCollectionDefined(Inputs))
            {
                writer.WritePropertyName("inputs"u8);
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static KnowledgeStoreTableProjectionSelector DeserializeKnowledgeStoreTableProjectionSelector(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string tableName = default;
            string referenceKeyName = default;
            string generatedKeyName = default;
            string source = default;
            string sourceContext = default;
            IList<InputFieldMappingEntry> inputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tableName"u8))
                {
                    tableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("referenceKeyName"u8))
                {
                    referenceKeyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("generatedKeyName"u8))
                {
                    generatedKeyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceContext"u8))
                {
                    sourceContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InputFieldMappingEntry> array = new List<InputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InputFieldMappingEntry.DeserializeInputFieldMappingEntry(item));
                    }
                    inputs = array;
                    continue;
                }
            }
            return new KnowledgeStoreTableProjectionSelector(
                referenceKeyName,
                generatedKeyName,
                source,
                sourceContext,
                inputs ?? new ChangeTrackingList<InputFieldMappingEntry>(),
                tableName);
        }
    }
}
