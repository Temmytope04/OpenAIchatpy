// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    internal partial class UnknownClusterPoolAvailableUpgradeProperties : IUtf8JsonSerializable, IJsonModel<ClusterPoolAvailableUpgradeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterPoolAvailableUpgradeProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterPoolAvailableUpgradeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolAvailableUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterPoolAvailableUpgradeProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("upgradeType"u8);
            writer.WriteStringValue(UpgradeType.ToString());
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

        ClusterPoolAvailableUpgradeProperties IJsonModel<ClusterPoolAvailableUpgradeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolAvailableUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterPoolAvailableUpgradeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterPoolAvailableUpgradeProperties(document.RootElement, options);
        }

        internal static UnknownClusterPoolAvailableUpgradeProperties DeserializeUnknownClusterPoolAvailableUpgradeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ClusterPoolAvailableUpgradeType upgradeType = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("upgradeType"u8))
                {
                    upgradeType = new ClusterPoolAvailableUpgradeType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownClusterPoolAvailableUpgradeProperties(upgradeType, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpgradeType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  upgradeType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  upgradeType: ");
                builder.AppendLine($"'{UpgradeType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ClusterPoolAvailableUpgradeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolAvailableUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ClusterPoolAvailableUpgradeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterPoolAvailableUpgradeProperties IPersistableModel<ClusterPoolAvailableUpgradeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolAvailableUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterPoolAvailableUpgradeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterPoolAvailableUpgradeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterPoolAvailableUpgradeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
