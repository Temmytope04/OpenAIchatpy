// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningEncryptionSetting : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(Identity);
            }
            writer.WritePropertyName("keyVaultProperties"u8);
            writer.WriteObjectValue(KeyVaultProperties);
            writer.WriteEndObject();
        }

        internal static MachineLearningEncryptionSetting DeserializeMachineLearningEncryptionSetting(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningEncryptionStatus status = default;
            Optional<MachineLearningCmkIdentity> identity = default;
            MachineLearningEncryptionKeyVaultProperties keyVaultProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = new MachineLearningEncryptionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = MachineLearningCmkIdentity.DeserializeMachineLearningCmkIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("keyVaultProperties"u8))
                {
                    keyVaultProperties = MachineLearningEncryptionKeyVaultProperties.DeserializeMachineLearningEncryptionKeyVaultProperties(property.Value);
                    continue;
                }
            }
            return new MachineLearningEncryptionSetting(status, identity.Value, keyVaultProperties);
        }
    }
}
