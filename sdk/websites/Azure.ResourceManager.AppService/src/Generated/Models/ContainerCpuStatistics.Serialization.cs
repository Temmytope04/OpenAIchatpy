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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ContainerCpuStatistics : IUtf8JsonSerializable, IModelJsonSerializable<ContainerCpuStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerCpuStatistics>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerCpuStatistics>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerCpuStatistics>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CpuUsage))
            {
                writer.WritePropertyName("cpuUsage"u8);
                if (CpuUsage is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContainerCpuUsage>)CpuUsage).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SystemCpuUsage))
            {
                writer.WritePropertyName("systemCpuUsage"u8);
                writer.WriteNumberValue(SystemCpuUsage.Value);
            }
            if (Optional.IsDefined(OnlineCpuCount))
            {
                writer.WritePropertyName("onlineCpuCount"u8);
                writer.WriteNumberValue(OnlineCpuCount.Value);
            }
            if (Optional.IsDefined(ThrottlingData))
            {
                writer.WritePropertyName("throttlingData"u8);
                if (ThrottlingData is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContainerThrottlingInfo>)ThrottlingData).Serialize(writer, options);
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

        internal static ContainerCpuStatistics DeserializeContainerCpuStatistics(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerCpuUsage> cpuUsage = default;
            Optional<long> systemCpuUsage = default;
            Optional<int> onlineCpuCount = default;
            Optional<ContainerThrottlingInfo> throttlingData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpuUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuUsage = ContainerCpuUsage.DeserializeContainerCpuUsage(property.Value);
                    continue;
                }
                if (property.NameEquals("systemCpuUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemCpuUsage = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("onlineCpuCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onlineCpuCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("throttlingData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throttlingData = ContainerThrottlingInfo.DeserializeContainerThrottlingInfo(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerCpuStatistics(cpuUsage.Value, Optional.ToNullable(systemCpuUsage), Optional.ToNullable(onlineCpuCount), throttlingData.Value, rawData);
        }

        ContainerCpuStatistics IModelJsonSerializable<ContainerCpuStatistics>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerCpuStatistics>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerCpuStatistics(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerCpuStatistics>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerCpuStatistics>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerCpuStatistics IModelSerializable<ContainerCpuStatistics>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerCpuStatistics>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerCpuStatistics(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerCpuStatistics"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerCpuStatistics"/> to convert. </param>
        public static implicit operator RequestContent(ContainerCpuStatistics model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerCpuStatistics"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerCpuStatistics(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerCpuStatistics(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
