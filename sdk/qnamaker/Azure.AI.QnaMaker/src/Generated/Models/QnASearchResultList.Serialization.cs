// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.QnaMaker.Models
{
    internal partial class QnASearchResultList
    {
        internal static QnASearchResultList DeserializeQnASearchResultList(JsonElement element)
        {
            Optional<IReadOnlyList<QnASearchResult>> answers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("answers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<QnASearchResult> array = new List<QnASearchResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QnASearchResult.DeserializeQnASearchResult(item));
                    }
                    answers = array;
                    continue;
                }
            }
            return new QnASearchResultList(Optional.ToList(answers));
        }
    }
}
