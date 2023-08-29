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
    public partial class MachineLearningServiceFunctionRetrieveDefaultDefinitionContent : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>(this, options.Format);

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

        internal static MachineLearningServiceFunctionRetrieveDefaultDefinitionContent DeserializeMachineLearningServiceFunctionRetrieveDefaultDefinitionContent(JsonElement element, ModelSerializerOptions options = default)
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
            return new MachineLearningServiceFunctionRetrieveDefaultDefinitionContent(bindingType, executeEndpoint.Value, Optional.ToNullable(udfType), rawData);
        }

        MachineLearningServiceFunctionRetrieveDefaultDefinitionContent IModelJsonSerializable<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningServiceFunctionRetrieveDefaultDefinitionContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningServiceFunctionRetrieveDefaultDefinitionContent IModelSerializable<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningServiceFunctionRetrieveDefaultDefinitionContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MachineLearningServiceFunctionRetrieveDefaultDefinitionContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MachineLearningServiceFunctionRetrieveDefaultDefinitionContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningServiceFunctionRetrieveDefaultDefinitionContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
