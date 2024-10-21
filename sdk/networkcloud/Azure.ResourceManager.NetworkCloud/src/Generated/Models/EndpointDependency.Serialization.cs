// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class EndpointDependency : IUtf8JsonSerializable, IJsonModel<EndpointDependency>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EndpointDependency>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EndpointDependency>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointDependency>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EndpointDependency)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("domainName"u8);
            writer.WriteStringValue(DomainName);
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
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

        EndpointDependency IJsonModel<EndpointDependency>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointDependency>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EndpointDependency)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEndpointDependency(document.RootElement, options);
        }

        internal static EndpointDependency DeserializeEndpointDependency(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domainName = default;
            long? port = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    port = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EndpointDependency(domainName, port, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EndpointDependency>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointDependency>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EndpointDependency)} does not support writing '{options.Format}' format.");
            }
        }

        EndpointDependency IPersistableModel<EndpointDependency>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointDependency>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEndpointDependency(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EndpointDependency)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EndpointDependency>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
