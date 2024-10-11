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
    public partial class MachineLearningPipelineJob : IUtf8JsonSerializable, IJsonModel<MachineLearningPipelineJob>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningPipelineJob>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningPipelineJob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningPipelineJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningPipelineJob)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Settings))
            {
                if (Settings != null)
                {
                    writer.WritePropertyName("settings"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Settings);
#else
                    using (JsonDocument document = JsonDocument.Parse(Settings))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                else
                {
                    writer.WriteNull("settings");
                }
            }
            if (Optional.IsCollectionDefined(Jobs))
            {
                if (Jobs != null)
                {
                    writer.WritePropertyName("jobs"u8);
                    writer.WriteStartObject();
                    foreach (var item in Jobs)
                    {
                        writer.WritePropertyName(item.Key);
                        if (item.Value == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
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
                else
                {
                    writer.WriteNull("jobs");
                }
            }
            if (Optional.IsCollectionDefined(Inputs))
            {
                if (Inputs != null)
                {
                    writer.WritePropertyName("inputs"u8);
                    writer.WriteStartObject();
                    foreach (var item in Inputs)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value, options);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("inputs");
                }
            }
            if (Optional.IsCollectionDefined(Outputs))
            {
                if (Outputs != null)
                {
                    writer.WritePropertyName("outputs"u8);
                    writer.WriteStartObject();
                    foreach (var item in Outputs)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value, options);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("outputs");
                }
            }
            if (Optional.IsDefined(SourceJobId))
            {
                if (SourceJobId != null)
                {
                    writer.WritePropertyName("sourceJobId"u8);
                    writer.WriteStringValue(SourceJobId);
                }
                else
                {
                    writer.WriteNull("sourceJobId");
                }
            }
        }

        MachineLearningPipelineJob IJsonModel<MachineLearningPipelineJob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningPipelineJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningPipelineJob)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningPipelineJob(document.RootElement, options);
        }

        internal static MachineLearningPipelineJob DeserializeMachineLearningPipelineJob(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BinaryData settings = default;
            IDictionary<string, BinaryData> jobs = default;
            IDictionary<string, MachineLearningJobInput> inputs = default;
            IDictionary<string, MachineLearningJobOutput> outputs = default;
            ResourceIdentifier sourceJobId = default;
            JobType jobType = default;
            string displayName = default;
            MachineLearningJobStatus? status = default;
            string experimentName = default;
            IDictionary<string, MachineLearningJobService> services = default;
            ResourceIdentifier computeId = default;
            bool? isArchived = default;
            MachineLearningIdentityConfiguration identity = default;
            ResourceIdentifier componentId = default;
            NotificationSetting notificationSetting = default;
            string description = default;
            IDictionary<string, string> tags = default;
            IDictionary<string, string> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("settings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        settings = null;
                        continue;
                    }
                    settings = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("jobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        jobs = null;
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    jobs = dictionary;
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        inputs = null;
                        continue;
                    }
                    Dictionary<string, MachineLearningJobInput> dictionary = new Dictionary<string, MachineLearningJobInput>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MachineLearningJobInput.DeserializeMachineLearningJobInput(property0.Value, options));
                    }
                    inputs = dictionary;
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        outputs = null;
                        continue;
                    }
                    Dictionary<string, MachineLearningJobOutput> dictionary = new Dictionary<string, MachineLearningJobOutput>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MachineLearningJobOutput.DeserializeMachineLearningJobOutput(property0.Value, options));
                    }
                    outputs = dictionary;
                    continue;
                }
                if (property.NameEquals("sourceJobId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sourceJobId = null;
                        continue;
                    }
                    sourceJobId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobType"u8))
                {
                    jobType = new JobType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        displayName = null;
                        continue;
                    }
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new MachineLearningJobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("experimentName"u8))
                {
                    experimentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("services"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        services = null;
                        continue;
                    }
                    Dictionary<string, MachineLearningJobService> dictionary = new Dictionary<string, MachineLearningJobService>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MachineLearningJobService.DeserializeMachineLearningJobService(property0.Value, options));
                    }
                    services = dictionary;
                    continue;
                }
                if (property.NameEquals("computeId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        computeId = null;
                        continue;
                    }
                    computeId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isArchived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchived = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = MachineLearningIdentityConfiguration.DeserializeMachineLearningIdentityConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("componentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        componentId = null;
                        continue;
                    }
                    componentId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("notificationSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        notificationSetting = null;
                        continue;
                    }
                    notificationSetting = NotificationSetting.DeserializeNotificationSetting(property.Value, options);
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
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
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
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningPipelineJob(
                description,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                properties ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                jobType,
                displayName,
                status,
                experimentName,
                services ?? new ChangeTrackingDictionary<string, MachineLearningJobService>(),
                computeId,
                isArchived,
                identity,
                componentId,
                notificationSetting,
                settings,
                jobs ?? new ChangeTrackingDictionary<string, BinaryData>(),
                inputs ?? new ChangeTrackingDictionary<string, MachineLearningJobInput>(),
                outputs ?? new ChangeTrackingDictionary<string, MachineLearningJobOutput>(),
                sourceJobId);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Settings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  settings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Settings))
                {
                    builder.Append("  settings: ");
                    builder.AppendLine($"'{Settings.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Jobs), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  jobs: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Jobs))
                {
                    if (Jobs.Any())
                    {
                        builder.Append("  jobs: ");
                        builder.AppendLine("{");
                        foreach (var item in Jobs)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine($"'{item.Value.ToString()}'");
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Inputs), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  inputs: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Inputs))
                {
                    if (Inputs.Any())
                    {
                        builder.Append("  inputs: ");
                        builder.AppendLine("{");
                        foreach (var item in Inputs)
                        {
                            builder.Append($"    '{item.Key}': ");
                            BicepSerializationHelpers.AppendChildObject(builder, item.Value, options, 4, false, "  inputs: ");
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Outputs), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  outputs: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Outputs))
                {
                    if (Outputs.Any())
                    {
                        builder.Append("  outputs: ");
                        builder.AppendLine("{");
                        foreach (var item in Outputs)
                        {
                            builder.Append($"    '{item.Key}': ");
                            BicepSerializationHelpers.AppendChildObject(builder, item.Value, options, 4, false, "  outputs: ");
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourceJobId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sourceJobId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SourceJobId))
                {
                    builder.Append("  sourceJobId: ");
                    builder.AppendLine($"'{SourceJobId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(JobType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  jobType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  jobType: ");
                builder.AppendLine($"'{JobType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  displayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DisplayName))
                {
                    builder.Append("  displayName: ");
                    if (DisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  status: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Status))
                {
                    builder.Append("  status: ");
                    builder.AppendLine($"'{Status.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExperimentName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  experimentName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExperimentName))
                {
                    builder.Append("  experimentName: ");
                    if (ExperimentName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ExperimentName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ExperimentName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Services), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  services: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Services))
                {
                    if (Services.Any())
                    {
                        builder.Append("  services: ");
                        builder.AppendLine("{");
                        foreach (var item in Services)
                        {
                            builder.Append($"    '{item.Key}': ");
                            BicepSerializationHelpers.AppendChildObject(builder, item.Value, options, 4, false, "  services: ");
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ComputeId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  computeId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ComputeId))
                {
                    builder.Append("  computeId: ");
                    builder.AppendLine($"'{ComputeId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsArchived), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isArchived: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsArchived))
                {
                    builder.Append("  isArchived: ");
                    var boolValue = IsArchived.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Identity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  identity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Identity))
                {
                    builder.Append("  identity: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Identity, options, 2, false, "  identity: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ComponentId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  componentId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ComponentId))
                {
                    builder.Append("  componentId: ");
                    builder.AppendLine($"'{ComponentId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NotificationSetting), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  notificationSetting: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NotificationSetting))
                {
                    builder.Append("  notificationSetting: ");
                    BicepSerializationHelpers.AppendChildObject(builder, NotificationSetting, options, 2, false, "  notificationSetting: ");
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

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningPipelineJob>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningPipelineJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningPipelineJob)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningPipelineJob IPersistableModel<MachineLearningPipelineJob>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningPipelineJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningPipelineJob(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningPipelineJob)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningPipelineJob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
