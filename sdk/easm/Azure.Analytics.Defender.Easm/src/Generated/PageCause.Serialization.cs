// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Analytics.Defender.Easm
{
    public partial class PageCause : IUtf8JsonWriteable, IJsonModel<PageCause>
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<PageCause>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PageCause>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PageCause>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PageCause)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Cause))
            {
                writer.WritePropertyName("cause"u8);
                writer.WriteStringValue(Cause);
            }
            if (Optional.IsDefined(CauseElementXPath))
            {
                writer.WritePropertyName("causeElementXPath"u8);
                writer.WriteStringValue(CauseElementXPath);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location);
            }
            if (Optional.IsDefined(PossibleMatches))
            {
                writer.WritePropertyName("possibleMatches"u8);
                writer.WriteNumberValue(PossibleMatches.Value);
            }
            if (Optional.IsDefined(LoopDetected))
            {
                writer.WritePropertyName("loopDetected"u8);
                writer.WriteBooleanValue(LoopDetected.Value);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteNumberValue(Version.Value);
            }
            if (Optional.IsDefined(DomChangeIndex))
            {
                writer.WritePropertyName("domChangeIndex"u8);
                writer.WriteNumberValue(DomChangeIndex.Value);
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
            writer.WriteEndObject();
        }

        PageCause IJsonModel<PageCause>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PageCause>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PageCause)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePageCause(document.RootElement, options);
        }

        internal static PageCause DeserializePageCause(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string cause = default;
            string causeElementXPath = default;
            string location = default;
            int? possibleMatches = default;
            bool? loopDetected = default;
            int? version = default;
            int? domChangeIndex = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cause"u8))
                {
                    cause = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("causeElementXPath"u8))
                {
                    causeElementXPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("possibleMatches"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    possibleMatches = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("loopDetected"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loopDetected = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("domChangeIndex"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domChangeIndex = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PageCause(
                cause,
                causeElementXPath,
                location,
                possibleMatches,
                loopDetected,
                version,
                domChangeIndex,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PageCause>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PageCause>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PageCause)} does not support '{options.Format}' format.");
            }
        }

        PageCause IPersistableModel<PageCause>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PageCause>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePageCause(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PageCause)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PageCause>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static PageCause FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePageCause(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual RequestBody ToRequestBody()
        {
            var content = new Utf8JsonRequestBody();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
