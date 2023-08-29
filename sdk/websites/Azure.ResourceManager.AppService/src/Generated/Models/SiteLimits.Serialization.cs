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
    public partial class SiteLimits : IUtf8JsonSerializable, IModelJsonSerializable<SiteLimits>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteLimits>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteLimits>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MaxPercentageCpu))
            {
                writer.WritePropertyName("maxPercentageCpu"u8);
                writer.WriteNumberValue(MaxPercentageCpu.Value);
            }
            if (Optional.IsDefined(MaxMemoryInMb))
            {
                writer.WritePropertyName("maxMemoryInMb"u8);
                writer.WriteNumberValue(MaxMemoryInMb.Value);
            }
            if (Optional.IsDefined(MaxDiskSizeInMb))
            {
                writer.WritePropertyName("maxDiskSizeInMb"u8);
                writer.WriteNumberValue(MaxDiskSizeInMb.Value);
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

        internal static SiteLimits DeserializeSiteLimits(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<double> maxPercentageCpu = default;
            Optional<long> maxMemoryInMb = default;
            Optional<long> maxDiskSizeInMb = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxPercentageCpu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPercentageCpu = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("maxMemoryInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxMemoryInMb = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxDiskSizeInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDiskSizeInMb = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteLimits(Optional.ToNullable(maxPercentageCpu), Optional.ToNullable(maxMemoryInMb), Optional.ToNullable(maxDiskSizeInMb), rawData);
        }

        SiteLimits IModelJsonSerializable<SiteLimits>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteLimits(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteLimits>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteLimits IModelSerializable<SiteLimits>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteLimits(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SiteLimits model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SiteLimits(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteLimits(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
