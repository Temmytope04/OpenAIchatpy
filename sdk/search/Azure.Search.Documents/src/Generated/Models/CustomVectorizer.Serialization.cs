// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class CustomVectorizer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CustomWebApiParameters))
            {
                writer.WritePropertyName("customWebApiParameters"u8);
                writer.WriteObjectValue(CustomWebApiParameters);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        internal static CustomVectorizer DeserializeCustomVectorizer(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CustomWebApiParameters customWebApiParameters = default;
            string name = default;
            VectorSearchVectorizerKind kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customWebApiParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customWebApiParameters = CustomWebApiParameters.DeserializeCustomWebApiParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new VectorSearchVectorizerKind(property.Value.GetString());
                    continue;
                }
            }
            return new CustomVectorizer(name, kind, customWebApiParameters);
        }
    }
}
