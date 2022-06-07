// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class DocumentLine
    {
        internal static DocumentLine DeserializeDocumentLine(JsonElement element)
        {
            string content = default;
            Optional<IReadOnlyList<float>> polygon = default;
            IReadOnlyList<DocumentSpan> spans = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"))
                {
                    content = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("polygon"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    polygon = array;
                    continue;
                }
                if (property.NameEquals("spans"))
                {
                    List<DocumentSpan> array = new List<DocumentSpan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentSpan.DeserializeDocumentSpan(item));
                    }
                    spans = array;
                    continue;
                }
            }
            return new DocumentLine(content, Optional.ToList(polygon), spans);
        }
    }
}
