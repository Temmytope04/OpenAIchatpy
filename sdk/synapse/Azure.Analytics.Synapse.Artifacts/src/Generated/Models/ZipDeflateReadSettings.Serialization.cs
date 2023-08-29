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
    [JsonConverter(typeof(ZipDeflateReadSettingsConverter))]
    public partial class ZipDeflateReadSettings : IUtf8JsonSerializable, IModelJsonSerializable<ZipDeflateReadSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ZipDeflateReadSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ZipDeflateReadSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ZipDeflateReadSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PreserveZipFileNameAsFolder))
            {
                writer.WritePropertyName("preserveZipFileNameAsFolder"u8);
                writer.WriteObjectValue(PreserveZipFileNameAsFolder);
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

        internal static ZipDeflateReadSettings DeserializeZipDeflateReadSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> preserveZipFileNameAsFolder = default;
            string type = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preserveZipFileNameAsFolder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preserveZipFileNameAsFolder = property.Value.GetObject();
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
            return new ZipDeflateReadSettings(type, additionalProperties, preserveZipFileNameAsFolder.Value);
        }

        ZipDeflateReadSettings IModelJsonSerializable<ZipDeflateReadSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ZipDeflateReadSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeZipDeflateReadSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ZipDeflateReadSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ZipDeflateReadSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ZipDeflateReadSettings IModelSerializable<ZipDeflateReadSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ZipDeflateReadSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeZipDeflateReadSettings(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ZipDeflateReadSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ZipDeflateReadSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeZipDeflateReadSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class ZipDeflateReadSettingsConverter : JsonConverter<ZipDeflateReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, ZipDeflateReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ZipDeflateReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeZipDeflateReadSettings(document.RootElement);
            }
        }
    }
}
