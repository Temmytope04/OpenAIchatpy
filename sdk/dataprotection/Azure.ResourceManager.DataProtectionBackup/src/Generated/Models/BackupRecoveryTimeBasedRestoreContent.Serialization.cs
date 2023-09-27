// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupRecoveryTimeBasedRestoreContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("recoveryPointTime"u8);
            writer.WriteStringValue(RecoverOn, "O");
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WritePropertyName("restoreTargetInfo"u8);
            writer.WriteObjectValue(RestoreTargetInfo);
            writer.WritePropertyName("sourceDataStoreType"u8);
            writer.WriteStringValue(SourceDataStoreType.ToString());
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(IdentityDetails))
            {
                writer.WritePropertyName("identityDetails"u8);
                writer.WriteObjectValue(IdentityDetails);
            }
            writer.WriteEndObject();
        }
    }
}
