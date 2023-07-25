// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class RestoreFileSpecs : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(FileSpecType))
            {
                writer.WritePropertyName("fileSpecType"u8);
                writer.WriteStringValue(FileSpecType);
            }
            if (Optional.IsDefined(TargetFolderPath))
            {
                writer.WritePropertyName("targetFolderPath"u8);
                writer.WriteStringValue(TargetFolderPath);
            }
            writer.WriteEndObject();
        }

        internal static RestoreFileSpecs DeserializeRestoreFileSpecs(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> path = default;
            Optional<string> fileSpecType = default;
            Optional<string> targetFolderPath = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileSpecType"u8))
                {
                    fileSpecType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetFolderPath"u8))
                {
                    targetFolderPath = property.Value.GetString();
                    continue;
                }
            }
            return new RestoreFileSpecs(path.Value, fileSpecType.Value, targetFolderPath.Value);
        }
    }
}
