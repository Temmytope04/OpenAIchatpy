// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class SoftwareUpdateConfigurationTargetProperties : IUtf8JsonSerializable, IJsonModel<SoftwareUpdateConfigurationTargetProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SoftwareUpdateConfigurationTargetProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SoftwareUpdateConfigurationTargetProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationTargetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationTargetProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AzureQueries))
            {
                writer.WritePropertyName("azureQueries"u8);
                writer.WriteStartArray();
                foreach (var item in AzureQueries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NonAzureQueries))
            {
                writer.WritePropertyName("nonAzureQueries"u8);
                writer.WriteStartArray();
                foreach (var item in NonAzureQueries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        SoftwareUpdateConfigurationTargetProperties IJsonModel<SoftwareUpdateConfigurationTargetProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationTargetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationTargetProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSoftwareUpdateConfigurationTargetProperties(document.RootElement, options);
        }

        internal static SoftwareUpdateConfigurationTargetProperties DeserializeSoftwareUpdateConfigurationTargetProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<AzureQueryProperties> azureQueries = default;
            IList<NonAzureQueryProperties> nonAzureQueries = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureQueries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureQueryProperties> array = new List<AzureQueryProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureQueryProperties.DeserializeAzureQueryProperties(item, options));
                    }
                    azureQueries = array;
                    continue;
                }
                if (property.NameEquals("nonAzureQueries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NonAzureQueryProperties> array = new List<NonAzureQueryProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NonAzureQueryProperties.DeserializeNonAzureQueryProperties(item, options));
                    }
                    nonAzureQueries = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SoftwareUpdateConfigurationTargetProperties(azureQueries ?? new ChangeTrackingList<AzureQueryProperties>(), nonAzureQueries ?? new ChangeTrackingList<NonAzureQueryProperties>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SoftwareUpdateConfigurationTargetProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationTargetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationTargetProperties)} does not support '{options.Format}' format.");
            }
        }

        SoftwareUpdateConfigurationTargetProperties IPersistableModel<SoftwareUpdateConfigurationTargetProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationTargetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSoftwareUpdateConfigurationTargetProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationTargetProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SoftwareUpdateConfigurationTargetProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
