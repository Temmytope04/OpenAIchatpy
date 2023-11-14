// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningServicePrincipalDatastoreCredentials : IUtf8JsonSerializable, IJsonModel<MachineLearningServicePrincipalDatastoreCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningServicePrincipalDatastoreCredentials>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MachineLearningServicePrincipalDatastoreCredentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MachineLearningServicePrincipalDatastoreCredentials>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AuthorityUri))
            {
                if (AuthorityUri != null)
                {
                    writer.WritePropertyName("authorityUrl"u8);
                    writer.WriteStringValue(AuthorityUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("authorityUrl");
                }
            }
            writer.WritePropertyName("clientId"u8);
            writer.WriteStringValue(ClientId);
            if (Optional.IsDefined(ResourceUri))
            {
                if (ResourceUri != null)
                {
                    writer.WritePropertyName("resourceUrl"u8);
                    writer.WriteStringValue(ResourceUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("resourceUrl");
                }
            }
            writer.WritePropertyName("secrets"u8);
            writer.WriteObjectValue(Secrets);
            writer.WritePropertyName("tenantId"u8);
            writer.WriteStringValue(TenantId);
            writer.WritePropertyName("credentialsType"u8);
            writer.WriteStringValue(CredentialsType.ToString());
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        MachineLearningServicePrincipalDatastoreCredentials IJsonModel<MachineLearningServicePrincipalDatastoreCredentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningServicePrincipalDatastoreCredentials)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningServicePrincipalDatastoreCredentials(document.RootElement, options);
        }

        internal static MachineLearningServicePrincipalDatastoreCredentials DeserializeMachineLearningServicePrincipalDatastoreCredentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> authorityUrl = default;
            Guid clientId = default;
            Optional<Uri> resourceUrl = default;
            MachineLearningServicePrincipalDatastoreSecrets secrets = default;
            Guid tenantId = default;
            CredentialsType credentialsType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorityUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        authorityUrl = null;
                        continue;
                    }
                    authorityUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("resourceUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceUrl = null;
                        continue;
                    }
                    resourceUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secrets"u8))
                {
                    secrets = MachineLearningServicePrincipalDatastoreSecrets.DeserializeMachineLearningServicePrincipalDatastoreSecrets(property.Value);
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("credentialsType"u8))
                {
                    credentialsType = new CredentialsType(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningServicePrincipalDatastoreCredentials(credentialsType, serializedAdditionalRawData, authorityUrl.Value, clientId, resourceUrl.Value, secrets, tenantId);
        }

        BinaryData IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningServicePrincipalDatastoreCredentials)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MachineLearningServicePrincipalDatastoreCredentials IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningServicePrincipalDatastoreCredentials)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMachineLearningServicePrincipalDatastoreCredentials(document.RootElement, options);
        }

        string IPersistableModel<MachineLearningServicePrincipalDatastoreCredentials>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
