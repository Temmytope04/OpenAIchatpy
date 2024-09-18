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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PrivateDns.Models;

namespace Azure.ResourceManager.PrivateDns
{
    public partial class PrivateDnsZoneData : IUtf8JsonSerializable, IJsonModel<PrivateDnsZoneData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateDnsZoneData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PrivateDnsZoneData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateDnsZoneData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateDnsZoneData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(MaxNumberOfRecords))
            {
                writer.WritePropertyName("maxNumberOfRecordSets"u8);
                writer.WriteNumberValue(MaxNumberOfRecords.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfRecords))
            {
                writer.WritePropertyName("numberOfRecordSets"u8);
                writer.WriteNumberValue(NumberOfRecords.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxNumberOfVirtualNetworkLinks))
            {
                writer.WritePropertyName("maxNumberOfVirtualNetworkLinks"u8);
                writer.WriteNumberValue(MaxNumberOfVirtualNetworkLinks.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfVirtualNetworkLinks))
            {
                writer.WritePropertyName("numberOfVirtualNetworkLinks"u8);
                writer.WriteNumberValue(NumberOfVirtualNetworkLinks.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxNumberOfVirtualNetworkLinksWithRegistration))
            {
                writer.WritePropertyName("maxNumberOfVirtualNetworkLinksWithRegistration"u8);
                writer.WriteNumberValue(MaxNumberOfVirtualNetworkLinksWithRegistration.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfVirtualNetworkLinksWithRegistration))
            {
                writer.WritePropertyName("numberOfVirtualNetworkLinksWithRegistration"u8);
                writer.WriteNumberValue(NumberOfVirtualNetworkLinksWithRegistration.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PrivateDnsProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(PrivateDnsProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(InternalId))
            {
                writer.WritePropertyName("internalId"u8);
                writer.WriteStringValue(InternalId);
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

        PrivateDnsZoneData IJsonModel<PrivateDnsZoneData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateDnsZoneData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateDnsZoneData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateDnsZoneData(document.RootElement, options);
        }

        internal static PrivateDnsZoneData DeserializePrivateDnsZoneData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            long? maxNumberOfRecordSets = default;
            long? numberOfRecordSets = default;
            long? maxNumberOfVirtualNetworkLinks = default;
            long? numberOfVirtualNetworkLinks = default;
            long? maxNumberOfVirtualNetworkLinksWithRegistration = default;
            long? numberOfVirtualNetworkLinksWithRegistration = default;
            PrivateDnsProvisioningState? privateDnsProvisioningState = default;
            string internalId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("maxNumberOfRecordSets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxNumberOfRecordSets = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("numberOfRecordSets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfRecordSets = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("maxNumberOfVirtualNetworkLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxNumberOfVirtualNetworkLinks = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("numberOfVirtualNetworkLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfVirtualNetworkLinks = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("maxNumberOfVirtualNetworkLinksWithRegistration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxNumberOfVirtualNetworkLinksWithRegistration = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("numberOfVirtualNetworkLinksWithRegistration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfVirtualNetworkLinksWithRegistration = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateDnsProvisioningState = new PrivateDnsProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("internalId"u8))
                        {
                            internalId = property0.Value.GetString();
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
            return new PrivateDnsZoneData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                etag,
                maxNumberOfRecordSets,
                numberOfRecordSets,
                maxNumberOfVirtualNetworkLinks,
                numberOfVirtualNetworkLinks,
                maxNumberOfVirtualNetworkLinksWithRegistration,
                numberOfVirtualNetworkLinksWithRegistration,
                privateDnsProvisioningState,
                internalId,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Location), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  location: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  location: ");
                builder.AppendLine($"'{Location.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Tags), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tags: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Tags))
                {
                    if (Tags.Any())
                    {
                        builder.Append("  tags: ");
                        builder.AppendLine("{");
                        foreach (var item in Tags)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ETag), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  etag: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ETag))
                {
                    builder.Append("  etag: ");
                    builder.AppendLine($"'{ETag.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxNumberOfRecords), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    maxNumberOfRecordSets: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaxNumberOfRecords))
                {
                    builder.Append("    maxNumberOfRecordSets: ");
                    builder.AppendLine($"'{MaxNumberOfRecords.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NumberOfRecords), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    numberOfRecordSets: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NumberOfRecords))
                {
                    builder.Append("    numberOfRecordSets: ");
                    builder.AppendLine($"'{NumberOfRecords.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxNumberOfVirtualNetworkLinks), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    maxNumberOfVirtualNetworkLinks: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaxNumberOfVirtualNetworkLinks))
                {
                    builder.Append("    maxNumberOfVirtualNetworkLinks: ");
                    builder.AppendLine($"'{MaxNumberOfVirtualNetworkLinks.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NumberOfVirtualNetworkLinks), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    numberOfVirtualNetworkLinks: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NumberOfVirtualNetworkLinks))
                {
                    builder.Append("    numberOfVirtualNetworkLinks: ");
                    builder.AppendLine($"'{NumberOfVirtualNetworkLinks.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxNumberOfVirtualNetworkLinksWithRegistration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    maxNumberOfVirtualNetworkLinksWithRegistration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaxNumberOfVirtualNetworkLinksWithRegistration))
                {
                    builder.Append("    maxNumberOfVirtualNetworkLinksWithRegistration: ");
                    builder.AppendLine($"'{MaxNumberOfVirtualNetworkLinksWithRegistration.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NumberOfVirtualNetworkLinksWithRegistration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    numberOfVirtualNetworkLinksWithRegistration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NumberOfVirtualNetworkLinksWithRegistration))
                {
                    builder.Append("    numberOfVirtualNetworkLinksWithRegistration: ");
                    builder.AppendLine($"'{NumberOfVirtualNetworkLinksWithRegistration.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrivateDnsProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PrivateDnsProvisioningState))
                {
                    builder.Append("    provisioningState: ");
                    builder.AppendLine($"'{PrivateDnsProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InternalId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    internalId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(InternalId))
                {
                    builder.Append("    internalId: ");
                    if (InternalId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{InternalId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{InternalId}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<PrivateDnsZoneData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateDnsZoneData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PrivateDnsZoneData)} does not support writing '{options.Format}' format.");
            }
        }

        PrivateDnsZoneData IPersistableModel<PrivateDnsZoneData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateDnsZoneData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateDnsZoneData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateDnsZoneData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateDnsZoneData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
