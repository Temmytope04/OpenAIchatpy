// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    public partial class PreRulestackRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("ruleName"u8);
            writer.WriteStringValue(RuleName);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(RuleState))
            {
                writer.WritePropertyName("ruleState"u8);
                writer.WriteStringValue(RuleState.Value.ToString());
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteObjectValue(Source);
            }
            if (Optional.IsDefined(NegateSource))
            {
                writer.WritePropertyName("negateSource"u8);
                writer.WriteStringValue(NegateSource.Value.ToString());
            }
            if (Optional.IsDefined(Destination))
            {
                writer.WritePropertyName("destination"u8);
                writer.WriteObjectValue(Destination);
            }
            if (Optional.IsDefined(NegateDestination))
            {
                writer.WritePropertyName("negateDestination"u8);
                writer.WriteStringValue(NegateDestination.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Applications))
            {
                writer.WritePropertyName("applications"u8);
                writer.WriteStartArray();
                foreach (var item in Applications)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteObjectValue(Category);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol);
            }
            if (Optional.IsCollectionDefined(ProtocolPortList))
            {
                writer.WritePropertyName("protocolPortList"u8);
                writer.WriteStartArray();
                foreach (var item in ProtocolPortList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(InboundInspectionCertificate))
            {
                writer.WritePropertyName("inboundInspectionCertificate"u8);
                writer.WriteStringValue(InboundInspectionCertificate);
            }
            if (Optional.IsDefined(AuditComment))
            {
                writer.WritePropertyName("auditComment"u8);
                writer.WriteStringValue(AuditComment);
            }
            if (Optional.IsDefined(ActionType))
            {
                writer.WritePropertyName("actionType"u8);
                writer.WriteStringValue(ActionType.Value.ToString());
            }
            if (Optional.IsDefined(EnableLogging))
            {
                writer.WritePropertyName("enableLogging"u8);
                writer.WriteStringValue(EnableLogging.Value.ToString());
            }
            if (Optional.IsDefined(DecryptionRuleType))
            {
                writer.WritePropertyName("decryptionRuleType"u8);
                writer.WriteStringValue(DecryptionRuleType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartArray();
                foreach (var item in Tags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PreRulestackRuleData DeserializePreRulestackRuleData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ETag> etag = default;
            string ruleName = default;
            Optional<int> priority = default;
            Optional<string> description = default;
            Optional<RulestackStateType> ruleState = default;
            Optional<SourceAddressInfo> source = default;
            Optional<FirewallBooleanType> negateSource = default;
            Optional<DestinationAddressInfo> destination = default;
            Optional<FirewallBooleanType> negateDestination = default;
            Optional<IList<string>> applications = default;
            Optional<EdlMatchCategory> category = default;
            Optional<string> protocol = default;
            Optional<IList<string>> protocolPortList = default;
            Optional<string> inboundInspectionCertificate = default;
            Optional<string> auditComment = default;
            Optional<RulestackActionType> actionType = default;
            Optional<RulestackStateType> enableLogging = default;
            Optional<DecryptionRuleType> decryptionRuleType = default;
            Optional<IList<RulestackTagInfo>> tags = default;
            Optional<FirewallProvisioningState> provisioningState = default;
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
                        if (property0.NameEquals("etag"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            etag = new ETag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ruleName"u8))
                        {
                            ruleName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ruleState = new RulestackStateType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = SourceAddressInfo.DeserializeSourceAddressInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("negateSource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            negateSource = new FirewallBooleanType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("destination"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            destination = DestinationAddressInfo.DeserializeDestinationAddressInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("negateDestination"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            negateDestination = new FirewallBooleanType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("applications"u8))
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
                            applications = array;
                            continue;
                        }
                        if (property0.NameEquals("category"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            category = EdlMatchCategory.DeserializeEdlMatchCategory(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("protocol"u8))
                        {
                            protocol = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("protocolPortList"u8))
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
                            protocolPortList = array;
                            continue;
                        }
                        if (property0.NameEquals("inboundInspectionCertificate"u8))
                        {
                            inboundInspectionCertificate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("auditComment"u8))
                        {
                            auditComment = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("actionType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            actionType = new RulestackActionType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableLogging"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableLogging = new RulestackStateType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("decryptionRuleType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            decryptionRuleType = new DecryptionRuleType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tags"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RulestackTagInfo> array = new List<RulestackTagInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RulestackTagInfo.DeserializeRulestackTagInfo(item));
                            }
                            tags = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new FirewallProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PreRulestackRuleData(id, name, type, systemData.Value, Optional.ToNullable(etag), ruleName, Optional.ToNullable(priority), description.Value, Optional.ToNullable(ruleState), source.Value, Optional.ToNullable(negateSource), destination.Value, Optional.ToNullable(negateDestination), Optional.ToList(applications), category.Value, protocol.Value, Optional.ToList(protocolPortList), inboundInspectionCertificate.Value, auditComment.Value, Optional.ToNullable(actionType), Optional.ToNullable(enableLogging), Optional.ToNullable(decryptionRuleType), Optional.ToList(tags), Optional.ToNullable(provisioningState));
        }
    }
}
