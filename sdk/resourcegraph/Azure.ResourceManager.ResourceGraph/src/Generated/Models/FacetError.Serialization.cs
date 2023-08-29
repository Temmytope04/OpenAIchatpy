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

namespace Azure.ResourceManager.ResourceGraph.Models
{
    public partial class FacetError : IUtf8JsonSerializable, IModelJsonSerializable<FacetError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FacetError>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FacetError>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<FacetError>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("errors"u8);
            writer.WriteStartArray();
            foreach (var item in Errors)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("expression"u8);
            writer.WriteStringValue(Expression);
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        internal static FacetError DeserializeFacetError(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<FacetErrorDetails> errors = default;
            string expression = default;
            string resultType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errors"u8))
                {
                    List<FacetErrorDetails> array = new List<FacetErrorDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FacetErrorDetails.DeserializeFacetErrorDetails(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("expression"u8))
                {
                    expression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FacetError(expression, resultType, errors, rawData);
        }

        FacetError IModelJsonSerializable<FacetError>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<FacetError>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFacetError(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FacetError>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<FacetError>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FacetError IModelSerializable<FacetError>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<FacetError>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFacetError(doc.RootElement, options);
        }

        public static implicit operator RequestContent(FacetError model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator FacetError(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFacetError(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
