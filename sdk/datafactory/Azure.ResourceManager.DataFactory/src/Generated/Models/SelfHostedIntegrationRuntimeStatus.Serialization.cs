// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SelfHostedIntegrationRuntimeStatus : IUtf8JsonSerializable, IJsonModel<SelfHostedIntegrationRuntimeStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SelfHostedIntegrationRuntimeStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SelfHostedIntegrationRuntimeStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHostedIntegrationRuntimeStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHostedIntegrationRuntimeStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(RuntimeType.ToString());
            if (options.Format != "W" && DataFactoryName != null)
            {
                writer.WritePropertyName("dataFactoryName"u8);
                writer.WriteStringValue(DataFactoryName);
            }
            if (options.Format != "W" && State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("createTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && TaskQueueId.HasValue)
            {
                writer.WritePropertyName("taskQueueId"u8);
                writer.WriteStringValue(TaskQueueId.Value);
            }
            if (options.Format != "W" && InternalChannelEncryption.HasValue)
            {
                writer.WritePropertyName("internalChannelEncryption"u8);
                writer.WriteStringValue(InternalChannelEncryption.Value.ToString());
            }
            if (options.Format != "W" && Version != null)
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (!(Nodes is ChangeTrackingList<SelfHostedIntegrationRuntimeNode> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("nodes"u8);
                writer.WriteStartArray();
                foreach (var item in Nodes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ScheduledUpdateOn.HasValue)
            {
                writer.WritePropertyName("scheduledUpdateDate"u8);
                writer.WriteStringValue(ScheduledUpdateOn.Value, "O");
            }
            if (options.Format != "W" && UpdateDelayOffset.HasValue)
            {
                writer.WritePropertyName("updateDelayOffset"u8);
                writer.WriteStringValue(UpdateDelayOffset.Value, "P");
            }
            if (options.Format != "W" && LocalTimeZoneOffset.HasValue)
            {
                writer.WritePropertyName("localTimeZoneOffset"u8);
                writer.WriteStringValue(LocalTimeZoneOffset.Value, "P");
            }
            if (options.Format != "W" && !(Capabilities is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartObject();
                foreach (var item in Capabilities)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && !(ServiceUriStringList is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("serviceUrls"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceUriStringList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && AutoUpdate.HasValue)
            {
                writer.WritePropertyName("autoUpdate"u8);
                writer.WriteStringValue(AutoUpdate.Value.ToString());
            }
            if (options.Format != "W" && VersionStatus != null)
            {
                writer.WritePropertyName("versionStatus"u8);
                writer.WriteStringValue(VersionStatus);
            }
            if (!(Links is ChangeTrackingList<LinkedIntegrationRuntime> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("links"u8);
                writer.WriteStartArray();
                foreach (var item in Links)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && PushedVersion != null)
            {
                writer.WritePropertyName("pushedVersion"u8);
                writer.WriteStringValue(PushedVersion);
            }
            if (options.Format != "W" && LatestVersion != null)
            {
                writer.WritePropertyName("latestVersion"u8);
                writer.WriteStringValue(LatestVersion);
            }
            if (options.Format != "W" && AutoUpdateEta.HasValue)
            {
                writer.WritePropertyName("autoUpdateETA"u8);
                writer.WriteStringValue(AutoUpdateEta.Value, "O");
            }
            if (options.Format != "W" && IsSelfContainedInteractiveAuthoringEnabled.HasValue)
            {
                writer.WritePropertyName("selfContainedInteractiveAuthoringEnabled"u8);
                writer.WriteBooleanValue(IsSelfContainedInteractiveAuthoringEnabled.Value);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        SelfHostedIntegrationRuntimeStatus IJsonModel<SelfHostedIntegrationRuntimeStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHostedIntegrationRuntimeStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHostedIntegrationRuntimeStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSelfHostedIntegrationRuntimeStatus(document.RootElement, options);
        }

        internal static SelfHostedIntegrationRuntimeStatus DeserializeSelfHostedIntegrationRuntimeStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationRuntimeType type = default;
            string dataFactoryName = default;
            IntegrationRuntimeState? state = default;
            DateTimeOffset? createTime = default;
            Guid? taskQueueId = default;
            IntegrationRuntimeInternalChannelEncryptionMode? internalChannelEncryption = default;
            string version = default;
            IReadOnlyList<SelfHostedIntegrationRuntimeNode> nodes = default;
            DateTimeOffset? scheduledUpdateDate = default;
            TimeSpan? updateDelayOffset = default;
            TimeSpan? localTimeZoneOffset = default;
            IReadOnlyDictionary<string, string> capabilities = default;
            IReadOnlyList<string> serviceUrls = default;
            IntegrationRuntimeAutoUpdateState? autoUpdate = default;
            string versionStatus = default;
            IReadOnlyList<LinkedIntegrationRuntime> links = default;
            string pushedVersion = default;
            string latestVersion = default;
            DateTimeOffset? autoUpdateEta = default;
            bool? selfContainedInteractiveAuthoringEnabled = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new IntegrationRuntimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataFactoryName"u8))
                {
                    dataFactoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new IntegrationRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("createTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("taskQueueId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            taskQueueId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("internalChannelEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            internalChannelEncryption = new IntegrationRuntimeInternalChannelEncryptionMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SelfHostedIntegrationRuntimeNode> array = new List<SelfHostedIntegrationRuntimeNode>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SelfHostedIntegrationRuntimeNode.DeserializeSelfHostedIntegrationRuntimeNode(item, options));
                            }
                            nodes = array;
                            continue;
                        }
                        if (property0.NameEquals("scheduledUpdateDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scheduledUpdateDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updateDelayOffset"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updateDelayOffset = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("localTimeZoneOffset"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            localTimeZoneOffset = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("capabilities"u8))
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
                            capabilities = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("serviceUrls"u8))
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
                            serviceUrls = array;
                            continue;
                        }
                        if (property0.NameEquals("autoUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoUpdate = new IntegrationRuntimeAutoUpdateState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("versionStatus"u8))
                        {
                            versionStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("links"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<LinkedIntegrationRuntime> array = new List<LinkedIntegrationRuntime>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LinkedIntegrationRuntime.DeserializeLinkedIntegrationRuntime(item, options));
                            }
                            links = array;
                            continue;
                        }
                        if (property0.NameEquals("pushedVersion"u8))
                        {
                            pushedVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("latestVersion"u8))
                        {
                            latestVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("autoUpdateETA"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoUpdateEta = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("selfContainedInteractiveAuthoringEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            selfContainedInteractiveAuthoringEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SelfHostedIntegrationRuntimeStatus(
                type,
                dataFactoryName,
                state,
                additionalProperties,
                createTime,
                taskQueueId,
                internalChannelEncryption,
                version,
                nodes ?? new ChangeTrackingList<SelfHostedIntegrationRuntimeNode>(),
                scheduledUpdateDate,
                updateDelayOffset,
                localTimeZoneOffset,
                capabilities ?? new ChangeTrackingDictionary<string, string>(),
                serviceUrls ?? new ChangeTrackingList<string>(),
                autoUpdate,
                versionStatus,
                links ?? new ChangeTrackingList<LinkedIntegrationRuntime>(),
                pushedVersion,
                latestVersion,
                autoUpdateEta,
                selfContainedInteractiveAuthoringEnabled);
        }

        BinaryData IPersistableModel<SelfHostedIntegrationRuntimeStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHostedIntegrationRuntimeStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SelfHostedIntegrationRuntimeStatus)} does not support '{options.Format}' format.");
            }
        }

        SelfHostedIntegrationRuntimeStatus IPersistableModel<SelfHostedIntegrationRuntimeStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHostedIntegrationRuntimeStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSelfHostedIntegrationRuntimeStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SelfHostedIntegrationRuntimeStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SelfHostedIntegrationRuntimeStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
