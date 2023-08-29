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
    public partial class ReferenceInputProperties : IUtf8JsonSerializable, IModelJsonSerializable<ReferenceInputProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ReferenceInputProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ReferenceInputProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ReferenceInputProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Datasource))
            {
                writer.WritePropertyName("datasource"u8);
                writer.WriteObjectValue(Datasource);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(InputPropertiesType);
            if (Optional.IsDefined(Serialization))
            {
                writer.WritePropertyName("serialization"u8);
                writer.WriteObjectValue(Serialization);
            }
            if (Optional.IsDefined(Compression))
            {
                writer.WritePropertyName("compression"u8);
                writer.WriteObjectValue(Compression);
            }
            if (Optional.IsDefined(PartitionKey))
            {
                writer.WritePropertyName("partitionKey"u8);
                writer.WriteStringValue(PartitionKey);
            }
            if (Optional.IsDefined(WatermarkSettings))
            {
                writer.WritePropertyName("watermarkSettings"u8);
                writer.WriteObjectValue(WatermarkSettings);
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

        internal static ReferenceInputProperties DeserializeReferenceInputProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ReferenceInputDataSource> datasource = default;
            string type = default;
            Optional<StreamAnalyticsDataSerialization> serialization = default;
            Optional<StreamingJobDiagnostics> diagnostics = default;
            Optional<ETag> etag = default;
            Optional<StreamingCompression> compression = default;
            Optional<string> partitionKey = default;
            Optional<StreamingJobInputWatermarkProperties> watermarkSettings = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datasource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    datasource = ReferenceInputDataSource.DeserializeReferenceInputDataSource(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serialization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serialization = StreamAnalyticsDataSerialization.DeserializeStreamAnalyticsDataSerialization(property.Value);
                    continue;
                }
                if (property.NameEquals("diagnostics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diagnostics = StreamingJobDiagnostics.DeserializeStreamingJobDiagnostics(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("compression"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compression = StreamingCompression.DeserializeStreamingCompression(property.Value);
                    continue;
                }
                if (property.NameEquals("partitionKey"u8))
                {
                    partitionKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("watermarkSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    watermarkSettings = StreamingJobInputWatermarkProperties.DeserializeStreamingJobInputWatermarkProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ReferenceInputProperties(type, serialization.Value, diagnostics.Value, Optional.ToNullable(etag), compression.Value, partitionKey.Value, watermarkSettings.Value, datasource.Value, rawData);
        }

        ReferenceInputProperties IModelJsonSerializable<ReferenceInputProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ReferenceInputProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeReferenceInputProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ReferenceInputProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ReferenceInputProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ReferenceInputProperties IModelSerializable<ReferenceInputProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ReferenceInputProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeReferenceInputProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ReferenceInputProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ReferenceInputProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeReferenceInputProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
