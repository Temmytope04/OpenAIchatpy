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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class WorkflowVersionData : IUtf8JsonSerializable, IJsonModel<WorkflowVersionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkflowVersionData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WorkflowVersionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkflowVersionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkflowVersionData)} does not support writing '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ChangedOn))
            {
                writer.WritePropertyName("changedTime"u8);
                writer.WriteStringValue(ChangedOn.Value, "O");
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && Optional.IsDefined(AccessEndpoint))
            {
                writer.WritePropertyName("accessEndpoint"u8);
                writer.WriteStringValue(AccessEndpoint);
            }
            if (Optional.IsDefined(EndpointsConfiguration))
            {
                writer.WritePropertyName("endpointsConfiguration"u8);
                writer.WriteObjectValue(EndpointsConfiguration, options);
            }
            if (Optional.IsDefined(AccessControl))
            {
                writer.WritePropertyName("accessControl"u8);
                writer.WriteObjectValue(AccessControl, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            if (Optional.IsDefined(IntegrationAccount))
            {
                writer.WritePropertyName("integrationAccount"u8);
                writer.WriteObjectValue(IntegrationAccount, options);
            }
            if (Optional.IsDefined(Definition))
            {
                writer.WritePropertyName("definition"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Definition);
#else
                using (JsonDocument document = JsonDocument.Parse(Definition))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
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

        WorkflowVersionData IJsonModel<WorkflowVersionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkflowVersionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkflowVersionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkflowVersionData(document.RootElement, options);
        }

        internal static WorkflowVersionData DeserializeWorkflowVersionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

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
            WorkflowProvisioningState? provisioningState = default;
            DateTimeOffset? createdTime = default;
            DateTimeOffset? changedTime = default;
            WorkflowState? state = default;
            string version = default;
            string accessEndpoint = default;
            FlowEndpointsConfiguration endpointsConfiguration = default;
            FlowAccessControlConfiguration accessControl = default;
            WorkflowSku sku = default;
            WorkflowResourceReference integrationAccount = default;
            BinaryData definition = default;
            IDictionary<string, WorkflowContent> parameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new WorkflowProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("createdTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("changedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            changedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new WorkflowState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accessEndpoint"u8))
                        {
                            accessEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endpointsConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointsConfiguration = FlowEndpointsConfiguration.DeserializeFlowEndpointsConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("accessControl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessControl = FlowAccessControlConfiguration.DeserializeFlowAccessControlConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sku = WorkflowSku.DeserializeWorkflowSku(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("integrationAccount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            integrationAccount = WorkflowResourceReference.DeserializeWorkflowResourceReference(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("definition"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            definition = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, WorkflowContent> dictionary = new Dictionary<string, WorkflowContent>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, WorkflowContent.DeserializeWorkflowContent(property1.Value, options));
                            }
                            parameters = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WorkflowVersionData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                provisioningState,
                createdTime,
                changedTime,
                state,
                version,
                accessEndpoint,
                endpointsConfiguration,
                accessControl,
                sku,
                integrationAccount,
                definition,
                parameters ?? new ChangeTrackingDictionary<string, WorkflowContent>(),
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Location), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  location: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  location: ");
                builder.AppendLine($"'{Location.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Tags), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tags: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Tags))
                {
                    if (Tags.Any())
                    {
                        builder.Append("  tags: ");
                        builder.AppendLine("{");
                        foreach (var item in Tags)
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("    provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreatedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    createdTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CreatedOn))
                {
                    builder.Append("    createdTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(CreatedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ChangedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    changedTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ChangedOn))
                {
                    builder.Append("    changedTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(ChangedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(State), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    state: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(State))
                {
                    builder.Append("    state: ");
                    builder.AppendLine($"'{State.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Version), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    version: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Version))
                {
                    builder.Append("    version: ");
                    if (Version.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Version}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Version}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AccessEndpoint), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    accessEndpoint: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AccessEndpoint))
                {
                    builder.Append("    accessEndpoint: ");
                    if (AccessEndpoint.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AccessEndpoint}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AccessEndpoint}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndpointsConfiguration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    endpointsConfiguration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EndpointsConfiguration))
                {
                    builder.Append("    endpointsConfiguration: ");
                    BicepSerializationHelpers.AppendChildObject(builder, EndpointsConfiguration, options, 4, false, "    endpointsConfiguration: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AccessControl), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    accessControl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AccessControl))
                {
                    builder.Append("    accessControl: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AccessControl, options, 4, false, "    accessControl: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Sku), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    sku: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Sku))
                {
                    builder.Append("    sku: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Sku, options, 4, false, "    sku: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IntegrationAccount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    integrationAccount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IntegrationAccount))
                {
                    builder.Append("    integrationAccount: ");
                    BicepSerializationHelpers.AppendChildObject(builder, IntegrationAccount, options, 4, false, "    integrationAccount: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Definition), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    definition: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Definition))
                {
                    builder.Append("    definition: ");
                    builder.AppendLine($"'{Definition.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Parameters), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    parameters: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Parameters))
                {
                    if (Parameters.Any())
                    {
                        builder.Append("    parameters: ");
                        builder.AppendLine("{");
                        foreach (var item in Parameters)
                        {
                            builder.Append($"        '{item.Key}': ");
                            BicepSerializationHelpers.AppendChildObject(builder, item.Value, options, 6, false, "    parameters: ");
                        }
                        builder.AppendLine("    }");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<WorkflowVersionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkflowVersionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(WorkflowVersionData)} does not support writing '{options.Format}' format.");
            }
        }

        WorkflowVersionData IPersistableModel<WorkflowVersionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkflowVersionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkflowVersionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkflowVersionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkflowVersionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
