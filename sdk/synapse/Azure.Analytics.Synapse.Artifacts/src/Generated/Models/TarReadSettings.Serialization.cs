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
    [JsonConverter(typeof(TarReadSettingsConverter))]
    public partial class TarReadSettings : IUtf8JsonSerializable, IModelJsonSerializable<TarReadSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TarReadSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TarReadSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TarReadSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PreserveCompressionFileNameAsFolder))
            {
                writer.WritePropertyName("preserveCompressionFileNameAsFolder"u8);
                writer.WriteObjectValue(PreserveCompressionFileNameAsFolder);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static TarReadSettings DeserializeTarReadSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> preserveCompressionFileNameAsFolder = default;
            string type = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preserveCompressionFileNameAsFolder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preserveCompressionFileNameAsFolder = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new TarReadSettings(type, additionalProperties, preserveCompressionFileNameAsFolder.Value);
        }

        TarReadSettings IModelJsonSerializable<TarReadSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TarReadSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTarReadSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TarReadSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TarReadSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TarReadSettings IModelSerializable<TarReadSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TarReadSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTarReadSettings(doc.RootElement, options);
        }

        public static implicit operator RequestContent(TarReadSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator TarReadSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTarReadSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class TarReadSettingsConverter : JsonConverter<TarReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, TarReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TarReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTarReadSettings(document.RootElement);
            }
        }
    }
}
