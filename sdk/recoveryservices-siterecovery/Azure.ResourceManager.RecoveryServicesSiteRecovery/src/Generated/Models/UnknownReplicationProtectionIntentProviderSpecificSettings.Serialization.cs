// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class UnknownReplicationProtectionIntentProviderSpecificSettings : IUtf8JsonSerializable, IModelJsonSerializable<ReplicationProtectionIntentProviderSpecificSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ReplicationProtectionIntentProviderSpecificSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ReplicationProtectionIntentProviderSpecificSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static ReplicationProtectionIntentProviderSpecificSettings DeserializeUnknownReplicationProtectionIntentProviderSpecificSettings(JsonElement element, ModelSerializerOptions options = default) => DeserializeReplicationProtectionIntentProviderSpecificSettings(element, options);

        ReplicationProtectionIntentProviderSpecificSettings IModelJsonSerializable<ReplicationProtectionIntentProviderSpecificSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownReplicationProtectionIntentProviderSpecificSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ReplicationProtectionIntentProviderSpecificSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ReplicationProtectionIntentProviderSpecificSettings IModelSerializable<ReplicationProtectionIntentProviderSpecificSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeReplicationProtectionIntentProviderSpecificSettings(doc.RootElement, options);
        }
    }
}
