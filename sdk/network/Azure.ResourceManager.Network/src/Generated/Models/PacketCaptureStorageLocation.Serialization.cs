// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PacketCaptureStorageLocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (StorageId != null)
            {
                writer.WritePropertyName("storageId");
                writer.WriteStringValue(StorageId);
            }
            if (StoragePath != null)
            {
                writer.WritePropertyName("storagePath");
                writer.WriteStringValue(StoragePath);
            }
            if (FilePath != null)
            {
                writer.WritePropertyName("filePath");
                writer.WriteStringValue(FilePath);
            }
            writer.WriteEndObject();
        }

        internal static PacketCaptureStorageLocation DeserializePacketCaptureStorageLocation(JsonElement element)
        {
            string storageId = default;
            string storagePath = default;
            string filePath = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storagePath"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storagePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filePath"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filePath = property.Value.GetString();
                    continue;
                }
            }
            return new PacketCaptureStorageLocation(storageId, storagePath, filePath);
        }
    }
}
