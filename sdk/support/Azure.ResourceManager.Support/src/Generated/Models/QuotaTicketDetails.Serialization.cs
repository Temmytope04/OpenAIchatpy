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

namespace Azure.ResourceManager.Support.Models
{
    public partial class QuotaTicketDetails : IUtf8JsonSerializable, IModelJsonSerializable<QuotaTicketDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<QuotaTicketDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<QuotaTicketDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(QuotaChangeRequestSubType))
            {
                writer.WritePropertyName("quotaChangeRequestSubType"u8);
                writer.WriteStringValue(QuotaChangeRequestSubType);
            }
            if (Optional.IsDefined(QuotaChangeRequestVersion))
            {
                writer.WritePropertyName("quotaChangeRequestVersion"u8);
                writer.WriteStringValue(QuotaChangeRequestVersion);
            }
            if (Optional.IsCollectionDefined(QuotaChangeRequests))
            {
                writer.WritePropertyName("quotaChangeRequests"u8);
                writer.WriteStartArray();
                foreach (var item in QuotaChangeRequests)
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

        internal static QuotaTicketDetails DeserializeQuotaTicketDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> quotaChangeRequestSubType = default;
            Optional<string> quotaChangeRequestVersion = default;
            Optional<IList<SupportQuotaChangeContent>> quotaChangeRequests = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("quotaChangeRequestSubType"u8))
                {
                    quotaChangeRequestSubType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quotaChangeRequestVersion"u8))
                {
                    quotaChangeRequestVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quotaChangeRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SupportQuotaChangeContent> array = new List<SupportQuotaChangeContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SupportQuotaChangeContent.DeserializeSupportQuotaChangeContent(item));
                    }
                    quotaChangeRequests = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new QuotaTicketDetails(quotaChangeRequestSubType.Value, quotaChangeRequestVersion.Value, Optional.ToList(quotaChangeRequests), rawData);
        }

        QuotaTicketDetails IModelJsonSerializable<QuotaTicketDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeQuotaTicketDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<QuotaTicketDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        QuotaTicketDetails IModelSerializable<QuotaTicketDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeQuotaTicketDetails(doc.RootElement, options);
        }

        public static implicit operator RequestContent(QuotaTicketDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator QuotaTicketDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeQuotaTicketDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
