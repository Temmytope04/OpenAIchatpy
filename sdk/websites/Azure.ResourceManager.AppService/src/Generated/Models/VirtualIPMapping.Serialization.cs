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
    public partial class VirtualIPMapping : IUtf8JsonSerializable, IModelJsonSerializable<VirtualIPMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VirtualIPMapping>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VirtualIPMapping>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualIPMapping>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualIP))
            {
                writer.WritePropertyName("virtualIP"u8);
                writer.WriteStringValue(VirtualIP);
            }
            if (Optional.IsDefined(InternalHttpPort))
            {
                writer.WritePropertyName("internalHttpPort"u8);
                writer.WriteNumberValue(InternalHttpPort.Value);
            }
            if (Optional.IsDefined(InternalHttpsPort))
            {
                writer.WritePropertyName("internalHttpsPort"u8);
                writer.WriteNumberValue(InternalHttpsPort.Value);
            }
            if (Optional.IsDefined(IsInUse))
            {
                writer.WritePropertyName("inUse"u8);
                writer.WriteBooleanValue(IsInUse.Value);
            }
            if (Optional.IsDefined(ServiceName))
            {
                writer.WritePropertyName("serviceName"u8);
                writer.WriteStringValue(ServiceName);
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

        internal static VirtualIPMapping DeserializeVirtualIPMapping(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> virtualIP = default;
            Optional<int> internalHttpPort = default;
            Optional<int> internalHttpsPort = default;
            Optional<bool> inUse = default;
            Optional<string> serviceName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualIP"u8))
                {
                    virtualIP = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("internalHttpPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    internalHttpPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("internalHttpsPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    internalHttpsPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("inUse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inUse = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("serviceName"u8))
                {
                    serviceName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VirtualIPMapping(virtualIP.Value, Optional.ToNullable(internalHttpPort), Optional.ToNullable(internalHttpsPort), Optional.ToNullable(inUse), serviceName.Value, rawData);
        }

        VirtualIPMapping IModelJsonSerializable<VirtualIPMapping>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualIPMapping>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualIPMapping(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VirtualIPMapping>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualIPMapping>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VirtualIPMapping IModelSerializable<VirtualIPMapping>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualIPMapping>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVirtualIPMapping(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VirtualIPMapping"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VirtualIPMapping"/> to convert. </param>
        public static implicit operator RequestContent(VirtualIPMapping model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VirtualIPMapping"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VirtualIPMapping(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVirtualIPMapping(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
