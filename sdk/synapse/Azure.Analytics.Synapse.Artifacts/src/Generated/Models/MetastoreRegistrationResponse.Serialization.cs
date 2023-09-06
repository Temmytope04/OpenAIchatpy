// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(MetastoreRegistrationResponseConverter))]
    public partial class MetastoreRegistrationResponse : IUtf8JsonSerializable, IModelJsonSerializable<MetastoreRegistrationResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MetastoreRegistrationResponse>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MetastoreRegistrationResponse>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MetastoreRegistrationResponse>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
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

        internal static MetastoreRegistrationResponse DeserializeMetastoreRegistrationResponse(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RequestStatus> status = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new RequestStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MetastoreRegistrationResponse(Optional.ToNullable(status), rawData);
        }

        MetastoreRegistrationResponse IModelJsonSerializable<MetastoreRegistrationResponse>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MetastoreRegistrationResponse>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMetastoreRegistrationResponse(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MetastoreRegistrationResponse>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MetastoreRegistrationResponse>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MetastoreRegistrationResponse IModelSerializable<MetastoreRegistrationResponse>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MetastoreRegistrationResponse>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMetastoreRegistrationResponse(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MetastoreRegistrationResponse"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MetastoreRegistrationResponse"/> to convert. </param>
        public static implicit operator RequestContent(MetastoreRegistrationResponse model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MetastoreRegistrationResponse"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MetastoreRegistrationResponse(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMetastoreRegistrationResponse(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class MetastoreRegistrationResponseConverter : JsonConverter<MetastoreRegistrationResponse>
        {
            public override void Write(Utf8JsonWriter writer, MetastoreRegistrationResponse model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MetastoreRegistrationResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMetastoreRegistrationResponse(document.RootElement);
            }
        }
    }
}
