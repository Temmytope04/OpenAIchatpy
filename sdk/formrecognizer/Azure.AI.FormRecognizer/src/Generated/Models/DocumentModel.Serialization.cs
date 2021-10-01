// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class DocumentModel
    {
        internal static DocumentModel DeserializeDocumentModel(JsonElement element)
        {
            Optional<IReadOnlyDictionary<string, DocTypeInfo>> docTypes = default;
            string modelId = default;
            Optional<string> description = default;
            DateTimeOffset createdDateTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("docTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, DocTypeInfo> dictionary = new Dictionary<string, DocTypeInfo>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DocTypeInfo.DeserializeDocTypeInfo(property0.Value));
                    }
                    docTypes = dictionary;
                    continue;
                }
                if (property.NameEquals("modelId"))
                {
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new DocumentModel(modelId, description.Value, createdDateTime, Optional.ToDictionary(docTypes));
        }
    }
}
