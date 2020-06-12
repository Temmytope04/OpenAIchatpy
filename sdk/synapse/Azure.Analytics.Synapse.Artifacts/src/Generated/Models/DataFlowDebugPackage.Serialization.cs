// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class DataFlowDebugPackage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (SessionId != null)
            {
                writer.WritePropertyName("sessionId");
                writer.WriteStringValue(SessionId);
            }
            if (DataFlow != null)
            {
                writer.WritePropertyName("dataFlow");
                writer.WriteObjectValue(DataFlow);
            }
            if (Datasets != null)
            {
                writer.WritePropertyName("datasets");
                writer.WriteStartArray();
                foreach (var item in Datasets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (LinkedServices != null)
            {
                writer.WritePropertyName("linkedServices");
                writer.WriteStartArray();
                foreach (var item in LinkedServices)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Staging != null)
            {
                writer.WritePropertyName("staging");
                writer.WriteObjectValue(Staging);
            }
            if (DebugSettings != null)
            {
                writer.WritePropertyName("debugSettings");
                writer.WriteObjectValue(DebugSettings);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }
    }
}
