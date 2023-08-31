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

namespace Azure.ResourceManager.RecoveryServices.Models
{
    public partial class RecoveryServicesPrivateLinkServiceConnectionState : IUtf8JsonSerializable, IModelJsonSerializable<RecoveryServicesPrivateLinkServiceConnectionState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RecoveryServicesPrivateLinkServiceConnectionState>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RecoveryServicesPrivateLinkServiceConnectionState>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static RecoveryServicesPrivateLinkServiceConnectionState DeserializeRecoveryServicesPrivateLinkServiceConnectionState(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RecoveryServicesPrivateEndpointConnectionStatus> status = default;
            Optional<string> description = default;
            Optional<string> actionsRequired = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new RecoveryServicesPrivateEndpointConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionsRequired"u8))
                {
                    actionsRequired = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RecoveryServicesPrivateLinkServiceConnectionState(Optional.ToNullable(status), description.Value, actionsRequired.Value, rawData);
        }

        RecoveryServicesPrivateLinkServiceConnectionState IModelJsonSerializable<RecoveryServicesPrivateLinkServiceConnectionState>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryServicesPrivateLinkServiceConnectionState(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RecoveryServicesPrivateLinkServiceConnectionState>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RecoveryServicesPrivateLinkServiceConnectionState IModelSerializable<RecoveryServicesPrivateLinkServiceConnectionState>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRecoveryServicesPrivateLinkServiceConnectionState(doc.RootElement, options);
        }

        public static implicit operator RequestContent(RecoveryServicesPrivateLinkServiceConnectionState model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator RecoveryServicesPrivateLinkServiceConnectionState(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRecoveryServicesPrivateLinkServiceConnectionState(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
