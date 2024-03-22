// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsAlert : IUtf8JsonSerializable, IJsonModel<SecurityInsightsAlert>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsAlert>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsAlert>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAlert>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsAlert)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(AdditionalData))
            {
                writer.WritePropertyName("additionalData"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalData)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (options.Format != "W" && Optional.IsDefined(AlertDisplayName))
            {
                writer.WritePropertyName("alertDisplayName"u8);
                writer.WriteStringValue(AlertDisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(AlertType))
            {
                writer.WritePropertyName("alertType"u8);
                writer.WriteStringValue(AlertType);
            }
            if (options.Format != "W" && Optional.IsDefined(CompromisedEntity))
            {
                writer.WritePropertyName("compromisedEntity"u8);
                writer.WriteStringValue(CompromisedEntity);
            }
            if (options.Format != "W" && Optional.IsDefined(ConfidenceLevel))
            {
                writer.WritePropertyName("confidenceLevel"u8);
                writer.WriteStringValue(ConfidenceLevel.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ConfidenceReasons))
            {
                writer.WritePropertyName("confidenceReasons"u8);
                writer.WriteStartArray();
                foreach (var item in ConfidenceReasons)
                {
                    writer.WriteObjectValue<SecurityInsightsAlertConfidenceReason>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ConfidenceScore))
            {
                writer.WritePropertyName("confidenceScore"u8);
                writer.WriteNumberValue(ConfidenceScore.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ConfidenceScoreStatus))
            {
                writer.WritePropertyName("confidenceScoreStatus"u8);
                writer.WriteStringValue(ConfidenceScoreStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTimeUtc"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Intent))
            {
                writer.WritePropertyName("intent"u8);
                writer.WriteStringValue(Intent.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProviderAlertId))
            {
                writer.WritePropertyName("providerAlertId"u8);
                writer.WriteStringValue(ProviderAlertId);
            }
            if (options.Format != "W" && Optional.IsDefined(ProcessingEndOn))
            {
                writer.WritePropertyName("processingEndTime"u8);
                writer.WriteStringValue(ProcessingEndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProductComponentName))
            {
                writer.WritePropertyName("productComponentName"u8);
                writer.WriteStringValue(ProductComponentName);
            }
            if (options.Format != "W" && Optional.IsDefined(ProductName))
            {
                writer.WritePropertyName("productName"u8);
                writer.WriteStringValue(ProductName);
            }
            if (options.Format != "W" && Optional.IsDefined(ProductVersion))
            {
                writer.WritePropertyName("productVersion"u8);
                writer.WriteStringValue(ProductVersion);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RemediationSteps))
            {
                writer.WritePropertyName("remediationSteps"u8);
                writer.WriteStartArray();
                foreach (var item in RemediationSteps)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTimeUtc"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SystemAlertId))
            {
                writer.WritePropertyName("systemAlertId"u8);
                writer.WriteStringValue(SystemAlertId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Tactics))
            {
                writer.WritePropertyName("tactics"u8);
                writer.WriteStartArray();
                foreach (var item in Tactics)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(AlertGeneratedOn))
            {
                writer.WritePropertyName("timeGenerated"u8);
                writer.WriteStringValue(AlertGeneratedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(VendorName))
            {
                writer.WritePropertyName("vendorName"u8);
                writer.WriteStringValue(VendorName);
            }
            if (options.Format != "W" && Optional.IsDefined(AlertLink))
            {
                writer.WritePropertyName("alertLink"u8);
                writer.WriteStringValue(AlertLink);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ResourceIdentifiers))
            {
                writer.WritePropertyName("resourceIdentifiers"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceIdentifiers)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SecurityInsightsAlert IJsonModel<SecurityInsightsAlert>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAlert>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsAlert)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsAlert(document.RootElement, options);
        }

        internal static SecurityInsightsAlert DeserializeSecurityInsightsAlert(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SecurityInsightsEntityKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IReadOnlyDictionary<string, BinaryData> additionalData = default;
            string friendlyName = default;
            string alertDisplayName = default;
            string alertType = default;
            string compromisedEntity = default;
            SecurityInsightsAlertConfidenceLevel? confidenceLevel = default;
            IReadOnlyList<SecurityInsightsAlertConfidenceReason> confidenceReasons = default;
            double? confidenceScore = default;
            SecurityInsightsAlertConfidenceScoreStatus? confidenceScoreStatus = default;
            string description = default;
            DateTimeOffset? endTimeUtc = default;
            SecurityInsightsKillChainIntent? intent = default;
            string providerAlertId = default;
            DateTimeOffset? processingEndTime = default;
            string productComponentName = default;
            string productName = default;
            string productVersion = default;
            IReadOnlyList<string> remediationSteps = default;
            SecurityInsightsAlertSeverity? severity = default;
            DateTimeOffset? startTimeUtc = default;
            SecurityInsightsAlertStatus? status = default;
            string systemAlertId = default;
            IReadOnlyList<SecurityInsightsAttackTactic> tactics = default;
            DateTimeOffset? timeGenerated = default;
            string vendorName = default;
            string alertLink = default;
            IReadOnlyList<BinaryData> resourceIdentifiers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new SecurityInsightsEntityKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("additionalData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            additionalData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("alertDisplayName"u8))
                        {
                            alertDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("alertType"u8))
                        {
                            alertType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("compromisedEntity"u8))
                        {
                            compromisedEntity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("confidenceLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            confidenceLevel = new SecurityInsightsAlertConfidenceLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("confidenceReasons"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsAlertConfidenceReason> array = new List<SecurityInsightsAlertConfidenceReason>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SecurityInsightsAlertConfidenceReason.DeserializeSecurityInsightsAlertConfidenceReason(item, options));
                            }
                            confidenceReasons = array;
                            continue;
                        }
                        if (property0.NameEquals("confidenceScore"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            confidenceScore = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("confidenceScoreStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            confidenceScoreStatus = new SecurityInsightsAlertConfidenceScoreStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("intent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            intent = new SecurityInsightsKillChainIntent(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("providerAlertId"u8))
                        {
                            providerAlertId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("processingEndTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            processingEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("productComponentName"u8))
                        {
                            productComponentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productName"u8))
                        {
                            productName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productVersion"u8))
                        {
                            productVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("remediationSteps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
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
                        if (property0.NameEquals("severity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            severity = new SecurityInsightsAlertSeverity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new SecurityInsightsAlertStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("systemAlertId"u8))
                        {
                            systemAlertId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tactics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsAttackTactic> array = new List<SecurityInsightsAttackTactic>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityInsightsAttackTactic(item.GetString()));
                            }
                            tactics = array;
                            continue;
                        }
                        if (property0.NameEquals("timeGenerated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeGenerated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("vendorName"u8))
                        {
                            vendorName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("alertLink"u8))
                        {
                            alertLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceIdentifiers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BinaryData> array = new List<BinaryData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(BinaryData.FromString(item.GetRawText()));
                                }
                            }
                            resourceIdentifiers = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityInsightsAlert(
                id,
                name,
                type,
                systemData,
                kind,
                serializedAdditionalRawData,
                additionalData ?? new ChangeTrackingDictionary<string, BinaryData>(),
                friendlyName,
                alertDisplayName,
                alertType,
                compromisedEntity,
                confidenceLevel,
                confidenceReasons ?? new ChangeTrackingList<SecurityInsightsAlertConfidenceReason>(),
                confidenceScore,
                confidenceScoreStatus,
                description,
                endTimeUtc,
                intent,
                providerAlertId,
                processingEndTime,
                productComponentName,
                productName,
                productVersion,
                remediationSteps ?? new ChangeTrackingList<string>(),
                severity,
                startTimeUtc,
                status,
                systemAlertId,
                tactics ?? new ChangeTrackingList<SecurityInsightsAttackTactic>(),
                timeGenerated,
                vendorName,
                alertLink,
                resourceIdentifiers ?? new ChangeTrackingList<BinaryData>());
        }

        BinaryData IPersistableModel<SecurityInsightsAlert>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAlert>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsAlert)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityInsightsAlert IPersistableModel<SecurityInsightsAlert>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAlert>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsAlert(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsAlert)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsAlert>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
