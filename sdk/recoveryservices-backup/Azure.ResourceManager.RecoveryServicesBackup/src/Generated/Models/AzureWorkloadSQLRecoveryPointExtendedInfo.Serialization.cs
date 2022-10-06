// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class AzureWorkloadSQLRecoveryPointExtendedInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DataDirectoryTimeInUTC))
            {
                writer.WritePropertyName("dataDirectoryTimeInUTC");
                writer.WriteStringValue(DataDirectoryTimeInUTC.Value, "O");
            }
            if (Optional.IsCollectionDefined(DataDirectoryPaths))
            {
                writer.WritePropertyName("dataDirectoryPaths");
                writer.WriteStartArray();
                foreach (var item in DataDirectoryPaths)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AzureWorkloadSQLRecoveryPointExtendedInfo DeserializeAzureWorkloadSQLRecoveryPointExtendedInfo(JsonElement element)
        {
            Optional<DateTimeOffset> dataDirectoryTimeInUTC = default;
            Optional<IList<SQLDataDirectory>> dataDirectoryPaths = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataDirectoryTimeInUTC"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dataDirectoryTimeInUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("dataDirectoryPaths"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SQLDataDirectory> array = new List<SQLDataDirectory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SQLDataDirectory.DeserializeSQLDataDirectory(item));
                    }
                    dataDirectoryPaths = array;
                    continue;
                }
            }
            return new AzureWorkloadSQLRecoveryPointExtendedInfo(Optional.ToNullable(dataDirectoryTimeInUTC), Optional.ToList(dataDirectoryPaths));
        }
    }
}
