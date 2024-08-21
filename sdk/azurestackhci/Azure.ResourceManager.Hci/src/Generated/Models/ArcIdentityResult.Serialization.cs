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

namespace Azure.ResourceManager.Hci.Models
{
    public partial class ArcIdentityResult : IUtf8JsonSerializable, IJsonModel<ArcIdentityResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArcIdentityResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ArcIdentityResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcIdentityResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArcIdentityResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ArcApplicationClientId))
            {
                writer.WritePropertyName("arcApplicationClientId"u8);
                writer.WriteStringValue(ArcApplicationClientId.Value);
            }
            if (Optional.IsDefined(ArcApplicationTenantId))
            {
                writer.WritePropertyName("arcApplicationTenantId"u8);
                writer.WriteStringValue(ArcApplicationTenantId.Value);
            }
            if (Optional.IsDefined(ArcServicePrincipalObjectId))
            {
                writer.WritePropertyName("arcServicePrincipalObjectId"u8);
                writer.WriteStringValue(ArcServicePrincipalObjectId.Value);
            }
            if (Optional.IsDefined(ArcApplicationObjectId))
            {
                writer.WritePropertyName("arcApplicationObjectId"u8);
                writer.WriteStringValue(ArcApplicationObjectId.Value);
            }
            writer.WriteEndObject();
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

        ArcIdentityResult IJsonModel<ArcIdentityResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcIdentityResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArcIdentityResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArcIdentityResult(document.RootElement, options);
        }

        internal static ArcIdentityResult DeserializeArcIdentityResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? arcApplicationClientId = default;
            Guid? arcApplicationTenantId = default;
            Guid? arcServicePrincipalObjectId = default;
            Guid? arcApplicationObjectId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("arcApplicationClientId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            arcApplicationClientId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("arcApplicationTenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            arcApplicationTenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("arcServicePrincipalObjectId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            arcServicePrincipalObjectId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("arcApplicationObjectId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            arcApplicationObjectId = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ArcIdentityResult(arcApplicationClientId, arcApplicationTenantId, arcServicePrincipalObjectId, arcApplicationObjectId, serializedAdditionalRawData);
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

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ArcApplicationClientId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    arcApplicationClientId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ArcApplicationClientId))
                {
                    builder.Append("    arcApplicationClientId: ");
                    builder.AppendLine($"'{ArcApplicationClientId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ArcApplicationTenantId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    arcApplicationTenantId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ArcApplicationTenantId))
                {
                    builder.Append("    arcApplicationTenantId: ");
                    builder.AppendLine($"'{ArcApplicationTenantId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ArcServicePrincipalObjectId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    arcServicePrincipalObjectId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ArcServicePrincipalObjectId))
                {
                    builder.Append("    arcServicePrincipalObjectId: ");
                    builder.AppendLine($"'{ArcServicePrincipalObjectId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ArcApplicationObjectId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    arcApplicationObjectId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ArcApplicationObjectId))
                {
                    builder.Append("    arcApplicationObjectId: ");
                    builder.AppendLine($"'{ArcApplicationObjectId.Value.ToString()}'");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ArcIdentityResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcIdentityResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ArcIdentityResult)} does not support writing '{options.Format}' format.");
            }
        }

        ArcIdentityResult IPersistableModel<ArcIdentityResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcIdentityResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArcIdentityResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArcIdentityResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArcIdentityResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
