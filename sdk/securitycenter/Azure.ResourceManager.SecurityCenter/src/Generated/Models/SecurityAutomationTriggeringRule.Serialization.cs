// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityAutomationTriggeringRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PropertyJPath))
            {
                writer.WritePropertyName("propertyJPath"u8);
                writer.WriteStringValue(PropertyJPath);
            }
            if (Optional.IsDefined(PropertyType))
            {
                writer.WritePropertyName("propertyType"u8);
                writer.WriteStringValue(PropertyType.Value.ToString());
            }
            if (Optional.IsDefined(ExpectedValue))
            {
                writer.WritePropertyName("expectedValue"u8);
                writer.WriteStringValue(ExpectedValue);
            }
            if (Optional.IsDefined(Operator))
            {
                writer.WritePropertyName("operator"u8);
                writer.WriteStringValue(Operator.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static SecurityAutomationTriggeringRule DeserializeSecurityAutomationTriggeringRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> propertyJPath = default;
            Optional<AutomationTriggeringRulePropertyType> propertyType = default;
            Optional<string> expectedValue = default;
            Optional<AutomationTriggeringRuleOperator> @operator = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("propertyJPath"u8))
                {
                    propertyJPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("propertyType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    propertyType = new AutomationTriggeringRulePropertyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expectedValue"u8))
                {
                    expectedValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @operator = new AutomationTriggeringRuleOperator(property.Value.GetString());
                    continue;
                }
            }
            return new SecurityAutomationTriggeringRule(propertyJPath.Value, Optional.ToNullable(propertyType), expectedValue.Value, Optional.ToNullable(@operator));
        }
    }
}
