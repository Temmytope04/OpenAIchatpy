// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownLabelingJobMediaProperties))]
    public partial class LabelingJobMediaProperties : IUtf8JsonSerializable, IJsonModel<LabelingJobMediaProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LabelingJobMediaProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<LabelingJobMediaProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<LabelingJobMediaProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<LabelingJobMediaProperties>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("mediaType"u8);
            writer.WriteStringValue(MediaType.ToString());
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

        LabelingJobMediaProperties IJsonModel<LabelingJobMediaProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LabelingJobMediaProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLabelingJobMediaProperties(document.RootElement, options);
        }

        internal static LabelingJobMediaProperties DeserializeLabelingJobMediaProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("mediaType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Image": return LabelingJobImageProperties.DeserializeLabelingJobImageProperties(element);
                    case "Text": return LabelingJobTextProperties.DeserializeLabelingJobTextProperties(element);
                }
            }
            return UnknownLabelingJobMediaProperties.DeserializeUnknownLabelingJobMediaProperties(element);
        }

        BinaryData IPersistableModel<LabelingJobMediaProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LabelingJobMediaProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        LabelingJobMediaProperties IPersistableModel<LabelingJobMediaProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LabelingJobMediaProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeLabelingJobMediaProperties(document.RootElement, options);
        }

        string IPersistableModel<LabelingJobMediaProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
