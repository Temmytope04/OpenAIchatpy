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

namespace Azure.ResourceManager.IotCentral.Models
{
    public partial class IotCentralAppTemplateLocation : IUtf8JsonSerializable, IJsonModel<IotCentralAppTemplateLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotCentralAppTemplateLocation>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<IotCentralAppTemplateLocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<IotCentralAppTemplateLocation>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<IotCentralAppTemplateLocation>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Location))
                {
                    writer.WritePropertyName("id"u8);
                    writer.WriteStringValue(Location.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DisplayName))
                {
                    writer.WritePropertyName("displayName"u8);
                    writer.WriteStringValue(DisplayName);
                }
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

        IotCentralAppTemplateLocation IJsonModel<IotCentralAppTemplateLocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotCentralAppTemplateLocation)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotCentralAppTemplateLocation(document.RootElement, options);
        }

        internal static IotCentralAppTemplateLocation DeserializeIotCentralAppTemplateLocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> id = default;
            Optional<string> displayName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotCentralAppTemplateLocation(Optional.ToNullable(id), displayName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotCentralAppTemplateLocation>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotCentralAppTemplateLocation)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        IotCentralAppTemplateLocation IPersistableModel<IotCentralAppTemplateLocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotCentralAppTemplateLocation)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeIotCentralAppTemplateLocation(document.RootElement, options);
        }

        string IPersistableModel<IotCentralAppTemplateLocation>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
