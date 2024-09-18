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

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class ApplicationInsightsComponentFeature : IUtf8JsonSerializable, IJsonModel<ApplicationInsightsComponentFeature>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationInsightsComponentFeature>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApplicationInsightsComponentFeature>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentFeature>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentFeature)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(FeatureName))
            {
                writer.WritePropertyName("FeatureName"u8);
                writer.WriteStringValue(FeatureName);
            }
            if (options.Format != "W" && Optional.IsDefined(MeterId))
            {
                writer.WritePropertyName("MeterId"u8);
                writer.WriteStringValue(MeterId);
            }
            if (options.Format != "W" && Optional.IsDefined(MeterRateFrequency))
            {
                writer.WritePropertyName("MeterRateFrequency"u8);
                writer.WriteStringValue(MeterRateFrequency);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("ResouceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(IsHidden))
            {
                writer.WritePropertyName("IsHidden"u8);
                writer.WriteBooleanValue(IsHidden.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("Capabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Title))
            {
                writer.WritePropertyName("Title"u8);
                writer.WriteStringValue(Title);
            }
            if (options.Format != "W" && Optional.IsDefined(IsMainFeature))
            {
                writer.WritePropertyName("IsMainFeature"u8);
                writer.WriteBooleanValue(IsMainFeature.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SupportedAddonFeatures))
            {
                writer.WritePropertyName("SupportedAddonFeatures"u8);
                writer.WriteStringValue(SupportedAddonFeatures);
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
        }

        ApplicationInsightsComponentFeature IJsonModel<ApplicationInsightsComponentFeature>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentFeature>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentFeature)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationInsightsComponentFeature(document.RootElement, options);
        }

        internal static ApplicationInsightsComponentFeature DeserializeApplicationInsightsComponentFeature(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string featureName = default;
            string meterId = default;
            string meterRateFrequency = default;
            ResourceIdentifier resouceId = default;
            bool? isHidden = default;
            IReadOnlyList<ApplicationInsightsComponentFeatureCapability> capabilities = default;
            string title = default;
            bool? isMainFeature = default;
            string supportedAddonFeatures = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("FeatureName"u8))
                {
                    featureName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("MeterId"u8))
                {
                    meterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("MeterRateFrequency"u8))
                {
                    meterRateFrequency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ResouceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resouceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("IsHidden"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isHidden = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("Capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationInsightsComponentFeatureCapability> array = new List<ApplicationInsightsComponentFeatureCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationInsightsComponentFeatureCapability.DeserializeApplicationInsightsComponentFeatureCapability(item, options));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("Title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("IsMainFeature"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isMainFeature = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("SupportedAddonFeatures"u8))
                {
                    supportedAddonFeatures = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApplicationInsightsComponentFeature(
                featureName,
                meterId,
                meterRateFrequency,
                resouceId,
                isHidden,
                capabilities ?? new ChangeTrackingList<ApplicationInsightsComponentFeatureCapability>(),
                title,
                isMainFeature,
                supportedAddonFeatures,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FeatureName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  FeatureName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FeatureName))
                {
                    builder.Append("  FeatureName: ");
                    if (FeatureName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{FeatureName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{FeatureName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MeterId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  MeterId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MeterId))
                {
                    builder.Append("  MeterId: ");
                    if (MeterId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{MeterId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{MeterId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MeterRateFrequency), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  MeterRateFrequency: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MeterRateFrequency))
                {
                    builder.Append("  MeterRateFrequency: ");
                    if (MeterRateFrequency.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{MeterRateFrequency}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{MeterRateFrequency}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResourceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ResouceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ResourceId))
                {
                    builder.Append("  ResouceId: ");
                    builder.AppendLine($"'{ResourceId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsHidden), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  IsHidden: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsHidden))
                {
                    builder.Append("  IsHidden: ");
                    var boolValue = IsHidden.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Capabilities), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  Capabilities: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Capabilities))
                {
                    if (Capabilities.Any())
                    {
                        builder.Append("  Capabilities: ");
                        builder.AppendLine("[");
                        foreach (var item in Capabilities)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  Capabilities: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Title), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  Title: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Title))
                {
                    builder.Append("  Title: ");
                    if (Title.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Title}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Title}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsMainFeature), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  IsMainFeature: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsMainFeature))
                {
                    builder.Append("  IsMainFeature: ");
                    var boolValue = IsMainFeature.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportedAddonFeatures), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  SupportedAddonFeatures: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SupportedAddonFeatures))
                {
                    builder.Append("  SupportedAddonFeatures: ");
                    if (SupportedAddonFeatures.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SupportedAddonFeatures}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SupportedAddonFeatures}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ApplicationInsightsComponentFeature>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentFeature>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentFeature)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationInsightsComponentFeature IPersistableModel<ApplicationInsightsComponentFeature>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentFeature>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationInsightsComponentFeature(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentFeature)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationInsightsComponentFeature>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
