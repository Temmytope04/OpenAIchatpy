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

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageRoutingPreference : IUtf8JsonSerializable, IModelJsonSerializable<StorageRoutingPreference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageRoutingPreference>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageRoutingPreference>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RoutingChoice))
            {
                writer.WritePropertyName("routingChoice"u8);
                writer.WriteStringValue(RoutingChoice.Value.ToString());
            }
            if (Optional.IsDefined(IsMicrosoftEndpointsPublished))
            {
                writer.WritePropertyName("publishMicrosoftEndpoints"u8);
                writer.WriteBooleanValue(IsMicrosoftEndpointsPublished.Value);
            }
            if (Optional.IsDefined(IsInternetEndpointsPublished))
            {
                writer.WritePropertyName("publishInternetEndpoints"u8);
                writer.WriteBooleanValue(IsInternetEndpointsPublished.Value);
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

        internal static StorageRoutingPreference DeserializeStorageRoutingPreference(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StorageRoutingChoice> routingChoice = default;
            Optional<bool> publishMicrosoftEndpoints = default;
            Optional<bool> publishInternetEndpoints = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routingChoice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routingChoice = new StorageRoutingChoice(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publishMicrosoftEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publishMicrosoftEndpoints = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publishInternetEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publishInternetEndpoints = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageRoutingPreference(Optional.ToNullable(routingChoice), Optional.ToNullable(publishMicrosoftEndpoints), Optional.ToNullable(publishInternetEndpoints), rawData);
        }

        StorageRoutingPreference IModelJsonSerializable<StorageRoutingPreference>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageRoutingPreference(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageRoutingPreference>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageRoutingPreference IModelSerializable<StorageRoutingPreference>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageRoutingPreference(doc.RootElement, options);
        }

        public static implicit operator RequestContent(StorageRoutingPreference model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator StorageRoutingPreference(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageRoutingPreference(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
