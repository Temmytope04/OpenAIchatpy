// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineRunCommandUpdate : IUtf8JsonSerializable, IJsonModel<VirtualMachineRunCommandUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineRunCommandUpdate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineRunCommandUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineRunCommandUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineRunCommandUpdate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Source != null)
            {
                writer.WritePropertyName("source"u8);
                writer.WriteObjectValue(Source);
            }
            if (!(Parameters is ChangeTrackingList<RunCommandInputParameter> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ProtectedParameters is ChangeTrackingList<RunCommandInputParameter> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("protectedParameters"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedParameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (AsyncExecution.HasValue)
            {
                writer.WritePropertyName("asyncExecution"u8);
                writer.WriteBooleanValue(AsyncExecution.Value);
            }
            if (RunAsUser != null)
            {
                writer.WritePropertyName("runAsUser"u8);
                writer.WriteStringValue(RunAsUser);
            }
            if (RunAsPassword != null)
            {
                writer.WritePropertyName("runAsPassword"u8);
                writer.WriteStringValue(RunAsPassword);
            }
            if (TimeoutInSeconds.HasValue)
            {
                writer.WritePropertyName("timeoutInSeconds"u8);
                writer.WriteNumberValue(TimeoutInSeconds.Value);
            }
            if (OutputBlobUri != null)
            {
                writer.WritePropertyName("outputBlobUri"u8);
                writer.WriteStringValue(OutputBlobUri.AbsoluteUri);
            }
            if (ErrorBlobUri != null)
            {
                writer.WritePropertyName("errorBlobUri"u8);
                writer.WriteStringValue(ErrorBlobUri.AbsoluteUri);
            }
            if (OutputBlobManagedIdentity != null)
            {
                writer.WritePropertyName("outputBlobManagedIdentity"u8);
                writer.WriteObjectValue(OutputBlobManagedIdentity);
            }
            if (ErrorBlobManagedIdentity != null)
            {
                writer.WritePropertyName("errorBlobManagedIdentity"u8);
                writer.WriteObjectValue(ErrorBlobManagedIdentity);
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && InstanceView != null)
            {
                writer.WritePropertyName("instanceView"u8);
                writer.WriteObjectValue(InstanceView);
            }
            if (TreatFailureAsDeploymentFailure.HasValue)
            {
                writer.WritePropertyName("treatFailureAsDeploymentFailure"u8);
                writer.WriteBooleanValue(TreatFailureAsDeploymentFailure.Value);
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

        VirtualMachineRunCommandUpdate IJsonModel<VirtualMachineRunCommandUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineRunCommandUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineRunCommandUpdate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineRunCommandUpdate(document.RootElement, options);
        }

        internal static VirtualMachineRunCommandUpdate DeserializeVirtualMachineRunCommandUpdate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            VirtualMachineRunCommandScriptSource source = default;
            IList<RunCommandInputParameter> parameters = default;
            IList<RunCommandInputParameter> protectedParameters = default;
            bool? asyncExecution = default;
            string runAsUser = default;
            string runAsPassword = default;
            int? timeoutInSeconds = default;
            Uri outputBlobUri = default;
            Uri errorBlobUri = default;
            RunCommandManagedIdentity outputBlobManagedIdentity = default;
            RunCommandManagedIdentity errorBlobManagedIdentity = default;
            string provisioningState = default;
            VirtualMachineRunCommandInstanceView instanceView = default;
            bool? treatFailureAsDeploymentFailure = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = VirtualMachineRunCommandScriptSource.DeserializeVirtualMachineRunCommandScriptSource(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RunCommandInputParameter> array = new List<RunCommandInputParameter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RunCommandInputParameter.DeserializeRunCommandInputParameter(item, options));
                            }
                            parameters = array;
                            continue;
                        }
                        if (property0.NameEquals("protectedParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RunCommandInputParameter> array = new List<RunCommandInputParameter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RunCommandInputParameter.DeserializeRunCommandInputParameter(item, options));
                            }
                            protectedParameters = array;
                            continue;
                        }
                        if (property0.NameEquals("asyncExecution"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            asyncExecution = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("runAsUser"u8))
                        {
                            runAsUser = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("runAsPassword"u8))
                        {
                            runAsPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeoutInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeoutInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("outputBlobUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            outputBlobUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("errorBlobUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorBlobUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("outputBlobManagedIdentity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            outputBlobManagedIdentity = RunCommandManagedIdentity.DeserializeRunCommandManagedIdentity(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("errorBlobManagedIdentity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorBlobManagedIdentity = RunCommandManagedIdentity.DeserializeRunCommandManagedIdentity(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("instanceView"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instanceView = VirtualMachineRunCommandInstanceView.DeserializeVirtualMachineRunCommandInstanceView(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("treatFailureAsDeploymentFailure"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            treatFailureAsDeploymentFailure = property0.Value.GetBoolean();
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
            return new VirtualMachineRunCommandUpdate(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                source,
                parameters ?? new ChangeTrackingList<RunCommandInputParameter>(),
                protectedParameters ?? new ChangeTrackingList<RunCommandInputParameter>(),
                asyncExecution,
                runAsUser,
                runAsPassword,
                timeoutInSeconds,
                outputBlobUri,
                errorBlobUri,
                outputBlobManagedIdentity,
                errorBlobManagedIdentity,
                provisioningState,
                instanceView,
                treatFailureAsDeploymentFailure);
        }

        BinaryData IPersistableModel<VirtualMachineRunCommandUpdate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineRunCommandUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineRunCommandUpdate)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineRunCommandUpdate IPersistableModel<VirtualMachineRunCommandUpdate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineRunCommandUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineRunCommandUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineRunCommandUpdate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineRunCommandUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
