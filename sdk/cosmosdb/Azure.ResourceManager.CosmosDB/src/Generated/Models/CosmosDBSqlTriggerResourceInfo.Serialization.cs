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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBSqlTriggerResourceInfo : IUtf8JsonSerializable, IJsonModel<CosmosDBSqlTriggerResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBSqlTriggerResourceInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CosmosDBSqlTriggerResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlTriggerResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBSqlTriggerResourceInfo)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(TriggerName);
            if (Optional.IsDefined(Body))
            {
                writer.WritePropertyName("body"u8);
                writer.WriteStringValue(Body);
            }
            if (Optional.IsDefined(TriggerType))
            {
                writer.WritePropertyName("triggerType"u8);
                writer.WriteStringValue(TriggerType.Value.ToString());
            }
            if (Optional.IsDefined(TriggerOperation))
            {
                writer.WritePropertyName("triggerOperation"u8);
                writer.WriteStringValue(TriggerOperation.Value.ToString());
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

        CosmosDBSqlTriggerResourceInfo IJsonModel<CosmosDBSqlTriggerResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlTriggerResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBSqlTriggerResourceInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBSqlTriggerResourceInfo(document.RootElement, options);
        }

        internal static CosmosDBSqlTriggerResourceInfo DeserializeCosmosDBSqlTriggerResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string body = default;
            CosmosDBSqlTriggerType? triggerType = default;
            CosmosDBSqlTriggerOperation? triggerOperation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("body"u8))
                {
                    body = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    triggerType = new CosmosDBSqlTriggerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("triggerOperation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    triggerOperation = new CosmosDBSqlTriggerOperation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CosmosDBSqlTriggerResourceInfo(id, body, triggerType, triggerOperation, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TriggerName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TriggerName))
                {
                    builder.Append("  id: ");
                    if (TriggerName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TriggerName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TriggerName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Body), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  body: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Body))
                {
                    builder.Append("  body: ");
                    if (Body.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Body}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Body}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TriggerType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  triggerType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TriggerType))
                {
                    builder.Append("  triggerType: ");
                    builder.AppendLine($"'{TriggerType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TriggerOperation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  triggerOperation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TriggerOperation))
                {
                    builder.Append("  triggerOperation: ");
                    builder.AppendLine($"'{TriggerOperation.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CosmosDBSqlTriggerResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlTriggerResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBSqlTriggerResourceInfo)} does not support writing '{options.Format}' format.");
            }
        }

        CosmosDBSqlTriggerResourceInfo IPersistableModel<CosmosDBSqlTriggerResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlTriggerResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBSqlTriggerResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBSqlTriggerResourceInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBSqlTriggerResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
