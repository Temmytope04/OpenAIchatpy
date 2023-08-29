// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsPropertyArrayChangedConditionProperties : IUtf8JsonSerializable, IModelJsonSerializable<SecurityInsightsPropertyArrayChangedConditionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityInsightsPropertyArrayChangedConditionProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityInsightsPropertyArrayChangedConditionProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityInsightsPropertyArrayChangedConditionProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ConditionProperties))
            {
                writer.WritePropertyName("conditionProperties"u8);
                writer.WriteObjectValue(ConditionProperties);
            }
            writer.WritePropertyName("conditionType"u8);
            writer.WriteStringValue(ConditionType.ToString());
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static SecurityInsightsPropertyArrayChangedConditionProperties DeserializeSecurityInsightsPropertyArrayChangedConditionProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AutomationRulePropertyArrayChangedValuesCondition> conditionProperties = default;
            ConditionType conditionType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("conditionProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conditionProperties = AutomationRulePropertyArrayChangedValuesCondition.DeserializeAutomationRulePropertyArrayChangedValuesCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("conditionType"u8))
                {
                    conditionType = new ConditionType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SecurityInsightsPropertyArrayChangedConditionProperties(conditionType, conditionProperties.Value, rawData);
        }

        SecurityInsightsPropertyArrayChangedConditionProperties IModelJsonSerializable<SecurityInsightsPropertyArrayChangedConditionProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityInsightsPropertyArrayChangedConditionProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsPropertyArrayChangedConditionProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityInsightsPropertyArrayChangedConditionProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityInsightsPropertyArrayChangedConditionProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityInsightsPropertyArrayChangedConditionProperties IModelSerializable<SecurityInsightsPropertyArrayChangedConditionProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityInsightsPropertyArrayChangedConditionProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityInsightsPropertyArrayChangedConditionProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SecurityInsightsPropertyArrayChangedConditionProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SecurityInsightsPropertyArrayChangedConditionProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecurityInsightsPropertyArrayChangedConditionProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
