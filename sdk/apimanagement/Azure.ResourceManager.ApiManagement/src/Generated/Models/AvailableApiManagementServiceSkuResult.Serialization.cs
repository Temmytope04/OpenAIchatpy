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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class AvailableApiManagementServiceSkuResult : IUtf8JsonSerializable, IJsonModel<AvailableApiManagementServiceSkuResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailableApiManagementServiceSkuResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AvailableApiManagementServiceSkuResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableApiManagementServiceSkuResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailableApiManagementServiceSkuResult)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteObjectValue(Capacity, options);
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

        AvailableApiManagementServiceSkuResult IJsonModel<AvailableApiManagementServiceSkuResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableApiManagementServiceSkuResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailableApiManagementServiceSkuResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailableApiManagementServiceSkuResult(document.RootElement, options);
        }

        internal static AvailableApiManagementServiceSkuResult DeserializeAvailableApiManagementServiceSkuResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceType? resourceType = default;
            ResourceSku sku = default;
            ApiManagementResourceSkuCapacity capacity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ResourceSku.DeserializeResourceSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = ApiManagementResourceSkuCapacity.DeserializeApiManagementResourceSkuCapacity(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AvailableApiManagementServiceSkuResult(resourceType, sku, capacity, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResourceType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  resourceType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ResourceType))
                {
                    builder.Append("  resourceType: ");
                    builder.AppendLine($"'{ResourceType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("SkuName", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sku: ");
                builder.AppendLine("{");
                builder.Append("    name: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(Sku))
                {
                    builder.Append("  sku: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Sku, options, 2, false, "  sku: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Capacity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  capacity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Capacity))
                {
                    builder.Append("  capacity: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Capacity, options, 2, false, "  capacity: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AvailableApiManagementServiceSkuResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableApiManagementServiceSkuResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AvailableApiManagementServiceSkuResult)} does not support writing '{options.Format}' format.");
            }
        }

        AvailableApiManagementServiceSkuResult IPersistableModel<AvailableApiManagementServiceSkuResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableApiManagementServiceSkuResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAvailableApiManagementServiceSkuResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvailableApiManagementServiceSkuResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvailableApiManagementServiceSkuResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
