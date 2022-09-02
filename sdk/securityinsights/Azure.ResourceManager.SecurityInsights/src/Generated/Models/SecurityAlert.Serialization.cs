// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityAlert : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity");
                writer.WriteStringValue(Severity.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SecurityAlert DeserializeSecurityAlert(JsonElement element)
        {
            EntityKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyDictionary<string, BinaryData>> additionalData = default;
            Optional<string> friendlyName = default;
            Optional<string> alertDisplayName = default;
            Optional<string> alertType = default;
            Optional<string> compromisedEntity = default;
            Optional<ConfidenceLevel> confidenceLevel = default;
            Optional<IReadOnlyList<SecurityAlertPropertiesConfidenceReasonsItem>> confidenceReasons = default;
            Optional<double> confidenceScore = default;
            Optional<ConfidenceScoreStatus> confidenceScoreStatus = default;
            Optional<string> description = default;
            Optional<DateTimeOffset> endTimeUtc = default;
            Optional<KillChainIntent> intent = default;
            Optional<string> providerAlertId = default;
            Optional<DateTimeOffset> processingEndTime = default;
            Optional<string> productComponentName = default;
            Optional<string> productName = default;
            Optional<string> productVersion = default;
            Optional<IReadOnlyList<string>> remediationSteps = default;
            Optional<AlertSeverity> severity = default;
            Optional<DateTimeOffset> startTimeUtc = default;
            Optional<AlertStatus> status = default;
            Optional<string> systemAlertId = default;
            Optional<IReadOnlyList<AttackTactic>> tactics = default;
            Optional<DateTimeOffset> timeGenerated = default;
            Optional<string> vendorName = default;
            Optional<string> alertLink = default;
            Optional<IReadOnlyList<BinaryData>> resourceIdentifiers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new EntityKind(property.Value.GetString());
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
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
                        if (property0.NameEquals("additionalData"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                            }
                            additionalData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("alertDisplayName"))
                        {
                            alertDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("alertType"))
                        {
                            alertType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("compromisedEntity"))
                        {
                            compromisedEntity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("confidenceLevel"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            confidenceLevel = new ConfidenceLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("confidenceReasons"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SecurityAlertPropertiesConfidenceReasonsItem> array = new List<SecurityAlertPropertiesConfidenceReasonsItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SecurityAlertPropertiesConfidenceReasonsItem.DeserializeSecurityAlertPropertiesConfidenceReasonsItem(item));
                            }
                            confidenceReasons = array;
                            continue;
                        }
                        if (property0.NameEquals("confidenceScore"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            confidenceScore = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("confidenceScoreStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            confidenceScoreStatus = new ConfidenceScoreStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endTimeUtc"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            endTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("intent"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            intent = new KillChainIntent(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("providerAlertId"))
                        {
                            providerAlertId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("processingEndTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            processingEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("productComponentName"))
                        {
                            productComponentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productName"))
                        {
                            productName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productVersion"))
                        {
                            productVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("remediationSteps"))
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
                            remediationSteps = array;
                            continue;
                        }
                        if (property0.NameEquals("severity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            severity = new AlertSeverity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startTimeUtc"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new AlertStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("systemAlertId"))
                        {
                            systemAlertId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tactics"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AttackTactic> array = new List<AttackTactic>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new AttackTactic(item.GetString()));
                            }
                            tactics = array;
                            continue;
                        }
                        if (property0.NameEquals("timeGenerated"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            timeGenerated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("vendorName"))
                        {
                            vendorName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("alertLink"))
                        {
                            alertLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceIdentifiers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<BinaryData> array = new List<BinaryData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BinaryData.FromString(item.GetRawText()));
                            }
                            resourceIdentifiers = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SecurityAlert(id, name, type, systemData.Value, kind, Optional.ToDictionary(additionalData), friendlyName.Value, alertDisplayName.Value, alertType.Value, compromisedEntity.Value, Optional.ToNullable(confidenceLevel), Optional.ToList(confidenceReasons), Optional.ToNullable(confidenceScore), Optional.ToNullable(confidenceScoreStatus), description.Value, Optional.ToNullable(endTimeUtc), Optional.ToNullable(intent), providerAlertId.Value, Optional.ToNullable(processingEndTime), productComponentName.Value, productName.Value, productVersion.Value, Optional.ToList(remediationSteps), Optional.ToNullable(severity), Optional.ToNullable(startTimeUtc), Optional.ToNullable(status), systemAlertId.Value, Optional.ToList(tactics), Optional.ToNullable(timeGenerated), vendorName.Value, alertLink.Value, Optional.ToList(resourceIdentifiers));
        }
    }
}
