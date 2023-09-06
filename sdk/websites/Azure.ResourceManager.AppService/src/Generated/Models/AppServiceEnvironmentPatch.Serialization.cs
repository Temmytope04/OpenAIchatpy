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
    public partial class AppServiceEnvironmentPatch : IUtf8JsonSerializable, IModelJsonSerializable<AppServiceEnvironmentPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppServiceEnvironmentPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppServiceEnvironmentPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceEnvironmentPatch>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualNetwork))
            {
                writer.WritePropertyName("virtualNetwork"u8);
                if (VirtualNetwork is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AppServiceVirtualNetworkProfile>)VirtualNetwork).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(InternalLoadBalancingMode))
            {
                writer.WritePropertyName("internalLoadBalancingMode"u8);
                writer.WriteStringValue(InternalLoadBalancingMode.Value.ToString());
            }
            if (Optional.IsDefined(MultiSize))
            {
                writer.WritePropertyName("multiSize"u8);
                writer.WriteStringValue(MultiSize);
            }
            if (Optional.IsDefined(IPSslAddressCount))
            {
                writer.WritePropertyName("ipsslAddressCount"u8);
                writer.WriteNumberValue(IPSslAddressCount.Value);
            }
            if (Optional.IsDefined(DnsSuffix))
            {
                writer.WritePropertyName("dnsSuffix"u8);
                writer.WriteStringValue(DnsSuffix);
            }
            if (Optional.IsDefined(FrontEndScaleFactor))
            {
                writer.WritePropertyName("frontEndScaleFactor"u8);
                writer.WriteNumberValue(FrontEndScaleFactor.Value);
            }
            if (Optional.IsCollectionDefined(ClusterSettings))
            {
                writer.WritePropertyName("clusterSettings"u8);
                writer.WriteStartArray();
                foreach (var item in ClusterSettings)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AppServiceNameValuePair>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserWhitelistedIPRanges))
            {
                writer.WritePropertyName("userWhitelistedIpRanges"u8);
                writer.WriteStartArray();
                foreach (var item in UserWhitelistedIPRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DedicatedHostCount))
            {
                writer.WritePropertyName("dedicatedHostCount"u8);
                writer.WriteNumberValue(DedicatedHostCount.Value);
            }
            if (Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant"u8);
                writer.WriteBooleanValue(IsZoneRedundant.Value);
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

        internal static AppServiceEnvironmentPatch DeserializeAppServiceEnvironmentPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<HostingEnvironmentStatus> status = default;
            Optional<AppServiceVirtualNetworkProfile> virtualNetwork = default;
            Optional<LoadBalancingMode> internalLoadBalancingMode = default;
            Optional<string> multiSize = default;
            Optional<int> multiRoleCount = default;
            Optional<int> ipSslAddressCount = default;
            Optional<string> dnsSuffix = default;
            Optional<int> maximumNumberOfMachines = default;
            Optional<int> frontEndScaleFactor = default;
            Optional<bool> suspended = default;
            Optional<IList<AppServiceNameValuePair>> clusterSettings = default;
            Optional<IList<string>> userWhitelistedIPRanges = default;
            Optional<bool> hasLinuxWorkers = default;
            Optional<int> dedicatedHostCount = default;
            Optional<bool> zoneRedundant = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetString().ToHostingEnvironmentStatus();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetwork"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetwork = AppServiceVirtualNetworkProfile.DeserializeAppServiceVirtualNetworkProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("internalLoadBalancingMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            internalLoadBalancingMode = new LoadBalancingMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("multiSize"u8))
                        {
                            multiSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("multiRoleCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            multiRoleCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("ipsslAddressCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipSslAddressCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dnsSuffix"u8))
                        {
                            dnsSuffix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maximumNumberOfMachines"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maximumNumberOfMachines = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("frontEndScaleFactor"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            frontEndScaleFactor = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("suspended"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            suspended = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("clusterSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AppServiceNameValuePair> array = new List<AppServiceNameValuePair>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AppServiceNameValuePair.DeserializeAppServiceNameValuePair(item));
                            }
                            clusterSettings = array;
                            continue;
                        }
                        if (property0.NameEquals("userWhitelistedIpRanges"u8))
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
                            userWhitelistedIPRanges = array;
                            continue;
                        }
                        if (property0.NameEquals("hasLinuxWorkers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hasLinuxWorkers = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("dedicatedHostCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dedicatedHostCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundant"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zoneRedundant = property0.Value.GetBoolean();
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
            return new AppServiceEnvironmentPatch(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(status), virtualNetwork.Value, Optional.ToNullable(internalLoadBalancingMode), multiSize.Value, Optional.ToNullable(multiRoleCount), Optional.ToNullable(ipSslAddressCount), dnsSuffix.Value, Optional.ToNullable(maximumNumberOfMachines), Optional.ToNullable(frontEndScaleFactor), Optional.ToNullable(suspended), Optional.ToList(clusterSettings), Optional.ToList(userWhitelistedIPRanges), Optional.ToNullable(hasLinuxWorkers), Optional.ToNullable(dedicatedHostCount), Optional.ToNullable(zoneRedundant), kind.Value, rawData);
        }

        AppServiceEnvironmentPatch IModelJsonSerializable<AppServiceEnvironmentPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceEnvironmentPatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceEnvironmentPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppServiceEnvironmentPatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceEnvironmentPatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppServiceEnvironmentPatch IModelSerializable<AppServiceEnvironmentPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceEnvironmentPatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppServiceEnvironmentPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppServiceEnvironmentPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppServiceEnvironmentPatch"/> to convert. </param>
        public static implicit operator RequestContent(AppServiceEnvironmentPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppServiceEnvironmentPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppServiceEnvironmentPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppServiceEnvironmentPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
