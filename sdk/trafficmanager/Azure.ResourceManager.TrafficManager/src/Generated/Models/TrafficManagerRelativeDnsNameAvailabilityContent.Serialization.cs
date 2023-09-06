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

namespace Azure.ResourceManager.TrafficManager.Models
{
    public partial class TrafficManagerRelativeDnsNameAvailabilityContent : IUtf8JsonSerializable, IModelJsonSerializable<TrafficManagerRelativeDnsNameAvailabilityContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TrafficManagerRelativeDnsNameAvailabilityContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TrafficManagerRelativeDnsNameAvailabilityContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TrafficManagerRelativeDnsNameAvailabilityContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
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

        internal static TrafficManagerRelativeDnsNameAvailabilityContent DeserializeTrafficManagerRelativeDnsNameAvailabilityContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TrafficManagerRelativeDnsNameAvailabilityContent(name.Value, Optional.ToNullable(type), rawData);
        }

        TrafficManagerRelativeDnsNameAvailabilityContent IModelJsonSerializable<TrafficManagerRelativeDnsNameAvailabilityContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TrafficManagerRelativeDnsNameAvailabilityContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTrafficManagerRelativeDnsNameAvailabilityContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TrafficManagerRelativeDnsNameAvailabilityContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TrafficManagerRelativeDnsNameAvailabilityContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TrafficManagerRelativeDnsNameAvailabilityContent IModelSerializable<TrafficManagerRelativeDnsNameAvailabilityContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TrafficManagerRelativeDnsNameAvailabilityContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTrafficManagerRelativeDnsNameAvailabilityContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TrafficManagerRelativeDnsNameAvailabilityContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TrafficManagerRelativeDnsNameAvailabilityContent"/> to convert. </param>
        public static implicit operator RequestContent(TrafficManagerRelativeDnsNameAvailabilityContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TrafficManagerRelativeDnsNameAvailabilityContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TrafficManagerRelativeDnsNameAvailabilityContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTrafficManagerRelativeDnsNameAvailabilityContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
