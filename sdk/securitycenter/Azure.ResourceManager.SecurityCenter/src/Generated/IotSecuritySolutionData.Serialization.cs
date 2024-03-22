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
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class IotSecuritySolutionData : IUtf8JsonSerializable, IJsonModel<IotSecuritySolutionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotSecuritySolutionData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IotSecuritySolutionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecuritySolutionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotSecuritySolutionData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
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
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (Optional.IsDefined(Workspace))
            {
                writer.WritePropertyName("workspace"u8);
                writer.WriteStringValue(Workspace);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Export))
            {
                writer.WritePropertyName("export"u8);
                writer.WriteStartArray();
                foreach (var item in Export)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DisabledDataSources))
            {
                writer.WritePropertyName("disabledDataSources"u8);
                writer.WriteStartArray();
                foreach (var item in DisabledDataSources)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IotHubs))
            {
                writer.WritePropertyName("iotHubs"u8);
                writer.WriteStartArray();
                foreach (var item in IotHubs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UserDefinedResources))
            {
                writer.WritePropertyName("userDefinedResources"u8);
                writer.WriteObjectValue<UserDefinedResourcesProperties>(UserDefinedResources, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AutoDiscoveredResources))
            {
                writer.WritePropertyName("autoDiscoveredResources"u8);
                writer.WriteStartArray();
                foreach (var item in AutoDiscoveredResources)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RecommendationsConfiguration))
            {
                writer.WritePropertyName("recommendationsConfiguration"u8);
                writer.WriteStartArray();
                foreach (var item in RecommendationsConfiguration)
                {
                    writer.WriteObjectValue<RecommendationConfigurationProperties>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UnmaskedIPLoggingStatus))
            {
                writer.WritePropertyName("unmaskedIpLoggingStatus"u8);
                writer.WriteStringValue(UnmaskedIPLoggingStatus.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AdditionalWorkspaces))
            {
                writer.WritePropertyName("additionalWorkspaces"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalWorkspaces)
                {
                    writer.WriteObjectValue<AdditionalWorkspacesProperties>(item, options);
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

        IotSecuritySolutionData IJsonModel<IotSecuritySolutionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecuritySolutionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotSecuritySolutionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotSecuritySolutionData(document.RootElement, options);
        }

        internal static IotSecuritySolutionData DeserializeIotSecuritySolutionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string workspace = default;
            string displayName = default;
            SecuritySolutionStatus? status = default;
            IList<IotSecuritySolutionExportOption> export = default;
            IList<IotSecuritySolutionDataSource> disabledDataSources = default;
            IList<string> iotHubs = default;
            UserDefinedResourcesProperties userDefinedResources = default;
            IReadOnlyList<string> autoDiscoveredResources = default;
            IList<RecommendationConfigurationProperties> recommendationsConfiguration = default;
            UnmaskedIPLoggingStatus? unmaskedIPLoggingStatus = default;
            IList<AdditionalWorkspacesProperties> additionalWorkspaces = default;
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("workspace"u8))
                        {
                            workspace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new SecuritySolutionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("export"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IotSecuritySolutionExportOption> array = new List<IotSecuritySolutionExportOption>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new IotSecuritySolutionExportOption(item.GetString()));
                            }
                            export = array;
                            continue;
                        }
                        if (property0.NameEquals("disabledDataSources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IotSecuritySolutionDataSource> array = new List<IotSecuritySolutionDataSource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new IotSecuritySolutionDataSource(item.GetString()));
                            }
                            disabledDataSources = array;
                            continue;
                        }
                        if (property0.NameEquals("iotHubs"u8))
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
                            iotHubs = array;
                            continue;
                        }
                        if (property0.NameEquals("userDefinedResources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            userDefinedResources = UserDefinedResourcesProperties.DeserializeUserDefinedResourcesProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("autoDiscoveredResources"u8))
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
                            autoDiscoveredResources = array;
                            continue;
                        }
                        if (property0.NameEquals("recommendationsConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RecommendationConfigurationProperties> array = new List<RecommendationConfigurationProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RecommendationConfigurationProperties.DeserializeRecommendationConfigurationProperties(item, options));
                            }
                            recommendationsConfiguration = array;
                            continue;
                        }
                        if (property0.NameEquals("unmaskedIpLoggingStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            unmaskedIPLoggingStatus = new UnmaskedIPLoggingStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("additionalWorkspaces"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AdditionalWorkspacesProperties> array = new List<AdditionalWorkspacesProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AdditionalWorkspacesProperties.DeserializeAdditionalWorkspacesProperties(item, options));
                            }
                            additionalWorkspaces = array;
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
            return new IotSecuritySolutionData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                workspace,
                displayName,
                status,
                export ?? new ChangeTrackingList<IotSecuritySolutionExportOption>(),
                disabledDataSources ?? new ChangeTrackingList<IotSecuritySolutionDataSource>(),
                iotHubs ?? new ChangeTrackingList<string>(),
                userDefinedResources,
                autoDiscoveredResources ?? new ChangeTrackingList<string>(),
                recommendationsConfiguration ?? new ChangeTrackingList<RecommendationConfigurationProperties>(),
                unmaskedIPLoggingStatus,
                additionalWorkspaces ?? new ChangeTrackingList<AdditionalWorkspacesProperties>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotSecuritySolutionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecuritySolutionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotSecuritySolutionData)} does not support writing '{options.Format}' format.");
            }
        }

        IotSecuritySolutionData IPersistableModel<IotSecuritySolutionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecuritySolutionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotSecuritySolutionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotSecuritySolutionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotSecuritySolutionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
