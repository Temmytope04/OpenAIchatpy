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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ConnectivityCheckRequestDestination : IUtf8JsonSerializable, IModelJsonSerializable<ConnectivityCheckRequestDestination>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConnectivityCheckRequestDestination>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConnectivityCheckRequestDestination>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("address"u8);
            writer.WriteStringValue(Address);
            writer.WritePropertyName("port"u8);
            writer.WriteNumberValue(Port);
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

        internal static ConnectivityCheckRequestDestination DeserializeConnectivityCheckRequestDestination(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string address = default;
            long port = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("address"u8))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    port = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConnectivityCheckRequestDestination(address, port, rawData);
        }

        ConnectivityCheckRequestDestination IModelJsonSerializable<ConnectivityCheckRequestDestination>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectivityCheckRequestDestination(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConnectivityCheckRequestDestination>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConnectivityCheckRequestDestination IModelSerializable<ConnectivityCheckRequestDestination>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConnectivityCheckRequestDestination(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConnectivityCheckRequestDestination"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConnectivityCheckRequestDestination"/> to convert. </param>
        public static implicit operator RequestContent(ConnectivityCheckRequestDestination model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConnectivityCheckRequestDestination"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConnectivityCheckRequestDestination(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConnectivityCheckRequestDestination(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
