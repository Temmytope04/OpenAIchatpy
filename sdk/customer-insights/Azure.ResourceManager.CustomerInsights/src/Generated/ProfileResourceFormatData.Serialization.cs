// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    public partial class ProfileResourceFormatData : IUtf8JsonSerializable, IJsonModel<ProfileResourceFormatData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProfileResourceFormatData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProfileResourceFormatData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProfileResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProfileResourceFormatData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (!(Attributes is ChangeTrackingDictionary<string, IList<string>> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("attributes"u8);
                writer.WriteStartObject();
                foreach (var item in Attributes)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item.Value)
                    {
                        writer.WriteStringValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndObject();
            }
            if (!(Description is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStartObject();
                foreach (var item in Description)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(DisplayName is ChangeTrackingDictionary<string, string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStartObject();
                foreach (var item in DisplayName)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(LocalizedAttributes is ChangeTrackingDictionary<string, IDictionary<string, string>> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("localizedAttributes"u8);
                writer.WriteStartObject();
                foreach (var item in LocalizedAttributes)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartObject();
                    foreach (var item0 in item.Value)
                    {
                        writer.WritePropertyName(item0.Key);
                        writer.WriteStringValue(item0.Value);
                    }
                    writer.WriteEndObject();
                }
                writer.WriteEndObject();
            }
            if (SmallImage != null)
            {
                writer.WritePropertyName("smallImage"u8);
                writer.WriteStringValue(SmallImage);
            }
            if (MediumImage != null)
            {
                writer.WritePropertyName("mediumImage"u8);
                writer.WriteStringValue(MediumImage);
            }
            if (LargeImage != null)
            {
                writer.WritePropertyName("largeImage"u8);
                writer.WriteStringValue(LargeImage);
            }
            if (ApiEntitySetName != null)
            {
                writer.WritePropertyName("apiEntitySetName"u8);
                writer.WriteStringValue(ApiEntitySetName);
            }
            if (EntityType.HasValue)
            {
                writer.WritePropertyName("entityType"u8);
                writer.WriteStringValue(EntityType.Value.ToSerialString());
            }
            if (!(Fields is ChangeTrackingList<PropertyDefinition> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("fields"u8);
                writer.WriteStartArray();
                foreach (var item in Fields)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (InstancesCount.HasValue)
            {
                writer.WritePropertyName("instancesCount"u8);
                writer.WriteNumberValue(InstancesCount.Value);
            }
            if (options.Format != "W" && LastChangedUtc.HasValue)
            {
                writer.WritePropertyName("lastChangedUtc"u8);
                writer.WriteStringValue(LastChangedUtc.Value, "O");
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (SchemaItemTypeLink != null)
            {
                writer.WritePropertyName("schemaItemTypeLink"u8);
                writer.WriteStringValue(SchemaItemTypeLink);
            }
            if (options.Format != "W" && TenantId.HasValue)
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (TimestampFieldName != null)
            {
                writer.WritePropertyName("timestampFieldName"u8);
                writer.WriteStringValue(TimestampFieldName);
            }
            if (TypeName != null)
            {
                writer.WritePropertyName("typeName"u8);
                writer.WriteStringValue(TypeName);
            }
            if (!(StrongIds is ChangeTrackingList<StrongId> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("strongIds"u8);
                writer.WriteStartArray();
                foreach (var item in StrongIds)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ProfileResourceFormatData IJsonModel<ProfileResourceFormatData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProfileResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProfileResourceFormatData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProfileResourceFormatData(document.RootElement, options);
        }

        internal static ProfileResourceFormatData DeserializeProfileResourceFormatData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IDictionary<string, IList<string>> attributes = default;
            IDictionary<string, string> description = default;
            IDictionary<string, string> displayName = default;
            IDictionary<string, IDictionary<string, string>> localizedAttributes = default;
            string smallImage = default;
            string mediumImage = default;
            string largeImage = default;
            string apiEntitySetName = default;
            EntityType? entityType = default;
            IList<PropertyDefinition> fields = default;
            int? instancesCount = default;
            DateTimeOffset? lastChangedUtc = default;
            ProvisioningState? provisioningState = default;
            string schemaItemTypeLink = default;
            Guid? tenantId = default;
            string timestampFieldName = default;
            string typeName = default;
            IList<StrongId> strongIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("attributes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    List<string> array = new List<string>();
                                    foreach (var item in property1.Value.EnumerateArray())
                                    {
                                        array.Add(item.GetString());
                                    }
                                    dictionary.Add(property1.Name, array);
                                }
                            }
                            attributes = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            description = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            displayName = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("localizedAttributes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, IDictionary<string, string>> dictionary = new Dictionary<string, IDictionary<string, string>>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    Dictionary<string, string> dictionary0 = new Dictionary<string, string>();
                                    foreach (var property2 in property1.Value.EnumerateObject())
                                    {
                                        dictionary0.Add(property2.Name, property2.Value.GetString());
                                    }
                                    dictionary.Add(property1.Name, dictionary0);
                                }
                            }
                            localizedAttributes = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("smallImage"u8))
                        {
                            smallImage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("mediumImage"u8))
                        {
                            mediumImage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("largeImage"u8))
                        {
                            largeImage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiEntitySetName"u8))
                        {
                            apiEntitySetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("entityType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            entityType = property0.Value.GetString().ToEntityType();
                            continue;
                        }
                        if (property0.NameEquals("fields"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PropertyDefinition> array = new List<PropertyDefinition>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PropertyDefinition.DeserializePropertyDefinition(item, options));
                            }
                            fields = array;
                            continue;
                        }
                        if (property0.NameEquals("instancesCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instancesCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("lastChangedUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastChangedUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("schemaItemTypeLink"u8))
                        {
                            schemaItemTypeLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("timestampFieldName"u8))
                        {
                            timestampFieldName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("typeName"u8))
                        {
                            typeName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("strongIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StrongId> array = new List<StrongId>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StrongId.DeserializeStrongId(item, options));
                            }
                            strongIds = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProfileResourceFormatData(
                id,
                name,
                type,
                systemData,
                attributes ?? new ChangeTrackingDictionary<string, IList<string>>(),
                description ?? new ChangeTrackingDictionary<string, string>(),
                displayName ?? new ChangeTrackingDictionary<string, string>(),
                localizedAttributes ?? new ChangeTrackingDictionary<string, IDictionary<string, string>>(),
                smallImage,
                mediumImage,
                largeImage,
                apiEntitySetName,
                entityType,
                fields ?? new ChangeTrackingList<PropertyDefinition>(),
                instancesCount,
                lastChangedUtc,
                provisioningState,
                schemaItemTypeLink,
                tenantId,
                timestampFieldName,
                typeName,
                strongIds ?? new ChangeTrackingList<StrongId>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProfileResourceFormatData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProfileResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProfileResourceFormatData)} does not support '{options.Format}' format.");
            }
        }

        ProfileResourceFormatData IPersistableModel<ProfileResourceFormatData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProfileResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProfileResourceFormatData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProfileResourceFormatData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProfileResourceFormatData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
