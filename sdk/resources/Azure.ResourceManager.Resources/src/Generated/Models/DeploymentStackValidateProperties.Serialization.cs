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

namespace Azure.ResourceManager.Resources.Models
{
    public partial class DeploymentStackValidateProperties : IUtf8JsonSerializable, IJsonModel<DeploymentStackValidateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeploymentStackValidateProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeploymentStackValidateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentStackValidateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentStackValidateProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ActionOnUnmanage))
            {
                writer.WritePropertyName("actionOnUnmanage"u8);
                writer.WriteObjectValue(ActionOnUnmanage, options);
            }
            if (Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId);
            }
            if (Optional.IsDefined(DenySettings))
            {
                writer.WritePropertyName("denySettings"u8);
                writer.WriteObjectValue(DenySettings, options);
            }
            if (Optional.IsDefined(DeploymentScope))
            {
                writer.WritePropertyName("deploymentScope"u8);
                writer.WriteStringValue(DeploymentScope);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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
            if (Optional.IsDefined(TemplateLink))
            {
                writer.WritePropertyName("templateLink"u8);
                writer.WriteObjectValue(TemplateLink, options);
            }
            if (Optional.IsCollectionDefined(ValidatedResources))
            {
                writer.WritePropertyName("validatedResources"u8);
                writer.WriteStartArray();
                foreach (var item in ValidatedResources)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
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

        DeploymentStackValidateProperties IJsonModel<DeploymentStackValidateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentStackValidateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentStackValidateProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeploymentStackValidateProperties(document.RootElement, options);
        }

        internal static DeploymentStackValidateProperties DeserializeDeploymentStackValidateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ActionOnUnmanage actionOnUnmanage = default;
            string correlationId = default;
            DenySettings denySettings = default;
            string deploymentScope = default;
            string description = default;
            IDictionary<string, DeploymentParameter> parameters = default;
            DeploymentStacksTemplateLink templateLink = default;
            IList<SubResource> validatedResources = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionOnUnmanage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionOnUnmanage = ActionOnUnmanage.DeserializeActionOnUnmanage(property.Value, options);
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("denySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    denySettings = DenySettings.DeserializeDenySettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("deploymentScope"u8))
                {
                    deploymentScope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, DeploymentParameter> dictionary = new Dictionary<string, DeploymentParameter>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DeploymentParameter.DeserializeDeploymentParameter(property0.Value, options));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("templateLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateLink = DeploymentStacksTemplateLink.DeserializeDeploymentStacksTemplateLink(property.Value, options);
                    continue;
                }
                if (property.NameEquals("validatedResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SubResource> array = new List<SubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<SubResource>(item.GetRawText()));
                    }
                    validatedResources = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DeploymentStackValidateProperties(
                actionOnUnmanage,
                correlationId,
                denySettings,
                deploymentScope,
                description,
                parameters ?? new ChangeTrackingDictionary<string, DeploymentParameter>(),
                templateLink,
                validatedResources ?? new ChangeTrackingList<SubResource>(),
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ActionOnUnmanage), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  actionOnUnmanage: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ActionOnUnmanage))
                {
                    builder.Append("  actionOnUnmanage: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ActionOnUnmanage, options, 2, false, "  actionOnUnmanage: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CorrelationId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  correlationId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CorrelationId))
                {
                    builder.Append("  correlationId: ");
                    if (CorrelationId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CorrelationId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CorrelationId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DenySettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  denySettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DenySettings))
                {
                    builder.Append("  denySettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DenySettings, options, 2, false, "  denySettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeploymentScope), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  deploymentScope: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeploymentScope))
                {
                    builder.Append("  deploymentScope: ");
                    if (DeploymentScope.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DeploymentScope}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DeploymentScope}'");
                    }
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Parameters), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  parameters: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Parameters))
                {
                    if (Parameters.Any())
                    {
                        builder.Append("  parameters: ");
                        builder.AppendLine("{");
                        foreach (var item in Parameters)
                        {
                            builder.Append($"    '{item.Key}': ");
                            BicepSerializationHelpers.AppendChildObject(builder, item.Value, options, 4, false, "  parameters: ");
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TemplateLink), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  templateLink: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TemplateLink))
                {
                    builder.Append("  templateLink: ");
                    BicepSerializationHelpers.AppendChildObject(builder, TemplateLink, options, 2, false, "  templateLink: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ValidatedResources), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  validatedResources: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ValidatedResources))
                {
                    if (ValidatedResources.Any())
                    {
                        builder.Append("  validatedResources: ");
                        builder.AppendLine("[");
                        foreach (var item in ValidatedResources)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  validatedResources: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DeploymentStackValidateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentStackValidateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DeploymentStackValidateProperties)} does not support writing '{options.Format}' format.");
            }
        }

        DeploymentStackValidateProperties IPersistableModel<DeploymentStackValidateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentStackValidateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeploymentStackValidateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeploymentStackValidateProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeploymentStackValidateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
