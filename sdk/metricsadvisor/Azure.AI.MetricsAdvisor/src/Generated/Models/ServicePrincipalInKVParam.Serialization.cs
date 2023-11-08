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

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class ServicePrincipalInKVParam : IUtf8JsonSerializable, IJsonModel<ServicePrincipalInKVParam>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServicePrincipalInKVParam>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ServicePrincipalInKVParam>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyVaultEndpoint"u8);
            writer.WriteStringValue(KeyVaultEndpoint);
            writer.WritePropertyName("keyVaultClientId"u8);
            writer.WriteStringValue(KeyVaultClientId);
            if (Optional.IsDefined(KeyVaultClientSecret))
            {
                writer.WritePropertyName("keyVaultClientSecret"u8);
                writer.WriteStringValue(KeyVaultClientSecret);
            }
            writer.WritePropertyName("servicePrincipalIdNameInKV"u8);
            writer.WriteStringValue(ServicePrincipalIdNameInKV);
            writer.WritePropertyName("servicePrincipalSecretNameInKV"u8);
            writer.WriteStringValue(ServicePrincipalSecretNameInKV);
            writer.WritePropertyName("tenantId"u8);
            writer.WriteStringValue(TenantId);
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        ServicePrincipalInKVParam IJsonModel<ServicePrincipalInKVParam>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServicePrincipalInKVParam)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServicePrincipalInKVParam(document.RootElement, options);
        }

        internal static ServicePrincipalInKVParam DeserializeServicePrincipalInKVParam(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyVaultEndpoint = default;
            string keyVaultClientId = default;
            Optional<string> keyVaultClientSecret = default;
            string servicePrincipalIdNameInKV = default;
            string servicePrincipalSecretNameInKV = default;
            string tenantId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultEndpoint"u8))
                {
                    keyVaultEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultClientId"u8))
                {
                    keyVaultClientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultClientSecret"u8))
                {
                    keyVaultClientSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("servicePrincipalIdNameInKV"u8))
                {
                    servicePrincipalIdNameInKV = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("servicePrincipalSecretNameInKV"u8))
                {
                    servicePrincipalSecretNameInKV = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    tenantId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServicePrincipalInKVParam(keyVaultEndpoint, keyVaultClientId, keyVaultClientSecret.Value, servicePrincipalIdNameInKV, servicePrincipalSecretNameInKV, tenantId, serializedAdditionalRawData);
        }

        BinaryData IModel<ServicePrincipalInKVParam>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServicePrincipalInKVParam)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ServicePrincipalInKVParam IModel<ServicePrincipalInKVParam>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServicePrincipalInKVParam)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeServicePrincipalInKVParam(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ServicePrincipalInKVParam>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
