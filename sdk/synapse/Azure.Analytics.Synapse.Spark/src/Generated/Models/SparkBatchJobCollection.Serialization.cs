// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkBatchJobCollection
    {
        internal static SparkBatchJobCollection DeserializeSparkBatchJobCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int @from = default;
            int total = default;
            IReadOnlyList<SparkBatchJob> sessions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("from"u8))
                {
                    @from = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("total"u8))
                {
                    total = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sessions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SparkBatchJob> array = new List<SparkBatchJob>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SparkBatchJob.DeserializeSparkBatchJob(item));
                    }
                    sessions = array;
                    continue;
                }
            }
            return new SparkBatchJobCollection(@from, total, sessions ?? new ChangeTrackingList<SparkBatchJob>());
        }
    }
}
