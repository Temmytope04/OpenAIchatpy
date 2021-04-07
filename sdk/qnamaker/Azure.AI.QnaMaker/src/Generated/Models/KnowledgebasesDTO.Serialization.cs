// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.QnaMaker.Models
{
    internal partial class KnowledgebasesDTO
    {
        internal static KnowledgebasesDTO DeserializeKnowledgebasesDTO(JsonElement element)
        {
            Optional<IReadOnlyList<KnowledgebaseDTO>> knowledgebases = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("knowledgebases"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KnowledgebaseDTO> array = new List<KnowledgebaseDTO>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KnowledgebaseDTO.DeserializeKnowledgebaseDTO(item));
                    }
                    knowledgebases = array;
                    continue;
                }
            }
            return new KnowledgebasesDTO(Optional.ToList(knowledgebases));
        }
    }
}
