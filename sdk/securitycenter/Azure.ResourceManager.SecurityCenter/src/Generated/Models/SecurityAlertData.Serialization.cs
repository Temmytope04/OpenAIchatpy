// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SecurityAlertData : IUtf8JsonSerializable, IModelJsonSerializable<SecurityAlertData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityAlertData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityAlertData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ExtendedProperties))
            {
                writer.WritePropertyName("extendedProperties"u8);
                writer.WriteStartObject();
                foreach (var item in ExtendedProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(SupportingEvidence))
            {
                writer.WritePropertyName("supportingEvidence"u8);
                writer.WriteObjectValue(SupportingEvidence);
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static SecurityAlertData DeserializeSecurityAlertData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> version = default;
            Optional<string> alertType = default;
            Optional<string> systemAlertId = default;
            Optional<string> productComponentName = default;
            Optional<string> alertDisplayName = default;
            Optional<string> description = default;
            Optional<SecurityAlertSeverity> severity = default;
            Optional<KillChainIntent> intent = default;
            Optional<DateTimeOffset> startTimeUtc = default;
            Optional<DateTimeOffset> endTimeUtc = default;
            Optional<IReadOnlyList<SecurityAlertResourceIdentifier>> resourceIdentifiers = default;
            Optional<IReadOnlyList<string>> remediationSteps = default;
            Optional<string> vendorName = default;
            Optional<SecurityAlertStatus> status = default;
            Optional<IReadOnlyList<IDictionary<string, string>>> extendedLinks = default;
            Optional<Uri> alertUri = default;
            Optional<DateTimeOffset> timeGeneratedUtc = default;
            Optional<string> productName = default;
            Optional<DateTimeOffset> processingEndTimeUtc = default;
            Optional<IReadOnlyList<SecurityAlertEntity>> entities = default;
            Optional<bool> isIncident = default;
            Optional<string> correlationKey = default;
            Optional<IDictionary<string, string>> extendedProperties = default;
            Optional<string> compromisedEntity = default;
            Optional<IReadOnlyList<string>> techniques = default;
            Optional<IReadOnlyList<string>> subTechniques = default;
            Optional<SecurityAlertSupportingEvidence> supportingEvidence = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("alertType"u8))
                        {
                            alertType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("systemAlertId"u8))
                        {
                            systemAlertId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productComponentName"u8))
                        {
                            productComponentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("alertDisplayName"u8))
                        {
                            alertDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("severity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            severity = new SecurityAlertSeverity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("intent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            intent = new KillChainIntent(property0.Value.GetString());
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
                        if (property0.NameEquals("endTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("resourceIdentifiers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityAlertResourceIdentifier> array = new List<SecurityAlertResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SecurityAlertResourceIdentifier.DeserializeSecurityAlertResourceIdentifier(item));
                            }
                            resourceIdentifiers = array;
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
                        if (property0.NameEquals("vendorName"u8))
                        {
                            vendorName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new SecurityAlertStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("extendedLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IDictionary<string, string>> array = new List<IDictionary<string, string>>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                                    foreach (var property1 in item.EnumerateObject())
                                    {
                                        dictionary.Add(property1.Name, property1.Value.GetString());
                                    }
                                    array.Add(dictionary);
                                }
                            }
                            extendedLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("alertUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            alertUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("timeGeneratedUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeGeneratedUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("productName"u8))
                        {
                            productName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("processingEndTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            processingEndTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("entities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityAlertEntity> array = new List<SecurityAlertEntity>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SecurityAlertEntity.DeserializeSecurityAlertEntity(item));
                            }
                            entities = array;
                            continue;
                        }
                        if (property0.NameEquals("isIncident"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isIncident = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("correlationKey"u8))
                        {
                            correlationKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extendedProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            extendedProperties = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("compromisedEntity"u8))
                        {
                            compromisedEntity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("techniques"u8))
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
                            techniques = array;
                            continue;
                        }
                        if (property0.NameEquals("subTechniques"u8))
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
                            subTechniques = array;
                            continue;
                        }
                        if (property0.NameEquals("supportingEvidence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportingEvidence = SecurityAlertSupportingEvidence.DeserializeSecurityAlertSupportingEvidence(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SecurityAlertData(id, name, type, systemData.Value, version.Value, alertType.Value, systemAlertId.Value, productComponentName.Value, alertDisplayName.Value, description.Value, Optional.ToNullable(severity), Optional.ToNullable(intent), Optional.ToNullable(startTimeUtc), Optional.ToNullable(endTimeUtc), Optional.ToList(resourceIdentifiers), Optional.ToList(remediationSteps), vendorName.Value, Optional.ToNullable(status), Optional.ToList(extendedLinks), alertUri.Value, Optional.ToNullable(timeGeneratedUtc), productName.Value, Optional.ToNullable(processingEndTimeUtc), Optional.ToList(entities), Optional.ToNullable(isIncident), correlationKey.Value, Optional.ToDictionary(extendedProperties), compromisedEntity.Value, Optional.ToList(techniques), Optional.ToList(subTechniques), supportingEvidence.Value, rawData);
        }

        SecurityAlertData IModelJsonSerializable<SecurityAlertData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityAlertData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityAlertData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityAlertData IModelSerializable<SecurityAlertData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityAlertData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SecurityAlertData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SecurityAlertData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecurityAlertData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
