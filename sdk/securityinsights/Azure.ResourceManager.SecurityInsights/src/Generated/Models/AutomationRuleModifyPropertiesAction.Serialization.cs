// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class AutomationRuleModifyPropertiesAction : IUtf8JsonSerializable, IJsonModel<AutomationRuleModifyPropertiesAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationRuleModifyPropertiesAction>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AutomationRuleModifyPropertiesAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRuleModifyPropertiesAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationRuleModifyPropertiesAction)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ActionConfiguration))
            {
                writer.WritePropertyName("actionConfiguration"u8);
                writer.WriteObjectValue(ActionConfiguration, options);
            }
            writer.WritePropertyName("order"u8);
            writer.WriteNumberValue(Order);
            writer.WritePropertyName("actionType"u8);
            writer.WriteStringValue(ActionType.ToString());
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        AutomationRuleModifyPropertiesAction IJsonModel<AutomationRuleModifyPropertiesAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRuleModifyPropertiesAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationRuleModifyPropertiesAction)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationRuleModifyPropertiesAction(document.RootElement, options);
        }

        internal static AutomationRuleModifyPropertiesAction DeserializeAutomationRuleModifyPropertiesAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SecurityInsightsIncidentActionConfiguration actionConfiguration = default;
            int order = default;
            ActionType actionType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionConfiguration = SecurityInsightsIncidentActionConfiguration.DeserializeSecurityInsightsIncidentActionConfiguration(property.Value, options);
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
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AutomationRuleModifyPropertiesAction(order, actionType, serializedAdditionalRawData, actionConfiguration);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ActionConfiguration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  actionConfiguration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ActionConfiguration))
                {
                    builder.Append("  actionConfiguration: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ActionConfiguration, options, 2, false, "  actionConfiguration: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Order), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  order: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  order: ");
                builder.AppendLine($"{Order}");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ActionType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  actionType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  actionType: ");
                builder.AppendLine($"'{ActionType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AutomationRuleModifyPropertiesAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRuleModifyPropertiesAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AutomationRuleModifyPropertiesAction)} does not support writing '{options.Format}' format.");
            }
        }

        AutomationRuleModifyPropertiesAction IPersistableModel<AutomationRuleModifyPropertiesAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRuleModifyPropertiesAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutomationRuleModifyPropertiesAction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomationRuleModifyPropertiesAction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationRuleModifyPropertiesAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
