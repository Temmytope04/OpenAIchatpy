// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ManagedClusterClientCertificate : IUtf8JsonSerializable, IJsonModel<ManagedClusterClientCertificate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterClientCertificate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterClientCertificate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterClientCertificate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterClientCertificate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("isAdmin"u8);
            writer.WriteBooleanValue(IsAdmin);
            if (Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Thumbprint);
#else
                using (JsonDocument document = JsonDocument.Parse(Thumbprint))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(CommonName))
            {
                writer.WritePropertyName("commonName"u8);
                writer.WriteStringValue(CommonName);
            }
            if (Optional.IsDefined(IssuerThumbprint))
            {
                writer.WritePropertyName("issuerThumbprint"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(IssuerThumbprint);
#else
                using (JsonDocument document = JsonDocument.Parse(IssuerThumbprint))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        ManagedClusterClientCertificate IJsonModel<ManagedClusterClientCertificate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterClientCertificate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterClientCertificate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterClientCertificate(document.RootElement, options);
        }

        internal static ManagedClusterClientCertificate DeserializeManagedClusterClientCertificate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool isAdmin = default;
            BinaryData thumbprint = default;
            string commonName = default;
            BinaryData issuerThumbprint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isAdmin"u8))
                {
                    isAdmin = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    thumbprint = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("commonName"u8))
                {
                    commonName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuerThumbprint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    issuerThumbprint = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterClientCertificate(isAdmin, thumbprint, commonName, issuerThumbprint, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterClientCertificate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterClientCertificate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterClientCertificate)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterClientCertificate IPersistableModel<ManagedClusterClientCertificate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterClientCertificate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterClientCertificate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterClientCertificate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterClientCertificate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
