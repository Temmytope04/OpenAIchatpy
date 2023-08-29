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
    public partial class SpatialAnalysisOperationBase : IUtf8JsonSerializable, IModelJsonSerializable<SpatialAnalysisOperationBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SpatialAnalysisOperationBase>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SpatialAnalysisOperationBase>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
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

        internal static SpatialAnalysisOperationBase DeserializeSpatialAnalysisOperationBase(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.VideoAnalyzer.SpatialAnalysisCustomOperation": return SpatialAnalysisCustomOperation.DeserializeSpatialAnalysisCustomOperation(element);
                    case "#Microsoft.VideoAnalyzer.SpatialAnalysisPersonCountOperation": return SpatialAnalysisPersonCountOperation.DeserializeSpatialAnalysisPersonCountOperation(element);
                    case "#Microsoft.VideoAnalyzer.SpatialAnalysisPersonDistanceOperation": return SpatialAnalysisPersonDistanceOperation.DeserializeSpatialAnalysisPersonDistanceOperation(element);
                    case "#Microsoft.VideoAnalyzer.SpatialAnalysisPersonLineCrossingOperation": return SpatialAnalysisPersonLineCrossingOperation.DeserializeSpatialAnalysisPersonLineCrossingOperation(element);
                    case "#Microsoft.VideoAnalyzer.SpatialAnalysisPersonZoneCrossingOperation": return SpatialAnalysisPersonZoneCrossingOperation.DeserializeSpatialAnalysisPersonZoneCrossingOperation(element);
                    case "SpatialAnalysisTypedOperationBase": return SpatialAnalysisTypedOperationBase.DeserializeSpatialAnalysisTypedOperationBase(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownSpatialAnalysisOperationBase(type, rawData);
        }

        SpatialAnalysisOperationBase IModelJsonSerializable<SpatialAnalysisOperationBase>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSpatialAnalysisOperationBase(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SpatialAnalysisOperationBase>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SpatialAnalysisOperationBase IModelSerializable<SpatialAnalysisOperationBase>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSpatialAnalysisOperationBase(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SpatialAnalysisOperationBase model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SpatialAnalysisOperationBase(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSpatialAnalysisOperationBase(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
