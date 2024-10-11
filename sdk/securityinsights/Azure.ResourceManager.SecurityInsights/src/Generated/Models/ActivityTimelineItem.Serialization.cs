// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ActivityTimelineItem : IUtf8JsonSerializable, IJsonModel<ActivityTimelineItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ActivityTimelineItem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ActivityTimelineItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActivityTimelineItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ActivityTimelineItem)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("queryId"u8);
            writer.WriteStringValue(QueryId);
            writer.WritePropertyName("bucketStartTimeUTC"u8);
            writer.WriteStringValue(BucketStartOn, "O");
            writer.WritePropertyName("bucketEndTimeUTC"u8);
            writer.WriteStringValue(BucketEndOn, "O");
            writer.WritePropertyName("firstActivityTimeUTC"u8);
            writer.WriteStringValue(FirstActivityOn, "O");
            writer.WritePropertyName("lastActivityTimeUTC"u8);
            writer.WriteStringValue(LastActivityOn, "O");
            writer.WritePropertyName("content"u8);
            writer.WriteStringValue(Content);
            writer.WritePropertyName("title"u8);
            writer.WriteStringValue(Title);
        }

        ActivityTimelineItem IJsonModel<ActivityTimelineItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActivityTimelineItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ActivityTimelineItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeActivityTimelineItem(document.RootElement, options);
        }

        internal static ActivityTimelineItem DeserializeActivityTimelineItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string queryId = default;
            DateTimeOffset bucketStartTimeUTC = default;
            DateTimeOffset bucketEndTimeUTC = default;
            DateTimeOffset firstActivityTimeUTC = default;
            DateTimeOffset lastActivityTimeUTC = default;
            string content = default;
            string title = default;
            EntityTimelineKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryId"u8))
                {
                    queryId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bucketStartTimeUTC"u8))
                {
                    bucketStartTimeUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("bucketEndTimeUTC"u8))
                {
                    bucketEndTimeUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("firstActivityTimeUTC"u8))
                {
                    firstActivityTimeUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastActivityTimeUTC"u8))
                {
                    lastActivityTimeUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    content = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new EntityTimelineKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ActivityTimelineItem(
                kind,
                serializedAdditionalRawData,
                queryId,
                bucketStartTimeUTC,
                bucketEndTimeUTC,
                firstActivityTimeUTC,
                lastActivityTimeUTC,
                content,
                title);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueryId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  queryId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QueryId))
                {
                    builder.Append("  queryId: ");
                    if (QueryId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{QueryId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{QueryId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BucketStartOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  bucketStartTimeUTC: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  bucketStartTimeUTC: ");
                var formattedDateTimeString = TypeFormatters.ToString(BucketStartOn, "o");
                builder.AppendLine($"'{formattedDateTimeString}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BucketEndOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  bucketEndTimeUTC: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  bucketEndTimeUTC: ");
                var formattedDateTimeString = TypeFormatters.ToString(BucketEndOn, "o");
                builder.AppendLine($"'{formattedDateTimeString}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FirstActivityOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  firstActivityTimeUTC: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  firstActivityTimeUTC: ");
                var formattedDateTimeString = TypeFormatters.ToString(FirstActivityOn, "o");
                builder.AppendLine($"'{formattedDateTimeString}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastActivityOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastActivityTimeUTC: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  lastActivityTimeUTC: ");
                var formattedDateTimeString = TypeFormatters.ToString(LastActivityOn, "o");
                builder.AppendLine($"'{formattedDateTimeString}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Content), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  content: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Content))
                {
                    builder.Append("  content: ");
                    if (Content.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Content}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Content}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Title), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  title: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Title))
                {
                    builder.Append("  title: ");
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  kind: ");
                builder.AppendLine($"'{Kind.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ActivityTimelineItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActivityTimelineItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ActivityTimelineItem)} does not support writing '{options.Format}' format.");
            }
        }

        ActivityTimelineItem IPersistableModel<ActivityTimelineItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActivityTimelineItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeActivityTimelineItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ActivityTimelineItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ActivityTimelineItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
