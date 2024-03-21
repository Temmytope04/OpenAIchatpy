// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.DataMap
{
    public partial class AtlasClassification : IUtf8JsonSerializable, IJsonModel<AtlasClassification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AtlasClassification>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AtlasClassification>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasClassification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasClassification)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Attributes))
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
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(TypeName))
            {
                writer.WritePropertyName("typeName"u8);
                writer.WriteStringValue(TypeName);
            }
            if (Optional.IsDefined(LastModifiedTS))
            {
                writer.WritePropertyName("lastModifiedTS"u8);
                writer.WriteStringValue(LastModifiedTS);
            }
            if (Optional.IsDefined(EntityGuid))
            {
                writer.WritePropertyName("entityGuid"u8);
                writer.WriteStringValue(EntityGuid);
            }
            if (Optional.IsDefined(EntityStatus))
            {
                writer.WritePropertyName("entityStatus"u8);
                writer.WriteStringValue(EntityStatus.Value.ToString());
            }
            if (Optional.IsDefined(RemovePropagationsOnEntityDelete))
            {
                writer.WritePropertyName("removePropagationsOnEntityDelete"u8);
                writer.WriteBooleanValue(RemovePropagationsOnEntityDelete.Value);
            }
            if (Optional.IsCollectionDefined(ValidityPeriods))
            {
                writer.WritePropertyName("validityPeriods"u8);
                writer.WriteStartArray();
                foreach (var item in ValidityPeriods)
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

        AtlasClassification IJsonModel<AtlasClassification>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasClassification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasClassification)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAtlasClassification(document.RootElement, options);
        }

        internal static AtlasClassification DeserializeAtlasClassification(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, BinaryData> attributes = default;
            string typeName = default;
            string lastModifiedTS = default;
            string entityGuid = default;
            EntityStatus? entityStatus = default;
            bool? removePropagationsOnEntityDelete = default;
            IList<TimeBoundary> validityPeriods = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("attributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    attributes = dictionary;
                    continue;
                }
                if (property.NameEquals("typeName"u8))
                {
                    typeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastModifiedTS"u8))
                {
                    lastModifiedTS = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entityGuid"u8))
                {
                    entityGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entityStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    entityStatus = new EntityStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("removePropagationsOnEntityDelete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    removePropagationsOnEntityDelete = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("validityPeriods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TimeBoundary> array = new List<TimeBoundary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeBoundary.DeserializeTimeBoundary(item, options));
                    }
                    validityPeriods = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AtlasClassification(
                attributes ?? new ChangeTrackingDictionary<string, BinaryData>(),
                typeName,
                lastModifiedTS,
                entityGuid,
                entityStatus,
                removePropagationsOnEntityDelete,
                validityPeriods ?? new ChangeTrackingList<TimeBoundary>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AtlasClassification>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasClassification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AtlasClassification)} does not support '{options.Format}' format.");
            }
        }

        AtlasClassification IPersistableModel<AtlasClassification>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasClassification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAtlasClassification(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AtlasClassification)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AtlasClassification>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AtlasClassification FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAtlasClassification(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
