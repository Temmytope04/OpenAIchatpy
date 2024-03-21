// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    [PersistableModelProxy(typeof(UnknownDistributionMode))]
    public partial class DistributionMode : IUtf8JsonSerializable, IJsonModel<DistributionMode>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DistributionMode>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DistributionMode>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DistributionMode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DistributionMode)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("minConcurrentOffers"u8);
            writer.WriteNumberValue(MinConcurrentOffers);
            writer.WritePropertyName("maxConcurrentOffers"u8);
            writer.WriteNumberValue(MaxConcurrentOffers);
            if (Optional.IsDefined(BypassSelectors))
            {
                writer.WritePropertyName("bypassSelectors"u8);
                writer.WriteBooleanValue(BypassSelectors.Value);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        DistributionMode IJsonModel<DistributionMode>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DistributionMode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DistributionMode)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDistributionMode(document.RootElement, options);
        }

        internal static DistributionMode DeserializeDistributionMode(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "bestWorker": return BestWorkerMode.DeserializeBestWorkerMode(element, options);
                    case "longestIdle": return LongestIdleMode.DeserializeLongestIdleMode(element, options);
                    case "roundRobin": return RoundRobinMode.DeserializeRoundRobinMode(element, options);
                }
            }
            return UnknownDistributionMode.DeserializeUnknownDistributionMode(element, options);
        }

        BinaryData IPersistableModel<DistributionMode>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DistributionMode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DistributionMode)} does not support '{options.Format}' format.");
            }
        }

        DistributionMode IPersistableModel<DistributionMode>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DistributionMode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDistributionMode(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DistributionMode)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DistributionMode>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DistributionMode FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDistributionMode(document.RootElement);
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
