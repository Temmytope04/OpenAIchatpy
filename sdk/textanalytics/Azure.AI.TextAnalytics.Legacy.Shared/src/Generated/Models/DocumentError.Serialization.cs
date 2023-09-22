// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class DocumentError
    {
        internal static DocumentError DeserializeDocumentError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            TextAnalyticsError error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = TextAnalyticsError.DeserializeTextAnalyticsError(property.Value);
                    continue;
                }
            }
            return new DocumentError(id, error);
        }
    }
}
