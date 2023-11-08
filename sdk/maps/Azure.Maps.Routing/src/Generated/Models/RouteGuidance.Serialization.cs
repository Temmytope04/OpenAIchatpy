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

namespace Azure.Maps.Routing.Models
{
    public partial class RouteGuidance : IUtf8JsonSerializable, IJsonModel<RouteGuidance>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RouteGuidance>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<RouteGuidance>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(Instructions))
                {
                    writer.WritePropertyName("instructions"u8);
                    writer.WriteStartArray();
                    foreach (var item in Instructions)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(InstructionGroups))
                {
                    writer.WritePropertyName("instructionGroups"u8);
                    writer.WriteStartArray();
                    foreach (var item in InstructionGroups)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
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

        RouteGuidance IJsonModel<RouteGuidance>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RouteGuidance)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRouteGuidance(document.RootElement, options);
        }

        internal static RouteGuidance DeserializeRouteGuidance(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<RouteInstruction>> instructions = default;
            Optional<IReadOnlyList<RouteInstructionGroup>> instructionGroups = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instructions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouteInstruction> array = new List<RouteInstruction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteInstruction.DeserializeRouteInstruction(item));
                    }
                    instructions = array;
                    continue;
                }
                if (property.NameEquals("instructionGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouteInstructionGroup> array = new List<RouteInstructionGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteInstructionGroup.DeserializeRouteInstructionGroup(item));
                    }
                    instructionGroups = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RouteGuidance(Optional.ToList(instructions), Optional.ToList(instructionGroups), serializedAdditionalRawData);
        }

        BinaryData IModel<RouteGuidance>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RouteGuidance)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RouteGuidance IModel<RouteGuidance>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RouteGuidance)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRouteGuidance(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<RouteGuidance>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
