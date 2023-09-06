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
    public partial class DiagnosticDataRendering : IUtf8JsonSerializable, IModelJsonSerializable<DiagnosticDataRendering>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DiagnosticDataRendering>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DiagnosticDataRendering>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiagnosticDataRendering>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RenderingType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RenderingType.Value.ToSerialString());
            }
            if (Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        internal static DiagnosticDataRendering DeserializeDiagnosticDataRendering(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DiagnosticDataRenderingType> type = default;
            Optional<string> title = default;
            Optional<string> description = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToDiagnosticDataRenderingType();
                    continue;
                }
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DiagnosticDataRendering(Optional.ToNullable(type), title.Value, description.Value, rawData);
        }

        DiagnosticDataRendering IModelJsonSerializable<DiagnosticDataRendering>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiagnosticDataRendering>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDiagnosticDataRendering(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DiagnosticDataRendering>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiagnosticDataRendering>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DiagnosticDataRendering IModelSerializable<DiagnosticDataRendering>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiagnosticDataRendering>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDiagnosticDataRendering(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DiagnosticDataRendering"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DiagnosticDataRendering"/> to convert. </param>
        public static implicit operator RequestContent(DiagnosticDataRendering model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DiagnosticDataRendering"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DiagnosticDataRendering(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDiagnosticDataRendering(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
