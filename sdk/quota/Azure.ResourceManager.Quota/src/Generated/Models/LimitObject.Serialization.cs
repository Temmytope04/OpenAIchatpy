// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Quota.Models
{
    public partial class LimitObject : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("value");
            writer.WriteNumberValue(Value);
            if (Optional.IsDefined(LimitType))
            {
                writer.WritePropertyName("limitType");
                writer.WriteStringValue(LimitType.Value.ToString());
            }
            writer.WritePropertyName("limitObjectType");
            writer.WriteStringValue(LimitObjectType.ToString());
            writer.WriteEndObject();
        }

        internal static LimitObject DeserializeLimitObject(JsonElement element)
        {
            int value = default;
            Optional<QuotaLimitType> limitType = default;
            LimitType limitObjectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("limitType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    limitType = new QuotaLimitType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("limitObjectType"))
                {
                    limitObjectType = new LimitType(property.Value.GetString());
                    continue;
                }
            }
            return new LimitObject(limitObjectType, value, Optional.ToNullable(limitType));
        }
    }
}
