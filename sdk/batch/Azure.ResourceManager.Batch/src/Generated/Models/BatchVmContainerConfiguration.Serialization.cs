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

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchVmContainerConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<BatchVmContainerConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BatchVmContainerConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BatchVmContainerConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ContainerType.ToString());
            if (Optional.IsCollectionDefined(ContainerImageNames))
            {
                writer.WritePropertyName("containerImageNames"u8);
                writer.WriteStartArray();
                foreach (var item in ContainerImageNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ContainerRegistries))
            {
                writer.WritePropertyName("containerRegistries"u8);
                writer.WriteStartArray();
                foreach (var item in ContainerRegistries)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<BatchVmContainerRegistry>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static BatchVmContainerConfiguration DeserializeBatchVmContainerConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BatchVmContainerType type = default;
            Optional<IList<string>> containerImageNames = default;
            Optional<IList<BatchVmContainerRegistry>> containerRegistries = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new BatchVmContainerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("containerImageNames"u8))
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
                    containerImageNames = array;
                    continue;
                }
                if (property.NameEquals("containerRegistries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchVmContainerRegistry> array = new List<BatchVmContainerRegistry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchVmContainerRegistry.DeserializeBatchVmContainerRegistry(item));
                    }
                    containerRegistries = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BatchVmContainerConfiguration(type, Optional.ToList(containerImageNames), Optional.ToList(containerRegistries), rawData);
        }

        BatchVmContainerConfiguration IModelJsonSerializable<BatchVmContainerConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchVmContainerConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BatchVmContainerConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BatchVmContainerConfiguration IModelSerializable<BatchVmContainerConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBatchVmContainerConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BatchVmContainerConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BatchVmContainerConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(BatchVmContainerConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BatchVmContainerConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BatchVmContainerConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBatchVmContainerConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
