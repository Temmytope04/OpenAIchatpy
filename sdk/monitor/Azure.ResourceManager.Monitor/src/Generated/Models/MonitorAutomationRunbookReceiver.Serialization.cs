// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorAutomationRunbookReceiver : IUtf8JsonSerializable, IJsonModel<MonitorAutomationRunbookReceiver>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorAutomationRunbookReceiver>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitorAutomationRunbookReceiver>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorAutomationRunbookReceiver>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorAutomationRunbookReceiver)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("automationAccountId"u8);
            writer.WriteStringValue(AutomationAccountId);
            writer.WritePropertyName("runbookName"u8);
            writer.WriteStringValue(RunbookName);
            writer.WritePropertyName("webhookResourceId"u8);
            writer.WriteStringValue(WebhookResourceId);
            writer.WritePropertyName("isGlobalRunbook"u8);
            writer.WriteBooleanValue(IsGlobalRunbook);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ServiceUri))
            {
                writer.WritePropertyName("serviceUri"u8);
                writer.WriteStringValue(ServiceUri.AbsoluteUri);
            }
            if (Optional.IsDefined(UseCommonAlertSchema))
            {
                writer.WritePropertyName("useCommonAlertSchema"u8);
                writer.WriteBooleanValue(UseCommonAlertSchema.Value);
            }
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

        MonitorAutomationRunbookReceiver IJsonModel<MonitorAutomationRunbookReceiver>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorAutomationRunbookReceiver>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorAutomationRunbookReceiver)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorAutomationRunbookReceiver(document.RootElement, options);
        }

        internal static MonitorAutomationRunbookReceiver DeserializeMonitorAutomationRunbookReceiver(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier automationAccountId = default;
            string runbookName = default;
            ResourceIdentifier webhookResourceId = default;
            bool isGlobalRunbook = default;
            string name = default;
            Uri serviceUri = default;
            bool? useCommonAlertSchema = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("automationAccountId"u8))
                {
                    automationAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("runbookName"u8))
                {
                    runbookName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("webhookResourceId"u8))
                {
                    webhookResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isGlobalRunbook"u8))
                {
                    isGlobalRunbook = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useCommonAlertSchema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useCommonAlertSchema = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorAutomationRunbookReceiver(
                automationAccountId,
                runbookName,
                webhookResourceId,
                isGlobalRunbook,
                name,
                serviceUri,
                useCommonAlertSchema,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorAutomationRunbookReceiver>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorAutomationRunbookReceiver>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorAutomationRunbookReceiver)} does not support '{options.Format}' format.");
            }
        }

        MonitorAutomationRunbookReceiver IPersistableModel<MonitorAutomationRunbookReceiver>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorAutomationRunbookReceiver>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorAutomationRunbookReceiver(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorAutomationRunbookReceiver)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorAutomationRunbookReceiver>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
