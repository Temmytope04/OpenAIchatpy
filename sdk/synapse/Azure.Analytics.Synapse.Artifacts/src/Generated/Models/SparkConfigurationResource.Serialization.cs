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
    [JsonConverter(typeof(SparkConfigurationResourceConverter))]
    public partial class SparkConfigurationResource : IUtf8JsonSerializable, IModelJsonSerializable<SparkConfigurationResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SparkConfigurationResource>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SparkConfigurationResource>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SparkConfigurationResource>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteObjectValue(Properties);
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

        internal static SparkConfigurationResource DeserializeSparkConfigurationResource(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SparkConfiguration properties = default;
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    properties = SparkConfiguration.DeserializeSparkConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SparkConfigurationResource(id.Value, name.Value, type.Value, etag.Value, properties, rawData);
        }

        SparkConfigurationResource IModelJsonSerializable<SparkConfigurationResource>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SparkConfigurationResource>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSparkConfigurationResource(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SparkConfigurationResource>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SparkConfigurationResource>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SparkConfigurationResource IModelSerializable<SparkConfigurationResource>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SparkConfigurationResource>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSparkConfigurationResource(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SparkConfigurationResource model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SparkConfigurationResource(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSparkConfigurationResource(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class SparkConfigurationResourceConverter : JsonConverter<SparkConfigurationResource>
        {
            public override void Write(Utf8JsonWriter writer, SparkConfigurationResource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SparkConfigurationResource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSparkConfigurationResource(document.RootElement);
            }
        }
    }
}
