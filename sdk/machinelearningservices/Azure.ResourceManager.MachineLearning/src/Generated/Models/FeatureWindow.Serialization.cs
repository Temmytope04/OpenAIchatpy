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
    public partial class FeatureWindow : IUtf8JsonSerializable, IJsonModel<FeatureWindow>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FeatureWindow>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<FeatureWindow>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FeatureWindowEnd))
            {
                if (FeatureWindowEnd != null)
                {
                    writer.WritePropertyName("featureWindowEnd"u8);
                    writer.WriteStringValue(FeatureWindowEnd.Value, "O");
                }
                else
                {
                    writer.WriteNull("featureWindowEnd");
                }
            }
            if (Optional.IsDefined(FeatureWindowStart))
            {
                if (FeatureWindowStart != null)
                {
                    writer.WritePropertyName("featureWindowStart"u8);
                    writer.WriteStringValue(FeatureWindowStart.Value, "O");
                }
                else
                {
                    writer.WriteNull("featureWindowStart");
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

        FeatureWindow IJsonModel<FeatureWindow>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FeatureWindow)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFeatureWindow(document.RootElement, options);
        }

        internal static FeatureWindow DeserializeFeatureWindow(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset?> featureWindowEnd = default;
            Optional<DateTimeOffset?> featureWindowStart = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("featureWindowEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        featureWindowEnd = null;
                        continue;
                    }
                    featureWindowEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("featureWindowStart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        featureWindowStart = null;
                        continue;
                    }
                    featureWindowStart = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FeatureWindow(Optional.ToNullable(featureWindowEnd), Optional.ToNullable(featureWindowStart), serializedAdditionalRawData);
        }

        BinaryData IModel<FeatureWindow>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FeatureWindow)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        FeatureWindow IModel<FeatureWindow>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FeatureWindow)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeFeatureWindow(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<FeatureWindow>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
