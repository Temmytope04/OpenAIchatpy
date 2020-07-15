// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class GeoReplicationStats : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(LastSyncTime))
            {
                writer.WritePropertyName("lastSyncTime");
                writer.WriteStringValue(LastSyncTime.Value, "O");
            }
            if (Optional.IsDefined(CanFailover))
            {
                writer.WritePropertyName("canFailover");
                writer.WriteBooleanValue(CanFailover.Value);
            }
            writer.WriteEndObject();
        }

        internal static GeoReplicationStats DeserializeGeoReplicationStats(JsonElement element)
        {
            Optional<GeoReplicationStatus> status = default;
            Optional<DateTimeOffset> lastSyncTime = default;
            Optional<bool> canFailover = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = new GeoReplicationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastSyncTime"))
                {
                    lastSyncTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("canFailover"))
                {
                    canFailover = property.Value.GetBoolean();
                    continue;
                }
            }
            return new GeoReplicationStats(Optional.ToNullable(status), Optional.ToNullable(lastSyncTime), Optional.ToNullable(canFailover));
        }
    }
}
