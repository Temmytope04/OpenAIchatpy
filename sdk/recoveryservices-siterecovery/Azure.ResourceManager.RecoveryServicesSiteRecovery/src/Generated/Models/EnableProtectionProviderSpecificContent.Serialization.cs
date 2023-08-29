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
    public partial class EnableProtectionProviderSpecificContent : IUtf8JsonSerializable, IModelJsonSerializable<EnableProtectionProviderSpecificContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EnableProtectionProviderSpecificContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EnableProtectionProviderSpecificContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

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

        internal static EnableProtectionProviderSpecificContent DeserializeEnableProtectionProviderSpecificContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A2A": return A2AEnableProtectionContent.DeserializeA2AEnableProtectionContent(element);
                    case "A2ACrossClusterMigration": return A2ACrossClusterMigrationEnableProtectionContent.DeserializeA2ACrossClusterMigrationEnableProtectionContent(element);
                    case "HyperVReplicaAzure": return HyperVReplicaAzureEnableProtectionContent.DeserializeHyperVReplicaAzureEnableProtectionContent(element);
                    case "InMage": return InMageEnableProtectionContent.DeserializeInMageEnableProtectionContent(element);
                    case "InMageAzureV2": return InMageAzureV2EnableProtectionContent.DeserializeInMageAzureV2EnableProtectionContent(element);
                    case "InMageRcm": return InMageRcmEnableProtectionContent.DeserializeInMageRcmEnableProtectionContent(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
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
            return new Models.EnableProtectionProviderSpecificContent(instanceType, rawData);
        }

        EnableProtectionProviderSpecificContent IModelJsonSerializable<EnableProtectionProviderSpecificContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEnableProtectionProviderSpecificContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EnableProtectionProviderSpecificContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EnableProtectionProviderSpecificContent IModelSerializable<EnableProtectionProviderSpecificContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEnableProtectionProviderSpecificContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(EnableProtectionProviderSpecificContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator EnableProtectionProviderSpecificContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEnableProtectionProviderSpecificContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
