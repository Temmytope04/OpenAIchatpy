// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class WorkflowTriggerHistoryData
    {
        internal static WorkflowTriggerHistoryData DeserializeWorkflowTriggerHistoryData(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<DateTimeOffset> scheduledTime = default;
            Optional<WorkflowStatus> status = default;
            Optional<string> code = default;
            Optional<BinaryData> error = default;
            Optional<string> trackingId = default;
            Optional<Correlation> correlation = default;
            Optional<ContentLink> inputsLink = default;
            Optional<ContentLink> outputsLink = default;
            Optional<bool> fired = default;
            Optional<ResourceReference> run = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("startTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("scheduledTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            scheduledTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new WorkflowStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("code"))
                        {
                            code = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("error"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            error = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("trackingId"))
                        {
                            trackingId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("correlation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            correlation = Correlation.DeserializeCorrelation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("inputsLink"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            inputsLink = ContentLink.DeserializeContentLink(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("outputsLink"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            outputsLink = ContentLink.DeserializeContentLink(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("fired"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            fired = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("run"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            run = ResourceReference.DeserializeResourceReference(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WorkflowTriggerHistoryData(id.Value, name.Value, type.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(scheduledTime), Optional.ToNullable(status), code.Value, error.Value, trackingId.Value, correlation.Value, inputsLink.Value, outputsLink.Value, Optional.ToNullable(fired), run.Value);
        }
    }
}
