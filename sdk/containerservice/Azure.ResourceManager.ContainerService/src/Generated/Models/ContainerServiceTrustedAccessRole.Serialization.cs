// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceTrustedAccessRole : IUtf8JsonSerializable, IJsonModel<ContainerServiceTrustedAccessRole>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceTrustedAccessRole>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerServiceTrustedAccessRole>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceTrustedAccessRole>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceTrustedAccessRole)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(SourceResourceType))
            {
                writer.WritePropertyName("sourceResourceType"u8);
                writer.WriteStringValue(SourceResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Rules))
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
            writer.WriteEndObject();
        }

        ContainerServiceTrustedAccessRole IJsonModel<ContainerServiceTrustedAccessRole>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceTrustedAccessRole>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceTrustedAccessRole)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceTrustedAccessRole(document.RootElement, options);
        }

        internal static ContainerServiceTrustedAccessRole DeserializeContainerServiceTrustedAccessRole(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceResourceType = default;
            string name = default;
            IReadOnlyList<ContainerServiceTrustedAccessRoleRule> rules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceResourceType"u8))
                {
                    sourceResourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerServiceTrustedAccessRoleRule> array = new List<ContainerServiceTrustedAccessRoleRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerServiceTrustedAccessRoleRule.DeserializeContainerServiceTrustedAccessRoleRule(item, options));
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
            return new ContainerServiceTrustedAccessRole(sourceResourceType, name, rules ?? new ChangeTrackingList<ContainerServiceTrustedAccessRoleRule>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourceResourceType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sourceResourceType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SourceResourceType))
                {
                    builder.Append("  sourceResourceType: ");
                    if (SourceResourceType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SourceResourceType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SourceResourceType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Rules), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  rules: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Rules))
                {
                    if (Rules.Any())
                    {
                        builder.Append("  rules: ");
                        builder.AppendLine("[");
                        foreach (var item in Rules)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  rules: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerServiceTrustedAccessRole>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceTrustedAccessRole>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceTrustedAccessRole)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerServiceTrustedAccessRole IPersistableModel<ContainerServiceTrustedAccessRole>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceTrustedAccessRole>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerServiceTrustedAccessRole(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceTrustedAccessRole)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceTrustedAccessRole>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
