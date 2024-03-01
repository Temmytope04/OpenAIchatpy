// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderCspmAwsOfferingMdcContainersImageAssessment : IUtf8JsonSerializable, IJsonModel<DefenderCspmAwsOfferingMdcContainersImageAssessment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderCspmAwsOfferingMdcContainersImageAssessment>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefenderCspmAwsOfferingMdcContainersImageAssessment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOfferingMdcContainersImageAssessment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderCspmAwsOfferingMdcContainersImageAssessment)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (IsEnabled.HasValue)
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (CloudRoleArn != null)
            {
                writer.WritePropertyName("cloudRoleArn"u8);
                writer.WriteStringValue(CloudRoleArn);
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

        DefenderCspmAwsOfferingMdcContainersImageAssessment IJsonModel<DefenderCspmAwsOfferingMdcContainersImageAssessment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOfferingMdcContainersImageAssessment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderCspmAwsOfferingMdcContainersImageAssessment)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderCspmAwsOfferingMdcContainersImageAssessment(document.RootElement, options);
        }

        internal static DefenderCspmAwsOfferingMdcContainersImageAssessment DeserializeDefenderCspmAwsOfferingMdcContainersImageAssessment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enabled = default;
            string cloudRoleArn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cloudRoleArn"u8))
                {
                    cloudRoleArn = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefenderCspmAwsOfferingMdcContainersImageAssessment(enabled, cloudRoleArn, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefenderCspmAwsOfferingMdcContainersImageAssessment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOfferingMdcContainersImageAssessment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderCspmAwsOfferingMdcContainersImageAssessment)} does not support '{options.Format}' format.");
            }
        }

        DefenderCspmAwsOfferingMdcContainersImageAssessment IPersistableModel<DefenderCspmAwsOfferingMdcContainersImageAssessment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOfferingMdcContainersImageAssessment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderCspmAwsOfferingMdcContainersImageAssessment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderCspmAwsOfferingMdcContainersImageAssessment)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderCspmAwsOfferingMdcContainersImageAssessment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
