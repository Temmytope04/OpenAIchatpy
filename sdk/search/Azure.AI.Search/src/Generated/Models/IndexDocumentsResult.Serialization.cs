// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Search.Models
{
    public partial class IndexDocumentsResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Results != null)
            {
                writer.WritePropertyName("value");
                writer.WriteStartArray();
                foreach (var item in Results)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
        internal static IndexDocumentsResult DeserializeIndexDocumentsResult(JsonElement element)
        {
            IndexDocumentsResult result = new IndexDocumentsResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Results = new List<IndexingResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Results.Add(IndexingResult.DeserializeIndexingResult(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
