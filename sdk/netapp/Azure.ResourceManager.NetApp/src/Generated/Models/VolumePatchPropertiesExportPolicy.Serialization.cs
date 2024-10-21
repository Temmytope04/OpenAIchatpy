// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    internal partial class VolumePatchPropertiesExportPolicy : IUtf8JsonSerializable, IJsonModel<VolumePatchPropertiesExportPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VolumePatchPropertiesExportPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VolumePatchPropertiesExportPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumePatchPropertiesExportPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VolumePatchPropertiesExportPolicy)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules"u8);
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    writer.WriteObjectValue(item, options);
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
        }

        VolumePatchPropertiesExportPolicy IJsonModel<VolumePatchPropertiesExportPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumePatchPropertiesExportPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VolumePatchPropertiesExportPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVolumePatchPropertiesExportPolicy(document.RootElement, options);
        }

        internal static VolumePatchPropertiesExportPolicy DeserializeVolumePatchPropertiesExportPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<NetAppVolumeExportPolicyRule> rules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetAppVolumeExportPolicyRule> array = new List<NetAppVolumeExportPolicyRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetAppVolumeExportPolicyRule.DeserializeNetAppVolumeExportPolicyRule(item, options));
                    }
                    rules = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VolumePatchPropertiesExportPolicy(rules ?? new ChangeTrackingList<NetAppVolumeExportPolicyRule>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VolumePatchPropertiesExportPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumePatchPropertiesExportPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VolumePatchPropertiesExportPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        VolumePatchPropertiesExportPolicy IPersistableModel<VolumePatchPropertiesExportPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumePatchPropertiesExportPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVolumePatchPropertiesExportPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VolumePatchPropertiesExportPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VolumePatchPropertiesExportPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
