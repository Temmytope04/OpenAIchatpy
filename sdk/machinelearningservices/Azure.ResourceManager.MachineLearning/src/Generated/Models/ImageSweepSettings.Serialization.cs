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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ImageSweepSettings : IUtf8JsonSerializable, IJsonModel<ImageSweepSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageSweepSettings>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ImageSweepSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ImageSweepSettings>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ImageSweepSettings>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EarlyTermination))
            {
                if (EarlyTermination != null)
                {
                    writer.WritePropertyName("earlyTermination"u8);
                    writer.WriteObjectValue(EarlyTermination);
                }
                else
                {
                    writer.WriteNull("earlyTermination");
                }
            }
            writer.WritePropertyName("samplingAlgorithm"u8);
            writer.WriteStringValue(SamplingAlgorithm.ToString());
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

        ImageSweepSettings IJsonModel<ImageSweepSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ImageSweepSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageSweepSettings(document.RootElement, options);
        }

        internal static ImageSweepSettings DeserializeImageSweepSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningEarlyTerminationPolicy> earlyTermination = default;
            SamplingAlgorithmType samplingAlgorithm = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("earlyTermination"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyTermination = null;
                        continue;
                    }
                    earlyTermination = MachineLearningEarlyTerminationPolicy.DeserializeMachineLearningEarlyTerminationPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("samplingAlgorithm"u8))
                {
                    samplingAlgorithm = new SamplingAlgorithmType(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImageSweepSettings(earlyTermination.Value, samplingAlgorithm, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImageSweepSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ImageSweepSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ImageSweepSettings IPersistableModel<ImageSweepSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ImageSweepSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeImageSweepSettings(document.RootElement, options);
        }

        string IPersistableModel<ImageSweepSettings>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
