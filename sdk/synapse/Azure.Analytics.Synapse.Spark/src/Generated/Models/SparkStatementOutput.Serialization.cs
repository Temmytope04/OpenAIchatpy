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

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkStatementOutput : IUtf8JsonSerializable, IModelJsonSerializable<SparkStatementOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SparkStatementOutput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SparkStatementOutput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            writer.WritePropertyName("execution_count"u8);
            writer.WriteNumberValue(ExecutionCount);
            if (Optional.IsDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteObjectValue(Data);
            }
            if (Optional.IsDefined(ErrorName))
            {
                if (ErrorName != null)
                {
                    writer.WritePropertyName("ename"u8);
                    writer.WriteStringValue(ErrorName);
                }
                else
                {
                    writer.WriteNull("ename");
                }
            }
            if (Optional.IsDefined(ErrorValue))
            {
                if (ErrorValue != null)
                {
                    writer.WritePropertyName("evalue"u8);
                    writer.WriteStringValue(ErrorValue);
                }
                else
                {
                    writer.WriteNull("evalue");
                }
            }
            if (Optional.IsCollectionDefined(Traceback))
            {
                if (Traceback != null)
                {
                    writer.WritePropertyName("traceback"u8);
                    writer.WriteStartArray();
                    foreach (var item in Traceback)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("traceback");
                }
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

        internal static SparkStatementOutput DeserializeSparkStatementOutput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> status = default;
            int executionCount = default;
            Optional<object> data = default;
            Optional<string> ename = default;
            Optional<string> evalue = default;
            Optional<IReadOnlyList<string>> traceback = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("execution_count"u8))
                {
                    executionCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    data = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("ename"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        ename = null;
                        continue;
                    }
                    ename = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("evalue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        evalue = null;
                        continue;
                    }
                    evalue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("traceback"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    traceback = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SparkStatementOutput(status.Value, executionCount, data.Value, ename.Value, evalue.Value, Optional.ToList(traceback), rawData);
        }

        SparkStatementOutput IModelJsonSerializable<SparkStatementOutput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSparkStatementOutput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SparkStatementOutput>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SparkStatementOutput IModelSerializable<SparkStatementOutput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSparkStatementOutput(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SparkStatementOutput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SparkStatementOutput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSparkStatementOutput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
