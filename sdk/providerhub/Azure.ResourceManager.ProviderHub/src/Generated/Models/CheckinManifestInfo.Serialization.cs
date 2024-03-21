// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class CheckinManifestInfo : IUtf8JsonSerializable, IJsonModel<CheckinManifestInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CheckinManifestInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CheckinManifestInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckinManifestInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CheckinManifestInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("isCheckedIn"u8);
            writer.WriteBooleanValue(IsCheckedIn);
            writer.WritePropertyName("statusMessage"u8);
            writer.WriteStringValue(StatusMessage);
            if (Optional.IsDefined(PullRequest))
            {
                writer.WritePropertyName("pullRequest"u8);
                writer.WriteStringValue(PullRequest);
            }
            if (Optional.IsDefined(CommitId))
            {
                writer.WritePropertyName("commitId"u8);
                writer.WriteStringValue(CommitId);
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

        CheckinManifestInfo IJsonModel<CheckinManifestInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckinManifestInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CheckinManifestInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCheckinManifestInfo(document.RootElement, options);
        }

        internal static CheckinManifestInfo DeserializeCheckinManifestInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool isCheckedIn = default;
            string statusMessage = default;
            string pullRequest = default;
            string commitId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isCheckedIn"u8))
                {
                    isCheckedIn = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("statusMessage"u8))
                {
                    statusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pullRequest"u8))
                {
                    pullRequest = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("commitId"u8))
                {
                    commitId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CheckinManifestInfo(isCheckedIn, statusMessage, pullRequest, commitId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CheckinManifestInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckinManifestInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CheckinManifestInfo)} does not support '{options.Format}' format.");
            }
        }

        CheckinManifestInfo IPersistableModel<CheckinManifestInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckinManifestInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCheckinManifestInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CheckinManifestInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CheckinManifestInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
