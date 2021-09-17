// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkStatement
    {
        internal static SparkStatement DeserializeSparkStatement(JsonElement element)
        {
            int id = default;
            Optional<string> code = default;
            Optional<LivyStatementStates> state = default;
            Optional<SparkStatementOutput> output = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = new LivyStatementStates(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("output"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        output = null;
                        continue;
                    }
                    output = SparkStatementOutput.DeserializeSparkStatementOutput(property.Value);
                    continue;
                }
            }
            return new SparkStatement(id, code.Value, Optional.ToNullable(state), output.Value);
        }
    }
}
