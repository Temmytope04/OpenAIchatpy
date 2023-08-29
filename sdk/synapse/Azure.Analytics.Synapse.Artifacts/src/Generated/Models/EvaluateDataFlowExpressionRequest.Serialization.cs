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
    [JsonConverter(typeof(EvaluateDataFlowExpressionRequestConverter))]
    public partial class EvaluateDataFlowExpressionRequest : IUtf8JsonSerializable, IModelJsonSerializable<EvaluateDataFlowExpressionRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EvaluateDataFlowExpressionRequest>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EvaluateDataFlowExpressionRequest>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId);
            }
            if (Optional.IsDefined(DataFlowName))
            {
                writer.WritePropertyName("dataFlowName"u8);
                writer.WriteStringValue(DataFlowName);
            }
            if (Optional.IsDefined(StreamName))
            {
                writer.WritePropertyName("streamName"u8);
                writer.WriteStringValue(StreamName);
            }
            if (Optional.IsDefined(RowLimits))
            {
                writer.WritePropertyName("rowLimits"u8);
                writer.WriteNumberValue(RowLimits.Value);
            }
            if (Optional.IsDefined(Expression))
            {
                writer.WritePropertyName("expression"u8);
                writer.WriteStringValue(Expression);
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

        internal static EvaluateDataFlowExpressionRequest DeserializeEvaluateDataFlowExpressionRequest(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sessionId = default;
            Optional<string> dataFlowName = default;
            Optional<string> streamName = default;
            Optional<int> rowLimits = default;
            Optional<string> expression = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFlowName"u8))
                {
                    dataFlowName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streamName"u8))
                {
                    streamName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rowLimits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rowLimits = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("expression"u8))
                {
                    expression = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EvaluateDataFlowExpressionRequest(sessionId.Value, dataFlowName.Value, streamName.Value, Optional.ToNullable(rowLimits), expression.Value, rawData);
        }

        EvaluateDataFlowExpressionRequest IModelJsonSerializable<EvaluateDataFlowExpressionRequest>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEvaluateDataFlowExpressionRequest(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EvaluateDataFlowExpressionRequest>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EvaluateDataFlowExpressionRequest IModelSerializable<EvaluateDataFlowExpressionRequest>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEvaluateDataFlowExpressionRequest(doc.RootElement, options);
        }

        public static implicit operator RequestContent(EvaluateDataFlowExpressionRequest model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator EvaluateDataFlowExpressionRequest(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEvaluateDataFlowExpressionRequest(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class EvaluateDataFlowExpressionRequestConverter : JsonConverter<EvaluateDataFlowExpressionRequest>
        {
            public override void Write(Utf8JsonWriter writer, EvaluateDataFlowExpressionRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EvaluateDataFlowExpressionRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEvaluateDataFlowExpressionRequest(document.RootElement);
            }
        }
    }
}
