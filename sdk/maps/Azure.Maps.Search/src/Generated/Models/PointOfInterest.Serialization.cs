// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    public partial class PointOfInterest : IUtf8JsonSerializable, IJsonModel<PointOfInterest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PointOfInterest>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<PointOfInterest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Name))
                {
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(Name);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Phone))
                {
                    writer.WritePropertyName("phone"u8);
                    writer.WriteStringValue(Phone);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(UrlInternal))
                {
                    writer.WritePropertyName("url"u8);
                    writer.WriteStringValue(UrlInternal);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(CategorySets))
                {
                    writer.WritePropertyName("categorySet"u8);
                    writer.WriteStartArray();
                    foreach (var item in CategorySets)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(Categories))
                {
                    writer.WritePropertyName("categories"u8);
                    writer.WriteStartArray();
                    foreach (var item in Categories)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(Classifications))
                {
                    writer.WritePropertyName("classifications"u8);
                    writer.WriteStartArray();
                    foreach (var item in Classifications)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(Brands))
                {
                    writer.WritePropertyName("brands"u8);
                    writer.WriteStartArray();
                    foreach (var item in Brands)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (Optional.IsDefined(OperatingHours))
            {
                writer.WritePropertyName("openingHours"u8);
                writer.WriteObjectValue(OperatingHours);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        PointOfInterest IJsonModel<PointOfInterest>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PointOfInterest)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePointOfInterest(document.RootElement, options);
        }

        internal static PointOfInterest DeserializePointOfInterest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> phone = default;
            Optional<string> url = default;
            Optional<IReadOnlyList<PointOfInterestCategorySet>> categorySet = default;
            Optional<IReadOnlyList<string>> categories = default;
            Optional<IReadOnlyList<PointOfInterestClassification>> classifications = default;
            Optional<IReadOnlyList<BrandName>> brands = default;
            Optional<OperatingHours> openingHours = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phone"u8))
                {
                    phone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("categorySet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PointOfInterestCategorySet> array = new List<PointOfInterestCategorySet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PointOfInterestCategorySet.DeserializePointOfInterestCategorySet(item));
                    }
                    categorySet = array;
                    continue;
                }
                if (property.NameEquals("categories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    categories = array;
                    continue;
                }
                if (property.NameEquals("classifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PointOfInterestClassification> array = new List<PointOfInterestClassification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PointOfInterestClassification.DeserializePointOfInterestClassification(item));
                    }
                    classifications = array;
                    continue;
                }
                if (property.NameEquals("brands"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BrandName> array = new List<BrandName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BrandName.DeserializeBrandName(item));
                    }
                    brands = array;
                    continue;
                }
                if (property.NameEquals("openingHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    openingHours = OperatingHours.DeserializeOperatingHours(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PointOfInterest(name.Value, phone.Value, url.Value, Optional.ToList(categorySet), Optional.ToList(categories), Optional.ToList(classifications), Optional.ToList(brands), openingHours.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<PointOfInterest>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PointOfInterest)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PointOfInterest IModel<PointOfInterest>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PointOfInterest)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePointOfInterest(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<PointOfInterest>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
