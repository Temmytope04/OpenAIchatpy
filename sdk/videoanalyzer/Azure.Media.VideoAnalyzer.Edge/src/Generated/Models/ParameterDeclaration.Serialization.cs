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

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class ParameterDeclaration : IUtf8JsonSerializable, IModelJsonSerializable<ParameterDeclaration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ParameterDeclaration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ParameterDeclaration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ParameterDeclaration>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Default))
            {
                writer.WritePropertyName("default"u8);
                writer.WriteStringValue(Default);
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

        internal static ParameterDeclaration DeserializeParameterDeclaration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            ParameterType type = default;
            Optional<string> description = default;
            Optional<string> @default = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ParameterType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("default"u8))
                {
                    @default = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ParameterDeclaration(name, type, description.Value, @default.Value, rawData);
        }

        ParameterDeclaration IModelJsonSerializable<ParameterDeclaration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ParameterDeclaration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeParameterDeclaration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ParameterDeclaration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ParameterDeclaration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ParameterDeclaration IModelSerializable<ParameterDeclaration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ParameterDeclaration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeParameterDeclaration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ParameterDeclaration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ParameterDeclaration"/> to convert. </param>
        public static implicit operator RequestContent(ParameterDeclaration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ParameterDeclaration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ParameterDeclaration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeParameterDeclaration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
