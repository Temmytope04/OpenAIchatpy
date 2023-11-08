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

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class ChangeThresholdConditionPatch : IUtf8JsonSerializable, IJsonModel<ChangeThresholdConditionPatch>
    {
        void IJsonModel<ChangeThresholdConditionPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ChangePercentage))
            {
                writer.WritePropertyName("changePercentage"u8);
                writer.WriteNumberValue(ChangePercentage.Value);
            }
            if (Optional.IsDefined(ShiftPoint))
            {
                writer.WritePropertyName("shiftPoint"u8);
                writer.WriteNumberValue(ShiftPoint.Value);
            }
            if (Optional.IsDefined(WithinRange))
            {
                writer.WritePropertyName("withinRange"u8);
                writer.WriteBooleanValue(WithinRange.Value);
            }
            if (Optional.IsDefined(AnomalyDetectorDirection))
            {
                writer.WritePropertyName("anomalyDetectorDirection"u8);
                writer.WriteStringValue(AnomalyDetectorDirection.Value.ToString());
            }
            if (Optional.IsDefined(SuppressCondition))
            {
                writer.WritePropertyName("suppressCondition"u8);
                writer.WriteObjectValue(SuppressCondition);
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

        ChangeThresholdConditionPatch IJsonModel<ChangeThresholdConditionPatch>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ChangeThresholdConditionPatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChangeThresholdConditionPatch(document.RootElement, options);
        }

        internal static ChangeThresholdConditionPatch DeserializeChangeThresholdConditionPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<double> changePercentage = default;
            Optional<int> shiftPoint = default;
            Optional<bool> withinRange = default;
            Optional<AnomalyDetectorDirection> anomalyDetectorDirection = default;
            Optional<SuppressConditionPatch> suppressCondition = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("changePercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changePercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("shiftPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shiftPoint = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("withinRange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    withinRange = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("anomalyDetectorDirection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    anomalyDetectorDirection = new AnomalyDetectorDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("suppressCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    suppressCondition = SuppressConditionPatch.DeserializeSuppressConditionPatch(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ChangeThresholdConditionPatch(Optional.ToNullable(changePercentage), Optional.ToNullable(shiftPoint), Optional.ToNullable(withinRange), Optional.ToNullable(anomalyDetectorDirection), suppressCondition.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<ChangeThresholdConditionPatch>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ChangeThresholdConditionPatch)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ChangeThresholdConditionPatch IModel<ChangeThresholdConditionPatch>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ChangeThresholdConditionPatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeChangeThresholdConditionPatch(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ChangeThresholdConditionPatch>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
