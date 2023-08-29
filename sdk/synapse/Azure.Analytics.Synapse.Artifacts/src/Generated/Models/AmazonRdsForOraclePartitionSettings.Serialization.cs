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
    [JsonConverter(typeof(AmazonRdsForOraclePartitionSettingsConverter))]
    public partial class AmazonRdsForOraclePartitionSettings : IUtf8JsonSerializable, IModelJsonSerializable<AmazonRdsForOraclePartitionSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AmazonRdsForOraclePartitionSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AmazonRdsForOraclePartitionSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PartitionNames))
            {
                writer.WritePropertyName("partitionNames"u8);
                writer.WriteObjectValue(PartitionNames);
            }
            if (Optional.IsDefined(PartitionColumnName))
            {
                writer.WritePropertyName("partitionColumnName"u8);
                writer.WriteObjectValue(PartitionColumnName);
            }
            if (Optional.IsDefined(PartitionUpperBound))
            {
                writer.WritePropertyName("partitionUpperBound"u8);
                writer.WriteObjectValue(PartitionUpperBound);
            }
            if (Optional.IsDefined(PartitionLowerBound))
            {
                writer.WritePropertyName("partitionLowerBound"u8);
                writer.WriteObjectValue(PartitionLowerBound);
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

        internal static AmazonRdsForOraclePartitionSettings DeserializeAmazonRdsForOraclePartitionSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> partitionNames = default;
            Optional<object> partitionColumnName = default;
            Optional<object> partitionUpperBound = default;
            Optional<object> partitionLowerBound = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionNames = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionColumnName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionUpperBound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionUpperBound = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionLowerBound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionLowerBound = property.Value.GetObject();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AmazonRdsForOraclePartitionSettings(partitionNames.Value, partitionColumnName.Value, partitionUpperBound.Value, partitionLowerBound.Value, rawData);
        }

        AmazonRdsForOraclePartitionSettings IModelJsonSerializable<AmazonRdsForOraclePartitionSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAmazonRdsForOraclePartitionSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AmazonRdsForOraclePartitionSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AmazonRdsForOraclePartitionSettings IModelSerializable<AmazonRdsForOraclePartitionSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAmazonRdsForOraclePartitionSettings(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AmazonRdsForOraclePartitionSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AmazonRdsForOraclePartitionSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAmazonRdsForOraclePartitionSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class AmazonRdsForOraclePartitionSettingsConverter : JsonConverter<AmazonRdsForOraclePartitionSettings>
        {
            public override void Write(Utf8JsonWriter writer, AmazonRdsForOraclePartitionSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AmazonRdsForOraclePartitionSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAmazonRdsForOraclePartitionSettings(document.RootElement);
            }
        }
    }
}
