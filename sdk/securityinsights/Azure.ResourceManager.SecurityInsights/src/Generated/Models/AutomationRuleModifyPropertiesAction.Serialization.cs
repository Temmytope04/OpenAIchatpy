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
    public partial class AutomationRuleModifyPropertiesAction : IUtf8JsonSerializable, IModelJsonSerializable<AutomationRuleModifyPropertiesAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AutomationRuleModifyPropertiesAction>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AutomationRuleModifyPropertiesAction>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AutomationRuleModifyPropertiesAction>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ActionConfiguration))
            {
                writer.WritePropertyName("actionConfiguration"u8);
                writer.WriteObjectValue(ActionConfiguration);
            }
            writer.WritePropertyName("order"u8);
            writer.WriteNumberValue(Order);
            writer.WritePropertyName("actionType"u8);
            writer.WriteStringValue(ActionType.ToString());
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

        internal static AutomationRuleModifyPropertiesAction DeserializeAutomationRuleModifyPropertiesAction(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SecurityInsightsIncidentActionConfiguration> actionConfiguration = default;
            int order = default;
            ActionType actionType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionConfiguration = SecurityInsightsIncidentActionConfiguration.DeserializeSecurityInsightsIncidentActionConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("order"u8))
                {
                    order = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("actionType"u8))
                {
                    actionType = new ActionType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AutomationRuleModifyPropertiesAction(order, actionType, actionConfiguration.Value, rawData);
        }

        AutomationRuleModifyPropertiesAction IModelJsonSerializable<AutomationRuleModifyPropertiesAction>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AutomationRuleModifyPropertiesAction>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationRuleModifyPropertiesAction(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AutomationRuleModifyPropertiesAction>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AutomationRuleModifyPropertiesAction>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AutomationRuleModifyPropertiesAction IModelSerializable<AutomationRuleModifyPropertiesAction>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AutomationRuleModifyPropertiesAction>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAutomationRuleModifyPropertiesAction(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AutomationRuleModifyPropertiesAction model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AutomationRuleModifyPropertiesAction(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAutomationRuleModifyPropertiesAction(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
