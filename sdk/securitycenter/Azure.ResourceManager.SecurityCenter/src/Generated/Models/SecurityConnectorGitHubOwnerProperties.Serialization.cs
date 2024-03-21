// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityConnectorGitHubOwnerProperties : IUtf8JsonSerializable, IJsonModel<SecurityConnectorGitHubOwnerProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityConnectorGitHubOwnerProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityConnectorGitHubOwnerProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorGitHubOwnerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityConnectorGitHubOwnerProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningStatusMessage))
            {
                writer.WritePropertyName("provisioningStatusMessage"u8);
                writer.WriteStringValue(ProvisioningStatusMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningStatusUpdateTimeUtc))
            {
                writer.WritePropertyName("provisioningStatusUpdateTimeUtc"u8);
                writer.WriteStringValue(ProvisioningStatusUpdateTimeUtc.Value, "O");
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(OwnerUri))
            {
                writer.WritePropertyName("ownerUrl"u8);
                writer.WriteStringValue(OwnerUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(GitHubInternalId))
            {
                writer.WritePropertyName("gitHubInternalId"u8);
                writer.WriteStringValue(GitHubInternalId);
            }
            if (Optional.IsDefined(OnboardingState))
            {
                writer.WritePropertyName("onboardingState"u8);
                writer.WriteStringValue(OnboardingState.Value.ToString());
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

        SecurityConnectorGitHubOwnerProperties IJsonModel<SecurityConnectorGitHubOwnerProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorGitHubOwnerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityConnectorGitHubOwnerProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityConnectorGitHubOwnerProperties(document.RootElement, options);
        }

        internal static SecurityConnectorGitHubOwnerProperties DeserializeSecurityConnectorGitHubOwnerProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string provisioningStatusMessage = default;
            DateTimeOffset? provisioningStatusUpdateTimeUtc = default;
            DevOpsProvisioningState? provisioningState = default;
            Uri ownerUrl = default;
            string gitHubInternalId = default;
            ResourceOnboardingState? onboardingState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningStatusMessage"u8))
                {
                    provisioningStatusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatusUpdateTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningStatusUpdateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DevOpsProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ownerUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ownerUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("gitHubInternalId"u8))
                {
                    gitHubInternalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("onboardingState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onboardingState = new ResourceOnboardingState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityConnectorGitHubOwnerProperties(
                provisioningStatusMessage,
                provisioningStatusUpdateTimeUtc,
                provisioningState,
                ownerUrl,
                gitHubInternalId,
                onboardingState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityConnectorGitHubOwnerProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorGitHubOwnerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityConnectorGitHubOwnerProperties)} does not support '{options.Format}' format.");
            }
        }

        SecurityConnectorGitHubOwnerProperties IPersistableModel<SecurityConnectorGitHubOwnerProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorGitHubOwnerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityConnectorGitHubOwnerProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityConnectorGitHubOwnerProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityConnectorGitHubOwnerProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
