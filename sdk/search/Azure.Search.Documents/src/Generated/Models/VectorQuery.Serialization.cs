// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class VectorQuery : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(KNearestNeighborsCount))
            {
                writer.WritePropertyName("k"u8);
                writer.WriteNumberValue(KNearestNeighborsCount.Value);
            }
            if (Optional.IsDefined(FieldsRaw))
            {
                writer.WritePropertyName("fields"u8);
                writer.WriteStringValue(FieldsRaw);
            }
            if (Optional.IsDefined(Exhaustive))
            {
                writer.WritePropertyName("exhaustive"u8);
                writer.WriteBooleanValue(Exhaustive.Value);
            }
            writer.WriteEndObject();
        }

        internal static VectorQuery DeserializeVectorQuery(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "vector": return VectorizedQuery.DeserializeVectorizedQuery(element);
                }
            }
            return UnknownVectorQuery.DeserializeUnknownVectorQuery(element);
        }
    }
}
