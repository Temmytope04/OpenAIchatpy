// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class RecommendedActionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state");
                writer.WriteObjectValue(State);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RecommendedActionData DeserializeRecommendedActionData(JsonElement element)
        {
            Optional<string> kind = default;
            Optional<string> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> recommendationReason = default;
            Optional<DateTimeOffset> validSince = default;
            Optional<DateTimeOffset> lastRefresh = default;
            Optional<RecommendedActionStateInfo> state = default;
            Optional<bool> isExecutableAction = default;
            Optional<bool> isRevertableAction = default;
            Optional<bool> isArchivedAction = default;
            Optional<DateTimeOffset> executeActionStartTime = default;
            Optional<string> executeActionDuration = default;
            Optional<DateTimeOffset> revertActionStartTime = default;
            Optional<string> revertActionDuration = default;
            Optional<RecommendedActionInitiatedBy> executeActionInitiatedBy = default;
            Optional<DateTimeOffset> executeActionInitiatedTime = default;
            Optional<RecommendedActionInitiatedBy> revertActionInitiatedBy = default;
            Optional<DateTimeOffset> revertActionInitiatedTime = default;
            Optional<int> score = default;
            Optional<RecommendedActionImplementationInfo> implementationDetails = default;
            Optional<RecommendedActionErrorInfo> errorDetails = default;
            Optional<IReadOnlyList<RecommendedActionImpactRecord>> estimatedImpact = default;
            Optional<IReadOnlyList<RecommendedActionImpactRecord>> observedImpact = default;
            Optional<IReadOnlyList<RecommendedActionMetricInfo>> timeSeries = default;
            Optional<IReadOnlyList<string>> linkedObjects = default;
            Optional<IReadOnlyDictionary<string, object>> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
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
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("recommendationReason"))
                        {
                            recommendationReason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("validSince"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            validSince = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastRefresh"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastRefresh = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = RecommendedActionStateInfo.DeserializeRecommendedActionStateInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isExecutableAction"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isExecutableAction = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isRevertableAction"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isRevertableAction = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isArchivedAction"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isArchivedAction = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("executeActionStartTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            executeActionStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("executeActionDuration"))
                        {
                            executeActionDuration = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("revertActionStartTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            revertActionStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("revertActionDuration"))
                        {
                            revertActionDuration = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("executeActionInitiatedBy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            executeActionInitiatedBy = property0.Value.GetString().ToRecommendedActionInitiatedBy();
                            continue;
                        }
                        if (property0.NameEquals("executeActionInitiatedTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            executeActionInitiatedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("revertActionInitiatedBy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            revertActionInitiatedBy = property0.Value.GetString().ToRecommendedActionInitiatedBy();
                            continue;
                        }
                        if (property0.NameEquals("revertActionInitiatedTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            revertActionInitiatedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("score"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            score = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("implementationDetails"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            implementationDetails = RecommendedActionImplementationInfo.DeserializeRecommendedActionImplementationInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("errorDetails"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            errorDetails = RecommendedActionErrorInfo.DeserializeRecommendedActionErrorInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("estimatedImpact"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RecommendedActionImpactRecord> array = new List<RecommendedActionImpactRecord>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RecommendedActionImpactRecord.DeserializeRecommendedActionImpactRecord(item));
                            }
                            estimatedImpact = array;
                            continue;
                        }
                        if (property0.NameEquals("observedImpact"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RecommendedActionImpactRecord> array = new List<RecommendedActionImpactRecord>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RecommendedActionImpactRecord.DeserializeRecommendedActionImpactRecord(item));
                            }
                            observedImpact = array;
                            continue;
                        }
                        if (property0.NameEquals("timeSeries"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RecommendedActionMetricInfo> array = new List<RecommendedActionMetricInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RecommendedActionMetricInfo.DeserializeRecommendedActionMetricInfo(item));
                            }
                            timeSeries = array;
                            continue;
                        }
                        if (property0.NameEquals("linkedObjects"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            linkedObjects = array;
                            continue;
                        }
                        if (property0.NameEquals("details"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, object> dictionary = new Dictionary<string, object>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetObject());
                            }
                            details = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RecommendedActionData(id, name, type, systemData, kind.Value, location.Value, recommendationReason.Value, Optional.ToNullable(validSince), Optional.ToNullable(lastRefresh), state.Value, Optional.ToNullable(isExecutableAction), Optional.ToNullable(isRevertableAction), Optional.ToNullable(isArchivedAction), Optional.ToNullable(executeActionStartTime), executeActionDuration.Value, Optional.ToNullable(revertActionStartTime), revertActionDuration.Value, Optional.ToNullable(executeActionInitiatedBy), Optional.ToNullable(executeActionInitiatedTime), Optional.ToNullable(revertActionInitiatedBy), Optional.ToNullable(revertActionInitiatedTime), Optional.ToNullable(score), implementationDetails.Value, errorDetails.Value, Optional.ToList(estimatedImpact), Optional.ToList(observedImpact), Optional.ToList(timeSeries), Optional.ToList(linkedObjects), Optional.ToDictionary(details));
        }
    }
}
