// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicWorkflowRunTrigger : IUtf8JsonSerializable, IJsonModel<LogicWorkflowRunTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicWorkflowRunTrigger>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<LogicWorkflowRunTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Name))
                {
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(Name);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Inputs))
                {
                    writer.WritePropertyName("inputs"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Inputs);
#else
                    using (JsonDocument document = JsonDocument.Parse(Inputs))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(InputsLink))
                {
                    writer.WritePropertyName("inputsLink"u8);
                    writer.WriteObjectValue(InputsLink);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Outputs))
                {
                    writer.WritePropertyName("outputs"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Outputs);
#else
                    using (JsonDocument document = JsonDocument.Parse(Outputs))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(OutputsLink))
                {
                    writer.WritePropertyName("outputsLink"u8);
                    writer.WriteObjectValue(OutputsLink);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ScheduledOn))
                {
                    writer.WritePropertyName("scheduledTime"u8);
                    writer.WriteStringValue(ScheduledOn.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(StartOn))
                {
                    writer.WritePropertyName("startTime"u8);
                    writer.WriteStringValue(StartOn.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(EndOn))
                {
                    writer.WritePropertyName("endTime"u8);
                    writer.WriteStringValue(EndOn.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(TrackingId))
                {
                    writer.WritePropertyName("trackingId"u8);
                    writer.WriteStringValue(TrackingId.Value);
                }
            }
            if (Optional.IsDefined(Correlation))
            {
                writer.WritePropertyName("correlation"u8);
                writer.WriteObjectValue(Correlation);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Code))
                {
                    writer.WritePropertyName("code"u8);
                    writer.WriteStringValue(Code);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Status))
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(Status.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Error))
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
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(TrackedProperties))
                {
                    writer.WritePropertyName("trackedProperties"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TrackedProperties);
#else
                    using (JsonDocument document = JsonDocument.Parse(TrackedProperties))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        LogicWorkflowRunTrigger IJsonModel<LogicWorkflowRunTrigger>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LogicWorkflowRunTrigger)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicWorkflowRunTrigger(document.RootElement, options);
        }

        internal static LogicWorkflowRunTrigger DeserializeLogicWorkflowRunTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<BinaryData> inputs = default;
            Optional<LogicContentLink> inputsLink = default;
            Optional<BinaryData> outputs = default;
            Optional<LogicContentLink> outputsLink = default;
            Optional<DateTimeOffset> scheduledTime = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<Guid> trackingId = default;
            Optional<Correlation> correlation = default;
            Optional<string> code = default;
            Optional<LogicWorkflowStatus> status = default;
            Optional<BinaryData> error = default;
            Optional<BinaryData> trackedProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inputs = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("inputsLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inputsLink = LogicContentLink.DeserializeLogicContentLink(property.Value);
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputs = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("outputsLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputsLink = LogicContentLink.DeserializeLogicContentLink(property.Value);
                    continue;
                }
                if (property.NameEquals("scheduledTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("trackingId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trackingId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("correlation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    correlation = Correlation.DeserializeCorrelation(property.Value);
                    continue;
                }
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new LogicWorkflowStatus(property.Value.GetString());
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
                if (property.NameEquals("trackedProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trackedProperties = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicWorkflowRunTrigger(name.Value, inputs.Value, inputsLink.Value, outputs.Value, outputsLink.Value, Optional.ToNullable(scheduledTime), Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(trackingId), correlation.Value, code.Value, Optional.ToNullable(status), error.Value, trackedProperties.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<LogicWorkflowRunTrigger>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LogicWorkflowRunTrigger)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        LogicWorkflowRunTrigger IModel<LogicWorkflowRunTrigger>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LogicWorkflowRunTrigger)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeLogicWorkflowRunTrigger(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<LogicWorkflowRunTrigger>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
