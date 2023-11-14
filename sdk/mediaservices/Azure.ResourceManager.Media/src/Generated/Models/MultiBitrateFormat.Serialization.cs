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

namespace Azure.ResourceManager.Media.Models
{
    public partial class MultiBitrateFormat : IUtf8JsonSerializable, IJsonModel<MultiBitrateFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MultiBitrateFormat>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MultiBitrateFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MultiBitrateFormat>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MultiBitrateFormat>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(OutputFiles))
            {
                writer.WritePropertyName("outputFiles"u8);
                writer.WriteStartArray();
                foreach (var item in OutputFiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("filenamePattern"u8);
            writer.WriteStringValue(FilenamePattern);
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

        MultiBitrateFormat IJsonModel<MultiBitrateFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MultiBitrateFormat)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMultiBitrateFormat(document.RootElement, options);
        }

        internal static MultiBitrateFormat DeserializeMultiBitrateFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.Mp4Format": return Mp4Format.DeserializeMp4Format(element);
                    case "#Microsoft.Media.TransportStreamFormat": return TransportStreamFormat.DeserializeTransportStreamFormat(element);
                }
            }
            Optional<IList<MediaOutputFile>> outputFiles = default;
            string odataType = "#Microsoft.Media.MultiBitrateFormat";
            string filenamePattern = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("outputFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaOutputFile> array = new List<MediaOutputFile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaOutputFile.DeserializeMediaOutputFile(item));
                    }
                    outputFiles = array;
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filenamePattern"u8))
                {
                    filenamePattern = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MultiBitrateFormat(odataType, filenamePattern, serializedAdditionalRawData, Optional.ToList(outputFiles));
        }

        BinaryData IPersistableModel<MultiBitrateFormat>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MultiBitrateFormat)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MultiBitrateFormat IPersistableModel<MultiBitrateFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MultiBitrateFormat)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMultiBitrateFormat(document.RootElement, options);
        }

        string IPersistableModel<MultiBitrateFormat>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
