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
    public partial class ExistingRecoveryVirtualNetwork : IUtf8JsonSerializable, IModelJsonSerializable<ExistingRecoveryVirtualNetwork>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExistingRecoveryVirtualNetwork>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExistingRecoveryVirtualNetwork>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ExistingRecoveryVirtualNetwork>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("recoveryVirtualNetworkId"u8);
            writer.WriteStringValue(RecoveryVirtualNetworkId);
            if (Optional.IsDefined(RecoverySubnetName))
            {
                writer.WritePropertyName("recoverySubnetName"u8);
                writer.WriteStringValue(RecoverySubnetName);
            }
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
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

        internal static ExistingRecoveryVirtualNetwork DeserializeExistingRecoveryVirtualNetwork(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier recoveryVirtualNetworkId = default;
            Optional<string> recoverySubnetName = default;
            string resourceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryVirtualNetworkId"u8))
                {
                    recoveryVirtualNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoverySubnetName"u8))
                {
                    recoverySubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExistingRecoveryVirtualNetwork(resourceType, recoveryVirtualNetworkId, recoverySubnetName.Value, rawData);
        }

        ExistingRecoveryVirtualNetwork IModelJsonSerializable<ExistingRecoveryVirtualNetwork>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ExistingRecoveryVirtualNetwork>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExistingRecoveryVirtualNetwork(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExistingRecoveryVirtualNetwork>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ExistingRecoveryVirtualNetwork>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExistingRecoveryVirtualNetwork IModelSerializable<ExistingRecoveryVirtualNetwork>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ExistingRecoveryVirtualNetwork>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExistingRecoveryVirtualNetwork(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ExistingRecoveryVirtualNetwork model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ExistingRecoveryVirtualNetwork(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExistingRecoveryVirtualNetwork(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
