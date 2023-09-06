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

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class DiscoveredOnvifDeviceCollection : IUtf8JsonSerializable, IModelJsonSerializable<DiscoveredOnvifDeviceCollection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DiscoveredOnvifDeviceCollection>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DiscoveredOnvifDeviceCollection>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiscoveredOnvifDeviceCollection>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DiscoveredOnvifDevice>)item).Serialize(writer, options);
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

        internal static DiscoveredOnvifDeviceCollection DeserializeDiscoveredOnvifDeviceCollection(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<DiscoveredOnvifDevice>> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiscoveredOnvifDevice> array = new List<DiscoveredOnvifDevice>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiscoveredOnvifDevice.DeserializeDiscoveredOnvifDevice(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DiscoveredOnvifDeviceCollection(Optional.ToList(value), rawData);
        }

        DiscoveredOnvifDeviceCollection IModelJsonSerializable<DiscoveredOnvifDeviceCollection>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiscoveredOnvifDeviceCollection>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDiscoveredOnvifDeviceCollection(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DiscoveredOnvifDeviceCollection>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiscoveredOnvifDeviceCollection>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DiscoveredOnvifDeviceCollection IModelSerializable<DiscoveredOnvifDeviceCollection>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiscoveredOnvifDeviceCollection>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDiscoveredOnvifDeviceCollection(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DiscoveredOnvifDeviceCollection"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DiscoveredOnvifDeviceCollection"/> to convert. </param>
        public static implicit operator RequestContent(DiscoveredOnvifDeviceCollection model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DiscoveredOnvifDeviceCollection"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DiscoveredOnvifDeviceCollection(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDiscoveredOnvifDeviceCollection(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
