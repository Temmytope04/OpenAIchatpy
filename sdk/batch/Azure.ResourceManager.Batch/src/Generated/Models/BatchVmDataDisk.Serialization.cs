// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchVmDataDisk : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("lun");
            writer.WriteNumberValue(Lun);
            if (Optional.IsDefined(Caching))
            {
                writer.WritePropertyName("caching");
                writer.WriteStringValue(Caching.Value.ToSerialString());
            }
            writer.WritePropertyName("diskSizeGB");
            writer.WriteNumberValue(DiskSizeInGB);
            if (Optional.IsDefined(StorageAccountType))
            {
                writer.WritePropertyName("storageAccountType");
                writer.WriteStringValue(StorageAccountType.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static BatchVmDataDisk DeserializeBatchVmDataDisk(JsonElement element)
        {
            int lun = default;
            Optional<BatchDiskCachingType> caching = default;
            int diskSizeGB = default;
            Optional<BatchStorageAccountType> storageAccountType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lun"))
                {
                    lun = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("caching"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    caching = property.Value.GetString().ToBatchDiskCachingType();
                    continue;
                }
                if (property.NameEquals("diskSizeGB"))
                {
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("storageAccountType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageAccountType = property.Value.GetString().ToBatchStorageAccountType();
                    continue;
                }
            }
            return new BatchVmDataDisk(lun, Optional.ToNullable(caching), diskSizeGB, Optional.ToNullable(storageAccountType));
        }
    }
}
