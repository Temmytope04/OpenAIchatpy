// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppWorkloadProfileStateProperties : IUtf8JsonSerializable, IJsonModel<ContainerAppWorkloadProfileStateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppWorkloadProfileStateProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppWorkloadProfileStateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppWorkloadProfileStateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppWorkloadProfileStateProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (MinimumCount.HasValue)
            {
                writer.WritePropertyName("minimumCount"u8);
                writer.WriteNumberValue(MinimumCount.Value);
            }
            if (MaximumCount.HasValue)
            {
                writer.WritePropertyName("maximumCount"u8);
                writer.WriteNumberValue(MaximumCount.Value);
            }
            if (CurrentCount.HasValue)
            {
                writer.WritePropertyName("currentCount"u8);
                writer.WriteNumberValue(CurrentCount.Value);
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

        ContainerAppWorkloadProfileStateProperties IJsonModel<ContainerAppWorkloadProfileStateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppWorkloadProfileStateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppWorkloadProfileStateProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppWorkloadProfileStateProperties(document.RootElement, options);
        }

        internal static ContainerAppWorkloadProfileStateProperties DeserializeContainerAppWorkloadProfileStateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? minimumCount = default;
            int? maximumCount = default;
            int? currentCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minimumCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimumCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maximumCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximumCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("currentCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppWorkloadProfileStateProperties(minimumCount, maximumCount, currentCount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppWorkloadProfileStateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppWorkloadProfileStateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppWorkloadProfileStateProperties)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppWorkloadProfileStateProperties IPersistableModel<ContainerAppWorkloadProfileStateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppWorkloadProfileStateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppWorkloadProfileStateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppWorkloadProfileStateProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppWorkloadProfileStateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
