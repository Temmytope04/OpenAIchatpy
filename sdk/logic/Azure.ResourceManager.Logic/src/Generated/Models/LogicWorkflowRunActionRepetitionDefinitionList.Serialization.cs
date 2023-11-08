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
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    internal partial class LogicWorkflowRunActionRepetitionDefinitionList : IUtf8JsonSerializable, IJsonModel<LogicWorkflowRunActionRepetitionDefinitionList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicWorkflowRunActionRepetitionDefinitionList>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<LogicWorkflowRunActionRepetitionDefinitionList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        LogicWorkflowRunActionRepetitionDefinitionList IJsonModel<LogicWorkflowRunActionRepetitionDefinitionList>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LogicWorkflowRunActionRepetitionDefinitionList)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicWorkflowRunActionRepetitionDefinitionList(document.RootElement, options);
        }

        internal static LogicWorkflowRunActionRepetitionDefinitionList DeserializeLogicWorkflowRunActionRepetitionDefinitionList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<LogicWorkflowRunActionRepetitionDefinitionData>> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LogicWorkflowRunActionRepetitionDefinitionData> array = new List<LogicWorkflowRunActionRepetitionDefinitionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogicWorkflowRunActionRepetitionDefinitionData.DeserializeLogicWorkflowRunActionRepetitionDefinitionData(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicWorkflowRunActionRepetitionDefinitionList(nextLink.Value, Optional.ToList(value), serializedAdditionalRawData);
        }

        BinaryData IModel<LogicWorkflowRunActionRepetitionDefinitionList>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LogicWorkflowRunActionRepetitionDefinitionList)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        LogicWorkflowRunActionRepetitionDefinitionList IModel<LogicWorkflowRunActionRepetitionDefinitionList>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LogicWorkflowRunActionRepetitionDefinitionList)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeLogicWorkflowRunActionRepetitionDefinitionList(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<LogicWorkflowRunActionRepetitionDefinitionList>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
