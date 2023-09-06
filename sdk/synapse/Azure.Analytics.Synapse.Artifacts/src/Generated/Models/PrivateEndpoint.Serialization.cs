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
    [JsonConverter(typeof(PrivateEndpointConverter))]
    public partial class PrivateEndpoint : IUtf8JsonSerializable, IModelJsonSerializable<PrivateEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PrivateEndpoint>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PrivateEndpoint>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateEndpoint>(this, options.Format);

            writer.WriteStartObject();
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

        internal static PrivateEndpoint DeserializePrivateEndpoint(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PrivateEndpoint(id.Value, rawData);
        }

        PrivateEndpoint IModelJsonSerializable<PrivateEndpoint>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateEndpoint>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateEndpoint(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PrivateEndpoint>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateEndpoint>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PrivateEndpoint IModelSerializable<PrivateEndpoint>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateEndpoint>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePrivateEndpoint(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PrivateEndpoint"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PrivateEndpoint"/> to convert. </param>
        public static implicit operator RequestContent(PrivateEndpoint model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PrivateEndpoint"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PrivateEndpoint(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePrivateEndpoint(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class PrivateEndpointConverter : JsonConverter<PrivateEndpoint>
        {
            public override void Write(Utf8JsonWriter writer, PrivateEndpoint model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override PrivateEndpoint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializePrivateEndpoint(document.RootElement);
            }
        }
    }
}
