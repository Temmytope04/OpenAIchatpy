// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class Replication
    {
        internal static Replication DeserializeReplication(JsonElement element)
        {
            Optional<EndpointType> endpointType = default;
            Optional<ReplicationSchedule> replicationSchedule = default;
            string remoteVolumeResourceId = default;
            Optional<string> remoteVolumeRegion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endpointType = new EndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("replicationSchedule"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    replicationSchedule = new ReplicationSchedule(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("remoteVolumeResourceId"))
                {
                    remoteVolumeResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remoteVolumeRegion"))
                {
                    remoteVolumeRegion = property.Value.GetString();
                    continue;
                }
            }
            return new Replication(Optional.ToNullable(endpointType), Optional.ToNullable(replicationSchedule), remoteVolumeResourceId, remoteVolumeRegion.Value);
        }
    }
}
