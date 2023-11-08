// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class ProvisionedClustersResponseProperties : IUtf8JsonSerializable, IJsonModel<ProvisionedClustersResponseProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProvisionedClustersResponseProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ProvisionedClustersResponseProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EnableRbac))
            {
                writer.WritePropertyName("enableRbac"u8);
                writer.WriteBooleanValue(EnableRbac.Value);
            }
            if (Optional.IsDefined(LinuxProfile))
            {
                writer.WritePropertyName("linuxProfile"u8);
                writer.WriteObjectValue(LinuxProfile);
            }
            if (Optional.IsDefined(Features))
            {
                writer.WritePropertyName("features"u8);
                writer.WriteObjectValue(Features);
            }
            if (Optional.IsCollectionDefined(AddonProfiles))
            {
                writer.WritePropertyName("addonProfiles"u8);
                writer.WriteStartObject();
                foreach (var item in AddonProfiles)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ControlPlane))
            {
                writer.WritePropertyName("controlPlane"u8);
                writer.WriteObjectValue(ControlPlane);
            }
            if (Optional.IsDefined(KubernetesVersion))
            {
                writer.WritePropertyName("kubernetesVersion"u8);
                writer.WriteStringValue(KubernetesVersion);
            }
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile);
            }
            if (Optional.IsDefined(NodeResourceGroup))
            {
                writer.WritePropertyName("nodeResourceGroup"u8);
                writer.WriteStringValue(NodeResourceGroup);
            }
            if (Optional.IsCollectionDefined(AgentPoolProfiles))
            {
                writer.WritePropertyName("agentPoolProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in AgentPoolProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CloudProviderProfile))
            {
                writer.WritePropertyName("cloudProviderProfile"u8);
                writer.WriteObjectValue(CloudProviderProfile);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Status))
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteObjectValue(Status);
                }
            }
            if (Optional.IsDefined(AadProfile))
            {
                writer.WritePropertyName("aadProfile"u8);
                writer.WriteObjectValue(AadProfile);
            }
            if (Optional.IsDefined(WindowsProfile))
            {
                writer.WritePropertyName("windowsProfile"u8);
                writer.WriteObjectValue(WindowsProfile);
            }
            if (Optional.IsDefined(HttpProxyConfig))
            {
                writer.WritePropertyName("httpProxyConfig"u8);
                writer.WriteObjectValue(HttpProxyConfig);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        ProvisionedClustersResponseProperties IJsonModel<ProvisionedClustersResponseProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProvisionedClustersResponseProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProvisionedClustersResponseProperties(document.RootElement, options);
        }

        internal static ProvisionedClustersResponseProperties DeserializeProvisionedClustersResponseProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enableRbac = default;
            Optional<LinuxProfileProperties> linuxProfile = default;
            Optional<ProvisionedClustersCommonPropertiesFeatures> features = default;
            Optional<IDictionary<string, AddonProfiles>> addonProfiles = default;
            Optional<ControlPlaneProfile> controlPlane = default;
            Optional<string> kubernetesVersion = default;
            Optional<NetworkProfile> networkProfile = default;
            Optional<string> nodeResourceGroup = default;
            Optional<IList<NamedAgentPoolProfile>> agentPoolProfiles = default;
            Optional<CloudProviderProfile> cloudProviderProfile = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<ProvisionedClustersCommonPropertiesStatus> status = default;
            Optional<AADProfileResponse> aadProfile = default;
            Optional<WindowsProfileResponse> windowsProfile = default;
            Optional<HttpProxyConfigResponse> httpProxyConfig = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableRbac"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableRbac = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("linuxProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linuxProfile = LinuxProfileProperties.DeserializeLinuxProfileProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("features"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    features = ProvisionedClustersCommonPropertiesFeatures.DeserializeProvisionedClustersCommonPropertiesFeatures(property.Value);
                    continue;
                }
                if (property.NameEquals("addonProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, AddonProfiles> dictionary = new Dictionary<string, AddonProfiles>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, Models.AddonProfiles.DeserializeAddonProfiles(property0.Value));
                    }
                    addonProfiles = dictionary;
                    continue;
                }
                if (property.NameEquals("controlPlane"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    controlPlane = ControlPlaneProfile.DeserializeControlPlaneProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("kubernetesVersion"u8))
                {
                    kubernetesVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkProfile = NetworkProfile.DeserializeNetworkProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("nodeResourceGroup"u8))
                {
                    nodeResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentPoolProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NamedAgentPoolProfile> array = new List<NamedAgentPoolProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NamedAgentPoolProfile.DeserializeNamedAgentPoolProfile(item));
                    }
                    agentPoolProfiles = array;
                    continue;
                }
                if (property.NameEquals("cloudProviderProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudProviderProfile = CloudProviderProfile.DeserializeCloudProviderProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = ProvisionedClustersCommonPropertiesStatus.DeserializeProvisionedClustersCommonPropertiesStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("aadProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aadProfile = AADProfileResponse.DeserializeAADProfileResponse(property.Value);
                    continue;
                }
                if (property.NameEquals("windowsProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsProfile = WindowsProfileResponse.DeserializeWindowsProfileResponse(property.Value);
                    continue;
                }
                if (property.NameEquals("httpProxyConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpProxyConfig = HttpProxyConfigResponse.DeserializeHttpProxyConfigResponse(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProvisionedClustersResponseProperties(aadProfile.Value, windowsProfile.Value, httpProxyConfig.Value, serializedAdditionalRawData, Optional.ToNullable(enableRbac), linuxProfile.Value, features.Value, Optional.ToDictionary(addonProfiles), controlPlane.Value, kubernetesVersion.Value, networkProfile.Value, nodeResourceGroup.Value, Optional.ToList(agentPoolProfiles), cloudProviderProfile.Value, Optional.ToNullable(provisioningState), status.Value);
        }

        BinaryData IModel<ProvisionedClustersResponseProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProvisionedClustersResponseProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ProvisionedClustersResponseProperties IModel<ProvisionedClustersResponseProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProvisionedClustersResponseProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeProvisionedClustersResponseProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ProvisionedClustersResponseProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
