// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class TypedErrorInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(TypedErrorInfoType);
            writer.WriteEndObject();
        }

        internal static TypedErrorInfo DeserializeTypedErrorInfo(JsonElement element)
        {
            string type = default;
            Optional<BinaryData> info = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("info"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    info = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new TypedErrorInfo(type, info.Value);
        }
    }
}
