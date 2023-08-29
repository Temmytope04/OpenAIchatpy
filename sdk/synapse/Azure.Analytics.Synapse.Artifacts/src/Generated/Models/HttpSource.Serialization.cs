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
    [JsonConverter(typeof(HttpSourceConverter))]
    public partial class HttpSource : IUtf8JsonSerializable, IModelJsonSerializable<HttpSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HttpSource>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HttpSource>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<HttpSource>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(HttpRequestTimeout))
            {
                writer.WritePropertyName("httpRequestTimeout"u8);
                writer.WriteObjectValue(HttpRequestTimeout);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(SourceRetryCount))
            {
                writer.WritePropertyName("sourceRetryCount"u8);
                writer.WriteObjectValue(SourceRetryCount);
            }
            if (Optional.IsDefined(SourceRetryWait))
            {
                writer.WritePropertyName("sourceRetryWait"u8);
                writer.WriteObjectValue(SourceRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static HttpSource DeserializeHttpSource(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> httpRequestTimeout = default;
            string type = default;
            Optional<object> sourceRetryCount = default;
            Optional<object> sourceRetryWait = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("httpRequestTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpRequestTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryWait = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new HttpSource(type, sourceRetryCount.Value, sourceRetryWait.Value, maxConcurrentConnections.Value, additionalProperties, httpRequestTimeout.Value);
        }

        HttpSource IModelJsonSerializable<HttpSource>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<HttpSource>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHttpSource(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HttpSource>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<HttpSource>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HttpSource IModelSerializable<HttpSource>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<HttpSource>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHttpSource(doc.RootElement, options);
        }

        public static implicit operator RequestContent(HttpSource model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator HttpSource(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHttpSource(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class HttpSourceConverter : JsonConverter<HttpSource>
        {
            public override void Write(Utf8JsonWriter writer, HttpSource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override HttpSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeHttpSource(document.RootElement);
            }
        }
    }
}
