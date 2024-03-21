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
    public partial class PipelineActivityRunInformation : IUtf8JsonSerializable, IJsonModel<PipelineActivityRunInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PipelineActivityRunInformation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PipelineActivityRunInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineActivityRunInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PipelineActivityRunInformation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PipelineName))
            {
                writer.WritePropertyName("pipelineName"u8);
                writer.WriteStringValue(PipelineName);
            }
            if (options.Format != "W" && Optional.IsDefined(PipelineRunId))
            {
                writer.WritePropertyName("pipelineRunId"u8);
                writer.WriteStringValue(PipelineRunId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ActivityName))
            {
                writer.WritePropertyName("activityName"u8);
                writer.WriteStringValue(ActivityName);
            }
            if (options.Format != "W" && Optional.IsDefined(ActivityType))
            {
                writer.WritePropertyName("activityType"u8);
                writer.WriteStringValue(ActivityType);
            }
            if (options.Format != "W" && Optional.IsDefined(ActivityRunId))
            {
                writer.WritePropertyName("activityRunId"u8);
                writer.WriteStringValue(ActivityRunId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LinkedServiceName))
            {
                writer.WritePropertyName("linkedServiceName"u8);
                writer.WriteStringValue(LinkedServiceName);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("activityRunStart"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("activityRunEnd"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(DurationInMs))
            {
                writer.WritePropertyName("durationInMs"u8);
                writer.WriteNumberValue(DurationInMs.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Input))
            {
                writer.WritePropertyName("input"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Input);
#else
                using (JsonDocument document = JsonDocument.Parse(Input))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && Optional.IsDefined(Output))
            {
                writer.WritePropertyName("output"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Output);
#else
                using (JsonDocument document = JsonDocument.Parse(Output))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Error);
#else
                using (JsonDocument document = JsonDocument.Parse(Error))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
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

        PipelineActivityRunInformation IJsonModel<PipelineActivityRunInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineActivityRunInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PipelineActivityRunInformation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePipelineActivityRunInformation(document.RootElement, options);
        }

        internal static PipelineActivityRunInformation DeserializePipelineActivityRunInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string pipelineName = default;
            Guid? pipelineRunId = default;
            string activityName = default;
            string activityType = default;
            Guid? activityRunId = default;
            string linkedServiceName = default;
            string status = default;
            DateTimeOffset? activityRunStart = default;
            DateTimeOffset? activityRunEnd = default;
            int? durationInMs = default;
            BinaryData input = default;
            BinaryData output = default;
            BinaryData error = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipelineName"u8))
                {
                    pipelineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pipelineRunId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pipelineRunId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("activityName"u8))
                {
                    activityName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activityType"u8))
                {
                    activityType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activityRunId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activityRunId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("linkedServiceName"u8))
                {
                    linkedServiceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activityRunStart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activityRunStart = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("activityRunEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activityRunEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("durationInMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durationInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("input"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    input = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    output = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new PipelineActivityRunInformation(
                pipelineName,
                pipelineRunId,
                activityName,
                activityType,
                activityRunId,
                linkedServiceName,
                status,
                activityRunStart,
                activityRunEnd,
                durationInMs,
                input,
                output,
                error,
                additionalProperties);
        }

        BinaryData IPersistableModel<PipelineActivityRunInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineActivityRunInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PipelineActivityRunInformation)} does not support '{options.Format}' format.");
            }
        }

        PipelineActivityRunInformation IPersistableModel<PipelineActivityRunInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineActivityRunInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePipelineActivityRunInformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PipelineActivityRunInformation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PipelineActivityRunInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
