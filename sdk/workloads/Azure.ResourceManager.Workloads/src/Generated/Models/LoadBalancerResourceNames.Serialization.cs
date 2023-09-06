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

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class LoadBalancerResourceNames : IUtf8JsonSerializable, IModelJsonSerializable<LoadBalancerResourceNames>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LoadBalancerResourceNames>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LoadBalancerResourceNames>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadBalancerResourceNames>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LoadBalancerName))
            {
                writer.WritePropertyName("loadBalancerName"u8);
                writer.WriteStringValue(LoadBalancerName);
            }
            if (Optional.IsCollectionDefined(FrontendIPConfigurationNames))
            {
                writer.WritePropertyName("frontendIpConfigurationNames"u8);
                writer.WriteStartArray();
                foreach (var item in FrontendIPConfigurationNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(BackendPoolNames))
            {
                writer.WritePropertyName("backendPoolNames"u8);
                writer.WriteStartArray();
                foreach (var item in BackendPoolNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(HealthProbeNames))
            {
                writer.WritePropertyName("healthProbeNames"u8);
                writer.WriteStartArray();
                foreach (var item in HealthProbeNames)
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

        internal static LoadBalancerResourceNames DeserializeLoadBalancerResourceNames(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> loadBalancerName = default;
            Optional<IList<string>> frontendIPConfigurationNames = default;
            Optional<IList<string>> backendPoolNames = default;
            Optional<IList<string>> healthProbeNames = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("loadBalancerName"u8))
                {
                    loadBalancerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("frontendIpConfigurationNames"u8))
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
                    frontendIPConfigurationNames = array;
                    continue;
                }
                if (property.NameEquals("backendPoolNames"u8))
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
                    backendPoolNames = array;
                    continue;
                }
                if (property.NameEquals("healthProbeNames"u8))
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
                    healthProbeNames = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LoadBalancerResourceNames(loadBalancerName.Value, Optional.ToList(frontendIPConfigurationNames), Optional.ToList(backendPoolNames), Optional.ToList(healthProbeNames), rawData);
        }

        LoadBalancerResourceNames IModelJsonSerializable<LoadBalancerResourceNames>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadBalancerResourceNames>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadBalancerResourceNames(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LoadBalancerResourceNames>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadBalancerResourceNames>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LoadBalancerResourceNames IModelSerializable<LoadBalancerResourceNames>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadBalancerResourceNames>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLoadBalancerResourceNames(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LoadBalancerResourceNames"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LoadBalancerResourceNames"/> to convert. </param>
        public static implicit operator RequestContent(LoadBalancerResourceNames model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LoadBalancerResourceNames"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LoadBalancerResourceNames(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLoadBalancerResourceNames(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
