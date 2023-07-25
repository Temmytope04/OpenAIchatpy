// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupInstancePolicyInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("policyId"u8);
            writer.WriteStringValue(PolicyId);
            if (Optional.IsDefined(PolicyParameters))
            {
                writer.WritePropertyName("policyParameters"u8);
                writer.WriteObjectValue(PolicyParameters);
            }
            writer.WriteEndObject();
        }

        internal static BackupInstancePolicyInfo DeserializeBackupInstancePolicyInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier policyId = default;
            Optional<string> policyVersion = default;
            Optional<BackupInstancePolicySettings> policyParameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyId"u8))
                {
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyVersion"u8))
                {
                    policyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyParameters = BackupInstancePolicySettings.DeserializeBackupInstancePolicySettings(property.Value);
                    continue;
                }
            }
            return new BackupInstancePolicyInfo(policyId, policyVersion.Value, policyParameters.Value);
        }
    }
}
