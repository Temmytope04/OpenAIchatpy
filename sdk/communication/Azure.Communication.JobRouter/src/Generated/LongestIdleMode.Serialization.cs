// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class LongestIdleMode : IUtf8JsonSerializable, IJsonModel<LongestIdleMode>
    {
        void IJsonModel<LongestIdleMode>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LongestIdleMode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(LongestIdleMode)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MinConcurrentOffers))
            {
                writer.WritePropertyName("minConcurrentOffers"u8);
                writer.WriteNumberValue(MinConcurrentOffers);
            }
            if (Optional.IsDefined(MaxConcurrentOffers))
            {
                writer.WritePropertyName("maxConcurrentOffers"u8);
                writer.WriteNumberValue(MaxConcurrentOffers);
            }
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

        LongestIdleMode IJsonModel<LongestIdleMode>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LongestIdleMode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(LongestIdleMode)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLongestIdleMode(document.RootElement, options);
        }

        internal static LongestIdleMode DeserializeLongestIdleMode(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> minConcurrentOffers = default;
            Optional<int> maxConcurrentOffers = default;
            Optional<bool> bypassSelectors = default;
            DistributionModeKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minConcurrentOffers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minConcurrentOffers = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxConcurrentOffers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentOffers = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bypassSelectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bypassSelectors = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new DistributionModeKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LongestIdleMode(minConcurrentOffers, maxConcurrentOffers, Optional.ToNullable(bypassSelectors), kind, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LongestIdleMode>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LongestIdleMode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(LongestIdleMode)} does not support '{options.Format}' format.");
            }
        }

        LongestIdleMode IPersistableModel<LongestIdleMode>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LongestIdleMode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLongestIdleMode(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(LongestIdleMode)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LongestIdleMode>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new LongestIdleMode FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLongestIdleMode(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
