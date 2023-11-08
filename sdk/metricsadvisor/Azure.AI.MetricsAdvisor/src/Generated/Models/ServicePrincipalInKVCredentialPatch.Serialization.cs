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
    internal partial class ServicePrincipalInKVCredentialPatch : IUtf8JsonSerializable, IJsonModel<ServicePrincipalInKVCredentialPatch>
    {
        void IJsonModel<ServicePrincipalInKVCredentialPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteObjectValue(Parameters);
            }
            writer.WritePropertyName("dataSourceCredentialType"u8);
            writer.WriteStringValue(DataSourceCredentialType.ToString());
            if (Optional.IsDefined(DataSourceCredentialName))
            {
                writer.WritePropertyName("dataSourceCredentialName"u8);
                writer.WriteStringValue(DataSourceCredentialName);
            }
            if (Optional.IsDefined(DataSourceCredentialDescription))
            {
                writer.WritePropertyName("dataSourceCredentialDescription"u8);
                writer.WriteStringValue(DataSourceCredentialDescription);
            }
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

        ServicePrincipalInKVCredentialPatch IJsonModel<ServicePrincipalInKVCredentialPatch>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServicePrincipalInKVCredentialPatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServicePrincipalInKVCredentialPatch(document.RootElement, options);
        }

        internal static ServicePrincipalInKVCredentialPatch DeserializeServicePrincipalInKVCredentialPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ServicePrincipalInKVParamPatch> parameters = default;
            DataSourceCredentialKind dataSourceCredentialType = default;
            Optional<string> dataSourceCredentialName = default;
            Optional<string> dataSourceCredentialDescription = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = ServicePrincipalInKVParamPatch.DeserializeServicePrincipalInKVParamPatch(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialType"u8))
                {
                    dataSourceCredentialType = new DataSourceCredentialKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialName"u8))
                {
                    dataSourceCredentialName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialDescription"u8))
                {
                    dataSourceCredentialDescription = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServicePrincipalInKVCredentialPatch(dataSourceCredentialType, dataSourceCredentialName.Value, dataSourceCredentialDescription.Value, serializedAdditionalRawData, parameters.Value);
        }

        BinaryData IModel<ServicePrincipalInKVCredentialPatch>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServicePrincipalInKVCredentialPatch)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ServicePrincipalInKVCredentialPatch IModel<ServicePrincipalInKVCredentialPatch>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServicePrincipalInKVCredentialPatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeServicePrincipalInKVCredentialPatch(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ServicePrincipalInKVCredentialPatch>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
