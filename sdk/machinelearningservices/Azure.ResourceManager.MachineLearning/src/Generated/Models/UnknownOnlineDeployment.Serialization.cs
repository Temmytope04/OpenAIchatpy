// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownOnlineDeployment : IUtf8JsonSerializable, IJsonModel<MachineLearningOnlineDeploymentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningOnlineDeploymentProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningOnlineDeploymentProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningOnlineDeploymentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningOnlineDeploymentProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("endpointComputeType"u8);
            writer.WriteStringValue(EndpointComputeType.ToString());
            if (Optional.IsDefined(ScaleSettings))
            {
                if (ScaleSettings != null)
                {
                    writer.WritePropertyName("scaleSettings"u8);
                    writer.WriteObjectValue(ScaleSettings, options);
                }
                else
                {
                    writer.WriteNull("scaleSettings");
                }
            }
            if (Optional.IsDefined(RequestSettings))
            {
                if (RequestSettings != null)
                {
                    writer.WritePropertyName("requestSettings"u8);
                    writer.WriteObjectValue(RequestSettings, options);
                }
                else
                {
                    writer.WriteNull("requestSettings");
                }
            }
            if (Optional.IsDefined(ModelMountPath))
            {
                if (ModelMountPath != null)
                {
                    writer.WritePropertyName("modelMountPath"u8);
                    writer.WriteStringValue(ModelMountPath);
                }
                else
                {
                    writer.WriteNull("modelMountPath");
                }
            }
            if (Optional.IsDefined(AppInsightsEnabled))
            {
                writer.WritePropertyName("appInsightsEnabled"u8);
                writer.WriteBooleanValue(AppInsightsEnabled.Value);
            }
            if (Optional.IsDefined(LivenessProbe))
            {
                if (LivenessProbe != null)
                {
                    writer.WritePropertyName("livenessProbe"u8);
                    writer.WriteObjectValue(LivenessProbe, options);
                }
                else
                {
                    writer.WriteNull("livenessProbe");
                }
            }
            if (Optional.IsDefined(ReadinessProbe))
            {
                if (ReadinessProbe != null)
                {
                    writer.WritePropertyName("readinessProbe"u8);
                    writer.WriteObjectValue(ReadinessProbe, options);
                }
                else
                {
                    writer.WriteNull("readinessProbe");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(InstanceType))
            {
                if (InstanceType != null)
                {
                    writer.WritePropertyName("instanceType"u8);
                    writer.WriteStringValue(InstanceType);
                }
                else
                {
                    writer.WriteNull("instanceType");
                }
            }
            if (Optional.IsDefined(Model))
            {
                if (Model != null)
                {
                    writer.WritePropertyName("model"u8);
                    writer.WriteStringValue(Model);
                }
                else
                {
                    writer.WriteNull("model");
                }
            }
            if (Optional.IsDefined(EgressPublicNetworkAccess))
            {
                writer.WritePropertyName("egressPublicNetworkAccess"u8);
                writer.WriteStringValue(EgressPublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(DataCollector))
            {
                if (DataCollector != null)
                {
                    writer.WritePropertyName("dataCollector"u8);
                    writer.WriteObjectValue(DataCollector, options);
                }
                else
                {
                    writer.WriteNull("dataCollector");
                }
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (Optional.IsDefined(CodeConfiguration))
            {
                if (CodeConfiguration != null)
                {
                    writer.WritePropertyName("codeConfiguration"u8);
                    writer.WriteObjectValue(CodeConfiguration, options);
                }
                else
                {
                    writer.WriteNull("codeConfiguration");
                }
            }
            if (Optional.IsDefined(EnvironmentId))
            {
                if (EnvironmentId != null)
                {
                    writer.WritePropertyName("environmentId"u8);
                    writer.WriteStringValue(EnvironmentId);
                }
                else
                {
                    writer.WriteNull("environmentId");
                }
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                if (EnvironmentVariables != null)
                {
                    writer.WritePropertyName("environmentVariables"u8);
                    writer.WriteStartObject();
                    foreach (var item in EnvironmentVariables)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("environmentVariables");
                }
            }
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

        MachineLearningOnlineDeploymentProperties IJsonModel<MachineLearningOnlineDeploymentProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningOnlineDeploymentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningOnlineDeploymentProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningOnlineDeploymentProperties(document.RootElement, options);
        }

        internal static UnknownOnlineDeployment DeserializeUnknownOnlineDeployment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningEndpointComputeType endpointComputeType = "Unknown";
            MachineLearningOnlineScaleSettings scaleSettings = default;
            MachineLearningOnlineRequestSettings requestSettings = default;
            string modelMountPath = default;
            bool? appInsightsEnabled = default;
            MachineLearningProbeSettings livenessProbe = default;
            MachineLearningProbeSettings readinessProbe = default;
            MachineLearningDeploymentProvisioningState? provisioningState = default;
            string instanceType = default;
            string model = default;
            MachineLearningEgressPublicNetworkAccessType? egressPublicNetworkAccess = default;
            DataCollector dataCollector = default;
            string description = default;
            IDictionary<string, string> properties = default;
            MachineLearningCodeConfiguration codeConfiguration = default;
            string environmentId = default;
            IDictionary<string, string> environmentVariables = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointComputeType"u8))
                {
                    endpointComputeType = new MachineLearningEndpointComputeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scaleSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        scaleSettings = null;
                        continue;
                    }
                    scaleSettings = MachineLearningOnlineScaleSettings.DeserializeMachineLearningOnlineScaleSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("requestSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        requestSettings = null;
                        continue;
                    }
                    requestSettings = MachineLearningOnlineRequestSettings.DeserializeMachineLearningOnlineRequestSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("modelMountPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelMountPath = null;
                        continue;
                    }
                    modelMountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appInsightsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appInsightsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("livenessProbe"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        livenessProbe = null;
                        continue;
                    }
                    livenessProbe = MachineLearningProbeSettings.DeserializeMachineLearningProbeSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("readinessProbe"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        readinessProbe = null;
                        continue;
                    }
                    readinessProbe = MachineLearningProbeSettings.DeserializeMachineLearningProbeSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new MachineLearningDeploymentProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        instanceType = null;
                        continue;
                    }
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        model = null;
                        continue;
                    }
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("egressPublicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    egressPublicNetworkAccess = new MachineLearningEgressPublicNetworkAccessType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataCollector"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataCollector = null;
                        continue;
                    }
                    dataCollector = DataCollector.DeserializeDataCollector(property.Value, options);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("codeConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        codeConfiguration = null;
                        continue;
                    }
                    codeConfiguration = MachineLearningCodeConfiguration.DeserializeMachineLearningCodeConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("environmentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        environmentId = null;
                        continue;
                    }
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentVariables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        environmentVariables = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    environmentVariables = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownOnlineDeployment(
                description,
                properties ?? new ChangeTrackingDictionary<string, string>(),
                codeConfiguration,
                environmentId,
                environmentVariables ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                endpointComputeType,
                scaleSettings,
                requestSettings,
                modelMountPath,
                appInsightsEnabled,
                livenessProbe,
                readinessProbe,
                provisioningState,
                instanceType,
                model,
                egressPublicNetworkAccess,
                dataCollector);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndpointComputeType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endpointComputeType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  endpointComputeType: ");
                builder.AppendLine($"'{EndpointComputeType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ScaleSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  scaleSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ScaleSettings))
                {
                    builder.Append("  scaleSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ScaleSettings, options, 2, false, "  scaleSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RequestSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  requestSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RequestSettings))
                {
                    builder.Append("  requestSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, RequestSettings, options, 2, false, "  requestSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ModelMountPath), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  modelMountPath: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ModelMountPath))
                {
                    builder.Append("  modelMountPath: ");
                    if (ModelMountPath.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ModelMountPath}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ModelMountPath}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AppInsightsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  appInsightsEnabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AppInsightsEnabled))
                {
                    builder.Append("  appInsightsEnabled: ");
                    var boolValue = AppInsightsEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LivenessProbe), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  livenessProbe: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LivenessProbe))
                {
                    builder.Append("  livenessProbe: ");
                    BicepSerializationHelpers.AppendChildObject(builder, LivenessProbe, options, 2, false, "  livenessProbe: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ReadinessProbe), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  readinessProbe: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ReadinessProbe))
                {
                    builder.Append("  readinessProbe: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ReadinessProbe, options, 2, false, "  readinessProbe: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("  provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InstanceType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  instanceType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(InstanceType))
                {
                    builder.Append("  instanceType: ");
                    if (InstanceType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{InstanceType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{InstanceType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Model), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  model: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Model))
                {
                    builder.Append("  model: ");
                    if (Model.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Model}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Model}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EgressPublicNetworkAccess), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  egressPublicNetworkAccess: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EgressPublicNetworkAccess))
                {
                    builder.Append("  egressPublicNetworkAccess: ");
                    builder.AppendLine($"'{EgressPublicNetworkAccess.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DataCollector), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dataCollector: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DataCollector))
                {
                    builder.Append("  dataCollector: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DataCollector, options, 2, false, "  dataCollector: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("  description: ");
                    if (Description.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Description}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Description}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Properties), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  properties: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Properties))
                {
                    if (Properties.Any())
                    {
                        builder.Append("  properties: ");
                        builder.AppendLine("{");
                        foreach (var item in Properties)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CodeConfiguration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  codeConfiguration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CodeConfiguration))
                {
                    builder.Append("  codeConfiguration: ");
                    BicepSerializationHelpers.AppendChildObject(builder, CodeConfiguration, options, 2, false, "  codeConfiguration: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnvironmentId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  environmentId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EnvironmentId))
                {
                    builder.Append("  environmentId: ");
                    if (EnvironmentId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EnvironmentId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EnvironmentId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnvironmentVariables), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  environmentVariables: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(EnvironmentVariables))
                {
                    if (EnvironmentVariables.Any())
                    {
                        builder.Append("  environmentVariables: ");
                        builder.AppendLine("{");
                        foreach (var item in EnvironmentVariables)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningOnlineDeploymentProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningOnlineDeploymentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningOnlineDeploymentProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningOnlineDeploymentProperties IPersistableModel<MachineLearningOnlineDeploymentProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningOnlineDeploymentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningOnlineDeploymentProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningOnlineDeploymentProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningOnlineDeploymentProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
