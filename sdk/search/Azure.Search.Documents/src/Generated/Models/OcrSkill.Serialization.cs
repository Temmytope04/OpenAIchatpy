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

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class OcrSkill : IUtf8JsonSerializable, IModelJsonSerializable<OcrSkill>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OcrSkill>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OcrSkill>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<OcrSkill>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultLanguageCode))
            {
                if (DefaultLanguageCode != null)
                {
                    writer.WritePropertyName("defaultLanguageCode"u8);
                    writer.WriteStringValue(DefaultLanguageCode.Value.ToString());
                }
                else
                {
                    writer.WriteNull("defaultLanguageCode");
                }
            }
            if (Optional.IsDefined(ShouldDetectOrientation))
            {
                if (ShouldDetectOrientation != null)
                {
                    writer.WritePropertyName("detectOrientation"u8);
                    writer.WriteBooleanValue(ShouldDetectOrientation.Value);
                }
                else
                {
                    writer.WriteNull("detectOrientation");
                }
            }
            if (Optional.IsDefined(LineEnding))
            {
                writer.WritePropertyName("lineEnding"u8);
                writer.WriteStringValue(LineEnding.Value.ToString());
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Context))
            {
                writer.WritePropertyName("context"u8);
                writer.WriteStringValue(Context);
            }
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("outputs"u8);
            writer.WriteStartArray();
            foreach (var item in Outputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        internal static OcrSkill DeserializeOcrSkill(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OcrSkillLanguage?> defaultLanguageCode = default;
            Optional<bool?> detectOrientation = default;
            Optional<LineEnding> lineEnding = default;
            string odataType = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<string> context = default;
            IList<InputFieldMappingEntry> inputs = default;
            IList<OutputFieldMappingEntry> outputs = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultLanguageCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultLanguageCode = null;
                        continue;
                    }
                    defaultLanguageCode = new OcrSkillLanguage(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("detectOrientation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        detectOrientation = null;
                        continue;
                    }
                    detectOrientation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lineEnding"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lineEnding = new LineEnding(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("context"u8))
                {
                    context = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    List<InputFieldMappingEntry> array = new List<InputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InputFieldMappingEntry.DeserializeInputFieldMappingEntry(item));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    List<OutputFieldMappingEntry> array = new List<OutputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutputFieldMappingEntry.DeserializeOutputFieldMappingEntry(item));
                    }
                    outputs = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OcrSkill(odataType, name.Value, description.Value, context.Value, inputs, outputs, Optional.ToNullable(defaultLanguageCode), Optional.ToNullable(detectOrientation), Optional.ToNullable(lineEnding), rawData);
        }

        OcrSkill IModelJsonSerializable<OcrSkill>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<OcrSkill>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOcrSkill(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OcrSkill>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<OcrSkill>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OcrSkill IModelSerializable<OcrSkill>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<OcrSkill>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOcrSkill(doc.RootElement, options);
        }

        public static implicit operator RequestContent(OcrSkill model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator OcrSkill(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOcrSkill(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
