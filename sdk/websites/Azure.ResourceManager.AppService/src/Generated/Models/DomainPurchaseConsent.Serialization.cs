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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DomainPurchaseConsent : IUtf8JsonSerializable, IModelJsonSerializable<DomainPurchaseConsent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DomainPurchaseConsent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DomainPurchaseConsent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AgreementKeys))
            {
                writer.WritePropertyName("agreementKeys"u8);
                writer.WriteStartArray();
                foreach (var item in AgreementKeys)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AgreedBy))
            {
                writer.WritePropertyName("agreedBy"u8);
                writer.WriteStringValue(AgreedBy);
            }
            if (Optional.IsDefined(AgreedOn))
            {
                writer.WritePropertyName("agreedAt"u8);
                writer.WriteStringValue(AgreedOn.Value, "O");
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

        internal static DomainPurchaseConsent DeserializeDomainPurchaseConsent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> agreementKeys = default;
            Optional<string> agreedBy = default;
            Optional<DateTimeOffset> agreedAt = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("agreementKeys"u8))
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
                    agreementKeys = array;
                    continue;
                }
                if (property.NameEquals("agreedBy"u8))
                {
                    agreedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agreedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agreedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DomainPurchaseConsent(Optional.ToList(agreementKeys), agreedBy.Value, Optional.ToNullable(agreedAt), rawData);
        }

        DomainPurchaseConsent IModelJsonSerializable<DomainPurchaseConsent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDomainPurchaseConsent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DomainPurchaseConsent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DomainPurchaseConsent IModelSerializable<DomainPurchaseConsent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDomainPurchaseConsent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DomainPurchaseConsent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DomainPurchaseConsent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDomainPurchaseConsent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
