// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Search.Models
{
    public partial class SearchServiceLimits : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (MaxFieldsPerIndex != null)
            {
                writer.WritePropertyName("maxFieldsPerIndex");
                writer.WriteNumberValue(MaxFieldsPerIndex.Value);
            }
            if (MaxFieldNestingDepthPerIndex != null)
            {
                writer.WritePropertyName("maxFieldNestingDepthPerIndex");
                writer.WriteNumberValue(MaxFieldNestingDepthPerIndex.Value);
            }
            if (MaxComplexCollectionFieldsPerIndex != null)
            {
                writer.WritePropertyName("maxComplexCollectionFieldsPerIndex");
                writer.WriteNumberValue(MaxComplexCollectionFieldsPerIndex.Value);
            }
            if (MaxComplexObjectsInCollectionsPerDocument != null)
            {
                writer.WritePropertyName("maxComplexObjectsInCollectionsPerDocument");
                writer.WriteNumberValue(MaxComplexObjectsInCollectionsPerDocument.Value);
            }
            writer.WriteEndObject();
        }
        internal static SearchServiceLimits DeserializeSearchServiceLimits(JsonElement element)
        {
            SearchServiceLimits result = new SearchServiceLimits();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxFieldsPerIndex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MaxFieldsPerIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxFieldNestingDepthPerIndex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MaxFieldNestingDepthPerIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxComplexCollectionFieldsPerIndex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MaxComplexCollectionFieldsPerIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxComplexObjectsInCollectionsPerDocument"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MaxComplexObjectsInCollectionsPerDocument = property.Value.GetInt32();
                    continue;
                }
            }
            return result;
        }
    }
}
