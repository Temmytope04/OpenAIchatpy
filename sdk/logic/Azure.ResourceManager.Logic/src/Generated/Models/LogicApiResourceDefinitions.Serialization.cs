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
    public partial class LogicApiResourceDefinitions : IUtf8JsonSerializable, IJsonModel<LogicApiResourceDefinitions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicApiResourceDefinitions>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<LogicApiResourceDefinitions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<LogicApiResourceDefinitions>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<LogicApiResourceDefinitions>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OriginalSwaggerUri))
            {
                writer.WritePropertyName("originalSwaggerUrl"u8);
                writer.WriteStringValue(OriginalSwaggerUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ModifiedSwaggerUri))
            {
                writer.WritePropertyName("modifiedSwaggerUrl"u8);
                writer.WriteStringValue(ModifiedSwaggerUri.AbsoluteUri);
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

        LogicApiResourceDefinitions IJsonModel<LogicApiResourceDefinitions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LogicApiResourceDefinitions)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicApiResourceDefinitions(document.RootElement, options);
        }

        internal static LogicApiResourceDefinitions DeserializeLogicApiResourceDefinitions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> originalSwaggerUrl = default;
            Optional<Uri> modifiedSwaggerUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("originalSwaggerUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    originalSwaggerUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("modifiedSwaggerUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modifiedSwaggerUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicApiResourceDefinitions(originalSwaggerUrl.Value, modifiedSwaggerUrl.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogicApiResourceDefinitions>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LogicApiResourceDefinitions)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        LogicApiResourceDefinitions IPersistableModel<LogicApiResourceDefinitions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LogicApiResourceDefinitions)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeLogicApiResourceDefinitions(document.RootElement, options);
        }

        string IPersistableModel<LogicApiResourceDefinitions>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
