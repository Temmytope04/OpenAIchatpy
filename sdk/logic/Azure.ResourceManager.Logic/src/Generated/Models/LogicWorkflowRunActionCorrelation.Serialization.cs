// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicWorkflowRunActionCorrelation : IUtf8JsonSerializable, IJsonModel<LogicWorkflowRunActionCorrelation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicWorkflowRunActionCorrelation>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<LogicWorkflowRunActionCorrelation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<LogicWorkflowRunActionCorrelation>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<LogicWorkflowRunActionCorrelation>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ActionTrackingId))
            {
                writer.WritePropertyName("actionTrackingId"u8);
                writer.WriteStringValue(ActionTrackingId.Value);
            }
            if (Optional.IsDefined(ClientTrackingId))
            {
                writer.WritePropertyName("clientTrackingId"u8);
                writer.WriteStringValue(ClientTrackingId);
            }
            if (Optional.IsCollectionDefined(ClientKeywords))
            {
                writer.WritePropertyName("clientKeywords"u8);
                writer.WriteStartArray();
                foreach (var item in ClientKeywords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        LogicWorkflowRunActionCorrelation IJsonModel<LogicWorkflowRunActionCorrelation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LogicWorkflowRunActionCorrelation)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicWorkflowRunActionCorrelation(document.RootElement, options);
        }

        internal static LogicWorkflowRunActionCorrelation DeserializeLogicWorkflowRunActionCorrelation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> actionTrackingId = default;
            Optional<string> clientTrackingId = default;
            Optional<IList<string>> clientKeywords = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionTrackingId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionTrackingId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("clientTrackingId"u8))
                {
                    clientTrackingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientKeywords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    clientKeywords = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicWorkflowRunActionCorrelation(clientTrackingId.Value, Optional.ToList(clientKeywords), serializedAdditionalRawData, Optional.ToNullable(actionTrackingId));
        }

        BinaryData IPersistableModel<LogicWorkflowRunActionCorrelation>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LogicWorkflowRunActionCorrelation)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        LogicWorkflowRunActionCorrelation IPersistableModel<LogicWorkflowRunActionCorrelation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LogicWorkflowRunActionCorrelation)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeLogicWorkflowRunActionCorrelation(document.RootElement, options);
        }

        string IPersistableModel<LogicWorkflowRunActionCorrelation>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
