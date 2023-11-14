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
    internal partial class AzureSQLConnectionStringCredentialPatch : IUtf8JsonSerializable, IJsonModel<AzureSQLConnectionStringCredentialPatch>
    {
        void IJsonModel<AzureSQLConnectionStringCredentialPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AzureSQLConnectionStringCredentialPatch>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AzureSQLConnectionStringCredentialPatch>)} interface");
            }

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

        AzureSQLConnectionStringCredentialPatch IJsonModel<AzureSQLConnectionStringCredentialPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureSQLConnectionStringCredentialPatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureSQLConnectionStringCredentialPatch(document.RootElement, options);
        }

        internal static AzureSQLConnectionStringCredentialPatch DeserializeAzureSQLConnectionStringCredentialPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureSQLConnectionStringParamPatch> parameters = default;
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
                    parameters = AzureSQLConnectionStringParamPatch.DeserializeAzureSQLConnectionStringParamPatch(property.Value);
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
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureSQLConnectionStringCredentialPatch(dataSourceCredentialType, dataSourceCredentialName.Value, dataSourceCredentialDescription.Value, serializedAdditionalRawData, parameters.Value);
        }

        BinaryData IPersistableModel<AzureSQLConnectionStringCredentialPatch>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureSQLConnectionStringCredentialPatch)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AzureSQLConnectionStringCredentialPatch IPersistableModel<AzureSQLConnectionStringCredentialPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureSQLConnectionStringCredentialPatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAzureSQLConnectionStringCredentialPatch(document.RootElement, options);
        }

        string IPersistableModel<AzureSQLConnectionStringCredentialPatch>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
