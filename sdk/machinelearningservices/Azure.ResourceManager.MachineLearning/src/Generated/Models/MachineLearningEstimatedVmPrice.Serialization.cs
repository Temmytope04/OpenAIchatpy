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
    public partial class MachineLearningEstimatedVmPrice : IUtf8JsonSerializable, IJsonModel<MachineLearningEstimatedVmPrice>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningEstimatedVmPrice>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<MachineLearningEstimatedVmPrice>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("retailPrice"u8);
            writer.WriteNumberValue(RetailPrice);
            writer.WritePropertyName("osType"u8);
            writer.WriteStringValue(OSType.ToString());
            writer.WritePropertyName("vmTier"u8);
            writer.WriteStringValue(VmTier.ToString());
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

        MachineLearningEstimatedVmPrice IJsonModel<MachineLearningEstimatedVmPrice>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningEstimatedVmPrice)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningEstimatedVmPrice(document.RootElement, options);
        }

        internal static MachineLearningEstimatedVmPrice DeserializeMachineLearningEstimatedVmPrice(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double retailPrice = default;
            MachineLearningVmPriceOSType osType = default;
            MachineLearningVmTier vmTier = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("retailPrice"u8))
                {
                    retailPrice = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = new MachineLearningVmPriceOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmTier"u8))
                {
                    vmTier = new MachineLearningVmTier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningEstimatedVmPrice(retailPrice, osType, vmTier, serializedAdditionalRawData);
        }

        BinaryData IModel<MachineLearningEstimatedVmPrice>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningEstimatedVmPrice)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MachineLearningEstimatedVmPrice IModel<MachineLearningEstimatedVmPrice>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningEstimatedVmPrice)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMachineLearningEstimatedVmPrice(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<MachineLearningEstimatedVmPrice>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
