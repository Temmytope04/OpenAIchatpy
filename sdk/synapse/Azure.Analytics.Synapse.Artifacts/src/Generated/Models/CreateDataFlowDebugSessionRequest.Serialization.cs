// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class CreateDataFlowDebugSessionRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (DataFlowName != null)
            {
                writer.WritePropertyName("dataFlowName");
                writer.WriteStringValue(DataFlowName);
            }
            if (ExistingClusterId != null)
            {
                writer.WritePropertyName("existingClusterId");
                writer.WriteStringValue(ExistingClusterId);
            }
            if (ClusterTimeout != null)
            {
                writer.WritePropertyName("clusterTimeout");
                writer.WriteNumberValue(ClusterTimeout.Value);
            }
            if (NewClusterName != null)
            {
                writer.WritePropertyName("newClusterName");
                writer.WriteStringValue(NewClusterName);
            }
            if (NewClusterNodeType != null)
            {
                writer.WritePropertyName("newClusterNodeType");
                writer.WriteStringValue(NewClusterNodeType);
            }
            if (DataBricksLinkedService != null)
            {
                writer.WritePropertyName("dataBricksLinkedService");
                writer.WriteObjectValue(DataBricksLinkedService);
            }
            writer.WriteEndObject();
        }
    }
}
