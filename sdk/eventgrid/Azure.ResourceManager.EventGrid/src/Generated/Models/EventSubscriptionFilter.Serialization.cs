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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class EventSubscriptionFilter : IUtf8JsonSerializable, IJsonModel<EventSubscriptionFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventSubscriptionFilter>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EventSubscriptionFilter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventSubscriptionFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventSubscriptionFilter)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(SubjectBeginsWith))
            {
                writer.WritePropertyName("subjectBeginsWith"u8);
                writer.WriteStringValue(SubjectBeginsWith);
            }
            if (Optional.IsDefined(SubjectEndsWith))
            {
                writer.WritePropertyName("subjectEndsWith"u8);
                writer.WriteStringValue(SubjectEndsWith);
            }
            if (Optional.IsCollectionDefined(IncludedEventTypes))
            {
                writer.WritePropertyName("includedEventTypes"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedEventTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsSubjectCaseSensitive))
            {
                writer.WritePropertyName("isSubjectCaseSensitive"u8);
                writer.WriteBooleanValue(IsSubjectCaseSensitive.Value);
            }
            if (Optional.IsDefined(IsAdvancedFilteringOnArraysEnabled))
            {
                writer.WritePropertyName("enableAdvancedFilteringOnArrays"u8);
                writer.WriteBooleanValue(IsAdvancedFilteringOnArraysEnabled.Value);
            }
            if (Optional.IsCollectionDefined(AdvancedFilters))
            {
                writer.WritePropertyName("advancedFilters"u8);
                writer.WriteStartArray();
                foreach (var item in AdvancedFilters)
                {
                    writer.WriteObjectValue(item, options);
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
        }

        EventSubscriptionFilter IJsonModel<EventSubscriptionFilter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventSubscriptionFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventSubscriptionFilter)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventSubscriptionFilter(document.RootElement, options);
        }

        internal static EventSubscriptionFilter DeserializeEventSubscriptionFilter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string subjectBeginsWith = default;
            string subjectEndsWith = default;
            IList<string> includedEventTypes = default;
            bool? isSubjectCaseSensitive = default;
            bool? enableAdvancedFilteringOnArrays = default;
            IList<AdvancedFilter> advancedFilters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subjectBeginsWith"u8))
                {
                    subjectBeginsWith = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subjectEndsWith"u8))
                {
                    subjectEndsWith = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("includedEventTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    includedEventTypes = array;
                    continue;
                }
                if (property.NameEquals("isSubjectCaseSensitive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSubjectCaseSensitive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableAdvancedFilteringOnArrays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAdvancedFilteringOnArrays = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("advancedFilters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AdvancedFilter> array = new List<AdvancedFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AdvancedFilter.DeserializeAdvancedFilter(item, options));
                    }
                    advancedFilters = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EventSubscriptionFilter(
                subjectBeginsWith,
                subjectEndsWith,
                includedEventTypes ?? new ChangeTrackingList<string>(),
                isSubjectCaseSensitive,
                enableAdvancedFilteringOnArrays,
                advancedFilters ?? new ChangeTrackingList<AdvancedFilter>(),
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SubjectBeginsWith), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  subjectBeginsWith: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SubjectBeginsWith))
                {
                    builder.Append("  subjectBeginsWith: ");
                    if (SubjectBeginsWith.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SubjectBeginsWith}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SubjectBeginsWith}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SubjectEndsWith), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  subjectEndsWith: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SubjectEndsWith))
                {
                    builder.Append("  subjectEndsWith: ");
                    if (SubjectEndsWith.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SubjectEndsWith}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SubjectEndsWith}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IncludedEventTypes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  includedEventTypes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(IncludedEventTypes))
                {
                    if (IncludedEventTypes.Any())
                    {
                        builder.Append("  includedEventTypes: ");
                        builder.AppendLine("[");
                        foreach (var item in IncludedEventTypes)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsSubjectCaseSensitive), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isSubjectCaseSensitive: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsSubjectCaseSensitive))
                {
                    builder.Append("  isSubjectCaseSensitive: ");
                    var boolValue = IsSubjectCaseSensitive.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsAdvancedFilteringOnArraysEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enableAdvancedFilteringOnArrays: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsAdvancedFilteringOnArraysEnabled))
                {
                    builder.Append("  enableAdvancedFilteringOnArrays: ");
                    var boolValue = IsAdvancedFilteringOnArraysEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AdvancedFilters), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  advancedFilters: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AdvancedFilters))
                {
                    if (AdvancedFilters.Any())
                    {
                        builder.Append("  advancedFilters: ");
                        builder.AppendLine("[");
                        foreach (var item in AdvancedFilters)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  advancedFilters: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<EventSubscriptionFilter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventSubscriptionFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(EventSubscriptionFilter)} does not support writing '{options.Format}' format.");
            }
        }

        EventSubscriptionFilter IPersistableModel<EventSubscriptionFilter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventSubscriptionFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventSubscriptionFilter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventSubscriptionFilter)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventSubscriptionFilter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
