// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsEntity : IUtf8JsonSerializable, IJsonModel<SecurityInsightsEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsEntity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsEntity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
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

        SecurityInsightsEntity IJsonModel<SecurityInsightsEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsEntity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsEntity(document.RootElement, options);
        }

        internal static SecurityInsightsEntity DeserializeSecurityInsightsEntity(JsonElement element, ModelReaderWriterOptions options = null)
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
                    case "Account": return SecurityInsightsAccountEntity.DeserializeSecurityInsightsAccountEntity(element, options);
                    case "AzureResource": return SecurityInsightsAzureResourceEntity.DeserializeSecurityInsightsAzureResourceEntity(element, options);
                    case "Bookmark": return SecurityInsightsHuntingBookmark.DeserializeSecurityInsightsHuntingBookmark(element, options);
                    case "CloudApplication": return SecurityInsightsCloudApplicationEntity.DeserializeSecurityInsightsCloudApplicationEntity(element, options);
                    case "DnsResolution": return SecurityInsightsDnsEntity.DeserializeSecurityInsightsDnsEntity(element, options);
                    case "File": return SecurityInsightsFileEntity.DeserializeSecurityInsightsFileEntity(element, options);
                    case "FileHash": return SecurityInsightsFileHashEntity.DeserializeSecurityInsightsFileHashEntity(element, options);
                    case "Host": return SecurityInsightsHostEntity.DeserializeSecurityInsightsHostEntity(element, options);
                    case "IoTDevice": return SecurityInsightsIotDeviceEntity.DeserializeSecurityInsightsIotDeviceEntity(element, options);
                    case "Ip": return SecurityInsightsIPEntity.DeserializeSecurityInsightsIPEntity(element, options);
                    case "Mailbox": return SecurityInsightsMailboxEntity.DeserializeSecurityInsightsMailboxEntity(element, options);
                    case "MailCluster": return SecurityInsightsMailClusterEntity.DeserializeSecurityInsightsMailClusterEntity(element, options);
                    case "MailMessage": return SecurityInsightsMailMessageEntity.DeserializeSecurityInsightsMailMessageEntity(element, options);
                    case "Malware": return SecurityInsightsMalwareEntity.DeserializeSecurityInsightsMalwareEntity(element, options);
                    case "Process": return SecurityInsightsProcessEntity.DeserializeSecurityInsightsProcessEntity(element, options);
                    case "RegistryKey": return SecurityInsightsRegistryKeyEntity.DeserializeSecurityInsightsRegistryKeyEntity(element, options);
                    case "RegistryValue": return SecurityInsightsRegistryValueEntity.DeserializeSecurityInsightsRegistryValueEntity(element, options);
                    case "SecurityAlert": return SecurityInsightsAlert.DeserializeSecurityInsightsAlert(element, options);
                    case "SecurityGroup": return SecurityInsightsGroupEntity.DeserializeSecurityInsightsGroupEntity(element, options);
                    case "SubmissionMail": return SecurityInsightsSubmissionMailEntity.DeserializeSecurityInsightsSubmissionMailEntity(element, options);
                    case "Url": return SecurityInsightsUriEntity.DeserializeSecurityInsightsUriEntity(element, options);
                }
            }
            return UnknownEntity.DeserializeUnknownEntity(element, options);
        }

        BinaryData IPersistableModel<SecurityInsightsEntity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsEntity)} does not support '{options.Format}' format.");
            }
        }

        SecurityInsightsEntity IPersistableModel<SecurityInsightsEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsEntity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsEntity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
