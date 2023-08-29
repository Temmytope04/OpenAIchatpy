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
    public partial class ReverseReplicationProviderSpecificContent : IUtf8JsonSerializable, IModelJsonSerializable<ReverseReplicationProviderSpecificContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ReverseReplicationProviderSpecificContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ReverseReplicationProviderSpecificContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static ReverseReplicationProviderSpecificContent DeserializeReverseReplicationProviderSpecificContent(JsonElement element, ModelSerializerOptions options = default)
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
                    case "A2A": return A2AReprotectContent.DeserializeA2AReprotectContent(element);
                    case "HyperVReplicaAzure": return HyperVReplicaAzureReprotectContent.DeserializeHyperVReplicaAzureReprotectContent(element);
                    case "InMage": return InMageReprotectContent.DeserializeInMageReprotectContent(element);
                    case "InMageAzureV2": return InMageAzureV2ReprotectContent.DeserializeInMageAzureV2ReprotectContent(element);
                    case "InMageRcm": return InMageRcmReprotectContent.DeserializeInMageRcmReprotectContent(element);
                    case "InMageRcmFailback": return InMageRcmFailbackReprotectContent.DeserializeInMageRcmFailbackReprotectContent(element);
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
            return new Models.ReverseReplicationProviderSpecificContent(instanceType, rawData);
        }

        ReverseReplicationProviderSpecificContent IModelJsonSerializable<ReverseReplicationProviderSpecificContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeReverseReplicationProviderSpecificContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ReverseReplicationProviderSpecificContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ReverseReplicationProviderSpecificContent IModelSerializable<ReverseReplicationProviderSpecificContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeReverseReplicationProviderSpecificContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ReverseReplicationProviderSpecificContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ReverseReplicationProviderSpecificContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeReverseReplicationProviderSpecificContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
