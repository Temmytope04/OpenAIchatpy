// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    public partial class NotificationHubMpnsCredential : IUtf8JsonSerializable, IJsonModel<NotificationHubMpnsCredential>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NotificationHubMpnsCredential>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NotificationHubMpnsCredential>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubMpnsCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationHubMpnsCredential)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(MpnsCertificate))
            {
                writer.WritePropertyName("mpnsCertificate"u8);
                writer.WriteStringValue(MpnsCertificate);
            }
            if (Optional.IsDefined(CertificateKey))
            {
                writer.WritePropertyName("certificateKey"u8);
                writer.WriteStringValue(CertificateKey);
            }
            if (Optional.IsDefined(ThumbprintString))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(ThumbprintString);
            }
            writer.WriteEndObject();
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

        NotificationHubMpnsCredential IJsonModel<NotificationHubMpnsCredential>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubMpnsCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationHubMpnsCredential)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNotificationHubMpnsCredential(document.RootElement, options);
        }

        internal static NotificationHubMpnsCredential DeserializeNotificationHubMpnsCredential(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string mpnsCertificate = default;
            string certificateKey = default;
            string thumbprint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("mpnsCertificate"u8))
                        {
                            mpnsCertificate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("certificateKey"u8))
                        {
                            certificateKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("thumbprint"u8))
                        {
                            thumbprint = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NotificationHubMpnsCredential(mpnsCertificate, certificateKey, thumbprint, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NotificationHubMpnsCredential>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubMpnsCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NotificationHubMpnsCredential)} does not support '{options.Format}' format.");
            }
        }

        NotificationHubMpnsCredential IPersistableModel<NotificationHubMpnsCredential>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubMpnsCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNotificationHubMpnsCredential(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NotificationHubMpnsCredential)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NotificationHubMpnsCredential>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
