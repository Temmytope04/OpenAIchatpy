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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VmmToVmmNetworkMappingSettings : IUtf8JsonSerializable, IModelJsonSerializable<VmmToVmmNetworkMappingSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VmmToVmmNetworkMappingSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VmmToVmmNetworkMappingSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmmToVmmNetworkMappingSettings>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        internal static VmmToVmmNetworkMappingSettings DeserializeVmmToVmmNetworkMappingSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string instanceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VmmToVmmNetworkMappingSettings(instanceType, rawData);
        }

        VmmToVmmNetworkMappingSettings IModelJsonSerializable<VmmToVmmNetworkMappingSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmmToVmmNetworkMappingSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVmmToVmmNetworkMappingSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VmmToVmmNetworkMappingSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmmToVmmNetworkMappingSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VmmToVmmNetworkMappingSettings IModelSerializable<VmmToVmmNetworkMappingSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmmToVmmNetworkMappingSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVmmToVmmNetworkMappingSettings(doc.RootElement, options);
        }

        public static implicit operator RequestContent(VmmToVmmNetworkMappingSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator VmmToVmmNetworkMappingSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVmmToVmmNetworkMappingSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
