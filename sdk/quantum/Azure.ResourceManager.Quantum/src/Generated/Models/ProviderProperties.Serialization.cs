// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Quantum.Models
{
    public partial class ProviderProperties : IUtf8JsonSerializable, IModelJsonSerializable<ProviderProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProviderProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProviderProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Aad))
            {
                writer.WritePropertyName("aad"u8);
                writer.WriteObjectValue(Aad);
            }
            if (Optional.IsDefined(ManagedApplication))
            {
                writer.WritePropertyName("managedApplication"u8);
                writer.WriteObjectValue(ManagedApplication);
            }
            if (Optional.IsCollectionDefined(Targets))
            {
                writer.WritePropertyName("targets"u8);
                writer.WriteStartArray();
                foreach (var item in Targets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Skus))
            {
                writer.WritePropertyName("skus"u8);
                writer.WriteStartArray();
                foreach (var item in Skus)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(QuotaDimensions))
            {
                writer.WritePropertyName("quotaDimensions"u8);
                writer.WriteStartArray();
                foreach (var item in QuotaDimensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PricingDimensions))
            {
                writer.WritePropertyName("pricingDimensions"u8);
                writer.WriteStartArray();
                foreach (var item in PricingDimensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ProviderProperties DeserializeProviderProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> description = default;
            Optional<string> providerType = default;
            Optional<string> company = default;
            Optional<string> defaultEndpoint = default;
            Optional<ProviderPropertiesAad> aad = default;
            Optional<ProviderPropertiesManagedApplication> managedApplication = default;
            Optional<IReadOnlyList<TargetDescription>> targets = default;
            Optional<IReadOnlyList<SkuDescription>> skus = default;
            Optional<IReadOnlyList<QuotaDimension>> quotaDimensions = default;
            Optional<IReadOnlyList<PricingDimension>> pricingDimensions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerType"u8))
                {
                    providerType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("company"u8))
                {
                    company = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultEndpoint"u8))
                {
                    defaultEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aad"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aad = ProviderPropertiesAad.DeserializeProviderPropertiesAad(property.Value);
                    continue;
                }
                if (property.NameEquals("managedApplication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedApplication = ProviderPropertiesManagedApplication.DeserializeProviderPropertiesManagedApplication(property.Value);
                    continue;
                }
                if (property.NameEquals("targets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TargetDescription> array = new List<TargetDescription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TargetDescription.DeserializeTargetDescription(item));
                    }
                    targets = array;
                    continue;
                }
                if (property.NameEquals("skus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SkuDescription> array = new List<SkuDescription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SkuDescription.DeserializeSkuDescription(item));
                    }
                    skus = array;
                    continue;
                }
                if (property.NameEquals("quotaDimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QuotaDimension> array = new List<QuotaDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QuotaDimension.DeserializeQuotaDimension(item));
                    }
                    quotaDimensions = array;
                    continue;
                }
                if (property.NameEquals("pricingDimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PricingDimension> array = new List<PricingDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PricingDimension.DeserializePricingDimension(item));
                    }
                    pricingDimensions = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ProviderProperties(description.Value, providerType.Value, company.Value, defaultEndpoint.Value, aad.Value, managedApplication.Value, Optional.ToList(targets), Optional.ToList(skus), Optional.ToList(quotaDimensions), Optional.ToList(pricingDimensions), rawData);
        }

        ProviderProperties IModelJsonSerializable<ProviderProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProviderProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProviderProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProviderProperties IModelSerializable<ProviderProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProviderProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ProviderProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ProviderProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeProviderProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
