// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class ReplicationStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AggregatedState))
            {
                writer.WritePropertyName("aggregatedState");
                writer.WriteStringValue(AggregatedState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Summary))
            {
                writer.WritePropertyName("summary");
                writer.WriteStartArray();
                foreach (var item in Summary)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ReplicationStatus DeserializeReplicationStatus(JsonElement element)
        {
            Optional<AggregatedReplicationState> aggregatedState = default;
            Optional<IList<RegionalReplicationStatus>> summary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aggregatedState"))
                {
                    aggregatedState = new AggregatedReplicationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("summary"))
                {
                    List<RegionalReplicationStatus> array = new List<RegionalReplicationStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RegionalReplicationStatus.DeserializeRegionalReplicationStatus(item));
                    }
                    summary = array;
                    continue;
                }
            }
            return new ReplicationStatus(Optional.ToNullable(aggregatedState), Optional.ToList(summary));
        }
    }
}
