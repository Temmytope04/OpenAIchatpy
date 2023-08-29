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
    public partial class MachineLearningStudioFunctionRetrieveDefaultDefinitionContent : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningStudioFunctionRetrieveDefaultDefinitionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningStudioFunctionRetrieveDefaultDefinitionContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningStudioFunctionRetrieveDefaultDefinitionContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningStudioFunctionRetrieveDefaultDefinitionContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("bindingType"u8);
            writer.WriteStringValue(BindingType);
            writer.WritePropertyName("bindingRetrievalProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ExecuteEndpoint))
            {
                writer.WritePropertyName("executeEndpoint"u8);
                writer.WriteStringValue(ExecuteEndpoint);
            }
            if (Optional.IsDefined(UdfType))
            {
                writer.WritePropertyName("udfType"u8);
                writer.WriteStringValue(UdfType.Value.ToString());
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

        internal static MachineLearningStudioFunctionRetrieveDefaultDefinitionContent DeserializeMachineLearningStudioFunctionRetrieveDefaultDefinitionContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string bindingType = default;
            Optional<string> executeEndpoint = default;
            Optional<StreamingJobFunctionUdfType> udfType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bindingType"u8))
                {
                    bindingType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bindingRetrievalProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("executeEndpoint"u8))
                        {
                            executeEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("udfType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            udfType = new StreamingJobFunctionUdfType(property0.Value.GetString());
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
            return new MachineLearningStudioFunctionRetrieveDefaultDefinitionContent(bindingType, executeEndpoint.Value, Optional.ToNullable(udfType), rawData);
        }

        MachineLearningStudioFunctionRetrieveDefaultDefinitionContent IModelJsonSerializable<MachineLearningStudioFunctionRetrieveDefaultDefinitionContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningStudioFunctionRetrieveDefaultDefinitionContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningStudioFunctionRetrieveDefaultDefinitionContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningStudioFunctionRetrieveDefaultDefinitionContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningStudioFunctionRetrieveDefaultDefinitionContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningStudioFunctionRetrieveDefaultDefinitionContent IModelSerializable<MachineLearningStudioFunctionRetrieveDefaultDefinitionContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningStudioFunctionRetrieveDefaultDefinitionContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningStudioFunctionRetrieveDefaultDefinitionContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MachineLearningStudioFunctionRetrieveDefaultDefinitionContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MachineLearningStudioFunctionRetrieveDefaultDefinitionContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningStudioFunctionRetrieveDefaultDefinitionContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
