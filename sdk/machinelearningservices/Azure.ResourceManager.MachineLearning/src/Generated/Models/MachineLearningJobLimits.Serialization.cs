// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningJobLimits : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("jobLimitsType"u8);
            writer.WriteStringValue(JobLimitsType.ToString());
            if (Optional.IsDefined(Timeout))
            {
                if (Timeout != null)
                {
                    writer.WritePropertyName("timeout"u8);
                    writer.WriteStringValue(Timeout.Value, "P");
                }
                else
                {
                    writer.WriteNull("timeout");
                }
            }
            writer.WriteEndObject();
        }

        internal static MachineLearningJobLimits DeserializeMachineLearningJobLimits(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("jobLimitsType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Sweep": return MachineLearningSweepJobLimits.DeserializeMachineLearningSweepJobLimits(element);
                    case "Command": return MachineLearningCommandJobLimits.DeserializeMachineLearningCommandJobLimits(element);
                }
            }
            return UnknownJobLimits.DeserializeUnknownJobLimits(element);
        }
    }
}
