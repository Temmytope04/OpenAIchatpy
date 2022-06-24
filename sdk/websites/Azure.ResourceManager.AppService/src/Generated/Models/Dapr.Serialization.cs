// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class Dapr : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(AppId))
            {
                writer.WritePropertyName("appId");
                writer.WriteStringValue(AppId);
            }
            if (Optional.IsDefined(AppPort))
            {
                writer.WritePropertyName("appPort");
                writer.WriteNumberValue(AppPort.Value);
            }
            if (Optional.IsCollectionDefined(Components))
            {
                writer.WritePropertyName("components");
                writer.WriteStartArray();
                foreach (var item in Components)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static Dapr DeserializeDapr(JsonElement element)
        {
            Optional<bool> enabled = default;
            Optional<string> appId = default;
            Optional<int> appPort = default;
            Optional<IList<DaprComponent>> components = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("appId"))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appPort"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    appPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("components"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DaprComponent> array = new List<DaprComponent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DaprComponent.DeserializeDaprComponent(item));
                    }
                    components = array;
                    continue;
                }
            }
            return new Dapr(Optional.ToNullable(enabled), appId.Value, Optional.ToNullable(appPort), Optional.ToList(components));
        }
    }
}
