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
    public partial class UnplannedFailoverProviderSpecificContent : IUtf8JsonSerializable, IModelJsonSerializable<UnplannedFailoverProviderSpecificContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<UnplannedFailoverProviderSpecificContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<UnplannedFailoverProviderSpecificContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static UnplannedFailoverProviderSpecificContent DeserializeUnplannedFailoverProviderSpecificContent(JsonElement element, ModelSerializerOptions options = default)
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
                    case "A2A": return A2AUnplannedFailoverContent.DeserializeA2AUnplannedFailoverContent(element);
                    case "HyperVReplicaAzure": return HyperVReplicaAzureUnplannedFailoverContent.DeserializeHyperVReplicaAzureUnplannedFailoverContent(element);
                    case "InMage": return InMageUnplannedFailoverContent.DeserializeInMageUnplannedFailoverContent(element);
                    case "InMageAzureV2": return InMageAzureV2UnplannedFailoverContent.DeserializeInMageAzureV2UnplannedFailoverContent(element);
                    case "InMageRcm": return InMageRcmUnplannedFailoverContent.DeserializeInMageRcmUnplannedFailoverContent(element);
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
            return new Models.UnplannedFailoverProviderSpecificContent(instanceType, rawData);
        }

        UnplannedFailoverProviderSpecificContent IModelJsonSerializable<UnplannedFailoverProviderSpecificContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnplannedFailoverProviderSpecificContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<UnplannedFailoverProviderSpecificContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        UnplannedFailoverProviderSpecificContent IModelSerializable<UnplannedFailoverProviderSpecificContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeUnplannedFailoverProviderSpecificContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(UnplannedFailoverProviderSpecificContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator UnplannedFailoverProviderSpecificContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeUnplannedFailoverProviderSpecificContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
