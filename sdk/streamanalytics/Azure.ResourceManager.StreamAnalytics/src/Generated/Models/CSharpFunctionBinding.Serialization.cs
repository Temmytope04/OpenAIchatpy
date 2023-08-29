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

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class CSharpFunctionBinding : IUtf8JsonSerializable, IModelJsonSerializable<CSharpFunctionBinding>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CSharpFunctionBinding>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CSharpFunctionBinding>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CSharpFunctionBinding>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FunctionBindingType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DllPath))
            {
                writer.WritePropertyName("dllPath"u8);
                writer.WriteStringValue(DllPath);
            }
            if (Optional.IsDefined(Class))
            {
                writer.WritePropertyName("class"u8);
                writer.WriteStringValue(Class);
            }
            if (Optional.IsDefined(Method))
            {
                writer.WritePropertyName("method"u8);
                writer.WriteStringValue(Method);
            }
            if (Optional.IsDefined(UpdateMode))
            {
                writer.WritePropertyName("updateMode"u8);
                writer.WriteStringValue(UpdateMode.Value.ToString());
            }
            writer.WriteEndObject();
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

        internal static CSharpFunctionBinding DeserializeCSharpFunctionBinding(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> dllPath = default;
            Optional<string> @class = default;
            Optional<string> method = default;
            Optional<StreamingJobFunctionUpdateMode> updateMode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("dllPath"u8))
                        {
                            dllPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("class"u8))
                        {
                            @class = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("method"u8))
                        {
                            method = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("updateMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updateMode = new StreamingJobFunctionUpdateMode(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CSharpFunctionBinding(type, dllPath.Value, @class.Value, method.Value, Optional.ToNullable(updateMode), rawData);
        }

        CSharpFunctionBinding IModelJsonSerializable<CSharpFunctionBinding>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CSharpFunctionBinding>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCSharpFunctionBinding(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CSharpFunctionBinding>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CSharpFunctionBinding>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CSharpFunctionBinding IModelSerializable<CSharpFunctionBinding>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CSharpFunctionBinding>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCSharpFunctionBinding(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CSharpFunctionBinding model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CSharpFunctionBinding(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCSharpFunctionBinding(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
