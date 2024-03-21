// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class ClusterAvailableVersion : IUtf8JsonSerializable, IJsonModel<ClusterAvailableVersion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterAvailableVersion>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClusterAvailableVersion>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterAvailableVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterAvailableVersion)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(SupportExpiryDate))
            {
                writer.WritePropertyName("supportExpiryDate"u8);
                writer.WriteStringValue(SupportExpiryDate);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetClusterVersion))
            {
                writer.WritePropertyName("targetClusterVersion"u8);
                writer.WriteStringValue(TargetClusterVersion);
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

        ClusterAvailableVersion IJsonModel<ClusterAvailableVersion>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterAvailableVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterAvailableVersion)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterAvailableVersion(document.RootElement, options);
        }

        internal static ClusterAvailableVersion DeserializeClusterAvailableVersion(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string supportExpiryDate = default;
            string targetClusterVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportExpiryDate"u8))
                {
                    supportExpiryDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetClusterVersion"u8))
                {
                    targetClusterVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClusterAvailableVersion(supportExpiryDate, targetClusterVersion, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterAvailableVersion>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterAvailableVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterAvailableVersion)} does not support '{options.Format}' format.");
            }
        }

        ClusterAvailableVersion IPersistableModel<ClusterAvailableVersion>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterAvailableVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterAvailableVersion(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterAvailableVersion)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterAvailableVersion>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
