// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class DeliveryRuleIsDeviceCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("parameters"u8);
            writer.WriteObjectValue(Properties);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name.ToString());
            writer.WriteEndObject();
        }

        internal static DeliveryRuleIsDeviceCondition DeserializeDeliveryRuleIsDeviceCondition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IsDeviceMatchCondition parameters = default;
            MatchVariable name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"u8))
                {
                    parameters = IsDeviceMatchCondition.DeserializeIsDeviceMatchCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = new MatchVariable(property.Value.GetString());
                    continue;
                }
            }
            return new DeliveryRuleIsDeviceCondition(name, parameters);
        }
    }
}
