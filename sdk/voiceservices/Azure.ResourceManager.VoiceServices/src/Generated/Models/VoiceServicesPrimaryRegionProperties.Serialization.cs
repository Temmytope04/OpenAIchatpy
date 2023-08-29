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

namespace Azure.ResourceManager.VoiceServices.Models
{
    public partial class VoiceServicesPrimaryRegionProperties : IUtf8JsonSerializable, IModelJsonSerializable<VoiceServicesPrimaryRegionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VoiceServicesPrimaryRegionProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VoiceServicesPrimaryRegionProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("operatorAddresses"u8);
            writer.WriteStartArray();
            foreach (var item in OperatorAddresses)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(EsrpAddresses))
            {
                writer.WritePropertyName("esrpAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in EsrpAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AllowedSignalingSourceAddressPrefixes))
            {
                writer.WritePropertyName("allowedSignalingSourceAddressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedSignalingSourceAddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AllowedMediaSourceAddressPrefixes))
            {
                writer.WritePropertyName("allowedMediaSourceAddressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedMediaSourceAddressPrefixes)
                {
                    writer.WriteStringValue(item);
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

        internal static VoiceServicesPrimaryRegionProperties DeserializeVoiceServicesPrimaryRegionProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> operatorAddresses = default;
            Optional<IList<string>> esrpAddresses = default;
            Optional<IList<string>> allowedSignalingSourceAddressPrefixes = default;
            Optional<IList<string>> allowedMediaSourceAddressPrefixes = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operatorAddresses"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    operatorAddresses = array;
                    continue;
                }
                if (property.NameEquals("esrpAddresses"u8))
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
                    esrpAddresses = array;
                    continue;
                }
                if (property.NameEquals("allowedSignalingSourceAddressPrefixes"u8))
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
                    allowedSignalingSourceAddressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("allowedMediaSourceAddressPrefixes"u8))
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
                    allowedMediaSourceAddressPrefixes = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VoiceServicesPrimaryRegionProperties(operatorAddresses, Optional.ToList(esrpAddresses), Optional.ToList(allowedSignalingSourceAddressPrefixes), Optional.ToList(allowedMediaSourceAddressPrefixes), rawData);
        }

        VoiceServicesPrimaryRegionProperties IModelJsonSerializable<VoiceServicesPrimaryRegionProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVoiceServicesPrimaryRegionProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VoiceServicesPrimaryRegionProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VoiceServicesPrimaryRegionProperties IModelSerializable<VoiceServicesPrimaryRegionProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVoiceServicesPrimaryRegionProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(VoiceServicesPrimaryRegionProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator VoiceServicesPrimaryRegionProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVoiceServicesPrimaryRegionProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
