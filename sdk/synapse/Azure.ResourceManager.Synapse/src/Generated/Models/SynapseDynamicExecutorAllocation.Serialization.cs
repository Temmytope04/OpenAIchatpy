// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseDynamicExecutorAllocation : IUtf8JsonSerializable, IJsonModel<SynapseDynamicExecutorAllocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseDynamicExecutorAllocation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseDynamicExecutorAllocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseDynamicExecutorAllocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseDynamicExecutorAllocation)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(MinExecutors))
            {
                writer.WritePropertyName("minExecutors"u8);
                writer.WriteNumberValue(MinExecutors.Value);
            }
            if (Optional.IsDefined(MaxExecutors))
            {
                writer.WritePropertyName("maxExecutors"u8);
                writer.WriteNumberValue(MaxExecutors.Value);
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

        SynapseDynamicExecutorAllocation IJsonModel<SynapseDynamicExecutorAllocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseDynamicExecutorAllocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseDynamicExecutorAllocation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseDynamicExecutorAllocation(document.RootElement, options);
        }

        internal static SynapseDynamicExecutorAllocation DeserializeSynapseDynamicExecutorAllocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enabled = default;
            int? minExecutors = default;
            int? maxExecutors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("minExecutors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minExecutors = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxExecutors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxExecutors = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SynapseDynamicExecutorAllocation(enabled, minExecutors, maxExecutors, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseDynamicExecutorAllocation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseDynamicExecutorAllocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseDynamicExecutorAllocation)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseDynamicExecutorAllocation IPersistableModel<SynapseDynamicExecutorAllocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseDynamicExecutorAllocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseDynamicExecutorAllocation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseDynamicExecutorAllocation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseDynamicExecutorAllocation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
