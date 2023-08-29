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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SitePatchInfo : IUtf8JsonSerializable, IModelJsonSerializable<SitePatchInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SitePatchInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SitePatchInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsCollectionDefined(HostNameSslStates))
            {
                writer.WritePropertyName("hostNameSslStates"u8);
                writer.WriteStartArray();
                foreach (var item in HostNameSslStates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ServerFarmId))
            {
                writer.WritePropertyName("serverFarmId"u8);
                writer.WriteStringValue(ServerFarmId);
            }
            if (Optional.IsDefined(IsReserved))
            {
                writer.WritePropertyName("reserved"u8);
                writer.WriteBooleanValue(IsReserved.Value);
            }
            if (Optional.IsDefined(IsXenon))
            {
                writer.WritePropertyName("isXenon"u8);
                writer.WriteBooleanValue(IsXenon.Value);
            }
            if (Optional.IsDefined(IsHyperV))
            {
                writer.WritePropertyName("hyperV"u8);
                writer.WriteBooleanValue(IsHyperV.Value);
            }
            if (Optional.IsDefined(SiteConfig))
            {
                writer.WritePropertyName("siteConfig"u8);
                writer.WriteObjectValue(SiteConfig);
            }
            if (Optional.IsDefined(IsScmSiteAlsoStopped))
            {
                writer.WritePropertyName("scmSiteAlsoStopped"u8);
                writer.WriteBooleanValue(IsScmSiteAlsoStopped.Value);
            }
            if (Optional.IsDefined(HostingEnvironmentProfile))
            {
                writer.WritePropertyName("hostingEnvironmentProfile"u8);
                writer.WriteObjectValue(HostingEnvironmentProfile);
            }
            if (Optional.IsDefined(IsClientAffinityEnabled))
            {
                writer.WritePropertyName("clientAffinityEnabled"u8);
                writer.WriteBooleanValue(IsClientAffinityEnabled.Value);
            }
            if (Optional.IsDefined(IsClientCertEnabled))
            {
                writer.WritePropertyName("clientCertEnabled"u8);
                writer.WriteBooleanValue(IsClientCertEnabled.Value);
            }
            if (Optional.IsDefined(ClientCertMode))
            {
                writer.WritePropertyName("clientCertMode"u8);
                writer.WriteStringValue(ClientCertMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(ClientCertExclusionPaths))
            {
                writer.WritePropertyName("clientCertExclusionPaths"u8);
                writer.WriteStringValue(ClientCertExclusionPaths);
            }
            if (Optional.IsDefined(IsHostNameDisabled))
            {
                writer.WritePropertyName("hostNamesDisabled"u8);
                writer.WriteBooleanValue(IsHostNameDisabled.Value);
            }
            if (Optional.IsDefined(CustomDomainVerificationId))
            {
                writer.WritePropertyName("customDomainVerificationId"u8);
                writer.WriteStringValue(CustomDomainVerificationId);
            }
            if (Optional.IsDefined(ContainerSize))
            {
                writer.WritePropertyName("containerSize"u8);
                writer.WriteNumberValue(ContainerSize.Value);
            }
            if (Optional.IsDefined(DailyMemoryTimeQuota))
            {
                writer.WritePropertyName("dailyMemoryTimeQuota"u8);
                writer.WriteNumberValue(DailyMemoryTimeQuota.Value);
            }
            if (Optional.IsDefined(CloningInfo))
            {
                writer.WritePropertyName("cloningInfo"u8);
                writer.WriteObjectValue(CloningInfo);
            }
            if (Optional.IsDefined(IsHttpsOnly))
            {
                writer.WritePropertyName("httpsOnly"u8);
                writer.WriteBooleanValue(IsHttpsOnly.Value);
            }
            if (Optional.IsDefined(RedundancyMode))
            {
                writer.WritePropertyName("redundancyMode"u8);
                writer.WriteStringValue(RedundancyMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(IsStorageAccountRequired))
            {
                writer.WritePropertyName("storageAccountRequired"u8);
                writer.WriteBooleanValue(IsStorageAccountRequired.Value);
            }
            if (Optional.IsDefined(KeyVaultReferenceIdentity))
            {
                writer.WritePropertyName("keyVaultReferenceIdentity"u8);
                writer.WriteStringValue(KeyVaultReferenceIdentity);
            }
            if (Optional.IsDefined(VirtualNetworkSubnetId))
            {
                writer.WritePropertyName("virtualNetworkSubnetId"u8);
                writer.WriteStringValue(VirtualNetworkSubnetId);
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

        internal static SitePatchInfo DeserializeSitePatchInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> state = default;
            Optional<IReadOnlyList<string>> hostNames = default;
            Optional<string> repositorySiteName = default;
            Optional<AppServiceUsageState> usageState = default;
            Optional<bool> enabled = default;
            Optional<IReadOnlyList<string>> enabledHostNames = default;
            Optional<WebSiteAvailabilityState> availabilityState = default;
            Optional<IList<HostNameSslState>> hostNameSslStates = default;
            Optional<ResourceIdentifier> serverFarmId = default;
            Optional<bool> reserved = default;
            Optional<bool> isXenon = default;
            Optional<bool> hyperV = default;
            Optional<DateTimeOffset> lastModifiedTimeUtc = default;
            Optional<SiteConfigProperties> siteConfig = default;
            Optional<IReadOnlyList<string>> trafficManagerHostNames = default;
            Optional<bool> scmSiteAlsoStopped = default;
            Optional<string> targetSwapSlot = default;
            Optional<HostingEnvironmentProfile> hostingEnvironmentProfile = default;
            Optional<bool> clientAffinityEnabled = default;
            Optional<bool> clientCertEnabled = default;
            Optional<ClientCertMode> clientCertMode = default;
            Optional<string> clientCertExclusionPaths = default;
            Optional<bool> hostNamesDisabled = default;
            Optional<string> customDomainVerificationId = default;
            Optional<string> outboundIPAddresses = default;
            Optional<string> possibleOutboundIPAddresses = default;
            Optional<int> containerSize = default;
            Optional<int> dailyMemoryTimeQuota = default;
            Optional<DateTimeOffset> suspendedTill = default;
            Optional<int> maxNumberOfWorkers = default;
            Optional<CloningInfo> cloningInfo = default;
            Optional<string> resourceGroup = default;
            Optional<bool> isDefaultContainer = default;
            Optional<string> defaultHostName = default;
            Optional<SlotSwapStatus> slotSwapStatus = default;
            Optional<bool> httpsOnly = default;
            Optional<RedundancyMode> redundancyMode = default;
            Optional<Guid> inProgressOperationId = default;
            Optional<bool> storageAccountRequired = default;
            Optional<string> keyVaultReferenceIdentity = default;
            Optional<ResourceIdentifier> virtualNetworkSubnetId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("state"u8))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostNames"u8))
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
                            hostNames = array;
                            continue;
                        }
                        if (property0.NameEquals("repositorySiteName"u8))
                        {
                            repositorySiteName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("usageState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usageState = property0.Value.GetString().ToAppServiceUsageState();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enabledHostNames"u8))
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
                            enabledHostNames = array;
                            continue;
                        }
                        if (property0.NameEquals("availabilityState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            availabilityState = property0.Value.GetString().ToWebSiteAvailabilityState();
                            continue;
                        }
                        if (property0.NameEquals("hostNameSslStates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<HostNameSslState> array = new List<HostNameSslState>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HostNameSslState.DeserializeHostNameSslState(item));
                            }
                            hostNameSslStates = array;
                            continue;
                        }
                        if (property0.NameEquals("serverFarmId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverFarmId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("reserved"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reserved = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isXenon"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isXenon = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hyperV"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hyperV = property0.Value.GetBoolean();
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
                        if (property0.NameEquals("siteConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            siteConfig = SiteConfigProperties.DeserializeSiteConfigProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("trafficManagerHostNames"u8))
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
                            trafficManagerHostNames = array;
                            continue;
                        }
                        if (property0.NameEquals("scmSiteAlsoStopped"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scmSiteAlsoStopped = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("targetSwapSlot"u8))
                        {
                            targetSwapSlot = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostingEnvironmentProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostingEnvironmentProfile = HostingEnvironmentProfile.DeserializeHostingEnvironmentProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clientAffinityEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientAffinityEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("clientCertEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientCertEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("clientCertMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientCertMode = property0.Value.GetString().ToClientCertMode();
                            continue;
                        }
                        if (property0.NameEquals("clientCertExclusionPaths"u8))
                        {
                            clientCertExclusionPaths = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostNamesDisabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostNamesDisabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("customDomainVerificationId"u8))
                        {
                            customDomainVerificationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("outboundIpAddresses"u8))
                        {
                            outboundIPAddresses = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("possibleOutboundIpAddresses"u8))
                        {
                            possibleOutboundIPAddresses = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containerSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            containerSize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dailyMemoryTimeQuota"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dailyMemoryTimeQuota = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("suspendedTill"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            suspendedTill = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("maxNumberOfWorkers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxNumberOfWorkers = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("cloningInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cloningInfo = CloningInfo.DeserializeCloningInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"u8))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isDefaultContainer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDefaultContainer = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultHostName"u8))
                        {
                            defaultHostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("slotSwapStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            slotSwapStatus = SlotSwapStatus.DeserializeSlotSwapStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("httpsOnly"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpsOnly = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("redundancyMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            redundancyMode = property0.Value.GetString().ToRedundancyMode();
                            continue;
                        }
                        if (property0.NameEquals("inProgressOperationId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            inProgressOperationId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountRequired"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountRequired = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("keyVaultReferenceIdentity"u8))
                        {
                            keyVaultReferenceIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkSubnetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetworkSubnetId = new ResourceIdentifier(property0.Value.GetString());
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
            return new SitePatchInfo(id, name, type, systemData.Value, identity, state.Value, Optional.ToList(hostNames), repositorySiteName.Value, Optional.ToNullable(usageState), Optional.ToNullable(enabled), Optional.ToList(enabledHostNames), Optional.ToNullable(availabilityState), Optional.ToList(hostNameSslStates), serverFarmId.Value, Optional.ToNullable(reserved), Optional.ToNullable(isXenon), Optional.ToNullable(hyperV), Optional.ToNullable(lastModifiedTimeUtc), siteConfig.Value, Optional.ToList(trafficManagerHostNames), Optional.ToNullable(scmSiteAlsoStopped), targetSwapSlot.Value, hostingEnvironmentProfile.Value, Optional.ToNullable(clientAffinityEnabled), Optional.ToNullable(clientCertEnabled), Optional.ToNullable(clientCertMode), clientCertExclusionPaths.Value, Optional.ToNullable(hostNamesDisabled), customDomainVerificationId.Value, outboundIPAddresses.Value, possibleOutboundIPAddresses.Value, Optional.ToNullable(containerSize), Optional.ToNullable(dailyMemoryTimeQuota), Optional.ToNullable(suspendedTill), Optional.ToNullable(maxNumberOfWorkers), cloningInfo.Value, resourceGroup.Value, Optional.ToNullable(isDefaultContainer), defaultHostName.Value, slotSwapStatus.Value, Optional.ToNullable(httpsOnly), Optional.ToNullable(redundancyMode), Optional.ToNullable(inProgressOperationId), Optional.ToNullable(storageAccountRequired), keyVaultReferenceIdentity.Value, virtualNetworkSubnetId.Value, kind.Value, rawData);
        }

        SitePatchInfo IModelJsonSerializable<SitePatchInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSitePatchInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SitePatchInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SitePatchInfo IModelSerializable<SitePatchInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSitePatchInfo(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SitePatchInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SitePatchInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSitePatchInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
