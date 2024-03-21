// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class RouterWorkerAssignment : IUtf8JsonSerializable, IJsonModel<RouterWorkerAssignment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RouterWorkerAssignment>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RouterWorkerAssignment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterWorkerAssignment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RouterWorkerAssignment)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("assignmentId"u8);
            writer.WriteStringValue(AssignmentId);
            writer.WritePropertyName("jobId"u8);
            writer.WriteStringValue(JobId);
            writer.WritePropertyName("capacityCost"u8);
            writer.WriteNumberValue(CapacityCost);
            writer.WritePropertyName("assignedAt"u8);
            writer.WriteStringValue(AssignedAt, "O");
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

        RouterWorkerAssignment IJsonModel<RouterWorkerAssignment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterWorkerAssignment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RouterWorkerAssignment)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRouterWorkerAssignment(document.RootElement, options);
        }

        internal static RouterWorkerAssignment DeserializeRouterWorkerAssignment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string assignmentId = default;
            string jobId = default;
            int capacityCost = default;
            DateTimeOffset assignedAt = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assignmentId"u8))
                {
                    assignmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacityCost"u8))
                {
                    capacityCost = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("assignedAt"u8))
                {
                    assignedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RouterWorkerAssignment(assignmentId, jobId, capacityCost, assignedAt, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RouterWorkerAssignment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterWorkerAssignment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RouterWorkerAssignment)} does not support '{options.Format}' format.");
            }
        }

        RouterWorkerAssignment IPersistableModel<RouterWorkerAssignment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterWorkerAssignment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRouterWorkerAssignment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RouterWorkerAssignment)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RouterWorkerAssignment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RouterWorkerAssignment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRouterWorkerAssignment(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
