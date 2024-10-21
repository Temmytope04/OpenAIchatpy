// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    [PersistableModelProxy(typeof(UnknownPartitionSchemeDescription))]
    public partial class PartitionSchemeDescription : IUtf8JsonSerializable, IJsonModel<PartitionSchemeDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PartitionSchemeDescription>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PartitionSchemeDescription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartitionSchemeDescription)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("partitionScheme"u8);
            writer.WriteStringValue(PartitionScheme.ToString());
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

        PartitionSchemeDescription IJsonModel<PartitionSchemeDescription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartitionSchemeDescription)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePartitionSchemeDescription(document.RootElement, options);
        }

        internal static PartitionSchemeDescription DeserializePartitionSchemeDescription(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("partitionScheme", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Named": return NamedPartitionSchemeDescription.DeserializeNamedPartitionSchemeDescription(element, options);
                    case "Singleton": return SingletonPartitionSchemeDescription.DeserializeSingletonPartitionSchemeDescription(element, options);
                    case "UniformInt64Range": return UniformInt64RangePartitionSchemeDescription.DeserializeUniformInt64RangePartitionSchemeDescription(element, options);
                }
            }
            return UnknownPartitionSchemeDescription.DeserializeUnknownPartitionSchemeDescription(element, options);
        }

        BinaryData IPersistableModel<PartitionSchemeDescription>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PartitionSchemeDescription)} does not support writing '{options.Format}' format.");
            }
        }

        PartitionSchemeDescription IPersistableModel<PartitionSchemeDescription>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePartitionSchemeDescription(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PartitionSchemeDescription)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PartitionSchemeDescription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
