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

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class DeliveryRuleUriPathCondition : IUtf8JsonSerializable, IModelJsonSerializable<DeliveryRuleUriPathCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DeliveryRuleUriPathCondition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DeliveryRuleUriPathCondition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DeliveryRuleUriPathCondition>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("parameters"u8);
            if (Properties is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<UriPathMatchCondition>)Properties).Serialize(writer, options);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name.ToString());
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

        internal static DeliveryRuleUriPathCondition DeserializeDeliveryRuleUriPathCondition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UriPathMatchCondition parameters = default;
            MatchVariable name = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"u8))
                {
                    parameters = UriPathMatchCondition.DeserializeUriPathMatchCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = new MatchVariable(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DeliveryRuleUriPathCondition(name, parameters, rawData);
        }

        DeliveryRuleUriPathCondition IModelJsonSerializable<DeliveryRuleUriPathCondition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DeliveryRuleUriPathCondition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDeliveryRuleUriPathCondition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DeliveryRuleUriPathCondition>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DeliveryRuleUriPathCondition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DeliveryRuleUriPathCondition IModelSerializable<DeliveryRuleUriPathCondition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DeliveryRuleUriPathCondition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDeliveryRuleUriPathCondition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DeliveryRuleUriPathCondition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DeliveryRuleUriPathCondition"/> to convert. </param>
        public static implicit operator RequestContent(DeliveryRuleUriPathCondition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DeliveryRuleUriPathCondition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DeliveryRuleUriPathCondition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDeliveryRuleUriPathCondition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
