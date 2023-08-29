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
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsAutomationRuleData : IUtf8JsonSerializable, IModelJsonSerializable<SecurityInsightsAutomationRuleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityInsightsAutomationRuleData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityInsightsAutomationRuleData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("displayName"u8);
            writer.WriteStringValue(DisplayName);
            writer.WritePropertyName("order"u8);
            writer.WriteNumberValue(Order);
            writer.WritePropertyName("triggeringLogic"u8);
            writer.WriteObjectValue(TriggeringLogic);
            writer.WritePropertyName("actions"u8);
            writer.WriteStartArray();
            foreach (var item in Actions)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        internal static SecurityInsightsAutomationRuleData DeserializeSecurityInsightsAutomationRuleData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            string displayName = default;
            int order = default;
            SecurityInsightsAutomationRuleTriggeringLogic triggeringLogic = default;
            IList<SecurityInsightsAutomationRuleAction> actions = default;
            Optional<DateTimeOffset> lastModifiedTimeUtc = default;
            Optional<DateTimeOffset> createdTimeUtc = default;
            Optional<SecurityInsightsClientInfo> lastModifiedBy = default;
            Optional<SecurityInsightsClientInfo> createdBy = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("order"u8))
                        {
                            order = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("triggeringLogic"u8))
                        {
                            triggeringLogic = SecurityInsightsAutomationRuleTriggeringLogic.DeserializeSecurityInsightsAutomationRuleTriggeringLogic(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("actions"u8))
                        {
                            List<SecurityInsightsAutomationRuleAction> array = new List<SecurityInsightsAutomationRuleAction>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SecurityInsightsAutomationRuleAction.DeserializeSecurityInsightsAutomationRuleAction(item));
                            }
                            actions = array;
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedBy = SecurityInsightsClientInfo.DeserializeSecurityInsightsClientInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("createdBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdBy = SecurityInsightsClientInfo.DeserializeSecurityInsightsClientInfo(property0.Value);
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
            return new SecurityInsightsAutomationRuleData(id, name, type, systemData.Value, displayName, order, triggeringLogic, actions, Optional.ToNullable(lastModifiedTimeUtc), Optional.ToNullable(createdTimeUtc), lastModifiedBy.Value, createdBy.Value, Optional.ToNullable(etag), rawData);
        }

        SecurityInsightsAutomationRuleData IModelJsonSerializable<SecurityInsightsAutomationRuleData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsAutomationRuleData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityInsightsAutomationRuleData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityInsightsAutomationRuleData IModelSerializable<SecurityInsightsAutomationRuleData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityInsightsAutomationRuleData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SecurityInsightsAutomationRuleData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SecurityInsightsAutomationRuleData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecurityInsightsAutomationRuleData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
