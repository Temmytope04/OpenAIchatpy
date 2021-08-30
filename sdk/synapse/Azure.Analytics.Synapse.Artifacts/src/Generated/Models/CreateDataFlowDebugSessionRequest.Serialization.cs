// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(CreateDataFlowDebugSessionRequestConverter))]
    public partial class CreateDataFlowDebugSessionRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DataFlowName))
            {
                writer.WritePropertyName("dataFlowName");
                writer.WriteStringValue(DataFlowName);
            }
            if (Optional.IsDefined(ExistingClusterId))
            {
                writer.WritePropertyName("existingClusterId");
                writer.WriteStringValue(ExistingClusterId);
            }
            if (Optional.IsDefined(ClusterTimeout))
            {
                writer.WritePropertyName("clusterTimeout");
                writer.WriteNumberValue(ClusterTimeout.Value);
            }
            if (Optional.IsDefined(NewClusterName))
            {
                writer.WritePropertyName("newClusterName");
                writer.WriteStringValue(NewClusterName);
            }
            if (Optional.IsDefined(NewClusterNodeType))
            {
                writer.WritePropertyName("newClusterNodeType");
                writer.WriteStringValue(NewClusterNodeType);
            }
            if (Optional.IsDefined(DataBricksLinkedService))
            {
                writer.WritePropertyName("dataBricksLinkedService");
                writer.WriteObjectValue(DataBricksLinkedService);
            }
            writer.WriteEndObject();
        }

        internal static CreateDataFlowDebugSessionRequest DeserializeCreateDataFlowDebugSessionRequest(JsonElement element)
        {
            Optional<string> dataFlowName = default;
            Optional<string> existingClusterId = default;
            Optional<int> clusterTimeout = default;
            Optional<string> newClusterName = default;
            Optional<string> newClusterNodeType = default;
            Optional<LinkedServiceResource> dataBricksLinkedService = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataFlowName"))
                {
                    dataFlowName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("existingClusterId"))
                {
                    existingClusterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterTimeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    clusterTimeout = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("newClusterName"))
                {
                    newClusterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("newClusterNodeType"))
                {
                    newClusterNodeType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataBricksLinkedService"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dataBricksLinkedService = LinkedServiceResource.DeserializeLinkedServiceResource(property.Value);
                    continue;
                }
            }
            return new CreateDataFlowDebugSessionRequest(dataFlowName.Value, existingClusterId.Value, Optional.ToNullable(clusterTimeout), newClusterName.Value, newClusterNodeType.Value, dataBricksLinkedService.Value);
        }

        internal partial class CreateDataFlowDebugSessionRequestConverter : JsonConverter<CreateDataFlowDebugSessionRequest>
        {
            public override void Write(Utf8JsonWriter writer, CreateDataFlowDebugSessionRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override CreateDataFlowDebugSessionRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCreateDataFlowDebugSessionRequest(document.RootElement);
            }
        }
    }
}
